using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Museum.Data;
using Museum.Models;
using Museum.Models.Tabs.Info;

namespace Museum.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : Controller
    {
        private MuseumContext context;

        public DataController(MuseumContext context)
        {
            this.context = context;
        }
        [HttpPost("AcceptItem")]
        public async Task<ActionResult<string>> AcceptItem([FromBody] AcceptRequest accReq)
        {
            Acceptance acceptance = new Acceptance();
            acceptance.name = accReq.name;
            acceptance.type = accReq.type;
            acceptance.shortDescription = accReq.shortDescription;
            acceptance.inventoryN = accReq.inventoryN;
            acceptance.insideN = accReq.insideN;
            acceptance.size = accReq.size;  
            acceptance.isDragMetal = accReq.isDragMetal;
            acceptance.isSpecFond = accReq.isSpecFond;
            acceptance.isWeapon = accReq.isWeapon;
            acceptance.specFondNum = accReq.specFondNum;


            List<BtwMatAcc> btwMatAcc = new List<BtwMatAcc>();
            foreach (var item in accReq.materials)
            {
                Material mat = await context.Materials.FindAsync(item.Id);
                btwMatAcc.Add(new BtwMatAcc() { Material = mat, Acceptance = acceptance});
            }

            List<BtwStatAcc> btwStatAcc = new List<BtwStatAcc>();
            foreach (var item in accReq.states)
            {
                State stat = await context.States.FindAsync(item.Id);
                btwStatAcc.Add(new BtwStatAcc() { State = stat, Acceptance = acceptance });
            }

            List<BtwTecAcc> btwTecAcc = new List<BtwTecAcc>();
            foreach (var item in accReq.techniques)
            {
                Technique tech = await context.Techniques.FindAsync(item.Id);
                btwTecAcc.Add(new BtwTecAcc() { Technique = tech, Acceptance = acceptance });
            }

            acceptance.materials = btwMatAcc;
            acceptance.states = btwStatAcc;
            acceptance.techniques = btwTecAcc;

            await context.BtwMatAccs.AddRangeAsync(acceptance.materials);
            await context.BtwStatAccs.AddRangeAsync(acceptance.states);
            await context.BtwTecAccs.AddRangeAsync(acceptance.techniques);

            await context.Acceptances.AddAsync(acceptance);

            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("GetMaterials")]
        public async Task<IEnumerable<Material>> GetMaterials()
        {
            return await context.Materials.ToListAsync();
        }

        [HttpGet("GetStates")]
        public async Task<IEnumerable<State>> GetStates()
        {
            return await context.States.ToListAsync();
        }
        [HttpGet("GetTechniques")]
        public async Task<IEnumerable<Technique>> GetTechniques()
        {
            return await context.Techniques.ToListAsync();
        }
    }
}

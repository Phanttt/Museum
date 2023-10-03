using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Museum.Data;
using Museum.Models;
using Museum.Models.Tabs.Info;
using Museum.Models.Tabs.Media;

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
        public async Task<ActionResult<string>> AcceptItem([FromBody] Acceptance acceptance)
        {
            Acceptance existedAcc = await context.Acceptances.FirstOrDefaultAsync(x=>x.id == acceptance.id);
            if (existedAcc!=null)
            {
                return BadRequest("Експонат вже існує з таким номером по книзі прийому");
            }
            existedAcc = await context.Acceptances.FirstOrDefaultAsync(x => x.inventoryN == acceptance.inventoryN);
            if (existedAcc != null)
            {
                return BadRequest("Експонат вже існує з таким інвентарним номером");
            }
            existedAcc = await context.Acceptances.FirstOrDefaultAsync(x => x.insideN == acceptance.insideN);
            if (existedAcc != null)
            {
                return BadRequest("Експонат вже існує з таким внутрішнім номером");
            }

            int maxInventoryN = await context.Acceptances.MaxAsync(x=>x.inventoryN);
            int maxInsideN = await context.Acceptances.MaxAsync(x=>x.insideN);

            if (acceptance.inventoryN == 0 )
            {
                acceptance.inventoryN = maxInventoryN + 1;
            }

            if (acceptance.insideN == 0)
            {
                acceptance.insideN = maxInsideN + 1;
            }

            UnifPassport unifPassport = new UnifPassport();
            acceptance.unifPassport = unifPassport;

            foreach (var material in acceptance.materials)
            {
                context.Entry(material).State = EntityState.Unchanged;
            }

            foreach (var material in acceptance.techniques)
            {
                context.Entry(material).State = EntityState.Unchanged;
            }

            foreach (var material in acceptance.states)
            {
                context.Entry(material).State = EntityState.Unchanged;
            }


            //acceptance.materials = btwMatAcc;
            //acceptance.states = btwStatAcc;
            //acceptance.techniques = btwTecAcc;

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

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Museum.Data;
using Museum.Data.ObjsForMediaRequests;
using Museum.Models;
using Museum.Models.Tabs.Info;
using Museum.Models.Tabs.Media;
using System.Text.Json.Serialization;
using System.Text.Json;
using Museum.Models.Tabs.InsideMuseum;

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
        public async Task<ActionResult<int>> AcceptItem([FromBody] Acceptance acceptance)
        {
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

            Acceptance existedAcc = await context.Acceptances
                     .Include(x => x.materials)
                     .Include(x => x.states)
                     .Include(x => x.techniques)
                     .FirstOrDefaultAsync(x => x.id == acceptance.id);

            if (acceptance.id == 0)
            {
                if (existedAcc != null)
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

                if (acceptance.inventoryN == 0)
                {
                    int maxInventoryN = await context.Acceptances.MaxAsync(x => x.inventoryN);
                    acceptance.inventoryN = maxInventoryN + 1;
                }

                if (acceptance.insideN == 0)
                {
                    int maxInsideN = await context.Acceptances.MaxAsync(x => x.insideN);
                    acceptance.insideN = maxInsideN + 1;
                }

                UnifPassport unifPassport = new UnifPassport();
                InsideInfo info = new InsideInfo();
                unifPassport = new UnifPassport();
                unifPassport.InsideInfo = info;
                acceptance.unifPassport = unifPassport;
                context.Acceptances.Add(acceptance);
            }
            else
            {
                existedAcc.techniques.Clear();
                existedAcc.materials.Clear();
                existedAcc.states.Clear();
                await context.SaveChangesAsync();

                context.Entry(existedAcc).State = EntityState.Detached;
                context.Acceptances.Update(acceptance);
            }

            await context.SaveChangesAsync();
            return Ok(acceptance.id);
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
        [HttpGet("GetAllObjects")]
        public async Task<IEnumerable<ObjForRespAll>> GetAllObjects()
        {
             List<ObjForRespAll> acceptances = await context.Acceptances
             .Include(x => x.unifPassport)
             .ThenInclude(x => x.Media)
             .ThenInclude(x => x.Images)
             .Select(x=> new ObjForRespAll
             {
                 id = x.id,
                 name = x.name,
                 images = x.unifPassport.Media.Images.Where(image => image.isMain).FirstOrDefault()
             })
             .ToListAsync();

            return acceptances;
        }
        [HttpGet("GetObjectById")]
        public async Task<ActionResult<Acceptance>> GetObjectById(int id)
        {
            Acceptance acceptance = await context.Acceptances
             .Where(x => x.id == id)
             .Include(x=>x.materials)
             .Include(x=>x.states)
             .Include(x=>x.techniques)
             .Include(x => x.unifPassport)
             .FirstOrDefaultAsync();

            if (acceptance == null)
            {
                return BadRequest("Об'екта з таким id не існує");
            }

            return Ok(acceptance);
        }
        [HttpDelete("DeleteObjectById")]
        public async Task<IActionResult> DeleteObjectById(int id)
        {
            Acceptance acc = await context.Acceptances.FindAsync(id);
            context.Acceptances.Remove(acc);

            await context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet("GetObjectByIdForShow")]
        public async Task<ActionResult<ShowedObj>> GetObjectByIdForShow(int id)
        {
            ShowedObj obj = await context.Acceptances
              .Include(x => x.unifPassport)
              .ThenInclude(x => x.Media)
              .ThenInclude(x => x.Images)
              .Select(x => new ShowedObj
              {
                  id = x.id,
                  name = x.name,
                  description = x.shortDescription,
                  images = x.unifPassport.Media.Images.ToList()
              })
              .FirstOrDefaultAsync(x=>x.id == id);

            if (obj == null)
            {
                return BadRequest("Об'екта з таким id не існує");
            }
            return Ok(obj);
        }
        [HttpGet("SearchItemsByCollectionName")]
        public async Task<ActionResult<IEnumerable<ObjForRespAll>>> SearchItemsByCollectionName(string name)
        {
            Collection collection = await context.Collections.FirstOrDefaultAsync(x => x.name == name);
            if (collection != null)
            {
                List<ObjForRespAll> acceptances = await context.Acceptances
                    .Include(x => x.unifPassport)
                    .ThenInclude(x => x.Media)
                    .ThenInclude(x => x.Images)
                    .Include(x => x.unifPassport.DetailInfo)
                    .ThenInclude(x => x.collections)
                    .Where(x => x.unifPassport.DetailInfo.collections.Contains(collection))
                    .Select(x => new ObjForRespAll
                    {
                        id = x.id,
                        name = x.name,
						description = x.shortDescription,
                        images = x.unifPassport.Media.Images.Where(image => image.isMain).FirstOrDefault(),
                    })
                    .ToListAsync();

                return acceptances;
            }
            return BadRequest("Колекції з такою назвою не знайдено");
        }
    
        [HttpGet("SearchItemsByFundName")]
        public async Task<ActionResult<IEnumerable<ObjForRespAll>>> SearchItemsByFundName(string name)
        {
            Fund fund = await context.Funds.FirstOrDefaultAsync(x => x.name == name);

            if (fund != null)
            {
                List<ObjForRespAll> acceptances = await context.Acceptances
                    .Include(x => x.unifPassport)
                    .ThenInclude(x => x.Media)
                    .ThenInclude(x => x.Images)
                    .Include(x => x.unifPassport.DetailInfo)
                    .ThenInclude(x => x.Fund)
                    .Where(x => x.unifPassport.DetailInfo.Fund.id == fund.id)
                    .Select(x => new ObjForRespAll
                    {
                        id = x.id,
                        name = x.name,
                        images = x.unifPassport.Media.Images.Where(image => image.isMain).FirstOrDefault()
                    })
                    .ToListAsync();

                return acceptances;
            }
            return BadRequest("Фонда з такою назвою не знайдено");
        }
    }
}

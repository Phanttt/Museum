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

        DataController(MuseumContext context)
        {
            this.context = context;
        }
        [HttpPut("AcceptItem")]
        public void AcceptItem(Acceptance acceptance)
        {

            
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

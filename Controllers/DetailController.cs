using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Museum.Data;
using Museum.Models;
using Museum.Models.Tabs.Info;

namespace Museum.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DetailController : Controller
    {
        private MuseumContext context;
        public DetailController(MuseumContext context)
        {
            this.context = context;
        }
        [HttpGet("GetFunds")]
        public async Task<ActionResult<IEnumerable<Fund>>> GetFunds()
        {
            List<Fund> funds = await context.Funds.ToListAsync();
            return funds;
        }
        [HttpGet("GetGroups")]
        public async Task<ActionResult<IEnumerable<Group>>> GetGroups()
        {
            List<Group> groups = await context.Groups.ToListAsync();
            return groups;
        }
        [HttpGet("GetCollections")]
        public async Task<ActionResult<IEnumerable<Collection>>> GetCollections()
        {
            List<Collection> collections = await context.Collections.ToListAsync();
            return collections;
        }
        [HttpPost("AddDetail")]
        public async Task<ActionResult<int>> AddDetail([FromBody] DetailInfo info)
        {

            return Ok(0);
        }

    }
}

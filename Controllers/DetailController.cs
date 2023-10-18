using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Museum.Data;
using Museum.Data.ObjsForDetail;
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

        [HttpGet("GetKeyWords")]
        public async Task<ActionResult<IEnumerable<KeyWord>>> GetKeyWords()
        {
            List<KeyWord> keyWords = await context.KeyWords.ToListAsync();
            return keyWords;
        }

        [HttpGet("GetTags")]
        public async Task<ActionResult<IEnumerable<Tag>>> GetTags()
        {
            List<Tag> tags = await context.Tags.ToListAsync();
            return tags;
        }

        [HttpGet("GetCollections")]
        public async Task<ActionResult<IEnumerable<Collection>>> GetCollections()
        {
            List<Collection> collections = await context.Collections.ToListAsync();
            return collections;
        }

        [HttpPost("AddGroup")]
        public async Task<ActionResult<Group>> AddGroup([FromBody] Group group)
        {
            await context.Groups.AddAsync(group);
            await context.SaveChangesAsync();
            return Ok(group);
        }

        [HttpPost("AddCollection")]
        public async Task<ActionResult<Collection>> AddCollection([FromBody] Collection collection)
        {
            await context.Collections.AddAsync(collection);
            await context.SaveChangesAsync();
            return Ok(collection);
        }

        [HttpPost("AddTag")]
        public async Task<ActionResult<Tag>> AddTag([FromBody] Tag tag)
        {
            await context.Tags.AddAsync(tag);
            await context.SaveChangesAsync();
            return Ok(tag);
        }
        [HttpPost("AddKeyWord")]
        public async Task<ActionResult<KeyWord>> AddKeyWord([FromBody] KeyWord keyWord)
        {
            await context.KeyWords.AddAsync(keyWord);
            await context.SaveChangesAsync();
            return Ok(keyWord);
        }

        [HttpPost("AddDetailInfo")]
        public async Task<ActionResult> AddDetailInfo([FromBody] ObjForDetail obj)
            {
            UnifPassport passport = await context.UnifPassports.FindAsync(obj.unifId);
            DetailInfo detailInfo = obj.detail;
            context.Entry(detailInfo.Fund).State = EntityState.Unchanged;
            foreach (var group in detailInfo.groups)
            {
                context.Entry(group).State = EntityState.Unchanged;
            }
            foreach (var group in detailInfo.collections)
            {
                context.Entry(group).State = EntityState.Unchanged;
            }
            foreach (var group in detailInfo.keyWords)
            {
                context.Entry(group).State = EntityState.Unchanged;
            }
            foreach (var group in detailInfo.tags)
            {
                context.Entry(group).State = EntityState.Unchanged;
            }
            passport.DetailInfo = detailInfo; 

            await context.DetailInfos.AddAsync(detailInfo);
            await context.SaveChangesAsync();
            return Ok(detailInfo);
        }
        [HttpGet("GetDetailInfo")]
        public async Task<ActionResult<DetailInfo>> GetDetailInfoById(int id)
        {
            DetailInfo? info = await context.DetailInfos
                .Include(x => x.groups)
                .Include(x => x.keyWords)
                .Include(x => x.tags)
                .Include(x => x.Fund)
                .Include(x => x.collections)
                .FirstOrDefaultAsync(x => x.id == id);

            return info;
        }
    }
}

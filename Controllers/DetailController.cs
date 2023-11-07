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
        [HttpPost("AddFund")]
        public async Task<ActionResult<Fund>> AddFund([FromBody] Fund fund)
        {
            await context.Funds.AddAsync(fund);
            await context.SaveChangesAsync();
            return Ok(fund);
        }
        [HttpDelete("DeleteCollectionById")]
        public async Task<ActionResult> DeleteCollectionById(int id) 
        {
            Collection col = await context.Collections.FirstAsync(x=>x.id == id);
            context.Collections.Remove(col);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("DeleteFundsById")]
        public async Task<ActionResult> DeleteFundsById(int id)
        {
            Fund fund = await context.Funds.FirstAsync(x => x.id == id);
            context.Funds.Remove(fund);
            await context.SaveChangesAsync();
            return Ok();
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

            if (detailInfo.id == 0)
            {
                passport.DetailInfo = detailInfo;

                await context.DetailInfos.AddAsync(detailInfo);
            }
            else
            {
                DetailInfo existedDetail = await context.DetailInfos
                    .Include(x => x.keyWords)
                    .Include(x => x.tags)
                    .Include(x => x.collections)
                    .Include(x => x.groups)
                    .FirstOrDefaultAsync(x => x.id == detailInfo.id);

                existedDetail.Fund = detailInfo.Fund;
                existedDetail.keyWords = detailInfo.keyWords;
                existedDetail.groups = detailInfo.groups;
                existedDetail.collections = detailInfo.collections;
                existedDetail.tags = detailInfo.tags;

                context.DetailInfos.Update(existedDetail);
            }

            await context.SaveChangesAsync();
            return Ok(detailInfo);
        }
        [HttpGet("GetDetailInfo")]
        public async Task<ActionResult<DetailInfo>> GetDetailInfoById(int id)
        {
            UnifPassport unif = await context.UnifPassports
                .Include(x => x.DetailInfo)
                .Include(x => x.DetailInfo.groups)
                .Include(x => x.DetailInfo.keyWords)
                .Include(x => x.DetailInfo.tags)
                .Include(x => x.DetailInfo.Fund)
                .Include(x => x.DetailInfo.collections)
                .FirstOrDefaultAsync(x => x.Id == id);
       

            return unif.DetailInfo;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Museum.Data;
using Museum.Data.ObjsForInsideInfo;
using Museum.Models;
using Museum.Models.Tabs.InsideMuseum;

namespace Museum.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InsideInfoController : Controller
    {
        private MuseumContext context;

        public InsideInfoController(MuseumContext context)
        {
            this.context = context;
        }
        [HttpPost("AddInsideInfo")]
        public async Task<InsideInfo> AddInsideInfo(InsideInfoObj insideInfoObj)
        {
            InsideInfo insideInfo = insideInfoObj.InsideInfo;

            if (insideInfo.exhibition.id == 0)
            {
                context.Entry(insideInfo).State = EntityState.Modified;
                insideInfo.exhibition = null;
            }
            else
            {
                context.Entry(insideInfo.exhibition).State = EntityState.Unchanged;
            }

            UnifPassport unifPassport = await context.UnifPassports.FindAsync(insideInfoObj.unifId);
            unifPassport.InsideInfo = insideInfo;

            context.InsideInfos.Update(insideInfo);
            await context.SaveChangesAsync();
            return insideInfo;
        }

        [HttpGet("GetInsideInfo")]
        public async Task<InsideInfo> GetInsideInfo(int id)
        {
            UnifPassport passport = await context.UnifPassports
                .Include(x => x.InsideInfo)
                .ThenInclude(x=>x.exhibition)
                .FirstOrDefaultAsync(x => x.Id == id);
            return passport.InsideInfo;
        }
        [HttpGet("GetExhibitions")]
        public async Task<IEnumerable<Exhibition>> GetExhibitions()
        {
            List<Exhibition> exhibitions = await context.Exhibitions.ToListAsync();
            return exhibitions;
        }
        [HttpGet("GetDocs")]
        public async Task<DataFile> GetDocs(int unifId)
        {
            UnifPassport unifPassport =  await context.UnifPassports
                .Include(x => x.InsideInfo)
                .ThenInclude(x => x.Files)
                .FirstOrDefaultAsync(x => x.Id == unifId);
            DataFile file = unifPassport.InsideInfo.Files;
            if (file == null)
            {
                return null;
            }
            return file;
        }
    }
}

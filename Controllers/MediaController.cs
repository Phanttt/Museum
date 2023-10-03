using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Museum.Data;
using Museum.Models;
using Museum.Models.Tabs.Media;

namespace Museum.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MediaController : Controller
    {
        private MuseumContext context;

        public MediaController(MuseumContext context)
        {
            this.context = context;
        }

        async Task<int> isMediaExist(int id)
        {
            UnifPassport unifPassport = await context.UnifPassports.FirstOrDefaultAsync(x => x.Id == id);

            Media media = unifPassport.Media;
            if (media == null)
            {
                Media newmed = new Media();
                await context.Medias.AddAsync(newmed);
                unifPassport.Media = newmed;
                await context.SaveChangesAsync();
                return newmed.id;
            }

            return media.id;
        }

        [HttpGet("GetImageRights")]
        public async Task<IEnumerable<ImageRight>> GetImageRights()
        {
            return await context.ImageRights.ToListAsync();
        }
        [HttpPost("AddGeneralInfoImg")]
        public async Task<ActionResult> AddGeneralInfoImg(GeneralInfo info)
        {
            await context.GeneralInfo.AddAsync(info);

            UnifPassport unifPassport = await context.UnifPassports.FirstOrDefaultAsync(x => x.Id == info.unifPassportId);

            Media media = unifPassport.Media;
            if (media == null)
            {
                Media newmed = new Media();
                newmed.GeneralInfo = info;
                await context.Medias.AddAsync(newmed);
                unifPassport.Media = newmed;
            }
            else
            {
                media.GeneralInfo = info;
            }

            


            await context.SaveChangesAsync();
            return Ok();
        }
        [HttpPost("AddImages")]
        public async Task<ActionResult> AddImages(Image image)
        {

            return Ok();
        }
    }
}

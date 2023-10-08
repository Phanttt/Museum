using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Museum.Data;
using Museum.Data.ObjsForMediaRequests;
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

        [HttpGet("GetImageRights")]
        public async Task<IEnumerable<ImageRight>> GetImageRights()
        {
            return await context.ImageRights.ToListAsync();
        }
        [HttpPost("AddGeneralInfoImg")]
        public async Task<ActionResult> AddGeneralInfoImg(GeneralInfo info)
        {
            context.Entry(info.ImageRight).State = EntityState.Unchanged;

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
        public async Task<ActionResult> AddImages(ImageObj imageObj)
        {
            Image image = imageObj.img;
            image.data = imageObj.imageBytes.ToArray();

            await context.Images.AddAsync(image);

            UnifPassport unifPassport = await context.UnifPassports
                .Include(x=>x.Media)
                .FirstOrDefaultAsync(x => x.Id == image.unifPassportId);

            Media media = unifPassport.Media;
            if (media == null)
            {
                Media newmed = new Media();
                newmed.Images.Add(image);
                await context.Medias.AddAsync(newmed);
                unifPassport.Media = newmed;
            }
            else
            {
                media.Images.Add(image);
            }

            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("GetGeneralInfoById")]
        public async Task<GeneralInfo> GetGeneralInfoById(int id)
        {
            return await context.GeneralInfo.FirstOrDefaultAsync(x => x.id == id);
        }

        [HttpGet("GetAllImagesByMediaId")]
        public async Task<IEnumerable<Image>> GetAllImagesByMediaId(int id)
        {
            Media media = await context.Medias.Include(x => x.Images).FirstOrDefaultAsync(x=>x.id == id);
            return media.Images;
        }
    }
}

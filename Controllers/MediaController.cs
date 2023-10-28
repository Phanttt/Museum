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
            if (info.id == 0)
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
            }
            else
            {
                context.GeneralInfo.Update(info);
            }
            await context.SaveChangesAsync();
            return Ok();
        }
        [HttpPost("AddImages")]
        public async Task<ActionResult<Image>> AddImages(ImageObj imageObj)
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
            return Ok(image);
        }

        [HttpGet("GetGeneralInfoById")]
        public async Task<GeneralInfo> GetGeneralInfoByUnifId(int id)
        {
            UnifPassport unif = await context.UnifPassports.Include(x => x.Media).ThenInclude(x => x.GeneralInfo).ThenInclude(x=>x.ImageRight).FirstOrDefaultAsync(x => x.Id == id);
            if (unif.Media == null)
            {
                return null;
            }
            return unif.Media.GeneralInfo;
        }

        [HttpGet("GetAllImagesByUnifId")]
        public async Task<ActionResult<IEnumerable<Image>>> GetAllImagesByUnifId(int id)
        {
            UnifPassport unif = await context.UnifPassports.Include(x => x.Media).ThenInclude(x => x.Images).FirstOrDefaultAsync(x => x.Id == id);
            if (unif.Media == null)
            {
                return null;
            }
            return Ok(unif.Media.Images);
        }

        [HttpPut("MakeMainImage")]   
        public async Task<IActionResult> MakeMainImage([FromBody] int imageId)
        {
            Image img = await context.Images.FirstOrDefaultAsync(x => x.id == imageId);
            List<Image> images = await context.Images.Where(x => x.MediaId == img.MediaId).ToListAsync();
            foreach (var item in images)
            {
                item.isMain = false;
            }
            img.isMain = true;
            await context.SaveChangesAsync();
            return Ok();
        }


        [HttpDelete("DeleteImage")]
        public async Task<IActionResult> DeleteImage([FromBody] int imageId)
        {
            Image img = await context.Images.FirstOrDefaultAsync(x => x.id == imageId);
            context.Remove(img);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("GetMainImage")]
        public async Task<IActionResult> GetMainImage(int unifId)
        {
            UnifPassport unif = await context.UnifPassports
                .Include(x => x.Media)
                .ThenInclude(x => x.Images)
                .FirstOrDefaultAsync(x=>x.Id == unifId);

            Image img = unif.Media.Images.Where(x => x.isMain).FirstOrDefault();
           
            return Ok(img);
        }
    }
}

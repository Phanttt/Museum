using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Museum.Data;
using Museum.Data.ObjsForReceiving;
using Museum.Models;
using Museum.Models.Tabs.Receiving;

namespace Museum.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewsController : Controller
    {
        private MuseumContext context;
            
        public NewsController(MuseumContext context)
        {
            this.context = context;
        }
        [HttpPost("AddNews")]
        public async Task<IActionResult> AddNews(ObjNews objNews)
        {
            News news = objNews.news;
            news.image = objNews.image.ToArray();
            if (news.id == 0)
            {
                news.date = DateTime.Now;
                await context.News.AddAsync(news);
            }
            else
            {
                News existedN = await context.News.FirstOrDefaultAsync(x => x.id == news.id);
                news.date = existedN.date;
                context.Entry(existedN).State = EntityState.Detached;

                context.News.Update(news);
            }
            await context.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete("DeleteNews")]
        public async Task<IActionResult> DeleteNews(int id)
        {
            News newsToDel = await context.News.FirstOrDefaultAsync(x => x.id == id);
            context.News.Remove(newsToDel);
            await context.SaveChangesAsync();
            return Ok();
        }
        [HttpGet("GetAllNews")]
        public async Task<IEnumerable<News>> GetAllNews()
        {
            List<News> allNews = await context.News
                 .OrderByDescending(x => x.date) 
                 .ToListAsync();

             return allNews;
        }
        [HttpGet("Get5LatestNews")]
        public async Task<IEnumerable<News>> Get5LatestNews()
        {
            List<News> top5News = await context.News
                .OrderByDescending(x => x.date)
                .Take(5)
                .ToListAsync();

            return top5News;
        }
        [HttpGet("GetNewsById")]
        public async Task<ActionResult<News>> GetNewsById(int id)
        {
            News news = await context.News.FirstOrDefaultAsync(x => x.id == id);
            if (news == null)
            {
                return BadRequest("Новини не знайдено");
            }
            return Ok(news);
        }
    }
}

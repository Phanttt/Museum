using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Museum.Data;
using Museum.Models;

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
        public async Task<News> AddNews(News news)
        {
            if (news.id == 0)
            {
                news.date = DateTime.Now;
                await context.News.AddAsync(news);
                await context.SaveChangesAsync();
            }
            else
            {
                context.News.Update(news);
            }
            return news;
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
    }
}

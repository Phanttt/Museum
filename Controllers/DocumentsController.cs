
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Museum.Data;
using Museum.Models;
using Museum.Models.Users;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace Museum.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentsController : Controller
    {
        private MuseumContext context;
        public string actToGiftingDeedPath { get; set; }
        public string giftingDeedPath { get; set; }
        public string intoFondActPath { get; set; }

        public DocumentsController(MuseumContext context)
        {
            this.context = context;

            string currentDirectory = Directory.GetCurrentDirectory();

            actToGiftingDeedPath = Path.Combine(currentDirectory, "Docs/ActToGiftingDeed.docx");
            giftingDeedPath = Path.Combine(currentDirectory, "Docs/GiftingDeed.docx");
            intoFondActPath = Path.Combine(currentDirectory, "Docs/IntoFondAct.docx");

        }

        [HttpGet("GiftingDeed")]
        public async Task<ActionResult> GiftingDeed(int id)
        {
            Acceptance? acceptance = await context.Acceptances
                .Include(x => x.unifPassport)
                .ThenInclude(x => x.Receiving)
                .Include(x => x.unifPassport.Receiving.Provider)
                .Include(x => x.unifPassport.Receiving.Recipient)
                .FirstOrDefaultAsync(x => x.id == id);

            if (acceptance != null)
            {
                using (DocX doc = DocX.Load(giftingDeedPath))
                {
                    doc.ReplaceText("<id>", acceptance.inventoryN.ToString());
                    doc.ReplaceText("<recipient>", acceptance.unifPassport.Receiving.Recipient.name);
                    doc.ReplaceText("<provider>", acceptance.unifPassport.Receiving.Provider.name);
                    doc.ReplaceText("<date>", acceptance.unifPassport.Receiving.date);

                    doc.SaveAs($"giftingDeed{acceptance.name}.docx");
                }

            }
            return Ok();
        }


        [HttpGet("ActToGiftingDeed")]
        public async Task<ActionResult> ActToGiftingDeed(int id, int userId)
        {
            User? user = await context.Users
                .Include(x=>x.Role)
                .Where(x=>x.id == userId)
                .FirstOrDefaultAsync();

            Acceptance? acceptance = await context.Acceptances
                .Include(x=>x.materials)
                .Include(x=>x.techniques)
                .Include(x=>x.states)
                .Include(x => x.unifPassport)
                .ThenInclude(x => x.Receiving)
                .Include(x => x.unifPassport.Receiving.Provider)
                .Include(x => x.unifPassport.Receiving.Purpose)
                .Include(x => x.unifPassport.Receiving.Recipient)
                .ThenInclude(x=> x.Role)
                .FirstOrDefaultAsync(x => x.id == id);

            if (acceptance != null)
            {
                using (DocX doc = DocX.Load(actToGiftingDeedPath))
                {
                    doc.ReplaceText("<id>", acceptance.inventoryN.ToString());
                    doc.ReplaceText("<recipientName>", acceptance.unifPassport.Receiving.Recipient.name);
                    doc.ReplaceText("<recipientRole>", acceptance.unifPassport.Receiving.Recipient.Role.name);
                    doc.ReplaceText("<providerName>", acceptance.unifPassport.Receiving.Provider.name);
                    doc.ReplaceText("<date>", acceptance.unifPassport.Receiving.date);

                    doc.ReplaceText("<userRole>", user.Role.name);
                    doc.ReplaceText("<userName>", user.name);


                    string content = "";
                    foreach (var item in acceptance.materials)
                    {
                        content += item.Name + " ";
                    }
                    doc.ReplaceText("<materials>", content);

                    content = "";
                    foreach (var item in acceptance.states)
                    {
                        content += item.Name + " ";
                    }
                    doc.ReplaceText("<states>", content);


                    content = "";
                    foreach (var item in acceptance.techniques)
                    {
                        content += item.Name + " ";
                    }
                    doc.ReplaceText("<techniques>", content);

                    doc.ReplaceText("<name>", acceptance.name);
                    doc.ReplaceText("<size>", acceptance.size);
                    doc.ReplaceText("<price>", acceptance.unifPassport.Receiving.price.ToString());
                    doc.ReplaceText("<inventoryN>", acceptance.inventoryN.ToString());
                    doc.ReplaceText("<purpose>", acceptance.unifPassport.Receiving.Purpose.name);


                    doc.SaveAs($"ActToGiftingDeed{acceptance.name}.docx");
                }

            }
            return Ok();
        }

        private string FormStringFromList(ICollection<Material> list)
        {
            string content = "";
            foreach (var item in list)
            {
                content += item.Name + ", ";
            }
            content = content.Substring(0, content.Length - 2);
            return content;
        }
        private string FormStringFromList(ICollection<Technique> list)
        {
            string content = "";
            foreach (var item in list)
            {
                content += item.Name + ", ";
            }
            content = content.Substring(0, content.Length - 2);
            return content;
        }
        private string FormStringFromList(ICollection<State> list)
        {
            string content = "";
            foreach (var item in list)
            {
                content += item.Name + ", ";
            }
            content = content.Substring(0, content.Length - 2);
            return content;
        }
    }
}

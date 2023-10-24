
using Microsoft.AspNetCore.Mvc;
using Museum.Data;
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
        public DocumentsController(MuseumContext context) { 
            this.context = context;

            string currentDirectory = Directory.GetCurrentDirectory();

            actToGiftingDeedPath = Path.Combine(currentDirectory, "Docs/ActToGiftingDeed.docx");
            giftingDeedPath = Path.Combine(currentDirectory, "Docs/GiftingDeed.docx");
            intoFondActPath = Path.Combine(currentDirectory, "Docs/IntoFondAct.docx");

        }

        [HttpGet("ActToGiftingDeed")]
        public void ActToGiftingDeed()
        {

            string placeholder1Value = "Value1";
            string placeholder2Value = "Value2";

            using (DocX doc = DocX.Load(actToGiftingDeedPath))
            {
                // Replace placeholders with actual data
                doc.ReplaceText("<<Placeholder1>>", placeholder1Value);
                doc.ReplaceText("<<Placeholder2>>", placeholder2Value);

                // Save the modified document
                doc.SaveAs("GiftingAct.docx");
            }
        }
    }
}

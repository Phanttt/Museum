
using Microsoft.AspNetCore.Mvc;
using Xceed.Words.NET;

namespace Museum.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentsController : Controller
    {

        [HttpGet("ActToGiftingDeed")]
        public void ActToGiftingDeed()
        {

            string filePath = @"C:\Users\arsep\Desktop\MNorm\Gact.docx";
            string placeholder1Value = "Value1";
            string placeholder2Value = "Value2";

            using (DocX doc = DocX.Load(filePath))
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

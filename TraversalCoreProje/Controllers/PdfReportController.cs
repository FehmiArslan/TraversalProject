using DocumentFormat.OpenXml.ExtendedProperties;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Operations;
using System.IO;
using System.Text;

namespace TraversalCoreProje.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();
            Paragraph paragraph = new Paragraph("Traversal Rezarvasyon Pdf Raporu");
            document.Add(paragraph);
            document.Close();
            return File("/pdfreports/dosya1.pdf", "application/pdf","dosya1.pdf");
        }
        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya2.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();

            PdfPTable pdfpTable = new PdfPTable(3);

            pdfpTable.AddCell("Misafir Adı");
            pdfpTable.AddCell("Misafir Soyadı");
            pdfpTable.AddCell("Misafir Tc Kimlik No");

            pdfpTable.AddCell("Eylül");
            pdfpTable.AddCell("Yücedağ");
            pdfpTable.AddCell("12245678910");

            pdfpTable.AddCell("Kemal");
            pdfpTable.AddCell("Yücedağ");
            pdfpTable.AddCell("12245678912");

            pdfpTable.AddCell("Yıldırım");
            pdfpTable.AddCell("Yücedağ");
            pdfpTable.AddCell("12245678914");
            
            document.Add(pdfpTable);

            document.Close();
            return File("/pdfreports/dosya2.pdf", "application/pdf", "dosya2.pdf");

            //Türkçe karakterler gelmiyor..
        }
    }
}

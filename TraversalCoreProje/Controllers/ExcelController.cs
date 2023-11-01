using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Controllers
{
    public class ExcelController : Controller
    {
        private readonly IExcelService _excelService;

        public ExcelController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        public IActionResult Index()
        {
 
            return View();
        } 
        public List<DestinationModel> DestinationList()
        {
            List<DestinationModel> destinationModels= new List<DestinationModel>();
            using (var c=new Context())
            {
                destinationModels = c.Destinations.Select(x => new DestinationModel
                {
                    City = x.City,
                    DayNight = x.DayNight,
                    Price=x.Price,
                    Capacity=x.Capacity,
                }).ToList();
            }
            return destinationModels;
        }
        public IActionResult StaticExcelReport()
        {
            // application/vnd.openxmlformats-officedocument.spreadsheetml.sheet
            return File(_excelService.ExcelList(DestinationList()), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "YeniExcel.xlsx");
        }
        public IActionResult DestinationExcelReport()
        {
            using var workBook = new ClosedXML.Excel.XLWorkbook();
            var workShhet = workBook.Worksheets.Add("Tur Listesi");
            workShhet.Cell(1, 1).Value = "Şehir";
            workShhet.Cell(1, 2).Value = "Konaklama Süresi";
            workShhet.Cell(1, 3).Value = "Fiyat";
            workShhet.Cell(1, 4).Value = "Kapasite";

            int rowCount = 2;
            foreach (var item in DestinationList())
            {
                workShhet.Cell(rowCount, 1).Value = item.City;
                workShhet.Cell(rowCount, 2).Value = item.DayNight;
                workShhet.Cell(rowCount, 3).Value = item.Price;
                workShhet.Cell(rowCount, 4).Value = item.Capacity;
                rowCount++;
            }
            using (var stream = new MemoryStream())
            {
                workBook.SaveAs(stream);
                var content = stream.ToArray();
                return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "TurRotaları_Excel.xlsx");
            }
        }
    }
}

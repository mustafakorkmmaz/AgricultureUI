using Agri.Business.Abstract;
using Agri.Data.DatabaseContexts;
using AgricultureUI.Models;
using AutoMapper;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OfficeOpenXml;





namespace AgricultureUI.Controllers
{
    public class ReportController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IContactService _contactService;

        public ReportController(IMapper mapper, IContactService contactService)
        {
            _mapper = mapper;
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Static()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            ExcelPackage package = new ExcelPackage();
            var workBook = package.Workbook.Worksheets.Add("StatikDosya");

            workBook.Cells[1, 1].Value = "Şehir Adı";
            workBook.Cells[1, 2].Value = "Çalışan Firma Sayısı";
            workBook.Cells[1, 3].Value = "Toplam Kg";

            workBook.Cells[2, 1].Value = "Kastamonu";
            workBook.Cells[2, 2].Value = "10";
            workBook.Cells[2, 3].Value = "790";

            workBook.Cells[3, 1].Value = "Kayseri";
            workBook.Cells[3, 2].Value = "3";
            workBook.Cells[3, 3].Value = "1000";

            workBook.Cells[4, 1].Value = "Sinop";
            workBook.Cells[4, 2].Value = "5";
            workBook.Cells[4, 3].Value = "770";

            var bytes = package.GetAsByteArray();

            return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "SehirRaporu.xlsx");




        }
        
        public List<ContactAddViewModel> IletisimList()
        {
            List<ContactAddViewModel> iletisimModels = new List<ContactAddViewModel>();
            var iletisimListesi = _contactService.GetListAll();
            
            _mapper.Map(iletisimListesi, iletisimModels);

            return iletisimModels;

        }
        public IActionResult DynamicReport()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Duyuru Listesi");
                workSheet.Cell(1,1).Value = "Mesaj ID";
                workSheet.Cell(1,2).Value = "Mesaj Atan İsim";
                workSheet.Cell(1,3).Value = "Mail";
                workSheet.Cell(1,4).Value = "Mesaj";
                workSheet.Cell(1,5).Value = "Tarih";


                int a = 2;
                foreach (var item in IletisimList())
                {
                    workSheet.Cell(a, 1).Value = item.Id;
                    workSheet.Cell(a, 2).Value = item.Name;
                    workSheet.Cell(a, 3).Value = item.Email;
                    workSheet.Cell(a, 4).Value = item.Message;
                    workSheet.Cell(a, 5).Value = item.ContactDate;
                    a++;
                }
                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content= stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "MesajRaporu.xlsx");
                }
            }
                
        }

    }
}
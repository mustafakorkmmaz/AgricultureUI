using AgricultureUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult ProductChart() 
        {
            var productViewModels = new List<ChartProductViewModel>();
            productViewModels.Add(new ChartProductViewModel
            {
                name = "Mısır",
                satiskg = 250
            });
            productViewModels.Add(new ChartProductViewModel
            {
                name = "Buğday",
                satiskg = 150
            });
            productViewModels.Add(new ChartProductViewModel
            {
                name = "Yulaf",
                satiskg = 125
            });
            productViewModels.Add(new ChartProductViewModel
            {
                name = "Arpa",
                satiskg = 300
            });
            productViewModels.Add(new ChartProductViewModel
            {
                name = "Mercimek",
                satiskg = 100
            });

            return Json(new {jsonlist=productViewModels});
        }
    }
}

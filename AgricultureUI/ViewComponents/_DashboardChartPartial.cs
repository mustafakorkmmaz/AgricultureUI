using Agri.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using NuGet.Packaging;

namespace AgricultureUI.ViewComponents
{
    public class _DashboardChartPartial:ViewComponent
    {
        private readonly ICityService _cityService;

        public _DashboardChartPartial(ICityService cityService)
        {
            _cityService = cityService;
        }

        public IViewComponentResult Invoke()
        {
            var cityNum = _cityService.GetListAll().Count;
            var cities = _cityService.GetListAll().ToArray();
            var myArray = new string[cityNum];
            for (int i = 0; i< cityNum; i++)
            {
                myArray[i] = cities[i].Name; 
            }
            var numArray = new int[cityNum];
            for (int i = 0; i < cityNum; i++)
            {
                numArray[i] = Convert.ToInt32(cities[i].Percentage);
            }
            
            ViewBag.cities= myArray;
            ViewBag.Nume= numArray;
            return View();
        }
    }
}

using Agri.Business.Abstract;
using Agri.Business.Concrete;
using Agri.Entity.Entities;
using AgricultureUI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.Controllers
{

    public class ServiceController : Controller
    {
        IServService _servService;
        IMapper _mapper;

        public ServiceController(IServService servService,IMapper mapper)
        {
            _servService = servService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var deneme = _servService.GetListAll();

            return View(deneme);
        }
        public IActionResult AddService()
        {
            return View(new ServiceEklemeViewModel());
        }
        [HttpPost]
        public IActionResult AddService(ServiceEklemeViewModel model)
        {
            var serv = _mapper.Map<Service>(model);
            _servService.Insert(serv);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteService (int id)
        {
            var deletedService = _servService.GetById(id);
            _servService.Delete(deletedService);
            return RedirectToAction("Index");
        }
        public IActionResult UpdateService(int id)
        {
            var sev = new ServiceEklemeViewModel();
            var updatedService = _servService.GetById(id);

            return View(_mapper.Map(updatedService, sev));
        }
        [HttpPost]
        public IActionResult UpdateService(ServiceEklemeViewModel model)
        {
            var up = _mapper.Map<Service>(model);
            _servService.Update(up);

            return RedirectToAction ("Index");

        }
       


    }
}

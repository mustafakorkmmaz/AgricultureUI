using Agri.Business.Abstract;
using Agri.Business.ValidationRules;
using Agri.Entity.Entities;
using AgricultureUI.Models;
using AutoMapper;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.Controllers
{
    public class StuffController : Controller
    {
        private readonly IStuffService _stuffService;
        private readonly IMapper _mapper;

        public StuffController(IStuffService stuffService, IMapper mapper)
        {
            _stuffService = stuffService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var stuffList = _stuffService.GetListAll();
            return View(stuffList);
        }
        public IActionResult AddStuff()
        {
            
            return View(new Stuff());
        }
        [HttpPost]
        public IActionResult AddStuff(Stuff stuff)
        {
            StuffValidator stuffValidator= new StuffValidator();
            ValidationResult result = stuffValidator.Validate(stuff);
            if(result.IsValid)
            {
                _stuffService.Insert(stuff);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(new Stuff());
            
        }
        public IActionResult DeleteStuff(int id) 
        {
            var deletedStuff = _stuffService.GetById(id);
            _stuffService.Delete(deletedStuff);
            return RedirectToAction("Index");
        }
        public IActionResult UpdateStuff(int id) 
        {
            var updatedStuff = _stuffService.GetById(id);
            return View(updatedStuff);
        }
        [HttpPost]
        public IActionResult UpdateStuff(Stuff stuff)
        {
            
            StuffValidator stuffValidator = new StuffValidator();
            ValidationResult result = stuffValidator.Validate(stuff);
            if (result.IsValid)
            {
                _stuffService.Update(stuff);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(new Stuff());

        }
    }
}

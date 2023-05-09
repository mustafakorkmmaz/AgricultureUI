using Agri.Business.Abstract;
using Agri.Business.ValidationRules;
using Agri.Entity.Entities;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            return View(_contactService.GetListAll());
        }
        public IActionResult MessageDetails(int id)
        {
            
            return View(_contactService.GetById(id));
        }
    }
}

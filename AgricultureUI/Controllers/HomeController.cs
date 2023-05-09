using Agri.Business.Abstract;
using Agri.Entity.Entities;
using AgricultureUI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AgricultureUI.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

       
		public HomeController(ILogger<HomeController> logger, IContactService contactService, IMapper mapper)
		{
			_logger = logger;
			_contactService = contactService;
			_mapper = mapper;
		}

		public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public PartialViewResult SendMessage()
        {
            return PartialView(new ContactAddViewModel());
        }
        [HttpPost]
		public IActionResult SendMessage(ContactAddViewModel model)
		{
            var con = _mapper.Map<Contact>(model);
            con.ContactDate= DateTime.Now;
            _contactService.Insert(con);
			return RedirectToAction("Index");
		}
        public PartialViewResult Scripts()
        {
            return PartialView();
        }
	}
}
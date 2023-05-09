using Agri.Business.Abstract;
using Agri.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        public IActionResult Index()
        {

            return View(_adminService.GetListAll());
        }
        public IActionResult AddAdmin() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAdmin(Admin admin)
        {
            _adminService.Insert(admin);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAdmin(int id)
        {
            _adminService.Delete(_adminService.GetById(id));

            return RedirectToAction("Index");   
        }
    }
}

using Agri.Business.Abstract;
using Agri.Entity.Entities;
using AgricultureUI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.Controllers
{
    public class LatestNewsController : Controller
    {
        private readonly INewsService _newsService;
        private readonly IMapper _mapper;

        public LatestNewsController(INewsService newsService,IMapper mapper)
        {
            _newsService = newsService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var val = _newsService.GetListAll();
            return View(val);
        }
        public IActionResult AddNews()
        {
            AnnouncementViewModel anc = new AnnouncementViewModel();
            return View(anc);

        }
        [HttpPost]
        public IActionResult AddNews(AnnouncementViewModel anc)
        {
            anc.NewsDate = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
            anc.Status = false;
            var map = _mapper.Map<News>(anc);
            _newsService.Insert(map);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteNews(int id)
        {
            var deletedNews = _newsService.GetById(id);
            _newsService.Delete(deletedNews);
            return RedirectToAction("Index");
        }
        public IActionResult UpdateNews(int id)
        {
            var sev = new AnnouncementViewModel();
            var updatedNews = _newsService.GetById(id);

            return View(_mapper.Map(updatedNews, sev));
        }
        [HttpPost]
        public IActionResult UpdateNews(int id, AnnouncementViewModel model)
        {
            var up = _mapper.Map<News>(model);
            _newsService.Update(up);

            return RedirectToAction("Index");

        }
        public IActionResult UpdateStatusTrue(int id)
        {
            _newsService.ChangeStatusToTrue(id);
            return RedirectToAction("Index");
        }
        public IActionResult UpdateStatusFalse(int id)
        {
            _newsService.ChangeStatusToFalse(id);
            return RedirectToAction("Index");
        }
    }
}

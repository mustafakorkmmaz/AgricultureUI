using Agri.Data.DatabaseContexts;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.ViewComponents
{
    public class _DashboardOverviewPartial:ViewComponent
    {
        private readonly AgricultureContext _context;

        public _DashboardOverviewPartial(AgricultureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.dnm = _context.Calisanlar.Count();
            ViewBag.servisSayimiz=_context.Servisler.Count();
            ViewBag.mesajSayimiz=_context.Iletisim.Count();

            ViewBag.ilkAdmin=_context.Calisanlar.Where(p=>p.Id==1).FirstOrDefault().Name;
            ViewBag.ilkAdminTitle=_context.Calisanlar.Where(p=>p.Id==1).FirstOrDefault().Title;

            ViewBag.sAdmin = _context.Calisanlar.Where(p => p.Id == 4).FirstOrDefault().Name;
            ViewBag.sAdminTitle = _context.Calisanlar.Where(p => p.Id == 4).FirstOrDefault().Title;

            ViewBag.trAdmin = _context.Calisanlar.Where(p => p.Id == 5).FirstOrDefault().Name;
            ViewBag.trAdminTitle = _context.Calisanlar.Where(p => p.Id == 5).FirstOrDefault().Title;

            ViewBag.foAdmin = _context.Calisanlar.Where(p => p.Id == 8).FirstOrDefault().Name;
            ViewBag.foAdminTitle = _context.Calisanlar.Where(p => p.Id == 8).FirstOrDefault().Title;

            return View();
        }
    }
}

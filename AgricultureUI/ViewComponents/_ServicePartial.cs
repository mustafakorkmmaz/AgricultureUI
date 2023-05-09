using Agri.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.ViewComponents
{
	public class _ServicePartial:ViewComponent
	{
		private readonly IServService _servService;

		public _ServicePartial(IServService servService)
		{
			_servService = servService;
		}

		public IViewComponentResult Invoke()
		{
			return View(_servService.GetListAll());
		}
	}
}

using Agri.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.ViewComponents
{
	public class _StuffPartial:ViewComponent
	{
		private readonly IStuffService _stuffService;

		public _StuffPartial(IStuffService stuffService)
		{
			_stuffService = stuffService;
		}

		public IViewComponentResult Invoke()
		{
			return View(_stuffService.GetListAll());
		}
	}
}

using Agri.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.ViewComponents
{
	public class _SocialMediaPartial:ViewComponent
	{
		private readonly ISocialMService _socialMService;

		public _SocialMediaPartial(ISocialMService socialMService)
		{
			_socialMService = socialMService;
		}

		public IViewComponentResult Invoke()
		{
			
			return View(_socialMService.GetListAll());
		}
	}
}

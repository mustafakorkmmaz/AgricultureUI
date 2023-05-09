using Agri.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AgricultureUI.ViewComponents
{
	public class _NewsPartial:ViewComponent
	{
		private readonly INewsService _newsService;

		public _NewsPartial(INewsService newsService)
		{
			_newsService = newsService;
		}

		public IViewComponentResult Invoke()
		{
			return View(_newsService.GetListAll());
		}
	}
}

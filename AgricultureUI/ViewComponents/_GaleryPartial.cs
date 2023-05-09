using Agri.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.ViewComponents
{
	public class _GaleryPartial:ViewComponent
	{
		private readonly IImageService _imageService;

		public _GaleryPartial(IImageService imageService)
		{
			_imageService = imageService;
		}

		public IViewComponentResult Invoke()
		{
			return View(_imageService.GetListAll());
		}
	}
}

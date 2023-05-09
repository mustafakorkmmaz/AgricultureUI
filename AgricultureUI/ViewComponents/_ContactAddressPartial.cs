using Agri.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.ViewComponents
{
	public class _ContactAddressPartial:ViewComponent
	{
		private readonly IAddressService _addressService;

		public _ContactAddressPartial(IAddressService addressService)
		{
			_addressService = addressService;
		}
		public IViewComponentResult Invoke()
		{
			return View(_addressService.GetListAll());
		}
	}
}

using Agri.Business.Abstract;
using Agri.Entity.Entities;
using AgricultureUI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressService _addressService;
        private readonly IMapper _mapper;

        public AddressController(IAddressService addressService,IMapper mapper)
        {
            _addressService = addressService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View(_addressService.GetListAll());
        }
        public IActionResult UpdateAddress(int id)
        {
            var model = new AddressUpdateViewModel();
            var updatedAddress = _addressService.GetById(id);

            return View(_mapper.Map(updatedAddress,model));
        }
        [HttpPost]
        public IActionResult UpdateAddress(AddressUpdateViewModel model)
        {
            var up = _mapper.Map<Address>(model);
            _addressService.Update(up);
            return RedirectToAction("Index");   
        }

    }
}

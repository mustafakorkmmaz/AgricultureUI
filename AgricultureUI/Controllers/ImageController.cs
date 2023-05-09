using Agri.Business.Abstract;
using Agri.Business.ValidationRules;
using Agri.DataAccess.Concrete.Efw;
using Agri.Entity.Entities;
using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageService _imageService;
        

        public ImageController(IImageService imageService,IMapper mapper)
        {
            _imageService = imageService;
            
        }

        public IActionResult Index()
        {
            
            return View(_imageService.GetListAll());
        }
        public IActionResult AddImage()
        {
            return View(new Image());
        }
        [HttpPost]
        public IActionResult AddImage(Image image)
        {
            ImageValidator stuffValidator = new ImageValidator();
            ValidationResult result = stuffValidator.Validate(image);
            if (result.IsValid)
            {
                _imageService.Insert(image);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(new Image());
        }
        public IActionResult DeleteImage(int id)
        {
            var deletedImage = _imageService.GetById(id);
            _imageService.Delete(deletedImage);
            return RedirectToAction("Index");
        }
        public IActionResult UpdateImage(int id)
        {
            var updatedImage = _imageService.GetById(id);
            return View(updatedImage);
        }
        [HttpPost]
        public IActionResult UpdateImage(Image image)
        {

            ImageValidator imageValidator = new ImageValidator();
            ValidationResult result = imageValidator.Validate(image);
            if (result.IsValid)
            {
                _imageService.Update(image);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(new Image());

        }
    }
}

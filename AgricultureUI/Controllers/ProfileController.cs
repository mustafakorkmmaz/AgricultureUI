using AgricultureUI.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public ProfileController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ProfileEditViewModel profileEditViewModel = new ProfileEditViewModel();
            profileEditViewModel.Email = user.Email;
            profileEditViewModel.PhoneNumber= user.PhoneNumber;

            return View(profileEditViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(ProfileEditViewModel profileEditViewModel)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (profileEditViewModel.Password == profileEditViewModel.PasswordCheck)
            {
                user.Email = profileEditViewModel.Email;
                user.PhoneNumber = profileEditViewModel.PhoneNumber;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, profileEditViewModel.Password);
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index","Login");
                }
            }
            return View(profileEditViewModel);
        }
        




    }
}

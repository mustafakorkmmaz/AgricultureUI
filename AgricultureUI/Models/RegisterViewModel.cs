using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace AgricultureUI.Models
{
    public class RegisterViewModel
    {
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kullanıcı adı boş bırakılamaz.")]
        public string UserName { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bu Alan boş bırakılamaz.")]
        public string Password { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bu Alan boş bırakılamaz.")]
        [Compare("Password",ErrorMessage="Şifre uyumlu değil.")]
        public string PasswordCheck { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mailboş bırakılamaz.")]

        public string Email { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace AgricultureUI.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Kullanıcı Alanı girilmesi zorunludur")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Şifre girilmesi zorunludur")]
        public string Password { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace AgricultureUI.Models
{
    public class ProfileEditViewModel
    {
        [Required(ErrorMessage ="Bu alan girilmesi zorunludur")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage ="Şifre girmek zorundasın")]
        public string Password { get; set; }
        [Required]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor sir.")]
        public string PasswordCheck { get; set; }
    }
}

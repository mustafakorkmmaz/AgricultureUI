using System.ComponentModel.DataAnnotations;

namespace AgricultureUI.Models
{
    public class ServiceEklemeViewModel
    {
        public int Id { get; set; }
        
        [Display(Name ="Servis Başlığı")]
        [Required(ErrorMessage ="Doldurman lazım..")]
        public string ServiceTitle { get; set; }
        [Display(Name = "Servis Açıklaması")]
        [Required(ErrorMessage = "Doldurman lazım..")]
        public string ServiceDescription { get; set; }
        [Display(Name = "Servis Resmi")]
        [Required(ErrorMessage = "Doldurman lazım..")]
        public string ServiceImage { get; set; }
    }
}

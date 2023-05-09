using System.ComponentModel.DataAnnotations;

namespace AgricultureUI.Models
{
    public class AddressUpdateViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Adresi mahalle sokak olarak giriniz")]
        [MinLength(10)]
        public string FDesc { get; set; }
        public string? SDesc { get; set; }
        public string? TDesc { get; set; }
        public string? FoDesc { get; set; }
        [Required]
        public string MapInfo { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class TestimonialViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Açıklama ekleyiniz.")]
        public string Comment { get; set; }
        [Required(ErrorMessage = "Ad ekleyiniz.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyad ekleyiniz.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Başlık ekleyiniz.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Reyting Seçiniz.")]
        public int? SelectedRating { get; set; }
        
        public List<SelectListItem>? RatingList { get; set; }
    }
}

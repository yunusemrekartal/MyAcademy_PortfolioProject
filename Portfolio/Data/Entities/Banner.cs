using System.ComponentModel.DataAnnotations;

namespace Portfolio.Data.Entities
{
    public class Banner
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Resim ekleyiniz")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage ="Banner başlığı ekleyiniz")]
        [MinLength(3,ErrorMessage ="Banner başlığı en az 3 karakter olmalıdır")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Banner açıklaması ekleyiniz.")]
        [MaxLength(100, ErrorMessage = "Banner açıklaması en çok 100 karakter olmalıdır.")]
        public string Description { get; set; }

    }
}

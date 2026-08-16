using System.ComponentModel.DataAnnotations;

namespace Portfolio.Data.Entities
{
    public class Experience
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Başlık Ekleyiniz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Açıklama Ekleyiniz")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Şirket Ekleyiniz")]
        public string Company { get; set; }
        [Required(ErrorMessage = "Başlama Yılı Ekleyiniz")]
        [Range(1900, 2100, ErrorMessage = "Başlama yılı sadece sayı olmalı ve geçerli bir yıl girilmelidir.")]
        public int StartYear { get; set; }
        [Range(1900, 2100, ErrorMessage = "Bitiş yılı sadece sayı olmalı ve geçerli bir yıl girilmelidir.")]
        public string? EndYear { get; set; }

    }
}

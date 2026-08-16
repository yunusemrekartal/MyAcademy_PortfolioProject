using System.ComponentModel.DataAnnotations;

namespace Portfolio.Data.Entities
{
    public class Education
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Okul Adı Ekleyiniz.")]
        public string SchoolName { get; set; }
        [Required(ErrorMessage = "Bölüm Ekleyiniz.")]
        public string Department { get; set; }
        [Required(ErrorMessage = "GANO Ekleyiniz.")]
        public string GPA { get; set; }
        [Required(ErrorMessage = "Başlangıç Yılı Ekleyiniz.")]
        public int StartYear { get; set; }
        public string? GraduationYear { get; set; }
        [Required(ErrorMessage = "Açıklama Ekleyiniz.")]
        public string Description { get; set; }

    }
}

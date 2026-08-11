using System.ComponentModel.DataAnnotations;

namespace Portfolio.Data.Entities
{
    public class Project
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Proje görseli ekleyiniz.")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Proje adı giriniz.")]
        [MinLength(3, ErrorMessage = "Proje adı en az 3 karakter olmalıdır.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Proje açıklaması ekleyiniz.")]
        [MaxLength(100, ErrorMessage = "Proje açıklaması en çok 100 karakter olmalıdır.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Github URL giriniz.")]
        public string GithubUrl { get; set; }
        public List<ProjectTechStack>? ProjectTechStacks { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace Portfolio.Data.Entities
{
    public class Service
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "İkon ekleyiniz.")]
        public string Icon { get; set; }
        [Required(ErrorMessage = "Başlık ekleyiniz.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Açıklama ekleyiniz.")]
        public string Description { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Kullanıcı adı boş olamaz.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Parola boş olamaz.")]
        public string Password { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace AgriCulturePresentation.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz.")]
        [MinLength(3,ErrorMessage ="Min 3 karakter giriniz.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi giriniz.")]
        public string Password { get; set; }
    }
}

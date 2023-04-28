using System.ComponentModel.DataAnnotations;

namespace AgriCulturePresentation.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Giriniz!")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Email Adresinizi Giriniz!")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz!")]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi Tekrardan Giriniz!")]
        [Compare("Password",ErrorMessage = "Şifreler uyumlu değil kontrol ediniz.")]
        public string? PasswordConfirm { get; set; }
        [Required(ErrorMessage = "Lütfen Telefon Numarası Giriniz!")]
        public string? PhoneNumber { get; set; }
  
    }
}

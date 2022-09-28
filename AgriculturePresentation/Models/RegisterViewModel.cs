using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgriculturePresentation.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz!")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Lütfen mail giriniz!")]
        public string mail { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi giriniz!")]
        public string password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz!")]
        [Compare("password",ErrorMessage ="Şifreler uyumlu değil, kontrol edin!")]
        public string passwordConfirm { get; set; }
    }
}

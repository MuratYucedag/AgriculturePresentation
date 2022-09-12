using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgriculturePresentation.Models
{
    public class ServiceAddViewModel
    {
        [Display(Name ="Başlık")]
        [Required(ErrorMessage ="Başlık boş geçilemez")]
        public string Title { get; set; }

        [Display(Name = "Görsel")]
        [Required(ErrorMessage = "Görsel değeri boş geçilemez")]
        public string Image { get; set; }

        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Açıklama boş geçilemez")]
        public string Description { get; set; }
    }
}

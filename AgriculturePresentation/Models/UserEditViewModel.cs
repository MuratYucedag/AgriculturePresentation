using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgriculturePresentation.Models
{
    public class UserEditViewModel
    {
        public string  Mail{ get; set; }
        public string  Phone{ get; set; }
        public string  Password{ get; set; }
        public string  ConfirmPassword{ get; set; }
    }
}

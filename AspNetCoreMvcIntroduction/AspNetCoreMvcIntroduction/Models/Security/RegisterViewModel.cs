using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcIntroduction.Models.Security
{
    public class RegisterViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        public string ConfirmedPassword { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int Age { get; set; }


    }
}

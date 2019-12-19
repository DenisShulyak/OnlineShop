using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineShop.DTO
{
    public class AuthDTO
    {
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(4)]
        public string Code { get; set; }
    }
}

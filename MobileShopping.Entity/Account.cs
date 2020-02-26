﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MobileShopping.Entity
{
    public class Account
    {
        //[Required(ErrorMessage = "Name Required")]
        [Required]
        public string UserName { get; set; }

        // [Required(ErrorMessage = "Email Required")]
        // [RegularExpression(" ^[a - zA - Z0 - 9_\\.-] +@([a - zA - Z0 - 9 -] +\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Not Valid EmailId")]
        //[Required]
        [Required]
        public string MailId { get; set; }
        // [Required(ErrorMessage = "Password Required")]
        //[Required]
        [Required]
        public string Password { get; set; }
        //[Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Age")]
        [Range(1, 100, ErrorMessage = "Age Should be min 1 and max 100")]
        [Required]
        public string Age { get; set; }
        //[Required(ErrorMessage = "Please Provide Gender")]
        [Required]
        public string Gender { get; set; }
        //[Required(ErrorMessage = "Mobile Number is required.")]
        [Required]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public long MobileNo { get; set; }
        //[Required(ErrorMessage = "City Required")]
        [Required]
        public string City { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MobileShopping.Entity
{
    public class Account
    {
        
        [Required]
        public string UserName { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
       // [RegularExpression(" ^[a - zA - Z0 - 9_\\.-] +@([a - zA - Z0 - 9 -] +\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Not Valid EmailId")]
       
        public string MailId { get; set; }
       
        [Required]
        
        public string Password { get; set; }

        
        public DateTime CreateDate { get; set; }

        public DateTime UpdatedDate { get; set; }
        public DateTime LastLoginTime { get; set; }
      
        [Range(1, 100, ErrorMessage = "Age Should be min 1 and max 100")]
        [Required]
        public int Age { get; set; }
   
        [Required]
        public string Gender { get; set; }
      
        [Required]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public long MobileNo { get; set; }
      

        [Required]
        public string City { get; set; }

    }
}

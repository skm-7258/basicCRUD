using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace basicCRUD.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Patient Name")]
        [Required(ErrorMessage = "please Enter your patient name")]
        public string Name { get; set; }

            
        [Display(Name ="Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage ="please enter your Email")]
        public string Email { get; set; }

        [Display(Name ="Mobile")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage ="please enter your Mobile Number")]
        public string Mobile { get; set; }
    }
}

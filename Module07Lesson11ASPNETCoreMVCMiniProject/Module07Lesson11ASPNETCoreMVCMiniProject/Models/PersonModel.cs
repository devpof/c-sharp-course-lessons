using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Module07Lesson10ASPNETCoreMVCMiniProject.Models
{
    public class PersonModel
    {
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Active User")]
        public bool IsActive { get; set; }

    }
}

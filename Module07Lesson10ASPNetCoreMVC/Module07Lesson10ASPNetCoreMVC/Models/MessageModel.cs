using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Module07Lesson10ASPNetCoreMVC.Models
{
    public class MessageModel
    {
        // This applies to Razor Pages as well
        [Required]
        [StringLength(10, MinimumLength = 5)]
        [Display(Name = "Cool Message")]
        public string Message { get; set; }
    }
}

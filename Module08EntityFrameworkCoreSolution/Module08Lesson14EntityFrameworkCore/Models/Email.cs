using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08Lesson14EntityFrameworkCore.Models
{
    public class Email
    {
        public int Id { get; set; }

        [Required]
        public int ContactId { get; set; }

        [Required]
        [MaxLength(100)] // This is for C# to know that there is a limit on how many characters
        [Column(TypeName = "varchar(100)")] //datatype depends on which database you are using
        public string EmailAddress { get; set; }
    }
}

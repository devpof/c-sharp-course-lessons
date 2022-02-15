using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08Lesson13LinqAndLambda.Models
{
    public class ContactModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<int> Addresses { get; set; }
    }
}

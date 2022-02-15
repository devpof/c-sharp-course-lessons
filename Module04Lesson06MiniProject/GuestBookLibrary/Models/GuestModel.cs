using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookLibrary.Models;

namespace GuestBookLibrary.Models
{
    public class GuestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //be specific to allow yourself the clarity not to be confused what message it is for
        public string MessageToHost { get; set; }

        public string GuestInfo
        {
            get
            {
                return $"{FirstName} {LastName}: {MessageToHost}";
            }
        }
    }
}

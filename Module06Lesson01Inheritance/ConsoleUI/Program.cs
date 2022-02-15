using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //SmartPhone smartphone = new SmartPhone();
            //smartphone.Carrier = "My Carrier";

            //LandLine landline = new LandLine();
            //landline.PlaceCall();

            //you can also do this
            //base class can be used to accomodate all it's child (direct or indirect) or same level class
            //it will not have access to the Cellphone and Smartphone though
            List<Phone> phones = new List<Phone>();

            phones.Add(new Cellphone());
            phones.Add(new SmartPhone());

            //IS CHECK
            //there is performance penalty for this since it will do a conversion
            //it is not huge but it is there. Do not abuse it!
            foreach (var phone in phones)
            {
                //put the value of phone to Cellphone type called cell
                //SmartPhone class will hit this too because it is a Cellphone
                //be careful with that.
                if (phone is Cellphone cell)
                {
                    cell.Carrier = "My carrier";
                }

                //put the value of phone to SmartPhone type called smartPhone
                if (phone is SmartPhone smartphone)
                {
                    smartphone.ConnectToInternet();
                }
            }

            Console.ReadLine();
        }
    }
}

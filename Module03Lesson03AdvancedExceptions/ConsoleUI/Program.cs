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
            /*
             * ADVANCED EXCEPTIONS
             * 
             * For multiple catch exceptions, the first one that matches will have priority.
             * Always put the general Exception last for multiple catch
             * 
             * PRO-TIP:
             * Exceptions indicate unexpected behavior. Create them yourself it it makes sense.
             */
            string name = "";

            try
            {
                DifferentMethod();

                Console.Write("What is your name: ");
                name = Console.ReadLine();

                ComplexMethod(name);

                SimpleMethod();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("You should not be calling these methods.");
                Console.WriteLine(ex.Message);
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("You forgot to finish your code!!!");
            }
            // you can make it so you run a catch based on a value
            // by using "when" filter/clause
            catch (Exception) when (name.ToLower() == "voldemort")
            {
                Console.WriteLine("You used Voldemort's name, didn't you?");
                //Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //Console.WriteLine(ex.Message);
            }
            // Reason for 'finally' block
            // for cleanup work. Example, for databases and you crash, that db is still open
            // so you need to make sure it is closed so it won't eat memory.
            // always runs after try-catch
            finally
            {
                Console.WriteLine("I always run");
            }

            Console.ReadLine();
        }

        private static void ComplexMethod(string name)
        {
            if (name.ToLower() == "shaq")
            {
                throw new InsufficientMemoryException("Shaq is too tall for this method");
            }

            throw new ArgumentException("This person isn't Shaq");
        }

        // imagine this SimpleMethod is in a different class or a library
        private static void SimpleMethod()
        {
            throw new InvalidOperationException("You should not be calling the SimpleMethod");
        }

        private static void DifferentMethod()
        {
            // you will see this if you use an auto-generated code in Visual Studio.
            // example is when you call a method that is not created yet.
            // Microsoft by default is throwing this exception so that the developer
            // will know this is not yet worked on.

            // PRO-TIP: delete the throw only after you completed coding your method.
            //throw new NotImplementedException();

            Console.WriteLine("This is the different method working properly.");
        }
    }
}

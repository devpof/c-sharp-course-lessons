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
             * HANDLING EXCEPTIONS
             * 
             * Exception - code does something unexpected.
             * 
             * Unhandled Exceptions will crash your application completely
             * 
             * BEST PRACTICES:
             * - Do not blindly catch and ignore exceptions and do not be afraid to close the application.
             * - try and limit on the specific line that you know will have an issue
             * - You need to think ahead.
             * - Make sure you validate your data.
             * - Bad data is the number cause for exceptions.
             */

            // The reason you add another try here so that you can bubble up the exception
            // or you can let the user know what happened. The try-catch inside the BadCall
            // method you can have it do like a log for the developer so that he/she can
            // check if it needs to be handled or not. On the other hand, the try-catch surrounding
            // the BadCall method will allow for custom messages to the user.
            //try
            //{
            //    BadCall();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("There was an exception thrown in our app");
            //    Console.WriteLine(ex.Message);
            //}


            //HomeWork
            HomeWork.Run();

            Console.ReadLine();
        }

        private static void BadCall()
        {
            int[] ages = new int[] { 1, 3, 5 };

            for (int i = 0; i <= ages.Length; i++) //line with exception intentionally
            {
                try
                {
                    Console.WriteLine(ages[i]);
                }
                catch (Exception ex) // ex: unofficial standard of the name of an exception
                {
                    Console.WriteLine("We had an error");
                    // just write ex instead if you are saving it into a file so it has complete info
                    Console.WriteLine(ex.Message);
                    // throw: Caught the exception and keep going as if it was never caught.
                    //        The message will use the line number of where the throw is.
                    // throw ex: This will create a new exception.
                    // throw new Exception(string message, Exception innerException):
                    //      preserve stack trace and line numbers.
                    //      If you look at the InnerException when debugging, you will see the exact line number of the error
                    throw new Exception("There was an error handling our array", ex);
                }

                // in general, avoid writing catch block below. Unless you really need to.
                // maybe useful for logging system into a file and the application
                // can still run even if the part got an exception
                //catch
                //{
                //    Console.WriteLine("We had an error");
                //}
            }
        }
    }
}

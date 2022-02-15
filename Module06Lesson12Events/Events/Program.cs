using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    /*
     * EVENTS
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            CollegeClassModel history = new CollegeClassModel("History 101", 3);
            CollegeClassModel math = new CollegeClassModel("Calculus 201", 2);

            // VS suggested the name of the method. it is based on the name of the class variable
            // and the name of the event. all in PascalCase and spaces are underscore.
            history.EnrollmentFull += CollegeClass_EnrollmentFull;

            history.SignUpStudent("Jane Smith").PrintToConsole();
            history.SignUpStudent("Hannah Banana").PrintToConsole();
            history.SignUpStudent("John Doe").PrintToConsole();
            history.SignUpStudent("Sue Storm").PrintToConsole();

            Console.WriteLine();

            math.EnrollmentFull += CollegeClass_EnrollmentFull;

            math.SignUpStudent("Jane Smith").PrintToConsole();
            math.SignUpStudent("Hannah Banana").PrintToConsole();
            math.SignUpStudent("John Doe").PrintToConsole();
            Console.ReadLine();
        }

        private static void CollegeClass_EnrollmentFull(object sender, string e)
        {
            // there are some apps where you don't get the string e.
            // but if the data is in the sender object passed, you can cast the sender object to its
            // type if you know what the object will be, in this case we know it is CollegeClassModel
            CollegeClassModel model = (CollegeClassModel)sender;

            Console.WriteLine();
            Console.WriteLine(e); //e contains the string you passed on the invocation of the event

            //using the model variable instead of string e, if e is not available.
            //Console.WriteLine($"{model.CourseTitle}: Full"); 
            Console.WriteLine();
        }
    }
}

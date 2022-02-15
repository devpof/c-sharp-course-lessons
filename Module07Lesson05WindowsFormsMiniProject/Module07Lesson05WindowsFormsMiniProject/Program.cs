using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module07Lesson05WindowsFormsMiniProject
{
    // Build a WinForms application with 2 forms. Create a form that takes in a person's info
    // and another that takes in address info (multiple per person).
    // When you click a button it opens up a new form where you add an address in and click
    // the button on the new form, it saves it back to the list box on the first form.
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PersonForm());
        }
    }
}

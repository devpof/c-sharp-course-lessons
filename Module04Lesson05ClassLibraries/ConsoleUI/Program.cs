using DemoLibrary.Models;
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
             * CLASS LIBRARIES
             * - It is not a User Interface. And when it is built, it is built into a .dll file
             * 
             * PRO TIP
             * Store as much of your code in class libraries as possible. The exception to it is
             * in general don't put UI code in your class library. Do the work in the class library and reading and writing
             * in the interface.
             * Class libraries are not to deal with UI stuff. It should deal with C# code.
             * 
             * Demo Library is a differnt project that's why you cannot 
             * get to the PersonModel directly. They do not talk to each other.
             * 
             * REFERENCES
             * To have them talk to each other you have to deal with the References under the Solution
             * References bring in code. Equivalent to import statement of C or C++
             * This is where we will add our own references. In this lesson we will add the DemoLibrary
             * 
             * BUILD mode:
             * DEBUG - objects stay until the end of the application. Development
             * RELEASE - objects get destroyed as soon as it is not used anymore. Deploying
             * 
             * bin > Debug folder.
             * ASSEMBLY NAME
             * Is the name of the application being built. It has the same name as the
             * project name. This appears under the bin > Debug folder. Filename is ConsoleUI.exe
             * Console Applications create executable files.
             * 
             * .pdb FILE
             * used for debugging when you're not in Visual Studio.
             * 
             * DemoLibrary.dll FILE
             * That is the class library. 
             * DLL file is a library file.
             * 
             * The other libraries not included are .NET Framework which is installed in your computer.
             * You have to have the .NET Framework installed in order to run console application in your machine.
             */

            PersonModel person = new PersonModel();
            

            Console.ReadLine();
        }
    }
}

using DemoLibrary;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    /*
     * Access Modifiers
     * public - accessible by anyone
     * private - only accessible in the same class it was declared.
     * protected - accessible on the child/grandchild class of the parent class where a protected modifier
     *              on the properties or method is declared.
     * internal - any class that is in the same assembly/project name can access an internal modifier class, prop or method.
     *              In this case, DataAccess class cannot be accessed outside DemoLibrary
     * protected internal - any class that inherits a class with protected internal modifiers on properties or methods
     *                      are able to access these said properties or methods.
     * private protected - any subclass that inherits a class with a private protected modifier can access them
     *                      but if and only if they are also in the same assembly
     */
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            //person.F

            Console.ReadLine();
        }
    }
}

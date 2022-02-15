using DemoLibrary;

namespace ConsoleUI
{
    public class ModifiedDataAccess : DataAccess
    {
        //protected internal access modifier can now access DataAccess.GetConnectionString
        //calling GetConnectionString from DataAccess
        //you need to inherit the class with protected internal methods if you want the child class to access
        //protected internal properties, methods.
        public void GetUnsecureConnectionInfo()
        {
            GetConnectionString();
        }
    }
}

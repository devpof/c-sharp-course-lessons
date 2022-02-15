using DemoLibrary;

namespace ConsoleUI
{
    public class CEO : Manager
    {
        public void GetConnectionInfo()
        {
            //internal access modifier for DataAccess Class
            //can't do this even though Manager has access to DataAccess.
            //this is because CEO class is not in the same Assembly or Project as DataAccess class.
            
            //protected internal access modifier for DataAccess methods
            //you can instantiate the class but still can't access the GetConnectionString method.
            DataAccess data = new DataAccess();

            //this is a way to get over around it.
            //create a public class here where that class inherits the DataAccess class.
            ModifiedDataAccess mDataAccess = new ModifiedDataAccess();
            mDataAccess.GetUnsecureConnectionInfo();
            formerLastName = "test";
        }
    }
}

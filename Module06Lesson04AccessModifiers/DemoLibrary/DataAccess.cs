namespace DemoLibrary
{
    //internal - This class can only be accessed anywhere inside the DemoLibrary project.
    //protected internal - You need to make the class public, and the method protected internal.
    public class DataAccess
    {
        protected internal string GetConnectionString()
        {
            return "Sensitive Data";
        }
    }
}

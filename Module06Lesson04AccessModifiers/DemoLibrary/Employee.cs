namespace DemoLibrary
{
    //since Employee is a child of Person, everything with protected modifier
    //can be access in this class
    public class Employee : Person
    {
        public string GetFormerLastName()
        {
            return formerLastName;
        }
    }
}

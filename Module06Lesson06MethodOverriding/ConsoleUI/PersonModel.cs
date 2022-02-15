namespace ConsoleUI
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        //Method Overriding: change the way the method behaves.
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}

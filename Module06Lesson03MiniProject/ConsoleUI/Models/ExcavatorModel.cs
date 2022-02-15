using System;

/*
 * Inventory System
 * Ask user to buy or rent things from us
 * 
 */
namespace ConsoleUI
{
    public class ExcavatorModel : InventoryItemModel, IRentable
    {
        public void Dig()
        {
            Console.WriteLine("I am diggin");
        }

        public void Rent()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This excavator has been rented.");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.WriteLine("This excavator has been returned.");
        }
    }
}

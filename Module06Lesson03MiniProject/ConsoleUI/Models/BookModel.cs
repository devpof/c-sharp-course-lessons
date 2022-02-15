using System;

/*
 * Inventory System
 * Ask user to buy or rent things from us
 * 
 */
namespace ConsoleUI
{
    public class BookModel : InventoryItemModel, IPurchasable
    {
        public int NumberOfPages { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This book has been purchased.");
        }
    }
}

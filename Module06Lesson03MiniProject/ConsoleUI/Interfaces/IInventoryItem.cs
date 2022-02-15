/*
 * Inventory System
 * Ask user to buy or rent things from us
 * 
 */
namespace ConsoleUI
{
    public interface IInventoryItem
    {
        string ProductName { get; set; }
        int QuantityInStock { get; set; }
    }
}

/*
 * Inventory System
 * Ask user to buy or rent things from us
 * 
 */
namespace ConsoleUI
{
    public interface IRentable : IInventoryItem
    {
        void Rent();
        void ReturnRental();
    }
}

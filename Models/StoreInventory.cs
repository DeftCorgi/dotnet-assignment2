using System;
namespace MagicInventorySystem.Models
{
    public class StoreInventory
    {
        public int StoreID { get; }

        public int ProductID { get; }
        public Product product { get; set; }

        public int Quantity { get; set; }
    }
}

using System;
namespace MagicInventorySystem.Models
{
    public class StockRequest
    {
        public int ID { get; }

        public int StoreID { get; set; }
        public Store store { get; set; }

        public int ProductID { get; set; }
        public Product product { get; set; }

        public int Quantity { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicInventorySystem.Models
{
    public class OwnerInventory
    {
        [Key, ForeignKey("Product")]
        public int ProductID { get; }
        public Product product { get; set; }

        public int Quantity { get; set; }
    }
}

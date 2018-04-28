using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MagicInventorySystem.Models
{
    public class Store
    {
        public int ID { get; }

        [Required, StringLength(200)]
        public String Name { get; set; }

        public ICollection<StoreInventory> Inventory { get; set; }
    }
}

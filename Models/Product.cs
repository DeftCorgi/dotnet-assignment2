using System;
using System.ComponentModel.DataAnnotations;

namespace MagicInventorySystem.Models
{
    public class Product
    {
        public int ID { get; }

        [Required, StringLength(200)]
        public String Name { get; set; }
    }
}

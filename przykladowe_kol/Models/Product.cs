using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace przykladowe_kol.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int IdProduct { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }
        public float PricePerUnit { get; set; }
        [MaxLength(40)]
        public string Type { get; set; }
        public ICollection<Order_Product> OrdersProducts { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace przykladowe_kol.Models
{
    public class Order_Product
    {
        [Key]
        [ForeignKey("Product")]
        [Required]
        public int IdProduct { get; set; }
        [Key]
        [ForeignKey("Order")]
        [Required]
        public int IdOrder { get; set; }
        [Required]
        public int Quantity { get; set; }
        [MaxLength(300)]
        public string Uwagi { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        
    }
}

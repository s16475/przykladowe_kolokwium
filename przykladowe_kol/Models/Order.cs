using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace przykladowe_kol.Models
{
    public class Order
    {
        [Key]
        [Required]
        public int IdOrder { get; set; }
        [Required]
        public DateTime DataPrzyjecia { get; set; }
        
        public DateTime DataRealizacji { get; set; }
        [MaxLength(300)]
        public string Uwagi { get; set; }
        [ForeignKey("Client")]
        public int IdClient { get; set; }
        [ForeignKey("Employee")]
        public int IdEmployee { get; set; }

        public Client Client { get; set; }
        public Employee Employee { get; set; }

        public ICollection<Order_Product> OrdersProducts { get; set; }
    }
}

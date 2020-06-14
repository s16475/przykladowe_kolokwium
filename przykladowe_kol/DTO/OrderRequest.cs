using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace przykladowe_kol.DTO
{
    public class OrderRequest
    {
        public DateTime DataPrzyjecia { get; set; }
        public string Uwagi { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}

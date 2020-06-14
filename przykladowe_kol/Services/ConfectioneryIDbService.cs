using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace przykladowe_kol.Services
{
    public interface ConfectioneryIDbService
    {
        IActionResult GetOrders(string Surname);
        IActionResult AddOrder(DTO.OrderRequest request, int id);
        IActionResult GetAllOrders();
    }
}

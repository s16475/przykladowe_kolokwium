using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace przykladowe_kol.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class ConfectioneryShopController : ControllerBase
    {
        private readonly Services.ConfectioneryIDbService _dbService;
        public ConfectioneryShopController(Services.ConfectioneryIDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpPost("{id}")]
        public IActionResult addOrder(DTO.OrderRequest request, int id)
        {
            return _dbService.AddOrder(request, id);
        }

        [HttpGet("{Surname}")]
        public IActionResult showOrders(String Surname)
        {
            return _dbService.GetOrders(Surname);
        }
        [HttpGet]
        public IActionResult showAllOrders()
        {
            return _dbService.GetAllOrders();
        }



    }
}

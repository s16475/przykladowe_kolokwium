using Microsoft.AspNetCore.Mvc;
using przykladowe_kol.DTO;
using przykladowe_kol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace przykladowe_kol.Services
{
    public class ConfectioneryDbService : ConfectioneryIDbService
    {
        public ConfectioneryShopDbContext Context { get; set; }
        public ConfectioneryDbService(ConfectioneryShopDbContext dbContext)
        {
            Context = dbContext;
        }

        public IActionResult GetOrders(string Surname)
        {
            
            
            var clientId = Context.Client.Where(a => a.Surname == Surname).Select(a => a.IdClient).FirstOrDefault();
            if (clientId == 0)
                return new BadRequestObjectResult("There is no such client");
            List<ProductResponse> products = new List<ProductResponse>();
            var orderIds = Context.Order.Where(o => o.IdClient == clientId).Select(o => o.IdOrder).ToList();
            foreach (int orderId in orderIds)
            {
                var productIds = Context.Order_Product.Where(o => o.IdOrder == orderId).Select(o => o.IdProduct).ToList();
                foreach (int productId in productIds)
                {
                    var wyrob = new ProductResponse()
                    {
                        Name = Context.Product.Where(p => p.IdProduct == productId).Select(p => p.Name).FirstOrDefault(),
                        Type = Context.Product.Where(p => p.IdProduct == productId).Select(p => p.Type).FirstOrDefault(),
                        Quantity = Context.Order_Product.Where(p => p.IdProduct == productId).Select(p => p.Quantity).FirstOrDefault()
                    };
                    products.Add(wyrob);
                }
            }
            return new OkObjectResult(products);
            
        }

        public IActionResult AddOrder(OrderRequest request, int id)
        {
            if (request.Products.Count() == 0)
                return new BadRequestObjectResult("The request is empty");
            var order = new Order
            {

                DataPrzyjecia = request.DataPrzyjecia,
                Uwagi = request.Uwagi,
                IdClient = id,
                IdEmployee = 1
            };
            Context.Order.Add(order);
            foreach (Products product in request.Products)
            {
                var productId = Context.Product.Where(k => k.Name == product.Product).Select(k => k.IdProduct).FirstOrDefault();
                if (productId == 0)
                    return new BadRequestObjectResult("No such product in database");
                var order_product = new Order_Product
                {
                    IdProduct = productId,
                    IdOrder = order.IdOrder,
                    Quantity = product.Quantity,
                    Uwagi = product.Uwagi
                };
                Context.Order_Product.Add(order_product);
            }
            Context.SaveChanges();

            return new OkResult();
        }

        public IActionResult GetAllOrders()
        {
            List<ProductResponse> orders = new List<ProductResponse>();
            var orderIds = Context.Order.Select(o => o.IdOrder).ToList();
            foreach (int orderId in orderIds)
            {
                var productIds = Context.Order_Product.Where(o => o.IdOrder == orderId).Select(o => o.IdProduct).ToList();
                foreach (int productId in productIds)
                {
                    var product = new ProductResponse()
                    {
                        Name = Context.Product.Where(p => p.IdProduct == productId).Select(p => p.Name).FirstOrDefault(),
                        Type = Context.Product.Where(p => p.IdProduct == productId).Select(p => p.Type).FirstOrDefault(),
                        Quantity = Context.Order_Product.Where(p => p.IdProduct == productId).Select(p => p.Quantity).FirstOrDefault()
                    };
                    orders.Add(product);
                }
            }
            return new OkObjectResult(orders);
        }
    }
}

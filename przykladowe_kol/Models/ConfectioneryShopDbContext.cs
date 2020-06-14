using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace przykladowe_kol.Models
{
    public class ConfectioneryShopDbContext : DbContext
    {
        public DbSet<Client> Client { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Order> Order { get; set; }

        public DbSet<Product> Product { get; set; }
        public DbSet<Order_Product> Order_Product { get; set; }

        public ConfectioneryShopDbContext()
        {

        }

        public ConfectioneryShopDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Client>().HasData(GetClientData());
            modelBuilder.Entity<Employee>().HasData(GetEmployeeData());
            modelBuilder.Entity<Order>().HasData(GetOrderData());
            modelBuilder.Entity<Product>().HasData(GetProductData());
            modelBuilder.Entity<Order_Product>().HasData(GetOrder_ProductData());
        }

        private List<Client> GetClientData()
        {
            var Clients = new List<Client>
            {
                new Client {IdClient = 1, Name="Adam", Surname = "Adamowski" },
                new Client {IdClient = 2, Name="Marian", Surname = "Pazdzioch" },
                new Client {IdClient = 3, Name="Ferdynand", Surname = "Kiepski" },
                new Client {IdClient = 4, Name="Arnold", Surname = "Boczek" }
            };
            return Clients;
        }

        private List<Employee> GetEmployeeData()
        {
            var Employees = new List<Employee>
            {
                new Employee {IdEmployee = 1, Name="Marcin", Surname = "Olejnik" },
                new Employee {IdEmployee = 2, Name="Tomasz", Surname = "Pulawski" },
                new Employee {IdEmployee = 3, Name="Tomasz", Surname = "Siedlecki" },
                new Employee {IdEmployee = 4, Name="Anna", Surname = "Karenina" }
            };
            return Employees;
        }

        private List<Order> GetOrderData()
        {
            var Orders = new List<Order>
            {
                new Order {IdOrder = 1, DataPrzyjecia = DateTime.Parse("19-03-2020"), DataRealizacji = DateTime.Parse("20-03-2020"), Uwagi = null, IdClient = 1, IdEmployee = 1 },
                new Order {IdOrder = 2, DataPrzyjecia = DateTime.Parse("22-04-2020"), DataRealizacji = DateTime.Parse("20-05-2020"), Uwagi = null, IdClient = 1, IdEmployee = 1 },
                new Order {IdOrder = 3, DataPrzyjecia = DateTime.Parse("23-05-2020"), DataRealizacji = DateTime.Parse("20-06-2020"), Uwagi = null, IdClient = 2, IdEmployee = 2 },
                new Order {IdOrder = 4, DataPrzyjecia = DateTime.Parse("10-03-2020"), DataRealizacji = DateTime.Parse("20-07-2020"), Uwagi = null, IdClient = 3, IdEmployee = 3 },
                new Order {IdOrder = 5, DataPrzyjecia = DateTime.Parse("09-03-2020"), DataRealizacji = DateTime.Parse("20-08-2020"), Uwagi = null, IdClient = 4, IdEmployee = 3 },
                new Order {IdOrder = 6, DataPrzyjecia = DateTime.Parse("08-03-2020"), DataRealizacji = DateTime.Parse("20-09-2020"), Uwagi = null, IdClient = 4, IdEmployee = 4 }
            };
            return Orders;
        }

        private List<Product> GetProductData()
        {
            var Products = new List<Product>
            {
                new Product {IdProduct = 1, Name = "Paczek", PricePerUnit = 3.4F, Type = "small" },
                new Product {IdProduct = 2, Name = "Tort", PricePerUnit = 30.0F, Type = "large" },
                new Product {IdProduct = 3, Name = "Szarotka", PricePerUnit = 25.5F, Type = "large" },
                new Product {IdProduct = 4, Name = "Wuzetka", PricePerUnit = 1.5F, Type = "small" }
            };
            return Products;
        }

        private List<Order_Product> GetOrder_ProductData()
        {
            var Order_Products = new List<Order_Product>
            {
                new Order_Product {IdProduct = 1, IdOrder = 1, Quantity = 5, Uwagi = null },
                new Order_Product {IdProduct = 1, IdOrder = 2, Quantity = 10, Uwagi = null },
                new Order_Product {IdProduct = 2, IdOrder = 3, Quantity = 1, Uwagi = null },
                new Order_Product {IdProduct = 2, IdOrder = 4, Quantity = 1, Uwagi = null },
                new Order_Product {IdProduct = 3, IdOrder = 5, Quantity = 2, Uwagi = null },
                new Order_Product {IdProduct = 4, IdOrder = 6, Quantity = 4, Uwagi = null },
            };
            return Order_Products;
        }


    }
}

using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using ShopMVC.Models;
using System.Security.Cryptography.X509Certificates;

namespace ShopMVC.Helper
{
    public static class SeedData
    {
        public static List<Product> Products { get; set; }
        static SeedData() {
            Products = SeedData.GetProduct();
        }
            public static List<Product> GetProduct() {
            return new List<Product>() {
                new Product(){
                    Id=1,
                    Name="Ноутбук Acer Aspire 7",
                    Description="A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black / AMD Ryzen 5 5500U / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650",
                    Price=28999
                },
                new Product(){
                    Id=2,
                    Name="Ноутбук ASUS Laptop",
                    Description="X515EA-BQ2066 (90NB0TY1-M00VF0) Slate Grey / 15.6\" IPS Full HD / Intel Core i3-1115G4 / RAM 12 ГБ / SSD 512 ГБ",
                    Price=16588
                },
                new Product(){
                    Id=3,
                    Name="Ноутбук Acer Aspire 5",
                    Description="A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black / AMD Ryzen 5 5500U / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650",
                    Price=42788
                }
            };
           
        }
     }
}

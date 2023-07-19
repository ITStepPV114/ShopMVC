using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public static class SeedData
    {
        public static List<Product> GetProduct()
        {
            return new List<Product>() {
                new Product(){
                    Id=1,
                    Name="Ноутбук Acer Aspire 7",
                    Description="A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black / AMD Ryzen 5 5500U / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650",
                    Price=28999,
                    ImagePath=@"https://content2.rozetka.com.ua/goods/images/big/343096346.jpg",
                    CategoryId=1
                },
                new Product(){
                    Id=2,
                    Name="Ноутбук ASUS Laptop",
                    Description="X515EA-BQ2066 (90NB0TY1-M00VF0) Slate Grey / 15.6\" IPS Full HD / Intel Core i3-1115G4 / RAM 12 ГБ / SSD 512 ГБ",
                    Price=16588,
                    ImagePath=@"https://content2.rozetka.com.ua/goods/images/big/347802389.jpg",
                    CategoryId=1
                },
                new Product(){
                    Id=3,
                    Name="Ноутбук Acer Aspire 5",
                    Description="A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black / AMD Ryzen 5 5500U / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650",
                    Price=42788,
                    ImagePath=@"https://content1.rozetka.com.ua/goods/images/big/342769719.jpg",
                    CategoryId=1
                },
                new Product(){
                    Id=3,
                    Name="Мобільний телефон Samsung Galaxy A24 6/128GB Black (SM-A245FZKVSEK)",
                    Description="Екран (6.5\", Super AMOLED, 2340x1080) / Mediatek Helio G99 (2 x 2.6 ГГц + 6 x 2.0 ГГц) / основна потрійна камера: 50 Мп + 5 Мп + 2 Мп, фронтальна камера: 13 Мп / RAM2 ГБ вбудованої пам'яті + microSD (до 1 ТБ) / 3G / LTE / GPS / ГЛОНАСС / BDS / підтримка 2х SIM-карток (Nano-SIM) / Android 13 / 5000 мА * год",
                    Price=8999,
                    ImagePath=@"https://content.rozetka.com.ua/goods/images/big/328132324.jpg",
                    CategoryId=2
                }
            };
        }

        public static List<Category> GetCategory()
        {
            return new List<Category>()
            {
                new Category(){ Id=1, Name="Laptop", Description="None"},
                new Category(){ Id=2, Name="Smartphone", Description="None"},
                new Category(){ Id=3, Name="Electronice", Description="None"},
            };
        }

    }
}

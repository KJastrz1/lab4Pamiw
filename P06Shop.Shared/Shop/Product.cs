﻿
namespace P06Shop.Shared.Shop
{
    public class Product
    {       
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Barcode { get; set; }

        public double Price { get; set; }

        public DateTime ReleaseDate { get; set; }

        public ICollection<OrderProduct>? OrderProducts { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace eTicaret.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public  string Isim { get; set; }
        public string ResimUrl { get; set; }
        public decimal Fiyat { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}

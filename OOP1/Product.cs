﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; } 
        public int CategoryId { get; set; }
        public string ProdutcName  { get; set; } //Ürün ismi
        public double UnitPrice { get; set; } //Ürün Fiyatı
        public int UnitsInStock { get; set; } //Ürün Stoğu


    }
}

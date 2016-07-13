using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEssentialTool.Models
{
    public class ShoppingCart
    {
        private IValueCalculator calc;

        public ShoppingCart(IValueCalculator c)
        {
            calc = c;
        }

        public IEnumerable<Product> Products { get; set; }

        public decimal CalculateProductTotal()
        {
            return calc.ValueProducts(Products);
        }
    }
}
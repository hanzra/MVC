using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEssentialTool.Models
{
    public class LinqValueCalculator : IValueCalculator
    {
        IDiscountHelper discount;
        public LinqValueCalculator(IDiscountHelper discount)
        {
            this.discount = discount;
        }
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return discount.ApplyDiscount(products.Sum(p => p.Price));
        }
    }
}
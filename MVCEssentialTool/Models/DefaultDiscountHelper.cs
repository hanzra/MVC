using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEssentialTool.Models
{
    public class DefaultDiscountHelper : IDiscountHelper
    {
        public decimal discountSize { get; set; }
        public decimal ApplyDiscount(decimal param)
        {
            return (param - (param*(discountSize / 100m)));
        }
    }
}
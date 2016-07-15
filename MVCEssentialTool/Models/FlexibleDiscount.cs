using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEssentialTool.Models
{
    public class FlexibleDiscount : IDiscountHelper
    {
        public decimal ApplyDiscount(decimal param)
        {
            decimal discount = param > 100 ? 70 : 50;
            return (param - (discount / 100 * param));
        }
    }
}
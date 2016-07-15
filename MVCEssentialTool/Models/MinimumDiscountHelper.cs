using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEssentialTool.Models
{
    public class MinimumDiscountHelper : IDiscountHelper
    {
        public decimal ApplyDiscount(decimal param)
        {
            if (param < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (param > 100)
            {
                return param * 0.9M;
            }
            else if (param >= 10 && param <= 100)
            {
                return param - 5;
            }
            else {
                return param;
            }
        }
    }
}
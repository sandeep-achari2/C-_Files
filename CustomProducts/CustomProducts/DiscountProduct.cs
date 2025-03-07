using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProducts
{
    public class DiscountProduct
    {
        public decimal Discount { get; set; }
        public decimal GetDiscountedPrice(decimal price)
        {
            return price - Discount;
        }
    }
}

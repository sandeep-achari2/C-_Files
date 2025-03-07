using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProducts
{
    internal class Products
    {
        internal int Id { get; set; }
        public string? ProductName { get; set; }
        public int Price { get; set; }

        public string GetProductInfo()
        {
            return $"Product ID: {Id}, Product Name: {ProductName}, Price: {Price}";
        }
    }
}

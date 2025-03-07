using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    public class Product
    {
        public string name;
        public string Description;

        // Default constructor
        public Product()//use private to make it private
        {
            Console.WriteLine($"Default Constructor at date and time {DateTime.Now.ToString()}");
        }
        public Product(string name, string Description)
        {
            this.name = name;
            this.Description = Description;
        }
    }
}
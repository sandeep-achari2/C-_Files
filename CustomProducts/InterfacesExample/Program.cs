using InterfacesExample;

internal class interface1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Laptop", "Dell Laptop");
            Console.WriteLine("Product Name: " + product.name);
            Console.WriteLine("Product Description: " + product.Description);
            Product product1 = new Product();
        }

    }
}

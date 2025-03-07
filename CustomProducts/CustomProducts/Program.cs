using CustomProducts;

DiscountProduct discountProduct = new DiscountProduct();
Products product = new Products();
product.Id = 1;
product.ProductName = "Laptop";
product.Price = 1000;

discountProduct.Discount = 100;
Console.WriteLine(product.GetProductInfo());
Console.WriteLine($"Discounted Price: {discountProduct.GetDiscountedPrice(product.Price)}");
using System.Collections.Generic;
using CSHARP.Collections;
using System;
namespace CSHARP.Testing
{
    public class ProductTest
    {
        public void testProduct(){
             List<Product> products = Product.GetSampleProducts();
             Predicate<Product>test = delegate(Product p ) { return p.Price > 10m;};
             List<Product>matches = products.FindAll(test);

             Action<Product>print = Console.WriteLine;
             matches.ForEach(print);
        }
    }
}
using System;
using System.Collections.Generic;
using CSHARP.Collections;
using System.Linq;
namespace CSHARP.LINQ
{
    public class Filtering
    {
        public void filterProduct(){
            List<Product>products = Product.GetSampleProducts();
            var filtered = from Product p in products
            where p.Price > 10
            select p;

            foreach(Product p in filtered){
                System.Console.WriteLine(p);
            }
        }
    }
}
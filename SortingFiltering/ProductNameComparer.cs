using CSHARP.Collections;
using System.Collections.Generic;
namespace CSHARP.SortingFiltering
{
    public class ProductNameComparer
    {
        public void compareProduct(){
            List<Product> products = Product.GetSampleProducts();
            products.Sort((x, y) => x.Name.CompareTo(y.Name));
            foreach (Product product in products)
            {
                System.Console.WriteLine(product);
            }
        }
    }
}
using System;
using CSHARP.Collections;
using CSHARP.SortingFiltering;
using CSHARP.Testing;
using CSHARP.LINQ;
namespace CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Collections
            /*Product p = new Product(name: "Test",price: 13.33m);
            System.Console.WriteLine(p.ToString());

            //SortingFiltering
            ProductNameComparer productNameComparer = new ProductNameComparer();
            productNameComparer.Compare();*/

            //Test
            /*ProductTest productTest = new ProductTest();
            productTest.test();*/
            XML xml = new XML();
            xml.processXML();

        }
    }
}

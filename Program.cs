using System;
using CSHARP.Collections;
using CSHARP.SortingFiltering;
using CSHARP.Testing;
using CSHARP.LINQ;
using CSHARP.Delegates;
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
           
           Person jon = new Person("Jon");
           Person tom = new Person("Tom");
           StringProcessor jonsVoice, tomsVoice, background;
           jonsVoice = new StringProcessor(jon.Say);
           tomsVoice = new StringProcessor(tom.Say);
           background = new StringProcessor(Background.Note);

           jonsVoice("Hello, son");
           tomsVoice.Invoke("Hello, Dad");
           background("An airplane flies past.");
        }
    }
}

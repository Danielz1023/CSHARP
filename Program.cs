using System;
using CSHARP.Collections;
using CSHARP.SortingFiltering;
using CSHARP.Testing;
using CSHARP.LINQ;
using CSHARP.Delegates;
using CSHARP.Multithreading;
using System.Threading.Tasks;
using System.Collections.Generic;
using CSHARP.Generics;
using CSHARP.Iterator;
using CSHARP.Nullable;

namespace CSHARP
{
    class Program
    {
        static async Task Main(string[] args)
        {
            /*Product p = new Product(name: "Test",price: 13.33m);
            System.Console.WriteLine(p.ToString());

            //SortingFiltering
            ProductNameComparer productNameComparer = new ProductNameComparer();
            productNameComparer.Compare();*/

            //Test
            /*ProductTest productTest = new ProductTest();
            productTest.test();*/

           //Delegates
           /*Person jon = new Person("Jon");
           Person tom = new Person("Tom");
           StringProcessor jonsVoice, tomsVoice, background;
           jonsVoice = new StringProcessor(jon.Say);
           tomsVoice = new StringProcessor(tom.Say);
           background = new StringProcessor(Background.Note);

           jonsVoice("Hello, son");
           tomsVoice.Invoke("Hello, Dad");
           background("An airplane flies past.");*/

           //Sync
           //Sync sync = new Sync();
           //sync.execute();

           //Async
           //Async async = new Async();
           //await async.execute();

           //AsyncParallel
           //AsyncWithParallel asyncWithParallel = new AsyncWithParallel();
           //await asyncWithParallel.execute();

           //Dictionary
           /*string text = @"Do you like green eggs and ham?
                            I do not like them, Sam-I-am.
                            I do not like green eggs and ham.";
           Dictionary<string,int> frequencies = Dictionary.CountWords(text);
           foreach(KeyValuePair<string, int> entry in frequencies){
               string word = entry.Key;
               int frequency = entry.Value;
               System.Console.WriteLine("{0} : {1} ",word,frequency);
            }*/
            
            //Generics
            //ListGeneric.run();

            //Reference comparison
            /*string name = "Daniel";
            string intro1 = "My name is " + name;
            string intro2 = "My name is " + name;
            System.Console.WriteLine(intro1 == intro2);
            System.Console.WriteLine(RefComparison.AreReferenceEqual(intro1,intro2));*/

            //Generic iterator
            /*GenericIterator counter = new GenericIterator();
            foreach(int x in counter){
                System.Console.WriteLine(x);
            }*/

            //Nullable
            NullablePerson turing = new NullablePerson("Alan Turing",new DateTime(1912,6,23),new DateTime(1954,6,7));
            NullablePerson knuth = new NullablePerson("Donald Knuth", new DateTime(1938,1,10),null);

        }
    }
}

﻿using System;
using CSHARP.Collections;
using CSHARP.SortingFiltering;
using CSHARP.Testing;
using CSHARP.LINQ;
using CSHARP.Delegates;
using CSHARP.Multithreading;
using System.Threading.Tasks;
using System.Collections.Generic;

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
            
        }
    }
}

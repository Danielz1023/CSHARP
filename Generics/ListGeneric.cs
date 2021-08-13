using System.Collections.Generic;

namespace CSHARP.Generics
{
    public class ListGeneric
    {
        public static List<T> MakeList<T>(T first, T second){
            List<T> list = new List<T>();
            list.Add(first);
            list.Add(second);
            return list;
        }
        public static void run(){
            List<string> list = MakeList<string>("Line 1","Line 2");
            foreach(string x in list){
                System.Console.WriteLine(x);
            }
        }
    }
}
using System;
namespace CSHARP.Delegates
{
    delegate void StringProcessor(string input);
    public class Person
    {
        string name;
        public Person(string name) { this.name = name;}
        public void Say(string message){
            System.Console.WriteLine("{0} says: {1}",name,message);
        }
    }
    class Background
    {
        public static void Note(string note){
            System.Console.WriteLine("({0})",note);
        }
    }
}
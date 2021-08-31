using System;
using System.Collections;
using System.Collections.Specialized;
namespace String_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String_Collections");
            DemoStringCollec obj = new DemoStringCollec();
            obj.PrintStringCollection();

            
        }
    }

    class DemoStringCollec
    {
        public void PrintStringCollection()
        {
            StringCollection sc = new StringCollection();
            Console.WriteLine("Befor Adding Elements in String Count");
            Console.WriteLine(sc.Count);

            // Adding elements in StringCollection
            sc.Add("C#");
            sc.Add("C++");
            sc.Add("Python");
            sc.Add("Java");
            sc.Add("SQL");

           
            Console.WriteLine("After Adding Element in String Count");
            Console.WriteLine(sc.Count);
        }
    }
}

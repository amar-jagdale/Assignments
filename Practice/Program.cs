using System;

namespace Practice
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //int i = null;
            //Console.WriteLine(i);
            Nullable<int> i1 = null;
            Nullable<int> s1 = 20;
            Console.WriteLine(i1.GetValueOrDefault());
            Console.WriteLine(s1.HasValue);
        }
    }


}

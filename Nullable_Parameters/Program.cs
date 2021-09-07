using System;
using System.Collections.Generic;

namespace Nullable_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============= Nullable Parameters =====================");
            NullableMethod();
            NonNullable();

        }

        public static void NullableMethod()
        {
            // defining Nullable type
            Nullable<int> a = null;

            // using the method
            // output will be 0 as default
            
            Console.WriteLine("Output of Nullable Value Bydefault :");
            // value of null is 0
            Console.WriteLine(a.GetValueOrDefault());

            int? Num1 = null;
            Console.WriteLine("Output of Nullable Variale of Num1 is :");
            Console.WriteLine(Num1.GetValueOrDefault());
        }


        public static void NonNullable()
        {
            // to define non-nullable
            Nullable<int> Num1 = 54;
            Console.WriteLine("Output of NonNallable Value of Num1 is:");
            Console.WriteLine(Num1.GetValueOrDefault());


            Nullable<int> Num2 = 90;
            Console.WriteLine("Output of NonNallable Value of Num2 is:");
            Console.WriteLine(Num2.GetValueOrDefault());
        }
    }
}

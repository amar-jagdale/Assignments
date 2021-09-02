using System;
using System.Collections.Generic;

namespace Generic_Class_Method_Implements
{                                              // Why we use Generic Because it is Makes your Code Type Independent
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("============== Generic Method Class Implementation ============");

            // Making Method as Generic<Data Type>
            bool Eqaul = Calculator.AreEqual<int>(2,10);  // Conversion of value types to object type at run time called boxing
            if (Eqaul)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }


            // Making Class as Generic<Data Type>
            //bool Eqaul = Calculator<string>.AreEqual(2, 10);  // Conversion of value types to object type at run time called boxing
            //if (Eqaul)
            //{
            //    Console.WriteLine("Equal");
            //}
            //else
            //{
            //    Console.WriteLine("Not Equal");
            //}
        }
    }
    //Making Method as Generic
    public class Calculator
    {
        public static bool AreEqual<T>(T value1, T value2)    // Creating Method Generic// Object Data types is class are predefined to support any Data Type 
       {
            return value1.Equals(value2);   // Compare value using Equals method      // T iscould be a int, string ,enum etc
        }
    }

    // Making Class as Generic 
    //public class Calculator<T> //Generic Class
    //{
    //    public static bool AreEqual(T value1, T value2)    
    //    {
    //        return value1.Equals(value2);                                      
    //}
}

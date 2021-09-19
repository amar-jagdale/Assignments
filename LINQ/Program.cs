using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq; // required for LINQ


namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- LINKQ  OEPRATION ON ARRAY---------");
            int[] arr = {11,24,58,4,75,26,44,78,55,47,98,25,34,56,58};
            // var brr = from i in arr select i;           //LINQ query FOR SELECTING ALL ELEMENT FROM QUERY LIKE sql querY(SELECT * FROM TABLE)
            //var brr = from i in arr where i > 40 orderby i select i; // Condition element greter than 40 and with sorted
            var brr = from i in arr where i > 40 orderby i descending select i; // condition with descending order element
            foreach (int item in brr)
            {
                Console.Write(" " + item);
            }
            Console.ReadLine();
           
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace FindTwoDigitNumFromList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Find Two Digit Number from List -----");
            List<int> arrayList = new List<int>();
            int num = 6;
            for(int j = 0; j < num; j++)
            {
                int item = Convert.ToInt32(Console.ReadLine());
                arrayList.Add(item);
            }

            int i = 0;
            foreach (var item in arrayList)
            {
                if(item>9 && item < 99)
                {
                    Console.WriteLine(item);
                }
                i++;
            }
            
          
            
        }
    }
}

using System;
using System.Collections;

namespace Sorted_LIst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Sorted_List_Impl obj = new Sorted_List_Impl();
            obj.Print_SortedList();
        }
    }

    class Sorted_List_Impl
    {
        public void Print_SortedList()
        {
            SortedList sl = new SortedList();

            //Adding item into HashTable  
            sl.Add(1, "Amar");
            sl.Add(12, "C#");
            sl.Add(8, "Java");
            sl.Add(4, "SQL");
            Console.WriteLine("Count : {0}", sl.Count);

            if (sl.ContainsValue(".NET"))
            {
                Console.WriteLine(".NET is already exist in the SortedList");
            }
            else
            {
                sl.Add(5, ".NET");
            } 
            Console.WriteLine("Value and key at position 2 is {0} , {1}", sl.GetByIndex(2), sl.GetKey(2));

            Console.Write("keys are : ");
            foreach (int i in sl.Keys)
            {
                Console.Write(i + " ");
                //sl.Remove(3);
            }
                
            //Geting the keys and value from SortedList  
            IList keys = sl.GetKeyList();
            IList values = sl.GetValueList();
            Console.WriteLine("\nValues are :");

            foreach (object obj in values)
            {
                Console.WriteLine(obj);
                Console.WriteLine("Index of Amar is : {0}", sl.IndexOfValue("Amar"));
            }
         
            Console.ReadLine();
        }

    }
}


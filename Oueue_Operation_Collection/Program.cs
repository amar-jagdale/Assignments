using System;
using System.Collections;

namespace Oueue_Operation_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            TestBitArray obj = new TestBitArray();
            obj.PrintBitArray();
        }
    }

    class TestBitArray
    {
        public void PrintBitArray()
        {
            // Declaring a Queue  
            Queue q = new Queue();

            // Adds an element at the end of Queue i.e. Enqueue operation  
            q.Enqueue(" Amar ");
            q.Enqueue(1);
            q.Enqueue(10.5);
            q.Enqueue(true);
            q.Enqueue('A');


            //Get the number of elements present in the Queue  
            Console.WriteLine("Count : {0}", q.Count);
            Console.WriteLine();


            //Printing all the element of Queue  
            Console.WriteLine("Element in Queue : ");
            foreach (object obj in q)
            {
                Console.WriteLine(obj);
                //Console.WriteLine();
            }

            //Returns the end of the Queue without removing  
            Console.WriteLine("End element of Queue : {0}", q.Peek());
            Console.WriteLine();


            //Removes and Returns the end element of the Queue i.e. Dequeue operation  
            object TopElement = q.Dequeue();
            Console.WriteLine("Removing End element of Queue = {0}\nNow End element of Queue = {1}\n", TopElement, q.Peek());


            //Determines whether an element present or not in the Queue  
            if (q.Contains('A'))
            {
                Console.WriteLine("A Found");
            }
            else
            {
                Console.WriteLine("Amar Not found");
            }

            //Copies the qack to a new Array(object)  
            Object[] ob = q.ToArray();
            Console.WriteLine();

            foreach (object obj in ob)
            {
                Console.WriteLine(obj);
            }

            //Trim the Queue  
            q.TrimToSize();

            //Removes all the element from Queue  
            q.Clear();
            
            Console.WriteLine("Count : {0}", q.Count);
            Console.ReadLine();
        }
    }
}


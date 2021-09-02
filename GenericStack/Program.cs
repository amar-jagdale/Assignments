using System;
using System.Collections.Generic;

namespace GenericStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******* Generic Stack *********");
            TestStack obj = new TestStack();
            obj.StackMethod();

        }
    }
     public class TestStack
    {
        public void StackMethod()
        {
            Stack<string> my_stack = new Stack<string>();
            my_stack.Push("Amar");
            my_stack.Push("Atul");
            my_stack.Push("Sachin");
            my_stack.Push("John");

            foreach (var item in my_stack)
            {
                Console.WriteLine(item);
            }

            // Total Element contained in the Stack
            Console.Write("Total number of elements in the Stack are : ");
            Console.WriteLine(my_stack.Count);


            // Displaying the top element of Stack
            // without removing it from the Stack
            Console.WriteLine("Element at the top is : " + my_stack.Peek());
            Console.WriteLine(my_stack.Count);   // Peek shows the Element without remaining Element so count is as it is


            Console.WriteLine("Remove Element at the top: ", my_stack.Pop());
            Console.WriteLine("After Removing Element Total Count is : ", my_stack.Count);

            Console.ReadLine();


        }
    }
}

using System;
using System.Collections.Generic;

namespace GenericStackImplement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================== GenericStack ===================");

            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "John",
                Gender = "Male"
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Amar",
                Gender = "Male"
            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Maria",
                Gender = "Female"
            };

            Customer customer4 = new Customer()
            {
                ID = 104,
                Name = "Peterson",
                Gender = "Male"
            };

            Stack<Customer> Stackcustomers = new Stack<Customer>();    //Creation of Stack Class instance 
            // push Item in Stack by using Push Method
            Stackcustomers.Push(customer1);
            Stackcustomers.Push(customer2);
            Stackcustomers.Push(customer3);
            Stackcustomers.Push(customer4);

            // Remove Element From Stack using Pop Method
            //Customer c1 = Stackcustomers.Pop();

          
            // show remaining Items in Stack
            //foreach (Customer c1 in Stackcustomers)
            //{
            //    Console.WriteLine(c1.ID + " " + c1.Name);   
            //    Console.WriteLine("Items left in the Stack:= " + Stackcustomers.Count);
            //}

            Customer c1 = Stackcustomers.Peek(); // Display the Top of the item in stack 
            Console.WriteLine(c1.ID + " " + c1.Name);
            Console.WriteLine("Items left in the Stack:= " + Stackcustomers.Count);


        }
    }

    public class Customer
    {
        public int ID { get; set; }      // Creating Properties
        public string Name { get; set; }
        public string Gender { get; set; }
    };
}

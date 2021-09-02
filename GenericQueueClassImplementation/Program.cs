using System;
using System.Collections.Generic;
namespace GenericQueueClassImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============== Queue Implementation =============");

            Customer cust1 = new Customer
            {
                Eid = 101,
                name="Sam",
                city="Goa"
            };

            Customer cust2 = new Customer
            {
                Eid = 102,
                name = "Shree",
                city = "Pune"
            };

            Customer cust3 = new Customer
            {
                Eid = 103,
                name = "Atul",
                city = "Mumbai"
            };

            Customer cust4 = new Customer
            {
                Eid = 104,
                name = "Amar",
                city = "Banglore"
            };

            Queue<Customer> queueCustomers = new Queue<Customer>();  // Queue generic Class Object Creation


            // Applying Enqueu Method
            queueCustomers.Enqueue(cust1);
            queueCustomers.Enqueue(cust2);
            queueCustomers.Enqueue(cust3);
            queueCustomers.Enqueue(cust4);

            // Applying Dequeue Method
            Customer c1 = queueCustomers.Dequeue();
            Console.WriteLine(c1.Eid + "" + c1.name);
            Console.WriteLine("Total Items in the Queue is:= " + queueCustomers.Count);

            Customer c2 = queueCustomers.Dequeue();
            Console.WriteLine(c2.Eid + "" + c2.name);
            Console.WriteLine("Total Items in the Queue is:= " + queueCustomers.Count);

            Customer c3 = queueCustomers.Dequeue();
            Console.WriteLine(c3.Eid + "" + c3.name);
            Console.WriteLine("Total Items in the Queue is:= " +queueCustomers.Count);

            Customer c4 = queueCustomers.Dequeue();
            Console.WriteLine(c4.Eid + "" + c4.name);
            Console.WriteLine("Total Items in the Queue is:= " + queueCustomers.Count);
        }
    }

    public class Customer
    {
        public int Eid { get; set; }
        public string name { get; set; }
        public string city { get; set; }
    }
}

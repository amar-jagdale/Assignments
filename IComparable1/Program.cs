using System;
using System.Collections;
using System.Collections.Generic;

namespace IComparable1
{
    class Employee : IComparable<Employee>
    {
        public int Salary { get; set; }
        public string Name { get; set; }

        public int CompareTo(Employee other)
        {
            // Alphabetic sort if salary is equal. [A to Z]
            if (this.Salary == other.Salary)
            {
                return this.Name.CompareTo(other.Name);
            }
            // Default to salary sort. [High to low]
            return other.Salary.CompareTo(this.Salary);
        }

        public override string ToString()
        {
            // String representation.
            return this.Salary.ToString() + "," + this.Name;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee() { Name = "Amar", Salary = 10000 });
            list.Add(new Employee() { Name = "JOHN", Salary = 10000 });
            list.Add(new Employee() { Name = "SAM", Salary = 10000 });
            list.Add(new Employee() { Name = "Sachin", Salary = 500000 });
            list.Add(new Employee() { Name = "Atul", Salary = 80000 });

            // Uses IComparable.CompareTo()
            list.Sort();

            // Uses Employee.ToString
            foreach (var element in list)
            {
                Console.WriteLine(element);

            }
            Console.ReadLine();
        }
    }
}

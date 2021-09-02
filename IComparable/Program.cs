using System;
using System.Collections;

namespace IComParable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** ICOmparable Implementation*****");
            Console.WriteLine("=====================================");

            ArrayList AL = new ArrayList();
            AL.Add(new Employee() { EmpName = "Amar", EmpId = 101 });
            AL.Add(new Employee() { EmpName = "Sam", EmpId = 102 });
            AL.Add(new Employee() { EmpName = "John", EmpId = 103 });
            AL.Add(new Employee() { EmpName = "Atul", EmpId = 101 });
            AL.Add(new Employee() { EmpName = "Sachin", EmpId = 104 });

            Employee emp = new Employee();
            emp.CompareTo(emp);
            foreach (var e in AL)
            {
                Console.WriteLine(e);
            }
        }
    }

    public class Employee: IComparable<Employee>
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }

        public int CompareTo(Employee e)
        {
            if (this.EmpId == e.EmpId)
            {
                return this.EmpName.CompareTo(e.EmpName);
            }

            return e.EmpId.CompareTo(this.EmpId);
        }

        public override string ToString()
        {
            return this.EmpId.ToString() + " : " + this.EmpName;
        }

    }
}



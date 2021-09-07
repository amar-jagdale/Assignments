using System;
using ClassLibrary1;
namespace CRUD_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================== CRUD__IMPLEMENTATION USING SQL =======================");
            Class1 obj = new Class1();
            obj.DisplayEmployee();

            obj.Addemployee();
            obj.DisplayEmployee();

            obj.EditEmployee();
            obj.DisplayEmployee();
            
            obj.DeleteEmployee();
            obj.DisplayEmployee();
           
        }
    }
}

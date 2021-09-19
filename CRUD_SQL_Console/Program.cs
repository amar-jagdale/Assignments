using System;
using DAL_CRUD;
using Model;
namespace CRUD_SQL_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================== CRUD__IMPLEMENTATION USING SQL =======================");
            CRUD_Implement obj = new CRUD_Implement();
            obj.DisplayEmployee();

            //obj.Addemployee();
            Employee emp = obj.GetInputFromUser();
            obj.AddNewEmployee(emp);
            obj.DisplayEmployee();

            //obj.EditEmployee();
            Employee editemp = obj.GetInputFromUser();
            obj.EditEmployee(editemp);
            obj.DisplayEmployee();

            Employee deleteemp = obj.GetInputFromUser();
            obj.DeleteEmployee(deleteemp);
            obj.DisplayEmployee();
        }
    }
}

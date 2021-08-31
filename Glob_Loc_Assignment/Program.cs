using System;
using ClassLibrary_Glob_loc_Assignment;
namespace Glob_Loc_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Class1 obj = new Class1();
            obj.local_method();
            obj.second_method();
        }
    }
}

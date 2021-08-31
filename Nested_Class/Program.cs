using System;
using ClassLibrary_NestedClass;
namespace Nested_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nested Class");
            //outer Class
            Outer_class obj = new Outer_class();
            // Outer Class Method
            obj.method1();

            //inner Class accessing the using . operator
            Outer_class.Inner_class obj1 = new Outer_class.Inner_class();
            // inner class method
            obj1.method2();
            
        }
    }
}

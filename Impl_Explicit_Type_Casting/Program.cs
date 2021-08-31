using System;
using ClassLibrary_Impl_Expl_TypeCast;
namespace Impl_Explicit_Type_Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Class1 obj = new Class1();
            obj.implTypeCast();
            obj.ExplTypeCast();
        }
    }
}

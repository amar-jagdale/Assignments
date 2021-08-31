using System;

namespace ClassLibrary_Impl_Expl_TypeCast
{
    public class Class1
    {
        public void implTypeCast()
        {
            //Implicit Casting(automatically) - converting a smaller type to a larger type size
            //char -> int -> long -> float -> double
            int a = 10;
            float b = a;
            Console.WriteLine("Before Casting:= "+b);
            Console.WriteLine(a);
            Console.WriteLine("After Casting: "+b);
        }

        public void ExplTypeCast()
        {
            //Explicit Casting (manually) - converting a larger type to a smaller size type
            //double -> float -> long -> int -> char
            double  d= 102.15d;
            int j = (int)d;
           
            Console.WriteLine(d);
            Console.WriteLine("After Casting: " + j);
        }

    }
}

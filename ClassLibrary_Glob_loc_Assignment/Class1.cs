using System;

namespace ClassLibrary_Glob_loc_Assignment
{
    public class Class1
    {
        //Globval Variable
        int b = 10;
        public void local_method()
        {
            // Local Variable
            int a = 10;
            Console.WriteLine("Global Variable Inside Method 1 " + b);
            Console.WriteLine("Loobal Variable Inside Method " + a);
        }
        public void second_method()
        {
            //Console.WriteLine("Global Variable Inside Method " + a);        // loca variable cannot accesed outside the method
            Console.WriteLine("Global Variable Inside Method 2 " + b);
        }
    }
}

using System;

namespace ClassLibrary_NestedClass
{
    // Outer class
    public class Outer_class
    {

        // Method of outer class
        public void method1()
        {
            Console.WriteLine("Outer class method");
        }

        // Inner class
        public class Inner_class
        {

            // Method of inner class
            public void method2()
            {
                Console.WriteLine("Inner class Method");
            }
        }
    }
}

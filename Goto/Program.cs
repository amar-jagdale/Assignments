using System;

namespace Goto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___Go_To__Lable");
            Goto obj = new Goto();
            obj.ImplGoto();
       }
    }

    class Goto
    {
        public void ImplGoto()
        {
            for (int i = 0; i <10; i++)
            {
                if (i == 5)
                {
                    goto exitlable;
                }

                Console.WriteLine(i);
            }
            Console.WriteLine("Statement after loop");

            exitlable:
            Console.WriteLine("Statement after lable");
        }
    }
}

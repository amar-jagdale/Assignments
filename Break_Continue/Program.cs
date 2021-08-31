using System;

namespace Break_Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Break_Continue_Statement");
            BreakContinue obj = new BreakContinue();
            obj.BreakConTinue();
        }
    }

    class BreakContinue
    {
        public void BreakConTinue()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}

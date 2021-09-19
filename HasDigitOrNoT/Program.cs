using System;

namespace HasDigitOrNoT
{
    class Program
    {
        private static bool HasDigit(int digit, int num)
        {
            while (num > 0)
            {
                if (num % 10 == digit)
                    return true;
                num /= 10;
                //num=num/10;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("HasDigitPresentOrNot");
            int num = Convert.ToInt32(Console.ReadLine());
            int digit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(HasDigit(digit, num));

        }
    }
}



using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public static int CountDs(string str)
        {
            int count = 0;
            for (int x = 0; x <=str.Length+1; x++)
            {
                if(str[x]<='D'|| str[x] >= 'd')
                {
                    count--;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string inpustr = Console.ReadLine();
            int count = CountDs(inpustr);
            Cobnso
        }
    }
}

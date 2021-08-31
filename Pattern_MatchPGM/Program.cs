using System;

namespace Pattern_MatchPGM
{
    class Program
    {
        static void Main(string[] args)
        {
            Trangle obj = new Trangle();
            obj.PrintTrangle();
            obj.PrintTrangleReverse();

            Diamond obj1 = new Diamond();
            obj1.DiamondShape();

            int n;
            Console.WriteLine("Enter Number :");
            n = Convert.ToInt32(Console.ReadLine());
            Pattern2 obj2 = new Pattern2();
            obj2.PrintPatern2(n);
           
        }
    }


    public class Trangle
    {
        public void PrintTrangle()
        {
            for (int i = 1; i <=5; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public void PrintTrangleReverse()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <=5; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

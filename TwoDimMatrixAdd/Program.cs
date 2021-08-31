using System;

namespace TwoDimMatrixAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Two Dimentional Matrix Addition");
            ArrayAddition obj = new ArrayAddition();
            obj.PrintAddMatrix();
        }
    }
   

    class ArrayAddition
    {
        public void PrintAddMatrix()
        {
                int[,] a = new int[3, 3];
                int[,] b = new int[3, 3];
                int[,] c = new int[3, 3];
                Console.WriteLine("Enter The Elements into the First Array");

                for (int i = 0; i <a.Length; i++)
                {
                    for (int j = 0; j <a.Length; j++)
                    {
                        a[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("Enter The Elements into the Second Array");
                for (int i = 0; i < b.Length; i++)
                {
                    for (int j = 0; j < b.Length; j++)
                    {
                        b[i, j] = int.Parse(Console.ReadLine());
                    }
                }


                Console.WriteLine("Addition of Two Matrix Is: ");
                for (int i = 0; i < c.Length; i++)
                {
                    for (int j = 0; j < c.Length; j++)
                    {
                        c[i, j] = a[i, j] + b[i, j];
                    }
                }

            Console.WriteLine("Result of Addition is ....");
            for (int i = 0; i <c.Length; i++)
            {
                for (int j = 0; j <c.Length; j++)
                {
                    Console.WriteLine(c[i, j]);
                }
            }

        }
    }
       
}

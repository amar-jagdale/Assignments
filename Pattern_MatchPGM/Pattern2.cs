using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_MatchPGM
{
    class Pattern2
    {
        public void PrintPatern2(int n)
        {
            
            //int m = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k);

                }
                for (int m = i - 1; m >= 1; m--)
                {
                    Console.Write(m);
                }


                Console.WriteLine();
            }
            for (int i = n - 1; i >= 1; i--)
            {

                for (int k = n - i; k >= 1; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for (int m = i - 1; m >= 1; m--)
                {
                    Console.Write(m);
                }
                Console.WriteLine();
            }
        }
    }
}

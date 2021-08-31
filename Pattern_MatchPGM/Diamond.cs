using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_MatchPGM
{
    class Diamond
    {
        public void DiamondShape()
        {
            for (int i = 1; i <= 4; i++)
            {
                int n = 4;

                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k >= 1; k--)
                {
                    Console.Write(k);
                }
                for (int l = 2; l <= i; l++)
                {
                    Console.Write(l);
                }

                Console.WriteLine();
            }

            for (int i = 3; i >= 1; i--)
            {
                int n = 3;

                for (int j = 0; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k >= 1; k--)
                {
                    Console.Write(k);
                }
                for (int l = 2; l <= i; l++)
                {
                    Console.Write(l);
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

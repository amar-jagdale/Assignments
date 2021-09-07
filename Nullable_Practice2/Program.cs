using System;
using System.Threading.Tasks;

namespace Nullable_Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============ Nullable ========");
            Myclass mycls = new Myclass();
            if (mycls.i == null)
            {
                Console.WriteLine("Null");
            }
            else
            {
                Console.WriteLine("Not Null");
            }
        }
    }

   public class Myclass
    {
        public Nullable<int> i = null;
    }
}



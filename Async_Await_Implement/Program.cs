using System;
using System.Threading.Tasks;
namespace Async_Await_Implement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============== Async and Await =================");
            Method1();
            Method2();
        }

        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i <20;  i++)
                {
                    Console.WriteLine("Method 1");
                    Task.Delay(200).Wait();
                }
            });
        }

        public static void Method2()
        {
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(" Method 2");
                // Do something
                Task.Delay(200).Wait();
            }
        }
    }
}

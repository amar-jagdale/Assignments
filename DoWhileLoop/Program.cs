using System;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do___While__Loop");
            TestDo_While obj = new TestDo_While();
            obj.TestDoWhile();

        }
    }

    class TestDo_While
    {
        public void TestDoWhile()
        {
            string actaulpin = "4321";
            int count = 0;
            string pin;

            do
            {
                Console.WriteLine("Enter Your PIN: ");
                pin = Console.ReadLine();
                count++;
            } while (pin != actaulpin && count <= 3);
            //Console.ReadLine();

            if (pin == actaulpin)
            {
                Console.WriteLine("Welcome User");
            }
            else
            {
                Console.WriteLine("Acount is Locked Please Contact Your Bank");
            }
        }
    }
}

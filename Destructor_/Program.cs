using System;

namespace Destructor_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Destructor Program *****");
            TestConstructor obj = new TestConstructor();
            obj.Values(12,2);
            
        }
    }

    public class TestConstructor
    {
        int Roll, Batch_no;

        // Constructor
        public TestConstructor()
        {
            Roll = 0;
            Batch_no = 0;
        }

        //Parametrized Method
        public void Values(int a,int b)
        {
            Roll = a;
            Batch_no = b;

            Console.WriteLine("Roll Number is:= " + Roll);
            Console.WriteLine("Batch_No: "+Batch_no);
        }

        //Destructor
        ~TestConstructor()
        {
            Console.WriteLine("Destructor Called");
        }
    }
}

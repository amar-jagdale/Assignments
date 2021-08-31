using System;

namespace Operator_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Value_Data_Types ******");
            ValueDataType obj = new ValueDataType();
            obj.Print_Value_Data_Type();


            //For_Each_lOOP
            Foreach obj1 = new Foreach();
            obj1.ForEachLoop();

        }
    }
    class ValueDataType
    {
        public void Print_Value_Data_Type()
        {
            int myNum = 5;               // Integer (whole number)
            double myDoubleNum = 5.99D;  // Floating point number
            char myLetter = 'D';         // Character
            bool B= true;          // Boolean
            string myText = "Hello";
            float b = 10.23f;


            Console.WriteLine("Integer: "+myNum);
            Console.WriteLine("Double: "+myDoubleNum);
            Console.WriteLine("Bool_Data Type Value: "+B);
            Console.WriteLine("String: "+myText);
            Console.WriteLine("Float Value is: {0}"+b);
            Console.WriteLine("Char: "+myLetter);

        }       
    }
    class Foreach
    {
        public void ForEachLoop()
        {
            string[] IPL = { "CSK", "Mumbai_Indians", "KKR", "SRH" };
            foreach (string i in IPL)
            {
                Console.WriteLine(i);
            }
        }
    }
}

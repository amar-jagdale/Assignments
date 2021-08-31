using System;

namespace ClassLibrary_Accssp_Demo_Cal
{
    public class Calculator
    {
        public int a;
        public int b;
        public int res;

        public void UserInput()
        {
            Console.WriteLine("Enter First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            
        }

        private void Addition()
        {
            res = a + b;
            Console.WriteLine("Additon of Two nuumber is: ",res);
        }

        internal void Substraction()
        {
            res = a - b;
            Console.WriteLine("Substraction of Two nuumber is: ", res);
        }

        public void Multiplication()
        {
            res = a * b;
            Console.WriteLine("Multiplication of Two nuumber is: ", res);
        }

         public void Division()
        {
            res = a / b;
            Console.WriteLine("Division of Two nuumber is: ", res);
        }
    }
}

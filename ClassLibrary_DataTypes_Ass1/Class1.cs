using System;

namespace ClassLibrary_DataTypes_Ass1
{
    public class Class1
    {
        // Default Value of Variable
        public void Default_Datatypes()
        {
            int a = default;
            float b = default;
            double d = default;
            decimal e = default;
            char c = default;
            string name = default;
            bool j = default;
            //enum E= default;


            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(d); 
            Console.WriteLine(e);
            Console.WriteLine(c);
            Console.WriteLine(name);
            Console.WriteLine(j);
        }

        //Variable Data Initialization
         public void dataTypes_initialization()
        {
            int id = 10;
            float sal = 251.21f;
            char ch = 'A';
            double num = 1245d;
            decimal num1 = 2451.24m;
            bool b = true;
         
            Console.WriteLine(id+" "+sal+" "+ch+" "+num+" "+num1+" "+b);


            // Constant Variable
            const int varconst= 12;
            Console.WriteLine("Constant Variable: " + varconst);
            //varconst = 15; // Changing Value of Constant Variable is not Possible Here
            const int B= varconst * 5; //Right Way
            //const int varconst= varconst * 5; // Wrong Way
        }
        
        public void rangedataType()
        {
            Console.WriteLine("Range of int data type is: "+int.MaxValue);
            Console.WriteLine("Range of float data type is: " + float.MaxValue);
            Console.WriteLine("Range of Decimal data type is: " + decimal.MaxValue);
            Console.WriteLine("Range of Double data type is: " + double.MaxValue);
            //Console.WriteLine("Range of string data type is: " + string.Empty);
            //Console.WriteLine("Range of char data type is: " + char.MaxValue);
        }
    }

}

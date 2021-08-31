using System;

namespace Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do_While_Switch__Case");
            DoSwitch obj = new DoSwitch();
            obj.PrintDoSwitch();
        }
    }

    class DoSwitch
    {
        public void PrintDoSwitch()
        {
            string Option;
            do
            {
                Console.WriteLine("_Address_Book__");
                Console.WriteLine("N--Add New Entry");
                Console.WriteLine("U--Update The Record");
                Console.WriteLine("R--Remove The Entry");
                Console.WriteLine("S-Show all Entry");
                Console.WriteLine("C--Close\n");

                Console.WriteLine("Please Enter Your Choice: ");
                Option = Console.ReadLine();

                switch (Option)
                {
                    case "N":
                        Console.WriteLine("You Have Selelcted the Add New Entry");
                        break;

                    case "U":
                        Console.WriteLine("You Have Selelcted Update the Entry Option");
                        break;

                    case "R":
                        Console.WriteLine("You Have Selected the Remove Record");
                        break;

                    case "C":
                        Console.WriteLine("The Programme will be Close now");
                        break;

                    default:
                        Console.WriteLine("Wrong Choice");
                        break;

                }
                Console.ReadLine();
            }

            
            while (Option!="C" && Option!="c");
        }
    }
}


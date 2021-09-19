using System;
using System.Collections;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- REVERSE STRING ---------");
            Console.WriteLine("Enter the String");
            string inputstr = Convert.ToString(Console.ReadLine());
            string resultstring = string.Join(" ", inputstr.Split(' ').Select(x => new string(x.Reverse().ToArray())));
            Console.WriteLine(resultstring);

            ReverseString obj = new ReverseString();
            obj.DispRevrstr();
            
        }
    }

    public class ReverseString
    {
        public void DispRevrstr()
        {
            Console.WriteLine("Enter String 2");
            string inpstr = Convert.ToString(Console.ReadLine());
            string reslut = string.Join(" ", inpstr.Split(' ').Select(y => new string(y.Reverse().ToArray())));
            Console.WriteLine(reslut);
        }
    }
}

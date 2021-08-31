using System;

namespace Enum_Programme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enum Data Type");
            Months obj = Months.August;
            Console.WriteLine(obj);
        }
    }

    enum Months
    {
        January,      //0
        February,     //1
        March,        //2
        April,
        June,
        July,
        August
    }
}

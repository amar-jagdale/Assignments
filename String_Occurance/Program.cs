using System;

namespace String_Occurance
{
    class Program
    {
        static int countOccurrences(string str,
                           string word)
        {
            // split the string by spaces
            string[] a = str.Split(' ');

            // search for pattern in string
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {

                // if match found increase count
                if (word.Equals(a[i]))
                    count++;
            }

            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the Word");
            string word = Convert.ToString(Console.ReadLine());
            Console.WriteLine(countOccurrences(str, word));

        }
    }
}

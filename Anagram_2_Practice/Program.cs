using System;

namespace Anagram_2_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Word First");
            string word1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Word Second");
            string word2 = Convert.ToString(Console.ReadLine());

            char[] char1 = word1.ToLower().ToCharArray();
            char[] char2 = word2.ToLower().ToCharArray();

            Array.Sort(char1);
            Array.Sort(char2);
           string newword1 = new string(char1);
           string newword2 = new string(char2);

            if (newword1 == newword2)
            {
                 Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}

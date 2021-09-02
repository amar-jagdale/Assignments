using System;
using System.Collections.Generic;
namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************ Implementaion of Generic List **************");
            Console.WriteLine("===========================================================");
            TestGenericList obj = new TestGenericList();
            obj.Display_List();



        }
    }

    public class TestGenericList
    {
        public void Display_List()
        {
            // Creating list using List Object
            // List Constructor List<T>

            List<int> my_List = new List<int>();

            // Adding Element to List by using Add method
            my_List.Add(125);
            my_List.Add(100);
            my_List.Add(5000);
            my_List.Add(9000);
            my_List.Add(22000);
            my_List.Add(44444);

            foreach (var item in my_List)
            {
                Console.WriteLine(item);                                                
            }
            Console.WriteLine("===========================================================");

            // Initial Count of List
            Console.WriteLine("Initial Count of List is: {0}", my_List.Count);

            // Uncomment the one by one method and check Output

            ////// Remove Element 100 using Remove() method
            //my_List.Remove(100);
            //Console.WriteLine("After Removing 2nd Elelment count is:{0}", my_List.Count);


            /////Remove Element using RemoveAt() method
            my_List.RemoveAt(4);
            Console.WriteLine("Remove Element Using RemoveAt method Remaining No of element Count is : {0}", my_List.Count);


            //// After using RemoveRange() method
            //my_List.RemoveRange(0, 2);
            //Console.WriteLine("Remove Element Using RaemoveRange method :{0}", my_List.Count);

            //// After using Clear() method
            //my_List.Clear();
            //Console.WriteLine("Total no of Element after using the Clear Method :{0}", my_List.Count);

            Console.ReadLine();
        }



    }



}

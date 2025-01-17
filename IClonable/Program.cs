﻿using System;
using System.Collections;
namespace IClonable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>>  IClonable  >>>>");
            Car car1 = new Car(1695);
            Car carTwo = car1.Clone() as Car;

            Console.WriteLine("{0}mm", car1);
            Console.WriteLine("{0}mm", carTwo);
        }
    }
    class Car : ICloneable
    {
        int width;

        public Car(int width)
        {
            this.width = width;
        }

        public object Clone()
        {
            return new Car(this.width);
        }

        public override string ToString()
        {
            return string.Format("Width of car = {0}", this.width);
        }
    }


}

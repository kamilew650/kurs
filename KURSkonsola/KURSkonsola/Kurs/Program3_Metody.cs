﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSkonsola
{
    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            var sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }

    public class Point 
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;

        }

        public void Move(Point newLocation)
        {
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");

            Move(newLocation.X, newLocation.Y);
        }

    }

    class Program3
    {
        //public static void Main(string[] args)
        //{

        //    //var number = int.Parse("abc");
        //    int number;
        //    var result = int.TryParse("abc", out number);
        //    if (result)
        //        Console.WriteLine(number);
        //    else
        //        Console.WriteLine("Conversion failed");


        //}

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at: {0}. {1}. ", point.X, point.Y);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("An unexpected error occured");
            }
        }

        static void UsePrams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
        }
    }
}

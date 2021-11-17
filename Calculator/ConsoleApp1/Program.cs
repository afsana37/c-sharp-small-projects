using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            double num1  = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The Result is: ");
            Console.WriteLine(num1 + num2);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace Return // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);
            Console.ReadLine();


        }

        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}
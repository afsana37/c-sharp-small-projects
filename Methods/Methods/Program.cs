using System;
using System.Collections.Generic;
using System.Linq;

namespace Array // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {

            SayHi("Mike Hannigan", 33);
            SayHi("Paul Rudd", 52);
            SayHi("Ant Man", 40);
            Console.ReadLine();


        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " your ages is " + age);
        }
    }
}
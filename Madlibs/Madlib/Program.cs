using System;
using System.Collections.Generic;
using System.Linq;

namespace Madlib // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string color, pluralNoun, movie;

            Console.WriteLine("Enter a color: ");
            color = Console.ReadLine();

            Console.WriteLine("Enter a pluralNoun: ");
            pluralNoun = Console.ReadLine();

            Console.WriteLine("Enter a movie: ");
            movie = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + movie);

            Console.ReadLine();

        }
    }
}
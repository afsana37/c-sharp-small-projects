using System;
using System.Collections.Generic;
using System.Linq;

namespace Array // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            string[] friends = new string[6];

            friends[0] = "Chandler";
            friends[1] = "Monica";
            friends[2] = "Joey";

            friends[3] = "Phoebe";
            friends[4] = "Ross";
            friends[5] = "Rachel";

            //Console.WriteLine(luckyNumbers[2]);
            Console.WriteLine(friends[3]);
            Console.ReadLine();


        }
    }
}
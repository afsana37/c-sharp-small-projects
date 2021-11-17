using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld // Note: actual namespace depends on the project name.
{ 

    public class Program
    {
        public static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;

            Console.WriteLine(c>b || c==a);

        }
    }

}


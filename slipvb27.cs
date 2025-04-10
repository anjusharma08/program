using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string : ");
            string input = Console.ReadLine();

            int length = input.Length;

            Console.WriteLine("The length of the string is: " +length);


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Program
    {

        static int Add(int a, int b)
        {
            return a + b;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1 no : ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2 no : ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int sum = Add(n1,n2);
            Console.WriteLine("The sum of 2 number is: "+sum);

            Console.WriteLine("Press any kry...");
            Console.ReadKey();


        }
    }
}

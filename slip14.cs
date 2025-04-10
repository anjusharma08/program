using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 10, 15, 20, 25 };
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("The sumof all elments in the array is :"+sum);
            Console.WriteLine("Press any kry...........");
            Console.ReadKey();
        }
    }
}

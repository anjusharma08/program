using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i<number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;       
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (IsPrime(num))
                Console.WriteLine(num + "is a prime number");
            else
                Console.WriteLine(num + "is not a prime number");

            Console.WriteLine("Press any key.....");
            Console.ReadKey();

        }
    }
}

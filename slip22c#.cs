using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("After Swapping: ");
            Console.WriteLine("A =" + a);
            Console.WriteLine("B =" + b);

        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter value of a : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping : ");
            Console.WriteLine("A= " + a);
            Console.WriteLine("B= " + b);


            swap(a, b);

            Console.WriteLine("Press any kry.........");
            Console.ReadKey();
        }
       
    }
}
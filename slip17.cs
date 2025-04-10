using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            String s;
            Console.WriteLine("Enter the String: ");
            s = Console.ReadLine();
            s = s.ToLower();

            Console.WriteLine("Vowels in Strings are : ");
            for(int i=0;i<s.Length;i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                {
                    Console.WriteLine(s[i]);
                    Console.WriteLine("pressc any kry ....");
                    Console.ReadKey();

                }

            }
        }
    }
}

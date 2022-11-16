using System;
using System.Security.Principal;
using System.Threading;

namespace Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                PritHalf(1, i);
            }
            for (int i = number - 1; i >= 1; i--)
            {
                PritHalf(1, i);
            }


        }
        static void PritHalf(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

        }


    }
}

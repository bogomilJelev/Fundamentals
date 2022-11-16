using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Printin(number);
        }

        static void Printin(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number == 0)
            {
                Console.WriteLine("The number 0 is zero.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
        }
    }
}

using System;

namespace condis2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            int number = 0;
            if (age % 2 == 0)
            {
                number = 2;
            }
            if (age % 3 == 0)
            {
                number = 3;
            }
            if (age % 6 == 0)
            {
                number = 6;
            }
            if (age % 7 == 0)
            {
                number = 7;
            }
            if (age % 10 == 0)
            {
                number = 10;
            }
            if (number == 0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {number}");
            }
        }
    }
}

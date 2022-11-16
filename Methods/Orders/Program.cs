using System;
using System.Security.Principal;
using System.Threading;

namespace ask
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            if (name == "coffee")
            {
                PrintSum(count, 1.50);
            }
            else if (name == "water")
            {
                PrintSum(count, 1.00);
            }
            else if (name == "coke")
            {
                PrintSum(count, 1.40);
            }
            else if (name == "snack")
            {
                PrintSum(count, 2.00);
            }

        }
        static void PrintSum(int count, double prize)
        {
            double all = count * prize;
            Console.WriteLine($"{all:f2}");
        }


    }
}

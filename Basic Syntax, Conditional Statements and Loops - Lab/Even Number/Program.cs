using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    num = Math.Abs(num);
                    Console.WriteLine($"The number is: {num}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }


            }
        }
    }
}


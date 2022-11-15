using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int num1 = 1;
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(num1);
                num1 += 2;
                sum += num1;


            }
            Console.WriteLine($"Sum: {(sum + 1) - num1}");
        }
    }
}


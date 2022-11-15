using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            if (end >= 1 && end <= 10)
                for (int i = end; i <= 10; i++)
                {
                    int sum = number * i;
                    Console.WriteLine($"{number} X {i} = {sum}");

                }
            else if (end > 10)
            {
                int sum2 = number * end;
                Console.WriteLine($"{number} X {end} = {sum2} ");
            }


        }
    }
}


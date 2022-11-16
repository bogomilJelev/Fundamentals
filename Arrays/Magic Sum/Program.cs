using System;
using System.Linq;

namespace ask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number2 = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
            {
                int first = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (first + numbers[j] == number2)
                    {
                        Console.WriteLine($"{first} {numbers[j]}");
                        break;
                    }
                }
            }
        }
    }
}

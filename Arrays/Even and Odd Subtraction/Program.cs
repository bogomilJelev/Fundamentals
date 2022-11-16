using System;
using System.Linq;

namespace arrays

{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int summeven = 0;
            int summodd = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    summeven += numbers[i];
                }
                else
                {
                    summodd += numbers[i];
                }

            }
            Console.WriteLine(summeven - summodd);



        }
    }
}

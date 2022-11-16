using System;
using System.IO;
using System.Linq;

namespace datatype_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Middle(input);





        }
        static void Middle(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                char a = input[i];
                char z = input[i + 1];
                int count1 = 0;
                int count2 = 0;
                for (int j = i + 1; j < input.Length; j++)
                {
                    count1++;
                }
                for (int b = i; b > 0; b--)
                {
                    count2++;
                }
                if (count1 == count2)
                {
                    Console.WriteLine($"{a}");
                    break;

                }
                else if (count1 == count2 + 1)
                {
                    Console.WriteLine($"{a}{z}");
                    break;
                }
                count1 = 0;
                count2 = 0;

            }
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {

            int ask = int.Parse(Console.ReadLine());
            string name = string.Empty;
            string age = string.Empty;
            int index = 0;
            int index2 = 0;
            int index3 = 0;
            int index4 = 0;
            for (int i = 0; i < ask; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int z = 0; z < input.Length; z++)
                {
                    char cur = input[z];
                    if (cur == '@')
                    {
                        index = z;
                    }
                    else if (cur == '|')
                    {
                        index2 = z;
                    }
                    else if (cur == '#')
                    {
                        index3 = z;
                    }
                    else if (cur == '*')
                    {
                        index4 = z;
                    }
                }

                int last = index2 - index;
                int last2 = index4 - index3;
                for (int z = index + 1; z < index + last; z++)
                {
                    name += input[z];
                }
                for (int f = index3 + 1; f < index3 + last2; f++)
                {
                    age += input[f];
                }
                Console.WriteLine($"{name} is {age} years old.");
                name = string.Empty;
                age = string.Empty;

            }



        }
    }
}

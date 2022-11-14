using System;
using System.IO;

namespace da_da
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool isTrue = false;


            for (int i = 1; i <= num; i++)
            {
                int count = 0;
                int dig = i;
                while (dig > 0)
                {
                    count += dig % 10;
                    dig = dig / 10;
                }
                if (count == 5 || count == 7 || count == 11)
                {
                    isTrue = true;

                }
                else
                {
                    isTrue = false;
                }
                Console.WriteLine($"{i} -> {isTrue}");

            }


        }
    }
}

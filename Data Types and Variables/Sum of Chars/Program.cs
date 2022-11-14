using System;
using System.IO;

namespace datatype_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                char curchar = char.Parse(Console.ReadLine());
                int curnum = curchar;
                sum += curnum;



            }


            Console.WriteLine($"The sum equals: {sum}");




        }
    }
}

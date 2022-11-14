using System;
using System.IO;

namespace datatype_1
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            long sum = 0;
            while (number > 0)
            {
                long last = number % 10;
                number /= 10;
                sum += last;


            }
            Console.WriteLine(sum);


        }
    }
}

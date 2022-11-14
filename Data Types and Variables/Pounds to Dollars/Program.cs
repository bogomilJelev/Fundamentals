using System;
using System.IO;

namespace da_da
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            decimal dolar = number * 1.31m;
            Console.WriteLine($"{dolar:f3}");

        }
    }
}

using System;
using System.IO;

namespace datatype_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            long sum = (num1 + 0L + num2) / num3 * num4;
            Console.WriteLine(sum);
        }
    }
}

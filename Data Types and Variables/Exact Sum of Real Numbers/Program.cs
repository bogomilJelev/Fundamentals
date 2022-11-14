using System;
using System.IO;

namespace da_da
{
    class Program
    {
        static void Main(string[] args)
        {
            int countfor = int.Parse(Console.ReadLine());
            decimal summ = 0;
            for (int i = 0; i < countfor; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                summ += num;

            }
            Console.WriteLine(summ);
        }
    }
}

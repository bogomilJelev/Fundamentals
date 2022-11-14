//using Microsoft.VisualBasic.CompilerServices;
using System;
//using System.IO;

namespace da_da
{
    class Program
    {
        static void Main(string[] args)
        {
            string sss = "";
            for (int i = 0; i < 3; i++)
            {
                char ask = char.Parse(Console.ReadLine());
                sss += ask;
            }
            Console.WriteLine(sss);

        }
    }
}

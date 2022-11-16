using System;
using System.IO;
using System.Linq;

namespace datatype_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            NxN(num);




        }
        static void NxN(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int z = 0; z < number; z++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }

    }
}


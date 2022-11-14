using System;
using System.IO;

namespace datatype_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                char curchar = (char)(i);
                Console.Write(curchar + " ");

            }


        }
    }
}

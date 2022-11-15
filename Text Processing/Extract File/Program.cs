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
            string[] text = Console.ReadLine().Split("\\").ToArray();
            int index = text.Length - 1;
            string[] file = text[index].Split(".").ToArray();
            Console.WriteLine($"File name: {file[0]}");
            Console.WriteLine($"File extension: {file[1]}");
        }
    }
}

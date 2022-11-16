using System;
using System.Collections.Generic;
using System.Linq;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split().Where(w => w.Length % 2 == 0).ToArray();
            foreach (var item in word)
            {
                Console.WriteLine(item);
            }
        }
    }
}

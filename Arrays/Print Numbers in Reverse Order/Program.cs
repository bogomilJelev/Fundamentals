﻿using System;
using System.Linq;

namespace arrays

{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

            }
            Console.Write(string.Join(' ', numbers.Reverse()));


        }
    }
}

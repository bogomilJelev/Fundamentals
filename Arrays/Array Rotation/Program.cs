using System;
using System.Linq;

namespace ask
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ").ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string indexzero = arr[0];
                for (int j = 1; j < arr.Length; j++)
                {
                    arr[j - 1] = arr[j];

                }
                arr[arr.Length - 1] = indexzero;

            }
            Console.WriteLine(string.Join(' ', arr));



        }
    }
}


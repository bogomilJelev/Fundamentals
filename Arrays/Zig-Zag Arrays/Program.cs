using System;
using System.Linq;

namespace ask
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];
            string[] arr2 = new string[n];
            for (int i = 0; i < n; i++)
            {
                string[] ast = Console.ReadLine().Split(" ").ToArray();
                string indexzero = ast[0];
                string indexone = ast[1];
                if (i % 2 == 0)
                {
                    arr[i] = indexzero;
                    arr2[i] = indexone;
                }
                else if (i % 2 == 1)
                {
                    arr2[i] = indexzero;
                    arr[i] = indexone;
                }

            }
            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine(string.Join(" ", arr2));


        }
    }
}

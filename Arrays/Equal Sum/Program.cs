using System;
using System.Linq;

namespace ask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToArray();
            bool ask = false;

            for (int curr = 0; curr < arr.Length; curr++)
            {
                int sumeright = 0;

                for (int i = curr + 1; i < arr.Length; i++)
                {
                    sumeright += arr[i];
                }

                int sumleft = 0;

                for (int j = curr - 1; j >= 0; j--)
                {
                    sumleft += arr[j];

                }
                if (sumleft == sumeright)
                {
                    Console.WriteLine(curr);
                    ask = true;
                    break;
                }
            }
            if (!ask)
            {
                Console.WriteLine("no");
            }
        }
    }
}

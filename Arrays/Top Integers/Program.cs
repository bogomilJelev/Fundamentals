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
            bool ask = true;
            for (int i = 0; i < arr.Length; i++)

            {
                int cur = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {



                    if (arr[j] >= cur)
                    {

                        ask = false;
                        break;

                    }
                }
                if (ask)
                {
                    Console.Write(cur + " ");
                }
                ask = true;


            }
        }
    }
}

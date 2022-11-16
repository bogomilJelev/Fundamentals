using System;
using System.Linq;

namespace ask
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();      //1 2 2  3 4 5 5 5 
            int bestcount = 0;
            int maxindex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                string firstn = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (firstn == arr[j])
                    {
                        count++;

                    }
                    else
                    {
                        break;
                    }
                }
                if (count > bestcount)
                {
                    bestcount = count;
                    maxindex = i;
                }
            }
            for (int i = 0; i < bestcount; i++)
            {
                Console.Write(arr[maxindex] + " ");
            }
        }
    }
}

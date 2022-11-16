using System;
using System.Linq;

namespace ask
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(" ");
            string[] arr2 = Console.ReadLine().Split(" ");
            foreach (string elementtwo in arr2)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (elementtwo == arr1[i])
                    {
                        Console.Write(elementtwo + " ");
                        break;
                    }
                }
            }


        }
    }
}

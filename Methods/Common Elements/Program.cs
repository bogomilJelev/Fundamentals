using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] arr1 = Console.ReadLine().Split(" ").ToArray();
        string[] arr2 = Console.ReadLine().Split(" ").ToArray();
        foreach (var item in arr2)
        {
            foreach (var item2 in arr1)
            {
                if (item == item2)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }


}


using System;
using System.Linq;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int sum = 0;
            bool IsTrue = true;
            int index = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                int arrr1 = arr1[i];
                int arrr2 = arr2[i];
                if (arrr1 == arrr2)
                {
                    sum += arrr1;

                }
                else
                {
                    index = i;
                    IsTrue = false;
                    break;
                }

            }
            if (IsTrue)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
            }



        }
    }
}

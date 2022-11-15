using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sum = 1;
            int allsum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                char curnum = (number[i]);
                int num = int.Parse(curnum.ToString());
                for (int z = num; z > 0; z--)
                {
                    sum *= z;
                }
                allsum += sum;


            }
            int number1 = int.Parse(number);
            if (number1 == allsum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();

            int num2 = int.Parse(Console.ReadLine());
            int ost = 0;
            int result = 0;
            List<int> sb = new List<int>();
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int cur = int.Parse(num1[i].ToString());
                result = cur * num2;
                if (ost != 0)
                {
                    result += ost;
                    ost = 0;
                }
                if (result > 9)
                {
                    ost = result / 10;
                    int ost2 = result % 10;
                    sb.Add(ost2);
                }
                else
                {
                    sb.Add(result);
                }

            }
            sb.Reverse();
            if (ost > 0)
            {
                Console.Write(ost);
                foreach (var item in sb)
                {

                    Console.Write(item);
                }
            }
            else
            {
                foreach (var item in sb)
                {
                    Console.Write(item);
                }
            }


        }
    }
}

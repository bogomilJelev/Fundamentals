using System;


namespace Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string result = PrintSum(order, count);
            Console.WriteLine(result);
        }

        private static string PrintSum(string str, int count)
        {
            string result = string.Empty;

            for (int i = 0; i < count; i++)
            {
                result += str;

            }
            return result;

        }
    }
}

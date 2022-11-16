using System;
//using System.IO;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayofweed = { "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday" };

            int day = int.Parse(Console.ReadLine());

            if (day < 1 || day > dayofweed.Length)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(dayofweed[day - 1]);
            }
        }
    }
}

using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 30;
            int mit = minutes - 60;
            if (minutes >= 60)
            {
                hours++;
                minutes = mit;
                if (minutes <= 9)
                {

                }

            }
            if (hours >= 24)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}


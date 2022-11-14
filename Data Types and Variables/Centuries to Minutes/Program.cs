using System;
using System.IO;

namespace da_da
{
    class Program
    {
        static void Main(string[] args)
        {
            int centurues = int.Parse(Console.ReadLine());
            int years = centurues * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minute = 60 * hours;
            Console.WriteLine($"{centurues} centuries = {years} years = {days} days = {hours} hours = {minute} minutes");


        }
    }
}

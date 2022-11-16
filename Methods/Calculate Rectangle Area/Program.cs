using System;
using System.Security.Principal;
using System.Threading;

namespace Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double widht = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double result = PrintSum(widht, height);
            Console.WriteLine(result);
        }
        static double PrintSum(double we, double he)
        {
            return we * he;


        }
    }
}

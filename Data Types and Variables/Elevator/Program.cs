using System;
using System.IO;

namespace datatype_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double people = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());
            double course = Math.Ceiling(people / capacity);
            Console.WriteLine(course);


        }
    }
}

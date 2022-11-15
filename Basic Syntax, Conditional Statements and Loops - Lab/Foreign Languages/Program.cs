using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            if (name == "USA" || name == "England")
            {
                Console.WriteLine("English");
            }
            else if (name == "Spain" || name == "Argentina" || name == "Mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}


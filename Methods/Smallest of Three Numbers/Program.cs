using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());
        IsValid(number, number2, number3);

    }

    private static void IsValid(int number, int number2, int number3)
    {
        if (number < number2 && number < number3)
        {
            Console.WriteLine(number);
        }
        else if (number2 < number && number2 < number3)
        {
            Console.WriteLine(number2);
        }
        else if (number3 < number && number3 < number2)
        {
            Console.WriteLine(number3);
        }
    }


}



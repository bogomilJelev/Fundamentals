using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        char a = char.Parse(Console.ReadLine());
        char b = char.Parse(Console.ReadLine());
        IsValid(a, b);

    }

    private static void IsValid(char a, char b)
    {
        if (a > b)
        {
            char first = a;
            a = b;
            b = first;
        }
        for (int i = a + 1; i < b; i++)
        {
            Console.Write((char)i + " ");
        }
    }


}


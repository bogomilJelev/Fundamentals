using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string name = Console.ReadLine();
        IsValid(name);

    }

    private static void IsValid(string name)
    {
        int count = 0;
        for (int i = 0; i < name.Length; i++)
        {
            char a = name[i];
            if (a == 'a' || a == 'A' || a == 'e' || a == 'E' || a == 'i' || a == 'I' || a == 'o' || a == 'O' || a == 'u' || a == 'U')
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }


}


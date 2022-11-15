using System;


namespace assaray
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            foreach (char ch in input)
            {
                var curcar = (char)(ch + 3);
                Console.Write(curcar);
            }

        }

    }
}


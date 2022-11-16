using System;
using System.IO;
using System.Linq;

namespace datatype_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int result = Add(num1, num2);
            int rress = Substra(result, num3);
            Console.WriteLine(rress);





        }
        static int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        static int Substra(int result, int num3)
        {
            int ress2 = result - num3;
            return ress2;
        }
    }
}


using System;
using System.Linq;
using System.Text;

namespace assaray
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            int bom = 0;
            for (int i = 0; i < text.Length; i++)
            {
                var churent = text[i];
                if (churent == '>')
                {
                    bom += int.Parse(text[i + 1].ToString());
                    continue;
                }
                if (bom > 0)
                {
                    text = text.Remove(i, 1);
                    i--;
                    bom--;
                }
            }
            Console.WriteLine(text);
        }
    }
}
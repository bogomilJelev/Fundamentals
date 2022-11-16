using System;
using System.Collections.Generic;
using System.Linq;

namespace assaray
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> output = new Dictionary<string, List<double>>();
            string command = Console.ReadLine();
            while (command != "buy")
            {
                string[] comand = command.Split();
                string nameitem = comand[0];
                double prodprice = double.Parse(comand[1]);
                double quantity = double.Parse(comand[2]);

                if (!output.ContainsKey(nameitem))
                {
                    List<double> pricequan = new List<double> { prodprice, quantity };
                    output.Add(nameitem, pricequan);
                }
                else
                {
                    output[nameitem][0] = prodprice;
                    output[nameitem][1] = output[nameitem][1] + quantity;
                }


                command = Console.ReadLine();

            }
            foreach (var item in output)
            {
                double tootle = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {tootle:f2} ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
  

    class Program
    {
        static (double peso, double yen) ConvertCurrency(double dollar)
        {
            double peso = dollar * 57.17;
            double yen = dollar * 146.67;
            return (peso, yen);
        }

        static void Main()
        {
            Console.Write("Enter currency in ($): ");
            string[] values = Console.ReadLine().Split(',');

            Console.WriteLine("\nDollar($)\tPhil Peso(P)\tJpn Yen(Y)");
            foreach (string v in values)
            {
                double dollar = double.Parse(v);
                var (peso, yen) = ConvertCurrency(dollar);
                Console.WriteLine($"{dollar}\t\t{peso:F2}\t\t{yen:F2}");
            }
            Console.ReadKey();
        }
    }
}

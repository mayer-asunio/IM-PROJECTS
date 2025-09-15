using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
        class Program
        {
            static string PrimeOrComposite(int n)
            {
                if (n <= 1) return "Composite"; 
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                        return "Composite";
                }
                return "Prime";
            }

            static void Main(string[] args)
            {
                Console.Write("Enter numbers (separated by space): ");
                string[] input = Console.ReadLine().Split();

                for (int i = 0; i < input.Length; i++)
                {
                    int num = int.Parse(input[i]);
                    Console.WriteLine($"{i + 1}. {num,-5} {PrimeOrComposite(num)}");
                }

                Console.ReadKey();
            }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
 
        {
            static void Main()
            {
                string input;

                while (true)
                {
                    Console.Write("Enter string: ");
                    input = Console.ReadLine();

                    if (input == "*")
                        break;

                    string original = input;
                    string lowered = input.ToLower();

                    char[] charArray = lowered.ToCharArray();
                    Array.Reverse(charArray);
                    string reversed = new string(charArray);

                    string result = (lowered == reversed) ? "Yes" : "No";

                    Console.WriteLine("\nOriginal String         Reversed String            Palindrome?");
                    Console.WriteLine($"  {original,-20} {reversed,-25} {result}\n");
                }
            }
        }
    }

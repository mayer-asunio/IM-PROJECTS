using System;
using System.Collections.Generic;

namespace CharFrequencyApp
{
    class Program
    {
        static Dictionary<char, int> GetFrequency(string word)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();
            foreach (char c in word)
            {
                if (char.IsWhiteSpace(c)) continue;

                char lowerChar = char.ToLower(c);
                if (freq.ContainsKey(lowerChar))
                    freq[lowerChar]++;
                else
                    freq[lowerChar] = 1;
            }
            return freq;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();
            string[] words = input.Split(',');

            foreach (string rawWord in words)
            {
                string word = rawWord.Trim();
                Dictionary<char, int> freq = GetFrequency(word);
                List<char> seen = new List<char>();
                List<string> output = new List<string>();

                foreach (char c in word)
                {
                    if (char.IsWhiteSpace(c)) continue;

                    char lower = char.ToLower(c);
                    if (!seen.Contains(lower))
                    {
                        char displayChar = char.IsUpper(c) ? char.ToUpper(lower) : lower;
                        output.Add($"{displayChar}={freq[lower]}");
                        seen.Add(lower);
                    }
                }
                Console.WriteLine(string.Join(", ", output));
            }
            Console.ReadKey();
        }
    }
}

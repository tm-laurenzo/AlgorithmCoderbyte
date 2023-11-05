using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoderbyte.LeetCode_C_sharp
{
    public static class _0125ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        { 
            StringBuilder cleanInput2 = new StringBuilder();
            foreach (char c in s) {
                if (Char.IsLetterOrDigit(c)){
                    cleanInput2 = cleanInput2.Append(c);
                }
            }

            string cleanInput = cleanInput2.ToString().ToLower();
            return cleanInput.SequenceEqual(cleanInput.Reverse());
        }

        public static void Run(string? input)
        {
            bool ans =  IsPalindrome((string)input);
            Console.WriteLine( ans );
        }
    }
}

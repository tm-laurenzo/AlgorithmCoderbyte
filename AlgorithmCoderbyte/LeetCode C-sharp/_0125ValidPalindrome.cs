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
         
            Console.WriteLine(  cleanInput2);
            return cleanInput2.ToString().ToLower().SequenceEqual(cleanInput2.ToString().ToLower().Reverse());
        }

        public static void Run(string? input)
        {
            bool ans =  IsPalindrome((string)input);
            Console.WriteLine( ans );
        }
    }
}

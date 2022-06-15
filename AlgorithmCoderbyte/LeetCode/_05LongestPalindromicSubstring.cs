using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoderbyte.LeetCode
{
    public static class _05LongestPalindromicSubstring
    {
        public static string LongestPalindrome(string input)
        {
            var workingString = input.ToLower();
            var listOfPalindromeSubstrings = new List<string>();
            for(int firstPointer = 0; firstPointer < workingString.Length; firstPointer++)
            {
                var currentSubString = workingString.Substring(firstPointer);
                if (currentSubString.SequenceEqual(currentSubString.Reverse()))
                {
                    listOfPalindromeSubstrings.Add(currentSubString);
                }

            }

            return "goat";
        }
    }
}

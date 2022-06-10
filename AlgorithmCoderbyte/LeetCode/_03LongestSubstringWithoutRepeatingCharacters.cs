using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoderbyte.LeetCode
{
    public static class _03LongestSubstringWithoutRepeatingCharacters
    {
        public static string LongestSubstringWithoutDuplication(string str)
        {
            List<string> listOfUniqueSubstrings = new List<string>();
            int firstPointer = 0;
            int secondPointer = 0;
            string uniqueSubstring = "";

            while (firstPointer < str.Length)
            {
              
                char firstPointerCharacter = str[firstPointer];
                if (!uniqueSubstring.Contains(firstPointerCharacter))
                {
                    uniqueSubstring += firstPointerCharacter;
                    firstPointer++;
                }
                else
                {
                    
                    listOfUniqueSubstrings.Add(uniqueSubstring);
                    secondPointer++;
                    firstPointer = secondPointer;
                    uniqueSubstring = "";
                }

                if(firstPointer == str.Length)
                {
                    listOfUniqueSubstrings.Add(uniqueSubstring);
                }
            }

            string longestSubstring = "";
            foreach (var substring in listOfUniqueSubstrings)
            {
                if(substring.Length > longestSubstring.Length)
                {
                    longestSubstring = substring;
                }
            }

            return longestSubstring;

        }

        public static void Run()
        {
            Console.WriteLine(LongestSubstringWithoutDuplication("clementisacap"));
            Console.WriteLine(LongestSubstringWithoutDuplication("grigamis"));
            Console.WriteLine(LongestSubstringWithoutDuplication("avvacvfadsss"));
            Console.WriteLine(LongestSubstringWithoutDuplication("arrastttaertys"));
            Console.WriteLine(LongestSubstringWithoutDuplication("c"));

        }
    }
}

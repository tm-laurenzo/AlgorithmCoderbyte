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

                for(int secondPointer = firstPointer + 1; secondPointer < workingString.Length; secondPointer++)
                {
                    //var currentSubString = workingString.Substring(firstPointer, secondPointer - firstPointer + 1);
                    var currentSubString = (secondPointer == workingString.Length - 1) ? workingString.Substring(firstPointer, secondPointer - firstPointer + 1) :
                        workingString.Substring(firstPointer, secondPointer -  firstPointer);
                    if (currentSubString.SequenceEqual(currentSubString.Reverse()))
                    {
                        listOfPalindromeSubstrings.Add(currentSubString);
                    }
                }
                

            }

            return listOfPalindromeSubstrings.OrderByDescending(x => x.Length).FirstOrDefault();
        }

        public static void Run()
        {


            //Console.WriteLine(LongestPalindrome("babad"));
            //Console.WriteLine(LongestPalindrome("abb"));
            //Console.WriteLine(LongestPalindrome("cbbd"));
            Console.WriteLine(LongestPalindrome("ac"));

        }
    }
}

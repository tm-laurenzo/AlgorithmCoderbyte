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


        public static String LongestPalindrome1(String s)
        {
            int maxPalinLength = 0;
            String longestPalindrome = null;
            int length = s.Length;
            // check all possible sub strings
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    int len = j - i;
                    String curr = s.Substring(i, j + 1);
                    if (curr.SequenceEqual(curr.Reverse()))
                    {
                        if (len > maxPalinLength)
                        {
                            longestPalindrome = curr;
                            maxPalinLength = len;
                        }
                    }
                }
            }
            return longestPalindrome;
        }
       




        public static void Run()
        {


            //Console.WriteLine(LongestPalindrome("babad"));
            //Console.WriteLine(LongestPalindrome("abb"));
            //Console.WriteLine(LongestPalindrome("cbbd"));
            Console.WriteLine(LongestPalindrome1("ac"));
            Console.WriteLine(LongestPalindrome1("abcda"));

        }
    }
}

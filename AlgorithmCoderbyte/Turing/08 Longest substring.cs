using System;
using System.Collections.Generic;
using System.Linq;

namespace Turing
{
    class LongestSubstring
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestSubstringWithoutDuplication("clementisacap"));
            Console.WriteLine(LongestSubstringWithoutDuplication("grigamis"));
            Console.WriteLine(LongestSubstringWithoutDuplication("avvacvfadsss"));
            Console.WriteLine(LongestSubstringWithoutDuplication("arrastttaertys"));

            /*        
                 Sample Input
                 string = "clementisacap"

                 Sample Output
                 "mentisac" 
            */
        }
        public static string LongestSubstringWithoutDuplication(string str)
        {
            string subStrings = "";
            List<string> subStringsList = new List<string>();

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (subStrings.Contains(str[j])) 
                    {
                        break;
                    }
                    else
                    {
                        subStrings += str[j];
                    }
                }
                subStringsList.Add(subStrings);
                subStrings = "";
            }
            
            return subStringsList.OrderByDescending(x => x.Length).FirstOrDefault();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlgorithmCoderbyte
{
    public static class LongestWord
    {
        /*
             Longest Word
             Have the function LongestWord(sen) take the sen 
             parameter being passed and return the longest word in 
             the string. If there are two or more words that are the 
             same length, return the first word from the string with
             that length. Ignore punctuation and assume sen will not 
             be empty. Words may also contain numbers, for example 
             "Hello world123 567"

             Examples
             Input: "fun&!! time"
             Output: time
             Input: "I love dogs"
             Output: love
        */

        public static string LongestWord1(string sen)
        {

            Regex rgx = new Regex(@"[^\w\s]");
            sen = rgx.Replace(sen, "");
            string[] words = sen.Split(' ');

            return words.OrderByDescending(x => x.Length).First();

        }

        public static string LongestWord2(string sen)
        {

            //One Liner For The Ages. 
            //Regex to strip our punctuation
            //Split on spaces,
            //Linq for the sorting by length
            //Linq to get the first item
            return Regex.Replace(sen, @"(\p{P})", "").Split(' ').OrderByDescending(i => i.Length).First();

        }

        public static string LongestWord3(string sen)
        {

            // code goes here  
            /* Note: In C# the return type of a function and the 
               parameter types being passed are defined, so this return 
               call must match the return type of the function.
               You are free to modify the return type. */

            // split sentence.
            //for each separate string,
            //check if the character is a letter then add it to a count. 
            // if the count is biggest return that string

            string[] words = sen.Split();
            int count = 0;
            int maxCount = 0;
            string maxWord = "";
            foreach (string word in words)
            {
                count = 0;
                foreach (char c in word)
                {
                    if (IsEnglishLetter(c))
                    {
                        ++count;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    maxWord = word;
                }

            }

            return maxWord;

        }
        static bool IsEnglishLetter(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        }

        public static void Run()
        {
            // keep this function call here
            Console.WriteLine(LongestWord1(Console.ReadLine()));
        }
    }

}

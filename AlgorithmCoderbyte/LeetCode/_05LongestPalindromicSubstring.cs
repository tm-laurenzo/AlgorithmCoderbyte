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
            //if ("a".SequenceEqual("a".Reverse())) Console.WriteLine("sequence equal works for single digit");
           
            var workingString = input.ToLower();
            var listOfPalindromeSubstrings = new List<string>();
            for(int firstPointer = 0; firstPointer < workingString.Length; firstPointer++)
            {

                for(int secondPointer = firstPointer; secondPointer < workingString.Length; secondPointer++)
                {
                    //var currentSubString = workingString.Substring(firstPointer, secondPointer - firstPointer + 1);
                    var currentSubString = workingString.Substring(firstPointer, secondPointer -  firstPointer + 1);
                    if (currentSubString.SequenceEqual(currentSubString.Reverse()))
                    {
                        listOfPalindromeSubstrings.Add(currentSubString);
                    }
                }
                

            }
            //foreach (var item in listOfPalindromeSubstrings)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine("answer");
            return listOfPalindromeSubstrings.OrderByDescending(x => x.Length).FirstOrDefault();
        }


       




        public static void Run()
        {


            //Console.WriteLine(LongestPalindrome("babad"));
            //Console.WriteLine(LongestPalindrome("abb"));
            //Console.WriteLine(LongestPalindrome("cbbd"));
            //Console.WriteLine(LongestPalindrome("ac"));
            //Console.WriteLine(LongestPalindrome("abcda"));
            Console.WriteLine(LongestPalindrome("zudfweormatjycujjirzjpyrmaxurectxrtqedmmgergwdvjmjtstdhcihacqnothgttgqfywcpgnuvwglvfiuxteopoyizgehkwuvvkqxbnufkcbodlhdmbqyghkojrgokpwdhtdrwmvdegwycecrgjvuexlguayzcammupgeskrvpthrmwqaqsdcgycdupykppiyhwzwcplivjnnvwhqkkxildtyjltklcokcrgqnnwzzeuqioyahqpuskkpbxhvzvqyhlegmoviogzwuiqahiouhnecjwysmtarjjdjqdrkljawzasriouuiqkcwwqsxifbndjmyprdozhwaoibpqrthpcjphgsfbeqrqqoqiqqdicvybzxhklehzzapbvcyleljawowluqgxxwlrymzojshlwkmzwpixgfjljkmwdtjeabgyrpbqyyykmoaqdambpkyyvukalbrzoyoufjqeftniddsfqnilxlplselqatdgjziphvrbokofvuerpsvqmzakbyzxtxvyanvjpfyvyiivqusfrsufjanmfibgrkwtiuoykiavpbqeyfsuteuxxjiyxvlvgmehycdvxdorpepmsinvmyzeqeiikajopqedyopirmhymozernxzaueljjrhcsofwyddkpnvcvzixdjknikyhzmstvbducjcoyoeoaqruuewclzqqqxzpgykrkygxnmlsrjudoaejxkipkgmcoqtxhelvsizgdwdyjwuumazxfstoaxeqqxoqezakdqjwpkrbldpcbbxexquqrznavcrprnydufsidakvrpuzgfisdxreldbqfizngtrilnbqboxwmwienlkmmiuifrvytukcqcpeqdwwucymgvyrektsnfijdcdoawbcwkkjkqwzffnuqituihjaklvthulmcjrhqcyzvekzqlxgddjoir "));

        }
    }
}

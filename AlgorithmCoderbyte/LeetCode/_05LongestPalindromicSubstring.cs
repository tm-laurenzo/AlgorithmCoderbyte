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

                for(int secondPointer = firstPointer; secondPointer < workingString.Length; secondPointer++)
                {
                   
                    var currentSubString = workingString.Substring(firstPointer, secondPointer -  firstPointer + 1);
                    if (currentSubString.SequenceEqual(currentSubString.Reverse()))
                    {
                        listOfPalindromeSubstrings.Add(currentSubString);

                    }
                }
                

            }
         
            Console.WriteLine("answer");
            return listOfPalindromeSubstrings.OrderByDescending(x => x.Length). FirstOrDefault();
        }

        public static String longestPalindrome_ExpandAroundTheCorner(String s)
        {
            if (s == null || s.Length < 1) return "";
            int start = 0, end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int len1 = expandAroundCenter(s, i, i);
                int len2 = expandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len > end - start)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }
            return s.Substring(start, end + 1);
        }

        private static int expandAroundCenter(String s, int left, int right)
        {
            int L = left, R = right;

            while (L >= 0 && R < s.Length && s[L] == s[R])
            {
                L--;
                R++;

            }
            return R - L - 1;
        }






        public static void Run()
        {


            Console.WriteLine(longestPalindrome_ExpandAroundTheCorner("babad"));
            //Console.WriteLine(LongestPalindrome("abb"));
            //Console.WriteLine(LongestPalindrome("cbbd"));
            //Console.WriteLine(LongestPalindrome("ac"));
            //Console.WriteLine(LongestPalindrome("abcda"));
            //Console.WriteLine(LongestPalindrome("zudfweormatjycujjirzjpyrmaxurectxrtqedmmgergwdvjmjtstdhcihacqnothgttgqfywcpgnuvwglvfiuxteopoyizgehkwuvvkqxbnufkcbodlhdmbqyghkojrgokpwdhtdrwmvdegwycecrgjvuexlguayzcammupgeskrvpthrmwqaqsdcgycdupykppiyhwzwcplivjnnvwhqkkxildtyjltklcokcrgqnnwzzeuqioyahqpuskkpbxhvzvqyhlegmoviogzwuiqahiouhnecjwysmtarjjdjqdrkljawzasriouuiqkcwwqsxifbndjmyprdozhwaoibpqrthpcjphgsfbeqrqqoqiqqdicvybzxhklehzzapbvcyleljawowluqgxxwlrymzojshlwkmzwpixgfjljkmwdtjeabgyrpbqyyykmoaqdambpkyyvukalbrzoyoufjqeftniddsfqnilxlplselqatdgjziphvrbokofvuerpsvqmzakbyzxtxvyanvjpfyvyiivqusfrsufjanmfibgrkwtiuoykiavpbqeyfsuteuxxjiyxvlvgmehycdvxdorpepmsinvmyzeqeiikajopqedyopirmhymozernxzaueljjrhcsofwyddkpnvcvzixdjknikyhzmstvbducjcoyoeoaqruuewclzqqqxzpgykrkygxnmlsrjudoaejxkipkgmcoqtxhelvsizgdwdyjwuumazxfstoaxeqqxoqezakdqjwpkrbldpcbbxexquqrznavcrprnydufsidakvrpuzgfisdxreldbqfizngtrilnbqboxwmwienlkmmiuifrvytukcqcpeqdwwucymgvyrektsnfijdcdoawbcwkkjkqwzffnuqituihjaklvthulmcjrhqcyzvekzqlxgddjoir "));

        }
    }
}

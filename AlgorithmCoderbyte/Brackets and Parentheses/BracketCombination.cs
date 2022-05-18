using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoderbyte
{
    public static class BracketCombination
    {
        /*
          Bracket Combinations

          Have the function BracketCombinations(num) read num which will be an 
          integer greater than or equal to zero, and return the number 
          of valid combinations that can be formed with num pairs of parentheses.
          For example, if the input is 3, then the possible combinations of 3 
          pairs of parenthesis, namely: ()()(), are ()()(), ()(()), (())(), ((())), 
          and (()()). There are 5 total combinations when the input is 3, so your program
          should return 5.

          Examples
          Input: 3
          Output: 5

          Input: 2
          Output: 2

       */

        public static int catalan(int n)
        {
            int res = 0;

            if (n <= 1) { return 1; }

            for (int i = 0; i < n; i++)
                res += catalan(i) * catalan(n - i - 1);

            return res;
        }

        public static int BracketCombinations1(int num)
        {
            return catalan(num);
        }


        public static int BracketCombinations2(int num)
        {
            if (num == 0)
            {
                return 0;
            }

            return IsAMatch(0, num, num);
        }

        public static int IsAMatch(int unmatchedOpenCount, int remainingOpen, int remainingClose)
        {
            if (remainingOpen == 0)
            {
                return 1;
            }

            var res = IsAMatch(unmatchedOpenCount + 1, remainingOpen - 1, remainingClose)
                   + (unmatchedOpenCount > 0 ? IsAMatch(unmatchedOpenCount - 1, remainingOpen, remainingClose - 1) : 0);

            //Console.WriteLine($"{unmatchedOpenCount}{remainingOpen}{remainingClose} --> {res}");
            return res;
        }



        public static void Run()
        {
            Console.WriteLine(BracketCombinations1(Convert.ToInt32( Console.ReadLine())));
        }

    }
}

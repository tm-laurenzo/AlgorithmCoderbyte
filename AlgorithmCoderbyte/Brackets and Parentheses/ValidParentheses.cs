using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoderbyte.Brackets_and_Parentheses
{
    public static class ValidParentheses
    {

          /*    
            APPROACH

            There will always be a pair of nested brackets, so removing the most inner pair,
            then move to the next outer pair, until you finish all pairs.
          */
        static string question =
            @"Given a string s containing just the characters 
                '(', ')', '{', '}', '[' and ']', 
                 determine if the input string is valid.

                An input string is valid if:

                Open brackets must be closed by the same type of brackets.
                Open brackets must be closed in the correct order.


                Example 1:

                Input: s = ()
                Output: true
                Example 2:

                Input: s = ()[]{}
                Output: true
                Example 3:

                Input: s = (]
                Output: false


                Constraints:

                1 <= s.length <= 104
                s consists of parentheses only ()[]{}. ";


        public static bool Valid(String s)
        {
            int n = -1;
            while (s.Length != n)
            {
                n = s.Length;
                s = s.Replace("()", "");
                s = s.Replace("{}", "");
                s = s.Replace("[]", "");
            }
            if (s.Length == 0) return true;
            else return false;
        }

        public static void Run()
        {
            Console.WriteLine("ValidParentheses Algorithm Running");
            Console.WriteLine(question);
            Console.WriteLine(Valid(Console.ReadLine()));
        }
    }
}

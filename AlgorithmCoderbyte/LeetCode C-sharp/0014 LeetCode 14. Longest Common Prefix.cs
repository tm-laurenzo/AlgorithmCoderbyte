using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoderbyte.LeetCode_C_sharp
{
    public static class _0014_LeetCode_14
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            string prefix = strs[0];
            for(int  i = 1; i < strs.Length; i++)
            {
                while(strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                }
            }
            return prefix;
        }
        public static void Run()
        {
            //Console.WriteLine(MyAtoi(" - 91283472332"));
            //Console.WriteLine(MyAtoi("words and 987"));
            //Console.WriteLine(MyAtoi("+-12"));
            //Console.WriteLine(MyAtoi("-abc"));
            Console.WriteLine(LongestCommonPrefix("1"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoderbyte.LeetCode_C_sharp
{
    public static class _08StringToInteger
    {
        public static int MyAtoi(string s)
        {
            int answer;
            string NumberString = "";

            s = s.Trim();
            if (s.StartsWith("+-") || s.StartsWith("-+") || string.IsNullOrEmpty(s))
            {
                return answer = 0;
            }
            if (!char.IsDigit(s[1]) && (s.StartsWith("+") || s.StartsWith("-")))
            {
                return answer = 0;
            }
            s = s.Trim('+');

            if (s.Contains('.'))
            {
                s = s.Remove(s.IndexOf('.'));
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0 && (s[i] == '+' || s[i] == '-'))
                {
                    NumberString = s[i] + "";
                    continue;
                }
                if (char.IsDigit(s[i]))
                {
                    NumberString = NumberString + s[i];
                    continue;
                }
                if (char.IsDigit(s[i]) == false && i != 0)
                {
                    break;
                }
            }
            if (NumberString == "-")
            {
                return answer = 0;
            }

            if (string.IsNullOrEmpty(NumberString))
                return answer = 0;
            if (Convert.ToDouble(NumberString) > int.MaxValue)
            {
                answer = int.MaxValue;
            }
            else if (Convert.ToDouble(NumberString) < int.MinValue)
            {
                answer = int.MinValue;
            }
            else
            {
                answer = Convert.ToInt32(NumberString);
            }

            return answer;
        }
        public static void Run()
        {
            //Console.WriteLine(MyAtoi(" - 91283472332"));
            //Console.WriteLine(MyAtoi("words and 987"));
            //Console.WriteLine(MyAtoi("+-12"));
            //Console.WriteLine(MyAtoi("-abc"));
            Console.WriteLine(MyAtoi("1"));
        }
    }
}

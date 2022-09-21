using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoderbyte.LeetCode_C_sharp
{
    public class _07ReverseNumbers
    {
        public static int Reverse(int x)
        {
            var strNum = x + "";
            Console.WriteLine(strNum);
            var formattedNumStr = "";
            formattedNumStr = new string(strNum.Reverse().ToArray());
            Console.WriteLine(formattedNumStr);
            if (formattedNumStr.Contains("-"))
            {
                formattedNumStr = formattedNumStr.Remove(formattedNumStr.Length - 1);
                formattedNumStr = "-" + formattedNumStr;
            }
            int answer;
            bool success = int.TryParse(formattedNumStr, out answer);
            if (success)
            {
                return answer;
            }
            return answer;
        }

        public static void Run()
        {
            Console.WriteLine(Reverse( 33345678));
        }
    }
}

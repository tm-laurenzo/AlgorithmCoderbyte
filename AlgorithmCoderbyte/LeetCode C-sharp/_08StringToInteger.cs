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
            string NumberString = "";

            s = s.Trim();
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
            string numStr2 = NumberString;
            numStr2 = numStr2.Trim('+');
            numStr2 = numStr2.Trim('-');
            int answer;
            if(numStr2 > int.MaxValue.ToString())
            {

            }

            if (string.IsNullOrEmpty(NumberString))
                return answer = 0;
            if (Convert.ToInt32(NumberString) > int.MaxValue)
            {
                answer = int.MaxValue;
            }
            else if(Convert.ToInt32(NumberString) < int.MinValue){
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
            Console.WriteLine(MyAtoi(" - 91283472332")); 
        }
    }
}

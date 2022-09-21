using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoderbyte.LeetCode_C_sharp
{
    public static class _06ZigZagConversion
    {
        public static string Convert(string s, int numRows)
        {
            //Defing StringBuilders
            StringBuilder[] sbs = new StringBuilder[numRows];
            for (int i = 0; i < numRows; i++)
            {
                sbs[i] = new StringBuilder();
            }
            //Define Variables
            char[] arr = s.ToCharArray();
            int n = arr.Length;
            int index = 0;

            //Traverse zig zag
            while (index < n)
            {
                //Go down
                for (int j = 0; j < numRows && index < n; j++)
                {
                    sbs[j].Append(arr[index++]);
                }
                //Go Up before start
                for (int j = numRows - 2; j > 0 && index < n; j--)
                {
                    sbs[j].Append(arr[index++]);
                }
            }

            //Combine all stringbuilders into one
            StringBuilder res = sbs[0];
            for (int i = 1; i < numRows; i++)
            {
                res.Append(sbs[i].ToString());
            }
            return res.ToString();
        }

        public static void Run()
        {
            Console.WriteLine(Convert("dkdkdf", 3));
        }
    }
}

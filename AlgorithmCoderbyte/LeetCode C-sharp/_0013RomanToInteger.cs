﻿using System;

namespace AlgorithmCoderbyte.LeetCode_C_sharp
{
    class _0013RomanToInteger
    {
        public static int RomanToInt(string s)
        {

            var current = GetNumber(s[0]);
            var total = 0;
            for (int i = 1; i < s.Length; i++)
            {
                var next = GetNumber(s[i]);
                if (current < next)
                {
                    total -= current;
                }
                else
                {
                    total += current;
                }
                current = next;
            }
            total += current;
            return total;
        }

        public static int GetNumber(char ch)
        {
            switch (ch)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: return 0;
            }
        }

        public static void Run()
        {
            Console.WriteLine(_0013RomanToInteger.RomanToInt("IV"));
        }
    }
}

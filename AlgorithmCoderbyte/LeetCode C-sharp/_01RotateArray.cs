using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoderbyte.LeetCode
{
    public static class _01RotateArray
    {
        static string question =
            @"  Problem: Rotate an array of n elements to the right by k steps.
                For example, with n = 7 and k = 3, the array [1,2,3,4,5,6,7] is 
                rotated to [5,6,7,1,2,3,4].
                How many different ways do you know to solve this problem?
            ";

        
        public static void rotate(int[] nums, int k)
        {
            if (k > nums.Length)
                k = k % nums.Length;
            int[] result = new int[nums.Length];
            for (int i = 0; i < k; i++)
            {
                result[i] = nums[nums.Length - k + i];
            }
            int j = 0;
            for (int i = k; i < nums.Length; i++)
            {
                result[i] = nums[j];
                j++;
            }
            //Array.Copy(result, 0, nums, 0, nums.Length);
            foreach (var item in result)
            {
                Console.Write(item);
            }
        }
        public static void Run()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(question);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("input [1,2,3,4,5,6,7]");
            rotate(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3);
        }
    }
}

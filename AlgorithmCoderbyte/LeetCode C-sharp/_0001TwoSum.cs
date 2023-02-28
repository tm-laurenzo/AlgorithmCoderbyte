using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoderbyte.LeetCode_C_sharp
{
    public static class _0001TwoSum
    {

        public static int[] TwoSum(int[] nums, int target)
        {
            List<int> indices = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length - 1) break;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        indices.Add(i);
                        indices.Add(j);
                    }

                }
            }
            return indices.ToArray();
        }

        public static void Run()
        {
            Console.WriteLine(_0001TwoSum.TwoSum( new int[] { 2, 7, 11, 15 }, 9));
        }

    }
}

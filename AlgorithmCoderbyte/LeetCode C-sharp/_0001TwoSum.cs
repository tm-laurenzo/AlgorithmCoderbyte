using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoderbyte.LeetCode_C_sharp
{
    public static class _0001TwoSum
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                int x = numbers[i];
                if (map.ContainsKey(target - x))
                {
                    return new int[] { map[target - x] + 1, i + 1 };
                }
                map[x] = i;
            }
            throw new ArgumentException("No two sum solution");
        }


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
            var ans = _0001TwoSum.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            foreach (var item in ans)
            {
                Console.WriteLine(  item);
            }
        }

    }
}

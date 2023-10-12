using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoderbyte.LeetCode_C_sharp
{
    public static class _0001TwoSum
    {
        public static int[] TwoSumUsingDictionary(int[] nums, int target)
        {
            // Create a hash table to store the seen elements.
            var seen = new Dictionary<int, int>();

            // Iterate over the array.
            for (int i = 0; i < nums.Length; i++)
            {
                // Calculate the complement of the current element.
                int complement = target - nums[i];

                // Check if the complement is in the hash table.
                if (seen.ContainsKey(complement))
                {
                    // Return the indices of the two elements.
                    return new int[] { i, seen[complement] };
                }

                // Add the current element to the hash table.
                seen[nums[i]] = i;
            }

            // If we reach this point, there is no solution to the problem.
            return null;
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
            var ans = _0001TwoSum.TwoSumUsingDictionary(new int[] { 2, 7, 11, 15 }, 9);
            foreach (var item in ans)
            {
                Console.WriteLine(  item);
            }
        }

    }
}

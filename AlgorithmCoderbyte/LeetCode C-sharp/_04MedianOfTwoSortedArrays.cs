using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoderbyte.LeetCode_C_sharp
{
    public static class _04MedianOfTwoSortedArrays
    {
        public static double MedianOfTwoSortedArrays(int[] array1, int[] array2)
        {

            var fullArray = array1.ToList();
            fullArray.AddRange(array2);
            fullArray.Sort();
            double answer = 0;
            if (fullArray.Count % 2 == 0)
            {
                int firstMiddleIndex = fullArray.Count / 2 - 1;
                int secondMiddleIndex = fullArray.Count / 2;
                var firstMiddleItem = fullArray.ElementAt(firstMiddleIndex);
                var secondMiddleItem = fullArray.ElementAt(secondMiddleIndex);



                answer = (double)(firstMiddleItem + secondMiddleItem) / 2;
            }
            else
            {
                answer = fullArray[(fullArray.Count / 2)];
            }



            return answer;
        }

        public static void Run()
        {
            int[] array1 = new int[] { 1, 2 };
            int[] array2 = new int[] { 3, 4 };

            Console.WriteLine(MedianOfTwoSortedArrays(array1, array2));

        }
    }
}

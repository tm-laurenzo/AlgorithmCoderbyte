﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        var sortedArr = arr.OrderBy(x => x).ToList();
        int smallest = 0;
        int largest = 0;
        for (int i = 0; i < sortedArr.Count() - 2; i++)
        {
            smallest += sortedArr[i];
        }
        for (int i = 1; i < sortedArr.Count() - 1; i++)
        {
            largest += sortedArr[i];
        }
        Console.WriteLine(smallest + " " + largest);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}

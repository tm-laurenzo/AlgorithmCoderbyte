using System;
using System.Linq;

namespace squaredSum
{
    class Program
    {
        /*
        Welcome. In this kata, you are asked to square every 
        digit of a number and concatenate them.
        For example, if we run 9119 through the function, 811181
        will come out, because 92 is 81 and 12 is 1.
        */
        /*        STEPS       
         
         01- convert the number passed as an arguement to a string, so that 
             every digit in the number can be iterated through
         02- iterate over the digits which are now characters in the string
         03- square each digit and add it to a string "outputString"
         04- return the integer form of the outputString
         
         */


        static void Main(string[] args)
        {
            Console.WriteLine(SquareDigits(439));
        }
        public static int SquareDigits(int n)
        {



            string input = n + "";
            string outputString = "";
            foreach (var item in input)
            {
                double squaredNumber = Math.Pow(int.Parse(item.ToString()), 2);
                outputString += squaredNumber;

            }

            return int.Parse(outputString);

        }
    }
}

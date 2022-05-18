using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoderbyte
{
    public static class RecursionFactorial
    {
        public static void Run()
        {
            Console.WriteLine("Enter the value you want to get its factorial");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Factorial of " + number + " is " + Factorial(number));

        }

        public static int Factorial(int number) {

            if (number == 0)
                return 1;

            else
                return number * Factorial(number - 1);
        }

    }
}

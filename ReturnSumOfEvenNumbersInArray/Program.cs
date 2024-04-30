using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnSumOfEvenNumbersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 144, 233, 377, 610 };

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0) // cause even numbers must be divided by 2 without a remainder, so the remainder == 0
                    sum += arr[i];
            }
            Console.WriteLine(sum);

            Console.WriteLine("---------------------------------------");

            for (int i = 0; i < arr.Length; i++) // shows the initial sequence of array's elements
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}

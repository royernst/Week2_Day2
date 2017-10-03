using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int arraySize = int.Parse(Console.ReadLine());
            //int[] newArray = new int[arraySize];
            //Console.WriteLine("The array is of length " + newArray.Length);

            string[] birthMonths = { "October", "July", "October", "May" };
            Console.WriteLine(Array.IndexOf(birthMonths, "May"));

            int[] numbers = { 2, 5, 9, 4, 3, 4, 6, 5 };
            Console.WriteLine(Array.LastIndexOf(numbers, 4));

            Array.Reverse(numbers);

            Console.WriteLine(numbers[0]);
        }
    }
}

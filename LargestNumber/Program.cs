using System;
using System.Linq;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type some numbers separated by comma like 4,8,2,12,9");

            string input = Console.ReadLine();

            int[] numbers = input.Split(',').Select(int.Parse).ToArray();

            int maxNumber = numbers.Max();

            Console.WriteLine("The largest number is " + maxNumber);

            Console.ReadLine();
        }
    }
}

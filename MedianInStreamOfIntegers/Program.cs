using System;

namespace MedianInStreamOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Median in a stream of integers!");
            Console.WriteLine("--------------------------------");

            MaxMinHeapHolder maxMinHeapHolder = new MaxMinHeapHolder(100);

            Console.WriteLine("Enter s to stop; Input a number to find running median");
            while (true) {
                var input = Console.ReadLine().ToString();
                if (input == "s") break;
                int number = int.Parse(input);
                maxMinHeapHolder.Median = maxMinHeapHolder.GetRunningMedian(number);
                Console.WriteLine("Running median is " + maxMinHeapHolder.Median);
            }
        }
    }
}

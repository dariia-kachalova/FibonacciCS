using System;
using System.Collections.Generic;
using System.Linq;

namespace FibonacciSequence
{
    static class Program
    {
        static void Main(string[] args)

        {
#pragma warning disable S2190 // Recursion should not be infinite
            static IEnumerable<int> GetFibonacci()
            {
                int previousVal1 = 0;
                int previousVal2 = 1;

                while (true)
                {
                    int nextVal = previousVal1 + previousVal2;
                    previousVal1 = previousVal2;
                    previousVal2 = nextVal;
                    yield return nextVal;
                }
            }
#pragma warning restore S2190 // Recursion should not be infinite
            foreach (int val in GetFibonacci().Take(5))
            {
                Console.WriteLine($"Value: {val}");
            }
        }
    }
}

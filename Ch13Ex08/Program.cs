using System;

namespace Ch13Ex08
{
    internal delegate int TwoIntegerOperationDelegate(int paramA, int paramB);

    internal static class Program
    {
        private static void PerformOperations(TwoIntegerOperationDelegate del)
        {
            for (var paramAVal = 1; paramAVal <= 5; paramAVal++)
            {
                for (var paramBVal = 1; paramBVal <= 5; paramBVal++)
                {
                    var delegateCallResult = del(paramAVal, paramBVal);
                    Console.Write($"f({paramAVal}, " + 
                        $"{paramBVal}) = {delegateCallResult}");
                    if (paramBVal != 5)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
            }
        }
        private static void Main(string[] args)
        {
            Console.WriteLine("f(a, b) = a + b:");
            PerformOperations((paramA, paramB) => paramA + paramB);
            Console.WriteLine("f(a, b) = a * b:");
            PerformOperations((paramA, paramB) => paramA * paramB);
            Console.WriteLine("f(a, b) = (a - b) % b:");
            PerformOperations((paramA, paramB) => (paramA - paramB) % paramB);
            Console.ReadKey();
        }
    }
}

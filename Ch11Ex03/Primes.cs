using System;
using System.Collections;

namespace Ch11Ex03
{
    public class Primes : IEnumerable
    {
        private long min;
        private long max;
        public Primes() : this(2, 100) { }
        public Primes(long minimum, long maximum)
        {
            min = minimum < 2 ? 2 : minimum;
            max = maximum;
        }
        public IEnumerator GetEnumerator()
        {
            for (long possiblePrime = min; possiblePrime <= max; possiblePrime++)
            {
                bool isPrime = true;
                for (long possibleFactor = 2; possibleFactor <=
                                              (long)Math.Floor(Math.Sqrt(possiblePrime)); possibleFactor++)
                {
                    long reminderAfterDivision = possiblePrime % possibleFactor;
                    if (reminderAfterDivision == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    yield return possiblePrime;
                }
            }
        }
    }
}

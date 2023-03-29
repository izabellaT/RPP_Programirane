using System;

namespace MulSumDigits
{
    class Program
    {
        
            private static int GetMultipleEvensAndOdds(int n)
            {
                int sumEvens = GetSumOfEvenDidits(n);
                int sumOdds = GetSumOddDigits(n);
                return sumEvens * sumOdds;
            }

            private static int GetSumOddDigits(int n)
            {
                int sum = 0;
                while (n > 0)
                {
                    int lastDigit = n % 10;
                if (lastDigit % 2 == 1)
                {
                    sum += lastDigit;
                }
                    n = n / 10;
                }
                return sum;
            }

            private static int GetSumOfEvenDidits(int n)
            {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                n = n / 10;
            }
            return sum;
            }

            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                n = Math.Abs(n);
                int result = GetMultipleEvensAndOdds(n);
                Console.WriteLine(result);
            }
    }
}

using System;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double limit = double.Parse(Console.ReadLine());

            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double difference = GetPercentageDifference(lastPrice, currentPrice); bool isSignificantDifference = HasSignificantDifference(difference, limit);

                string message = GetMessage(currentPrice, lastPrice, difference, isSignificantDifference);
                Console.WriteLine(message);

                lastPrice = currentPrice;
            }
        }
        private static string GetMessage(double currentPrice, double lastPrice, double difference, bool isSignificantDifference)
        {
            string message = " ";
            if (difference == 0)
            {
                message = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!isSignificantDifference)
            {
                message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference*100);
            }
            else if (isSignificantDifference && (difference > 0))
            {
                message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
            }
            else if (isSignificantDifference && (difference < 0))
                message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
            return message;
        }
        private static bool HasSignificantDifference(double limit, double difference)
        {
            if (Math.Abs(limit) >= difference)
            {
                return true;
            }
            return false;
        }
        private static double GetPercentageDifference(double lastPrice, double currentPrice)
        {
            double difference = (currentPrice - lastPrice) / lastPrice;
            return difference;
        }
    }
    
}

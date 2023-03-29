using System;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            string partOfDay = Console.ReadLine();
            double kilometers = double.Parse(Console.ReadLine());
            double pricePerKm = 0;

            switch (month)
            {
                case "Jan":
                    switch (partOfDay)
                    {
                        case "Day":
                            pricePerKm = 0.81;
                            break;
                        case "Night":
                            pricePerKm = 1.00;
                            break;
                    }
                    break;

                case "Feb":
                    switch (partOfDay)
                    {
                        case "Day":
                            pricePerKm = 0.81;
                            break;
                        case "Night":
                            pricePerKm = 1.00;
                            break;
                    }
                    break;

                case "March":
                    switch (partOfDay)
                    {
                        case "Day":
                            pricePerKm = 0.81;
                            break;
                        case "Night":
                            pricePerKm = 1.00;
                            break;
                    }
                    break;

                case "Apr":
                    switch (partOfDay)
                    {
                        case "Day":
                            pricePerKm = 0.81;
                            break;
                        case "Night":
                            pricePerKm = 1.00;
                            break;
                    }
                    break;

                case "May":
                    switch (partOfDay)
                    {
                        case "Day":
                            pricePerKm = 0.91;
                            break;
                        case "Night":
                            pricePerKm = 1.05;
                            break;
                    }
                    break;

                case "June":
                    switch (partOfDay)
                    {
                        case "Day":
                            pricePerKm = 0.91;
                            break;
                        case "Night":
                            pricePerKm = 1.05;
                            break;
                    }
                    break;

                case "July":
                    switch (partOfDay)
                    {
                        case "Day":
                            pricePerKm = 0.91;
                            break;
                        case "Night":
                            pricePerKm = 1.05;
                            break;
                    }
                    break;

                case "Aug":
                    switch (partOfDay)
                    {
                        case "Day":
                            pricePerKm = 0.91;
                                 break;
                        case "Night":
                            pricePerKm = 1.05;
                            break;
                    }
                    break;

                case "Sep":
                    switch (partOfDay)
                    {
                        case "Day":
                            pricePerKm = 0.85;
                            break;
                        case "Night":
                            pricePerKm = 1.03;
                            break;
                    }
                    break;

                case "Oct":
                    switch (partOfDay)
                    {
                        case "Day":
                            pricePerKm = 0.85;
                            break;
                        case "Night":
                            pricePerKm = 1.03;
                            break;
                    }
                    break;

                case "Nov":
                    switch (partOfDay)
                    {
                        case "Day":
                            pricePerKm = 0.85;
                            break;
                        case "Night":
                            pricePerKm = 1.03;
                            break;
                    }
                    break;

                case "Dec":
                    switch (partOfDay)
                    {
                        case "Day":
                            pricePerKm = 0.85;
                            break;
                        case "Night":
                            pricePerKm = 1.03;
                            break;
                    }
                    break;
            }
            double totalPrice = pricePerKm * kilometers;
            Console.WriteLine($"Total cost: {totalPrice} lv.");
        }

    }
}

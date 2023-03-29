using System;

namespace Boboni
{
    class Program
    {
        static void Main(string[] args)
        {
            string candyColor = Console.ReadLine();
            string boxSize = Console.ReadLine();
            int numOfBoxes = int.Parse(Console.ReadLine());
            double price = 0;

            switch (candyColor)
            {
                case "Red":
                    switch (boxSize)
                    {
                        case "Small":
                            price = 1.50 * numOfBoxes;
                            break;

                        case "Medium":
                            price = 2.20 * numOfBoxes;
                            break;

                        case "Large":
                            price = 3.70 * numOfBoxes;
                            break;
                    }
                    break;

                case "Blue":
                    switch (boxSize)
                    {
                        case "Small":
                            price = 1.30 * numOfBoxes;
                            break;

                        case "Medium":
                            price = 1.80 * numOfBoxes;
                            break;

                        case "Large":
                            price = 2.10 * numOfBoxes;
                            break;
                    }
                    break;

                case "Green":
                    switch (boxSize)
                    {
                        case "Small":
                            price = 2.50 * numOfBoxes;
                            break;

                        case "Medium":
                            price = 3.60 * numOfBoxes;
                            break;

                        case "Large":
                            price = 5.20 * numOfBoxes;
                            break;
                    }
                    break;

                default:
                    break;
            }
            if (boxSize == "Medium")
            {
                price -= price * 0.05;
            }
             if (boxSize == "Large" && candyColor == "Green" && numOfBoxes >= 5)
            {
                price -= price * 0.25;
            }
             if (price > 30.0)
            {
                price -= price * 0.10;
            }
            Console.WriteLine($"You bought {numOfBoxes} boxes of {candyColor} candy for {price:F2}lv.");
        }
    }

}

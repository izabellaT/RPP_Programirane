using System;

namespace UmnataLILI
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());
            int savings = 0;
            double moneyFromPresents = 0;
            int bonus = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    bonus += 10;
                    savings += bonus;
                    savings -= 1;

                }

                else
                {
                    moneyFromPresents += presentPrice;
                }
            }
            var allMoney = savings + moneyFromPresents;
            if (allMoney >= washingMachinePrice)
                Console.WriteLine("Yes! {0:F2}", allMoney - washingMachinePrice);
            else
                Console.WriteLine("No! {0:F2}", washingMachinePrice - allMoney);

        }
    }
}

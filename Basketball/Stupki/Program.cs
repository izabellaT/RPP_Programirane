using System;

namespace Stupki
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int totalSteps = 0;
            bool reachGoal = false;
            while (command != "Going home")
            {
                int steps = int.Parse(command);
                totalSteps += steps;
                if (totalSteps >= 10000)
                {
                    reachGoal = true;
                    break;
                }
                command = Console.ReadLine();
            }
            if (reachGoal)
            {
                int goalReached = totalSteps - 10000;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{goalReached} steps over the goal!");
            }
            else
            {
                int tooManySteps = int.Parse(Console.ReadLine());
                totalSteps += tooManySteps;
                if (totalSteps >= 10000)
                {
                    int toOManySteps = totalSteps - 10000;
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{toOManySteps} steps over the goal!");
                }
                else
                {
                    int neededSteps = 10000 - totalSteps;
                    Console.WriteLine($"{neededSteps} more steps to reach goal.");
                }
            }
        }
    }
}

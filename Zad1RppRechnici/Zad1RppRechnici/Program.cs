using System;
using System.Collections.Generic;
using System.Linq;

namespace Zad1RppRechnici
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> subjects = new Dictionary<string, int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string subject = input;

                if (!subjects.ContainsKey(subject))
                {
                    subjects.Add(subject, 1);
                }
                else
                {
                    subjects[subject] += 1;
                }
            }
            foreach (var subjecT in subjects)
            {
                Console.WriteLine($"{subjecT.Key} -> {subjecT.Value}");
                
            }
            Console.WriteLine($"Subjects count : { subjects.Count()}");
        }
    }
}

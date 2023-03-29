using System;
using System.Collections.Generic;
using System.Linq;

namespace IzpitwaneBella
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }
                string[] cmd = input.Split().ToArray();
                string name = input;

                if (!students.ContainsKey(name))
                {
                students.Add(name, 1);
                }
                else
                {
                    students[name] += 1;
                }
                }
                foreach (var student in students.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"{student.Key} -> {student.Value}");
                }
                Console.WriteLine($"Students count : { students.Count()}");
            }
        }
    }

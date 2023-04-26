﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="End")
                {
                    break;
                }
                stack.Push(input);
            }
            int n = int.Parse(Console.ReadLine());
            if (stack.Count()>n)
            {
                for (int i = 0; i < n; i++)
                {
                    stack.Pop();
                }
            }
            else
            {
                Console.WriteLine("there are not enough items!");
            }
            Console.WriteLine(string.Join("; ", stack));
        }
    }
}

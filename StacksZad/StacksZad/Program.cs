using System;
using System.Collections.Generic;
using System.Linq;

namespace StacksZad
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                stack.Push(num);
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                if (command[0] == "end")
                {
                    break;
                }
                switch (command[0])
                {
                    case "add":
                        {
                            int num1 = int.Parse(command[1]) + int.Parse(command[2]);
                            stack.Push(num1);
                            break;
                        }

                    case "remove":
                        {
                            int num1 = int.Parse(command[1]);
                            if (num1>stack.Count)
                            {
                                Console.WriteLine("There are not enough items!");
                            }
                            else
                            {
                                for (int i = 0; i < num1; i++)
                                {
                                    stack.Pop();
                                }
                            }
                            break;
                        }

                    case "contains":
                        {
                            int num1 = int.Parse(command[1]);
                            if (stack.Contains(num1))
                            {
                                Console.WriteLine("True");
                            }
                            else
                            {
                                stack.Push(num1);
                            }
                            break;
                        }
                }
            }
                Console.WriteLine(string.Join(" ", stack));
            }
        }
    }


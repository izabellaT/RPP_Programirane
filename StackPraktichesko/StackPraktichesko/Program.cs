using System;
using System.Collections.Generic;

namespace StackPraktichesko
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            
            string[] cmd = Console.ReadLine().Split();
            while (cmd[0] != "Finish")
            {
                if (cmd[0] == "add")
                {
                    int a = int.Parse(cmd[1]);
                    int b = int.Parse(cmd[2]);
                    stack.Push(a);
                    stack.Push(b);
                }

                if (cmd[0] == "Add")
                {
                    int a = int.Parse(cmd[1]);
                    int b = int.Parse(cmd[2]);
                    stack.Push(a);
                    stack.Push(b);
                }

                else if (cmd[0] == "Del")
                {
                    if (stack.Count < int.Parse(cmd[1]))
                    {
                        Console.WriteLine("Not enough items!");
                    }
                    else
                    {
                        for (int i = 0; i < int.Parse(cmd[1]); i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                else if (cmd[0] == "Contains")
                {
                    if (stack.Contains(int.Parse(cmd[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                }
                cmd = Console.ReadLine().Split();
            }
                Console.WriteLine(string.Join("; ", stack));
            }
        }
        }

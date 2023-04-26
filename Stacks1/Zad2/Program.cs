using System;
using System.Collections.Generic;
using System.Linq;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split().ToArray();
            Stack<string> stack = new Stack<string>();
          
            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i];
                if (name.StartsWith("A") || name.StartsWith("B") || name.StartsWith("C"))
                {
                    stack.Push(name);
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}

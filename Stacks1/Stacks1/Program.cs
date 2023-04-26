using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                int num = input[i];
                if (num%2==1)
                {
                    stack.Push(num);
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}

using System;
using System.Linq;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int colums = dimensions[1];

            int[,] arr = new int[rows, colums];

            //wuwejdane
            for (int i = 0; i < rows; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < colums; j++)
                {
                    arr[i, j] = input[j];
                }
            }

            //sumirane
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (i % 2 == 0)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}




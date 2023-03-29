using System;
using System.Linq;

namespace Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimension = int.Parse(Console.ReadLine());

            int rows = dimension;
            int colums = dimension;
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
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum = sum + arr[i, i];
            }
            Console.WriteLine(sum);
        }
    }
    }


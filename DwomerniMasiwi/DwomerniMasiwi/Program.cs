using System;
using System.Linq;

namespace DwomerniMasiwi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = dimension[0];
            int colums = dimension[1];
            int[,] arr = new int[rows, colums];

            //wuwejdane
            for (int i = 0; i < rows; i++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < colums; j++)
                {
                    arr[i, j] = input[j];
                }
            }

            //izwejdane
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }

            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
            }
            Console.WriteLine(rows);
            Console.WriteLine(colums);
            Console.WriteLine(sum);
        }
    }
}

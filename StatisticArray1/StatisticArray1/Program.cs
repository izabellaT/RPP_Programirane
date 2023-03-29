using System;

namespace StatisticArray1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(OptionsManager.CountLess100(arr));
            Console.WriteLine(OptionsManager.MaxNum(arr));

            OptionsManager.ChetniEdinRed(arr);
            Console.WriteLine(OptionsManager.ChetniSum(arr));
            Console.WriteLine(OptionsManager.ChetniCount(arr));

            arr = OptionsManager.ReverseArr(arr);
            OptionsManager.PrintArr(arr);


        }
    }
}

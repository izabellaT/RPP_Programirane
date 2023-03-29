using System;
using System.Linq;

namespace TestRPP
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("count= " + string.Join(" ", nums.Count(x => x<10)));
            Array.Reverse(nums);
            Console.WriteLine(string.Join("=>", nums));
        }
    }
}

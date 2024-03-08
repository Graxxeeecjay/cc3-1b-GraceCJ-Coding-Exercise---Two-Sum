using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many numbers?");
        int max = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[max];

        for (int x = 0; x < arr.Length; x++)
        {
            Console.WriteLine("Input a number");
            int num = Convert.ToInt32(Console.ReadLine());
            arr[x] = num;
        }

        Console.WriteLine("Input the target sum:");
        int target = Convert.ToInt32(Console.ReadLine());

        int[] twoSumIndices = TwoSum(arr, target);

        if (twoSumIndices.Length == 0)
        {
            Console.WriteLine("No two numbers add up to the target sum.");
        }
        else
        {
            Console.WriteLine($"Indices of the two numbers that add up to {target}: [{twoSumIndices[0]},{twoSumIndices[1]}]");
        }
    }

    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> seen = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (seen.ContainsKey(complement))
            {
                return new int[] { seen[complement], i };
            }
            seen[nums[i]] = i;
        }
        return new int[0];
    }
}

using System;

public class Program
{
    public static void Main()
    {
        int[] nums = { 1, 2, 3 };
        Permute(nums, 0);
    }

    public static void Permute(int[] nums, int index)
    {
        if (index == nums.Length)
        {
            Console.WriteLine(string.Join(", ", nums));
            return;
        }

        for (int i = index; i < nums.Length; i++)
        {
            Swap(nums, index, i);
            Permute(nums, index + 1);
            Swap(nums, index, i); // Restore the original order
        }
    }

    public static void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}
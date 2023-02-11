using System;

namespace SimpleEvent
{
    public class Solution
    {
        public static void Main(string[] args) 
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = new int[2];
            Solution s = new Solution();
            arr2 = s.TwoSum(arr,7);
            foreach (int i in arr2) 
            {
                System.Console.WriteLine(i);
            }

        }
        public int[] TwoSum(int[] nums, int target)
        {
            int i, j;
            int[] ans = new int[2];
            for (i = 0; i < nums.Length - 1; i++)
            {
                for (j = i + 1; j < nums.Length; j++)
                {
                    
                    if (nums[i] + nums[j] == target)
                    {
                        ans[0] = i;
                        ans[1] = j;
                        return ans;
                    }
                }
            }
            return ans;
        }
    }
}
using System;

namespace FindTheMiddleIndexInArray
{
    public class Solution
    {
        public static int FindMiddleIndex(int[] nums)
        {
            int[] leftSum = new int[nums.Length + 1];
            int[] rightSum = new int[nums.Length + 1];
            leftSum[0] = 0;
            rightSum[nums.Length] = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                leftSum[i + 1] = leftSum[i] + nums[i];
            }
            for (int i = nums.Length; i > 0; i--)
            {
                rightSum[i - 1] = rightSum[i] + nums[i - 1];
            }
            
            for (int i = 1; i < leftSum.Length; i++)
            {
                if (leftSum[i] == rightSum[i-1])
                {
                    return i - 1;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] nums = new int[] {2, 3, -1, 8, 4};

            int result = FindMiddleIndex(nums);

            Console.WriteLine("Result is: " + result);
        }
    }
}


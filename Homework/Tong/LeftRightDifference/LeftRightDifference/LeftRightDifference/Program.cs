using System;

namespace LeftRightDifference
{
    public class Solution
    {
        public static int[] LeftRightDifference(int[] nums)
        {
            int[] answer = new int[nums.Length];
            //Add your code here
            int[] leftSum = new int[nums.Length];
            int[] rightSum = new int[nums.Length];
            leftSum[0] = 0;
            rightSum[nums.Length - 1] = 0;

            for (int i = 1; i < nums.Length; ++i)
            {
                leftSum[i] = leftSum[i - 1] + nums[i - 1];
                rightSum[nums.Length - i - 1] = rightSum[nums.Length - i] + nums[nums.Length - i];
            }

            for (int i = 0; i < nums.Length; ++i)
            {
                answer[i] = Math.Abs(leftSum[i] - rightSum[i]);
            }
            return answer;
        }

        static void Main(string[] args)
        {
            int[] nums = new int[] { 10, 4, 8, 3 };

            int[] result = LeftRightDifference(nums);

            int[] expectResult = new int[] { 15, 1, 11, 22 };

            for (int i = 0; i < Math.Min(result.Length, expectResult.Length); ++i)
            {
                Console.WriteLine("Expect index: " + i + " is " + expectResult[i]);
                Console.WriteLine("Actually index: " + i + " is " + result[i]);
            }

            Console.WriteLine("Result is: " + result);
        }
    }
}
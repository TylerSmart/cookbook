namespace LeetCode.MaximumWidthRamp
{
    public static class Solution
    {
        public static int Solve(int[] nums)
        {
            int largestRamp = 0;

            for (int i = 0; i < nums.Length - largestRamp; i++)
            {
                for (int j = i + 1 + largestRamp; j < nums.Length; j++)
                {
                    int rampWidth = j - i;
                    if (nums[i] <= nums[j] && rampWidth > largestRamp)
                    {
                        largestRamp = rampWidth;
                    }

                }
            }

            return largestRamp;
        }
    }
}

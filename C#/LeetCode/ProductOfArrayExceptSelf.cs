namespace LeetCode.ProductOfArrayExceptSelf
{
    public static class Solution
    {
        public static int[] Solve(int[] nums)
        {
            int total = 1;
            bool containsZero = false;
            bool containsMultipleZero = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    total *= nums[i];
                }
                else
                {
                    if (containsZero == true) containsMultipleZero = true;
                    containsZero = true;
                }
            }

            int[] output = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (containsMultipleZero == true) output[i] = 0;
                else if (containsZero == true && nums[i] != 0) output[i] = 0;
                else if (containsZero == true && nums[i] == 0) output[i] = total;
                else output[i] = total / nums[i];
            }

            return output;
        }
    }
}

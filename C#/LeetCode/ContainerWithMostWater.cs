namespace LeetCode.ContainerWithMostWater
{
    public static class Solution
    {
        public static int Solve(int[] height)
        {
            int mostWater = 0;

            for (int i = 0, j = height.Length - 1; i < j;)
            {
                int water = Math.Min(height[i], height[j]) * (j - i);

                if (water > mostWater) mostWater = water;

                if (height[i] > height[j])
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }

            return mostWater;
        }
    }
}

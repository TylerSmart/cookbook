namespace LeetCode.MaxConsecutiveOnes3
{
    public static class Solution
    {
        public static int Solve(int[] nums, int k)
        {
            int max = 0;

            int l = 0;
            int r = 0;
            int zeroes = 0;
            int total = 0;

            while (r < nums.Length)
            {

                if (nums[r] == 1)
                {
                    total++;
                    r++;
                    if (total > max) max = total;
                }
                else
                {
                    if (zeroes < k)
                    {
                        total++;
                        zeroes++;
                        r++;
                        if (total > max) max = total;
                    }
                    else
                    {
                        while (l < r && zeroes == k)
                        {
                            if (nums[l] == 1)
                            {
                                total--;
                            }
                            else
                            {
                                if (zeroes > 0)
                                {
                                    total--;
                                    zeroes--;
                                }
                            }
                            l++;
                        }

                        if (l == r) r++;
                    }
                }

            }

            return max;
        }
    }
}
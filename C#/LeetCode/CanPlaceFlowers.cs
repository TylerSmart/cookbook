namespace LeetCode.CanPlaceFlowers
{
    public static class Solution
    {
        public static bool Solve(int[] flowerbed, int n)
        {
            if (n == 0) return true;
            if (n > flowerbed.Length) return false;

            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0 && (i - 1 < 0 || flowerbed[i - 1] == 0) && (i + 1 >= flowerbed.Length || flowerbed[i + 1] == 0))
                {
                    flowerbed[i] = 1;
                    n--;
                    if (n == 0) return true;
                }
            }
            return false;
        }
    }
}

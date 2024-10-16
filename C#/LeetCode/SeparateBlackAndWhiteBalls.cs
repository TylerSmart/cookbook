namespace LeetCode.SeparateBlackAndWhiteBalls
{
    public static class Soltuion
    {
        public static long Solve(string s)
        {
            long output = 0;
            int leftInPlace = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '0')
                {
                    output += (i - leftInPlace);
                    leftInPlace++;
                } 
            }

            return output;
        }
    }
}

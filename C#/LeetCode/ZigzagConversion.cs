namespace LeetCode.ZigzagConversion
{
    public static class Solution
    {
        public static string Solve(string s, int numRows)
        {
            if (s.Length <= numRows || numRows == 1) return s;

            int zigCount = numRows; // vertical
            int zagCount = numRows - 2; // diagonal

            List<char> output = new List<char>();

            for (int i = 0; i < s.Length; i += zigCount + zagCount)
            {
                output.Add(s[i]);
            }

            for (int i = 0; i < zagCount; i++)
            {
                for (int j = 0; j < (s.Length / (zigCount + zagCount)) + 1; j++)
                {
                    try
                    {
                    output.Add(s[(i + 1) + (j * (zigCount + zagCount))]);
                    } catch (Exception _) { }
                    try
                    {
                        output.Add(s[(i + 1) + (j * (zigCount + zagCount)) + (zagCount + zigCount - 2 - 2 * i)]);
                    } catch (Exception _) { }


                }
            }

            for (int i = (zigCount + zagCount) / 2; i < s.Length; i += zigCount + zagCount)
            {
                output.Add(s[i]);
            }

            return string.Join(null, output);
        }
    }
}

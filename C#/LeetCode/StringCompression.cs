namespace LeetCode.StringCompression
{
    public static class Solution
    {
        public static int Solve(char[] chars)
        {
            int output = 0;

            char? lastChar = null;
            int charCount = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                if (lastChar == chars[i])
                {
                    charCount++;
                }
                else
                {
                    lastChar = chars[i];
                    charCount = 1;
                }

                if (i + 1 == chars.Length || chars[i] != chars[i + 1])
                {
                    chars[output] = chars[i];
                    output++;
                    if (charCount > 1)
                    {
                        string charCountStr = charCount.ToString();
                        for (int j = 0; j < charCountStr.Length; j++)
                        {
                            chars[output] = charCountStr[j];
                            output++;

                        }
                    }

                }
            }

            return output;
        }
    }
}

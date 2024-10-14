namespace LeetCode.ReverseVowelsOfAString
{
    public static class Solution
    {
        public static string Solve(string s)
        {
            char[] VOWELS = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];
            char[] sArray = s.ToCharArray();

            for (int i = 0, j = sArray.Length - 1; i < j && j > i;)
            {
                if (VOWELS.Contains(sArray[i]) == false)
                {
                    i++;
                }

                if (VOWELS.Contains(sArray[j]) == false)
                {
                    j--;
                }

                if (VOWELS.Contains(s[i]) && VOWELS.Contains(s[j]))
                {
                    char temp = sArray[i];
                    sArray[i] = sArray[j];
                    sArray[j] = temp;

                    i++;
                    j--;
                }
            }

            return string.Join("", sArray);
        }
    }
}

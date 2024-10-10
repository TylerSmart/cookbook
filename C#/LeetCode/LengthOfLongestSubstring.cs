namespace LeetCode.LengthOfLongestSubstring
{
    public static class Solution
    {
        public static int Solve(string s)
        {
            int longest = 0;
            HashSet<char> charSet = new HashSet<char>();
            Queue<char> charQueue = new Queue<char>();

            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine($"Processing '{s[i]}'");
                if (charSet.Contains(s[i]))
                {
                    if (charSet.Count > longest)
                    {
                        longest = charSet.Count;
                    }

                    charSet.Remove(s[i]);
                    while (charQueue.Count > 0)
                    {
                        char popped = charQueue.Dequeue();
                        if (popped == s[i]) break;
                        charSet.Remove(popped);
                    }
                }
                charSet.Add(s[i]);
                charQueue.Enqueue(s[i]);
            }
            if (charSet.Count > longest)
            {
                longest = charSet.Count;
            }

            return longest;
        }
    }
}

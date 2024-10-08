using Algorithms;
using LeetCode;

namespace Tests
{
    [TestClass]
    public class LeetCodeTests
    {
        [TestMethod]
        public void MaximumWidthRamp()
        {
            Assert.AreEqual(4, LeetCode.MaximumWidthRamp.Solution.Solve([6, 0, 8, 2, 1, 5]));
            Assert.AreEqual(7, LeetCode.MaximumWidthRamp.Solution.Solve([9, 8, 1, 0, 1, 9, 4, 0, 4, 1]));
        }

        [TestMethod]
        public void TwoSum()
        {
            Assert.IsTrue(LeetCode.TwoSum.Solution.Solve([2, 7, 11, 15], 9).Order().SequenceEqual(new int[] { 0, 1 }.Order()));
            Assert.IsTrue(LeetCode.TwoSum.Solution.Solve([3, 2, 4], 6).Order().SequenceEqual(new int[] { 1, 2 }.Order()));
            Assert.IsTrue(LeetCode.TwoSum.Solution.Solve([3, 3], 6).Order().SequenceEqual(new int[] { 0, 1 }.Order()));
        }

        [TestMethod]
        public void AddTwoNumbers()
        {
            Assert.IsTrue(LeetCode.AddTwoNumbers.Solution.Solve(LeetCode.AddTwoNumbers.ListNode.FromArray([2, 4, 3]), LeetCode.AddTwoNumbers.ListNode.FromArray([5, 6, 4])).ToArray().SequenceEqual([7, 0, 8]));
            Assert.IsTrue(LeetCode.AddTwoNumbers.Solution.Solve(LeetCode.AddTwoNumbers.ListNode.FromArray([0]), LeetCode.AddTwoNumbers.ListNode.FromArray([0])).ToArray().SequenceEqual([0]));
            Assert.IsTrue(LeetCode.AddTwoNumbers.Solution.Solve(LeetCode.AddTwoNumbers.ListNode.FromArray([9, 9, 9, 9, 9, 9, 9]), LeetCode.AddTwoNumbers.ListNode.FromArray([9, 9, 9, 9])).ToArray().SequenceEqual([8, 9, 9, 9, 0, 0, 0, 1]));
        }

        [TestMethod]
        public void LengthOfLongestSubstring()
        {
            Assert.AreEqual(3, LeetCode.LengthOfLongestSubstring.Solution.Solve("abcabcbb"));
            Assert.AreEqual(1, LeetCode.LengthOfLongestSubstring.Solution.Solve("bbbbb"));
            Assert.AreEqual(3, LeetCode.LengthOfLongestSubstring.Solution.Solve("pwwkew"));
            Assert.AreEqual(1, LeetCode.LengthOfLongestSubstring.Solution.Solve(" "));
        }
    }
}
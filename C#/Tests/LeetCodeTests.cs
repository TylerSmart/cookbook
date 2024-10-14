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

        [TestMethod]
        public void TheNumberOfTheSmallestUnoccupiedChair()
        {
            Assert.AreEqual(1, LeetCode.TheNumberOfTheSmallestUnoccupiedChair.Solution.Solve([[1, 4], [2, 3], [4, 6]], 1));
            Assert.AreEqual(2, LeetCode.TheNumberOfTheSmallestUnoccupiedChair.Solution.Solve([[3, 10], [1, 5], [2, 6]], 0));
        }

        [TestMethod]
        public void MedianOfTwoSortedArrays()
        {
            Assert.AreEqual(2.00000, LeetCode.MedianOfTwoSortedArrays.Solution.Solve([1, 3], [2]));
            Assert.AreEqual(2.50000, LeetCode.MedianOfTwoSortedArrays.Solution.Solve([1, 2], [3, 4]));
        }

        [TestMethod]
        public void LongestPalindromicSubstring()
        {
            Assert.AreEqual("bb", LeetCode.LongestPalindromicSubstring.Solution.Solve("bb"));
            Assert.AreEqual("bab", LeetCode.LongestPalindromicSubstring.Solution.Solve("babad"));
            Assert.AreEqual("bb", LeetCode.LongestPalindromicSubstring.Solution.Solve("cbbd"));
            Assert.AreEqual("a", LeetCode.LongestPalindromicSubstring.Solution.Solve("a"));
        }

        [TestMethod]
        public void ZigzagConversion()
        {
            Assert.AreEqual("PAHNAPLSIIGYIR", LeetCode.ZigzagConversion.Solution.Solve("PAYPALISHIRING", 3));
            Assert.AreEqual("PINALSIGYAHRPI", LeetCode.ZigzagConversion.Solution.Solve("PAYPALISHIRING", 4));
            Assert.AreEqual("A", LeetCode.ZigzagConversion.Solution.Solve("A", 1));
        }

        [TestMethod]
        public void MergeStringsAlternately()
        {
            Assert.AreEqual("apbqcr", LeetCode.MergeStringsAlternately.Solution.Solve("abc", "pqr"));
            Assert.AreEqual("apbqrs", LeetCode.MergeStringsAlternately.Solution.Solve("ab", "pqrs"));
            Assert.AreEqual("apbqcd", LeetCode.MergeStringsAlternately.Solution.Solve("abcd", "pq"));
        }

        [TestMethod]
        public void GreatestCommonDivisorOfStrings()
        {
            Assert.AreEqual("ABC", LeetCode.GreatestCommonDivisorOfStrings.Solution.Solve("ABCABC", "ABC"));
            Assert.AreEqual("AB", LeetCode.GreatestCommonDivisorOfStrings.Solution.Solve("ABABAB", "ABAB"));
            Assert.AreEqual("", LeetCode.GreatestCommonDivisorOfStrings.Solution.Solve("LEET", "CODE"));
        }

        [TestMethod]
        public void KidsWithTheGreatestNumberOfCandies()
        {
            Assert.IsTrue(LeetCode.KidsWithTheGreatestNumberOfCandies.Solution.Solve([2, 3, 5, 1, 3], 3).SequenceEqual([true, true, true, false, true]));
            Assert.IsTrue(LeetCode.KidsWithTheGreatestNumberOfCandies.Solution.Solve([4, 2, 1, 1, 2], 1).SequenceEqual([true, false, false, false, false]));
            Assert.IsTrue(LeetCode.KidsWithTheGreatestNumberOfCandies.Solution.Solve([12, 1, 12], 10).SequenceEqual([true, false, true]));
        }

        [TestMethod]
        public void CanPlaceFlowers()
        {
            Assert.AreEqual(true, LeetCode.CanPlaceFlowers.Solution.Solve([1, 0, 0, 0, 1], 1));
            Assert.AreEqual(false, LeetCode.CanPlaceFlowers.Solution.Solve([1, 0, 0, 0, 1], 2));
            Assert.AreEqual(false, LeetCode.CanPlaceFlowers.Solution.Solve([1, 0, 0, 0, 0, 1], 2));
            Assert.AreEqual(false, LeetCode.CanPlaceFlowers.Solution.Solve([1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0], 223));
        }

        [TestMethod]
        public void ReverseVowelsOfAString()
        {
            Assert.AreEqual("AceCreIm", LeetCode.ReverseVowelsOfAString.Solution.Solve("IceCreAm"));
            Assert.AreEqual("leotcede", LeetCode.ReverseVowelsOfAString.Solution.Solve("leetcode"));
        }

        [TestMethod]
        public void ReverseWordsInAString()
        {
            Assert.AreEqual("example good a", LeetCode.ReverseWordsInAString.Solution.Solve("a good   example"));
            Assert.AreEqual("blue is sky the", LeetCode.ReverseWordsInAString.Solution.Solve("the sky is blue"));
            Assert.AreEqual("world hello", LeetCode.ReverseWordsInAString.Solution.Solve("  hello world  "));
        }

        [TestMethod]
        public void ProductOfArrayExceptSelf()
        {
            Assert.IsTrue(LeetCode.ProductOfArrayExceptSelf.Solution.Solve([1, 2, 3, 4]).SequenceEqual([24, 12, 8, 6]));
            Assert.IsTrue(LeetCode.ProductOfArrayExceptSelf.Solution.Solve([-1, 1, 0, -3, 3]).SequenceEqual([0, 0, 9, 0, 0]));
        }

        [TestMethod]
        public void IncreasingTripletSubsequence()
        {
            Assert.AreEqual(true, LeetCode.IncreasingTripletSubsequence.Solution.Solve([1, 2, 3, 4, 5]));
            Assert.AreEqual(false, LeetCode.IncreasingTripletSubsequence.Solution.Solve([5, 4, 3, 2, 1]));
            Assert.AreEqual(true, LeetCode.IncreasingTripletSubsequence.Solution.Solve([2, 1, 5, 0, 4, 6]));
        }
    }
}
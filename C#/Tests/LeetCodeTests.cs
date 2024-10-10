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
            Assert.AreEqual(LeetCode.MaximumWidthRamp.MaxWidthRamp([6, 0, 8, 2, 1, 5]), 4);
            Assert.AreEqual(LeetCode.MaximumWidthRamp.MaxWidthRamp([9, 8, 1, 0, 1, 9, 4, 0, 4, 1]), 7);
        }
    }
}
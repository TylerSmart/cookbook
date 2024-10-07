using Algorithms;

namespace Tests
{
    [TestClass]
    public class SortTests
    {
        List<int> list = Enumerable.Range(0, 10).Select(_ => new Random().Next(0, 100)).ToList();

        [TestMethod]
        public void InsertionSort()
        {
            List<int> sortedList = Sort.InsertionSort<int>(list.ToList());

            Console.WriteLine(string.Join(", ", list));
            Console.WriteLine(string.Join(", ", sortedList));

            Assert.IsTrue(Sort.Verify(sortedList, list));
        }

        [TestMethod]
        public void MergeSort()
        {
            List<int> sortedList = Sort.MergeSort<int>(list.ToList());

            Console.WriteLine(string.Join(", ", list));
            Console.WriteLine(string.Join(", ", sortedList));

            Assert.IsTrue(Sort.Verify(sortedList, list));
        }

        [TestMethod]
        public void BubbleSort()
        {
            List<int> sortedList = Sort.BubbleSort<int>(list.ToList());

            Console.WriteLine(string.Join(", ", list));
            Console.WriteLine(string.Join(", ", sortedList));

            Assert.IsTrue(Sort.Verify(sortedList, list));
        }

        [TestMethod]
        public void Heapsort()
        {
            List<int> sortedList = Sort.Heapsort<int>(list.ToList());

            Console.WriteLine(string.Join(", ", list));
            Console.WriteLine(string.Join(", ", sortedList));

            Assert.IsTrue(Sort.Verify(sortedList, list));
        }

        [TestMethod]
        public void Quicksort()
        {
            List<int> sortedList = Sort.Quicksort<int>(list.ToList());

            Console.WriteLine(string.Join(", ", list));
            Console.WriteLine(string.Join(", ", sortedList));

            Assert.IsTrue(Sort.Verify(sortedList, list));
        }

        [TestMethod]
        public void CountingSort()
        {
            List<int> sortedList = Sort.CountingSort<int>(list.ToList());

            Console.WriteLine(string.Join(", ", list));
            Console.WriteLine(string.Join(", ", sortedList));

            Assert.IsTrue(Sort.Verify(sortedList, list));
        }

        [TestMethod]
        public void RadixSort()
        {
            List<int> sortedList = Sort.RadixSort<int>(list.ToList());

            Console.WriteLine(string.Join(", ", list));
            Console.WriteLine(string.Join(", ", sortedList));

            Assert.IsTrue(Sort.Verify(sortedList, list));
        }

        [TestMethod]
        public void BucketSort()
        {
            List<int> sortedList = Sort.BucketSort<int>(list.ToList());

            Console.WriteLine(string.Join(", ", list));
            Console.WriteLine(string.Join(", ", sortedList));

            Assert.IsTrue(Sort.Verify(sortedList, list));
        }
    }
}
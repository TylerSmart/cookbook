using Algorithms;

namespace Tests
{
    [TestClass]
    public class SortTests
    {
        List<int> list = Enumerable.Range(0, 10).Select(_ => new Random().Next(0, 100)).ToList(); // Random List
        //List<int> list = new() { 2, 8, 7, 1, 3, 5, 6, 4 };
        //List<int> list = [58, 25, 63, 75, 97, 46, 11, 47, 44, 90, 56, 86, 32, 43, 19, 73, 63, 82, 24, 56, 99, 50, 14, 7, 42, 9, 51, 53, 11, 18, 1, 20, 21, 63, 60, 33, 86, 16, 85, 35, 20, 93, 81, 53, 45, 64, 63, 13, 25, 53, 27, 29, 92, 10, 28, 78, 31, 16, 62, 59, 2, 43, 46, 82, 91, 57, 51, 47, 11, 96, 54, 47, 67, 92, 72, 94, 83, 96, 26, 81, 76, 16, 81, 72, 27, 62, 54, 25, 99, 36, 66, 37, 1, 71, 70, 84, 66, 59, 17, 47, 91, 53, 10, 72, 16, 58, 51, 61, 54, 43, 45, 75, 81, 78, 83, 70, 95, 4, 65, 43, 61, 41, 54, 73, 69, 92, 22, 50, 85, 86, 69, 45, 97, 49, 17, 29, 30, 60, 76, 12, 26, 39, 95, 87, 81, 19, 76, 58, 38, 69, 12, 26, 95, 43, 65, 25, 68, 18, 96, 85, 24, 62, 5, 53, 91, 68, 88, 12, 6, 0, 22, 69, 7, 84, 84, 20, 48, 63, 72, 3, 53, 89, 25, 17, 45, 98, 71, 48, 50, 67, 74, 65, 33, 73, 23, 4, 63, 97, 20, 18, 68, 46, 93, 8, 18, 5, 36, 44, 74, 47, 98, 28, 0, 72, 98, 76, 8, 1, 67, 82, 77, 87, 84, 16, 91, 34, 26, 40, 64, 92, 65, 31, 81, 74, 60, 2, 31, 82, 85, 65, 38, 80, 41, 60, 23, 61, 45, 73, 39, 26, 17, 71, 2, 69, 13, 91, 53, 74, 96, 90, 67, 12, 87, 28, 19, 88, 31, 52, 60, 11, 70, 54, 65, 89, 71, 94, 37, 93, 76, 50, 25, 27, 8, 75, 48, 86, 90, 15, 44, 96, 90, 81, 73, 8, 21, 34, 51, 51, 9, 60, 84, 71, 40, 30, 88, 68, 77, 2, 5, 24, 43, 26, 38, 16, 3, 98, 91, 36, 52, 40, 91, 53, 54, 91, 17, 89, 56, 70, 47, 32, 6, 44, 95, 25, 11, 98, 71, 77, 21, 5, 84, 50, 3, 7, 47, 91, 55, 90, 13, 41, 26, 20, 49, 66, 18, 7, 71, 39, 26, 47, 1, 42, 27, 79, 26, 19, 54, 44, 63, 81, 90, 72, 42, 60, 28, 96, 17, 50, 59, 78, 21, 27, 8, 42, 43, 25, 85, 42, 42, 3, 4, 12, 11, 65, 80, 97, 30, 40, 39, 41, 83, 97, 66, 20, 54, 66, 51, 99, 42, 90, 43, 29, 60, 89, 91, 58, 57, 88, 7, 80, 95, 7, 6, 21, 90, 67, 67, 46, 71, 16, 33, 48, 21, 17, 85, 81, 38, 74, 15, 94, 95, 87, 7, 83, 57, 56, 56, 79, 78, 27, 5, 20, 1, 32, 83, 9, 7, 51, 32, 89, 17, 93, 24, 34, 93, 42, 49, 70, 36, 91, 0, 84, 37, 19, 52, 36, 77, 23, 36, 34, 73, 35, 99, 8, 0, 6, 71, 33, 30, 30, 35, 63, 75, 32, 20, 93, 15, 54, 57, 59, 16, 27, 65, 1, 11, 77, 54, 3, 6, 1, 3, 53, 57, 35, 60, 79, 14, 74, 32, 13, 35, 39, 91, 16, 82, 78, 74, 45, 84, 85, 88, 24, 60, 32, 60, 29, 83, 57, 42, 58, 4, 21, 9, 5, 74, 44, 80, 65, 2, 52, 16, 56, 65, 36, 6, 80, 43, 0, 63, 75, 37, 1, 36, 49, 96, 84, 85, 52, 69, 17, 2, 41, 84, 50, 0, 3, 14, 25, 79, 7, 13, 7, 64, 29, 21, 80, 35, 45, 86, 4, 65, 60, 3, 42, 11, 54, 56, 80, 35, 60, 79, 18, 30, 5, 57, 79, 88, 33, 77, 66, 15, 81, 57, 59, 32, 21, 47, 74, 73, 20, 51, 93, 81, 95, 14, 31, 37, 95, 48, 78, 98, 27, 27, 29, 21, 74, 6, 7, 71, 82, 45, 53, 75, 88, 25, 99, 75, 89, 52, 26, 47, 39, 22, 82, 79, 43, 51, 85, 54, 63, 17, 88, 69, 74, 3, 94, 84, 14, 6, 21, 90, 55, 89, 5, 71, 73, 48, 46, 37, 79, 30, 11, 54, 80, 48, 97, 87, 53, 45, 79, 5, 24, 88, 91, 8, 63, 97, 46, 66, 54, 82, 76, 27, 70, 69, 59, 97, 4, 47, 56, 50, 88, 19, 94, 5, 51, 63, 37, 58, 24, 80, 41, 71, 35, 66, 46, 89, 18, 79, 63, 52, 13, 81, 55, 34, 28, 67, 79, 62, 64, 19, 31, 85, 84, 13, 41, 66, 1, 31, 67, 26, 87, 27, 82, 1, 47, 75, 59, 26, 71, 65, 65, 61, 86, 28, 67, 46, 50, 34, 65, 94, 43, 35, 68, 35, 60, 80, 44, 18, 95, 66, 35, 49, 27, 29, 35, 17, 0, 84, 56, 95, 29, 22, 32, 61, 6, 2, 38, 98, 65, 73, 63, 15, 53, 55, 28, 51, 88, 8, 45, 74, 42, 42, 45, 0, 17, 99, 39, 86, 36, 44, 77, 32, 70, 48, 64, 56, 23, 70, 39, 0, 11, 61, 30, 50, 2, 70, 78, 94, 83, 88, 3, 77, 31, 94, 59, 26, 78, 6, 48, 87, 71, 63, 45, 77, 80, 89, 91, 35, 85, 35, 94, 22, 98, 6, 4, 9, 56, 83, 99, 90, 41, 85, 79, 93, 75, 48, 96, 92, 59, 21, 32, 33, 59, 82, 45, 72, 63, 95, 40, 70, 81, 40, 47, 76, 61, 70, 1, 41, 67, 6, 23, 56, 26, 17, 80, 8, 45, 48, 28, 70, 48, 60, 91, 74, 85, 17, 58, 54, 71, 20, 12, 16, 68, 69, 27, 84, 86, 71, 65, 85, 74, 41, 51, 74, 23, 28, 98, 0, 2, 19, 62, 6, 84, 89, 44, 8, 94, 74, 41, 81, 58, 44, 9, 44, 93, 95, 66, 10, 8, 35, 46, 26, 95, 55, 87, 77, 73, 45, 18, 45, 44, 7, 67, 42, 87, 38, 11, 28, 3, 48, 17, 12, 42, 66, 40, 31, 92, 23, 85, 55, 49, 35, 94, 56, 4, 67, 74, 14, 15];
        //List<int> list = Enumerable.Range(0, 100).Select((_, i) => i).ToList(); // Ordered List
        //List<int> list = Enumerable.Range(0, 100).Select((_, i) => 100 - i).ToList(); //  Reverse Ordered List

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
        public void QuicksortImproved()
        {
            List<int> sortedList = Sort.QuicksortImproved<int>(list.ToList());

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
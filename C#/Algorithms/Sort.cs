using System.Drawing;

namespace Algorithms
{
    public static class Sort
    {
        public static bool Verify<T>(List<T> sortedList, List<T> list) where T : IComparable<T>
        {
            // ensure both lists have the same count
            if (sortedList.Count != list.Count)
            {
                return false;
            }

            // ensure the sorted list has all the same elements as the original list
            Dictionary<T, int> sortedListCounts = new();
            Dictionary<T, int> listCounts = new();
            foreach (T key in sortedList)
            {
                if (sortedListCounts.ContainsKey(key))
                {
                    sortedListCounts[key]++;
                }
                else
                {
                    sortedListCounts[key] = 1;
                }
            }
            foreach (T key in list)
            {
                if (listCounts.ContainsKey(key))
                {
                    listCounts[key]++;
                }
                else
                {
                    listCounts[key] = 1;
                }
            }
            foreach (T key in list)
            {
                if (!sortedListCounts.ContainsKey(key) || sortedListCounts[key] != listCounts[key])
                {
                    return false;
                }
            }
            foreach (T key in sortedList)
            {
                if (!listCounts.ContainsKey(key) || sortedListCounts[key] != listCounts[key])
                {
                    return false;
                }
            }

            // ensure the sorted list is in order
            for (int i = 0; i < sortedList.Count - 1; i++)
            {
                if (sortedList[i].CompareTo(sortedList[i + 1]) > 0)
                {
                    return false;
                }
            }

            return true;
        }


        /*  Insertion Sort
         *  
         *  Worst Case Time Complexity: O(n^2)
         *  Best Case Time Complexity: O(n)
         *  Space Complexity: O(1)
         */
        public static List<T> InsertionSort<T>(List<T> A) where T : IComparable<T>
        {
            int n = A.Count;

            for (int i = 1; i < n; i++)
            {
                T key = A[i];
                int j = i - 1;

                while (j >= 0 && A[j].CompareTo(key) > 0)
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }
                A[j + 1] = key;
            }

            return A;
        }

        /*  Merge Sort
         *  
         *  Time Complexity: O(n*log(n))
         *  Space Complexity: O(n)
         */
        public static List<T> MergeSort<T>(List<T> A) where T : IComparable<T>
        {
            List<T> Merge(List<T> A, int p, int q, int r)
            {
                int n_L = q - p + 1;
                int n_R = r - q;
                List<T> L = new(new T[n_L]);
                List<T> R = new(new T[n_R]);
                int i, j;
                for (i = 0; i < n_L; i++)
                {
                    L[i] = A[p + i];
                }
                for (j = 0; j < n_R; j++)
                {
                    R[j] = A[q + j + 1];
                }

                i = 0;
                j = 0;
                int k = p;

                while (i < n_L && j < n_R)
                {
                    if (L[i].CompareTo(R[j]) <= 0)
                    {
                        A[k++] = L[i++];
                    }
                    else
                    {
                        A[k++] = R[j++];
                    }
                }
                while (i < n_L)
                {
                    A[k++] = L[i++];
                }
                while (j < n_R)
                {
                    A[k++] = R[j++];
                }

                return A;
            }

            List<T> Sort(List<T> A, int p, int r)
            {
                if (p >= r)
                {
                    return A;
                }

                int q = p + (r - p) / 2;

                Sort(A, p, q);
                Sort(A, q + 1, r);

                return Merge(A, p, q, r);
            }

            return Sort(A, 0, A.Count - 1);
        }

        /*  Bubble Sort
         *  
         *  Best Case Time Complexity: O(n)
         *  Worst Case Time Complexity: O(n^2)
         *  Space Complexity: O(1)
         */
        public static List<T> BubbleSort<T>(List<T> A) where T : IComparable<T>
        {
            int n = A.Count;

            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (A[j].CompareTo(A[j - 1]) < 0)
                    {
                        T temp = A[j];
                        A[j] = A[j - 1];
                        A[j - 1] = temp;
                    }
                }
            }

            return A;
        }

        /*  Heapsort
         *  
         *  Time Complexity: O(n*log(n))
         */
        public static List<T> Heapsort<T>(List<T> A) where T : IComparable<T>
        {
            static void MaxHeapify(List<T> A, int n, int i)
            {
                int largest = i;
                int l = 2 * i + 1;
                int r = 2 * i + 2;

                if (l < n && A[l].CompareTo(A[largest]) > 0)
                {
                    largest = l;
                }

                if (r < n && A[r].CompareTo(A[largest]) > 0)
                {
                    largest = r;
                }

                if (largest != i)
                {
                    T temp = A[i];
                    A[i] = A[largest];
                    A[largest] = temp;

                    MaxHeapify(A, n, largest);
                }
            }

            if (A.Count <= 1)
            {
                return A;
            }
            for (int i = A.Count / 2 - 1; i >= 0; i--)
            {
                MaxHeapify(A, A.Count, i);
            }
            for (int i = A.Count - 1; i >= 0; i--)
            {
                T temp = A[0];
                A[0] = A[i];
                A[i] = temp;
                MaxHeapify(A, i, 0);
            }

            return A;
        }

        /*  Quicksort
         *  
         *  Worst Case Time Complexity: O(n^2)
         *  Best Case Time Complexity: O(n*log(n))
         */
        public static List<T> Quicksort<T>(List<T> A) where T : IComparable<T>
        {
            throw new NotImplementedException();
        }

        /*  Counting Sort
         *  
         *  Time Complexity: O(k+n)
         */
        public static List<T> CountingSort<T>(List<T> A) where T : IComparable<T>
        {
            throw new NotImplementedException();
        }

        /*  Radix Sort
         *  
         *  Time Complexity: O(d(n+k))
         */
        public static List<T> RadixSort<T>(List<T> A) where T : IComparable<T>
        {
            throw new NotImplementedException();
        }

        /*  Bucket Sort
         *  
         *  Worst Case Time Complexity: O(n^2)
         *  Best Case Time Complexity: O(n)
         */
        public static List<T> BucketSort<T>(List<T> A) where T : IComparable<T>
        {
            throw new NotImplementedException();
        }

    }
}

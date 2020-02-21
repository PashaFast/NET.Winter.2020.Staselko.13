using System;
using System.Collections.Generic;

namespace BinarySearchAlgorithm
{
    /// <summary>
    /// Class BinarySearchAlgorithm.
    /// </summary>
    /// <typeparam name="T">Input parameter.</typeparam>
    public static class BinarySearchAlgorithm<T>
    {
        /// <summary>
        /// Element search method in a sorted array.
        /// </summary>
        /// <param name="arr">Input array.</param>
        /// <param name="x">Input element.</param>
        /// <returns>index of the element if it finds; -1 otherwise.</returns>
        public static int BinarySearch(T[] arr, T x)
        {
            if (arr == null)
            {
                throw new ArgumentNullException($"{arr} cannot be null.");
            }

            return BinarySearchHelper(arr, 0, arr.Length - 1, x);
        }

        /// <summary>
        /// Element search method in a sorted array.
        /// </summary>
        /// <param name="arr">Input array.</param>
        /// <param name="x">Input element.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>index of the element if it finds; -1 otherwise.</returns>
        public static int BinarySearch(T[] arr, T x, IComparer<T> comparer)
        {
            if (comparer == null)
            {
                throw new ArgumentNullException($"{comparer} cannot be null.");
            }

            if (arr == null)
            {
                throw new ArgumentNullException($"{arr} cannot be null.");
            }

            return BinarySearchHelper(arr, 0, arr.Length - 1, x, comparer);
        }

        private static int BinarySearchHelper(T[] arr, int l, int r, T x)
        {
            if (r >= l)
            {
                int mid = l + ((r - l) / 2);

                if (Comparer<T>.Default.Compare(arr[mid], x) == 0)
                {
                    return mid;
                }

                if (Comparer<T>.Default.Compare(arr[mid], x) == 1)
                {
                    return BinarySearchHelper(arr, l, mid - 1, x);
                }

                return BinarySearchHelper(arr, mid + 1, r, x);
            }

            return -1;
        }

        private static int BinarySearchHelper(T[] arr, int l, int r, T x, IComparer<T> comparer)
        {
            if (r >= l)
            {
                int mid = l + ((r - l) / 2);
                if (comparer.Compare(arr[mid], x) == 0)
                {
                    return mid;
                }

                if (comparer.Compare(arr[mid], x) == 1)
                {
                    return BinarySearchHelper(arr, l, mid - 1, x, comparer);
                }

                return BinarySearchHelper(arr, mid + 1, r, x, comparer);
            }

            return -1;
        }
    }
}

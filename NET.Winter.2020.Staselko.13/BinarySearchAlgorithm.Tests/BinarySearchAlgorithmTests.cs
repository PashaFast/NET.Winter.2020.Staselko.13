using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace BinarySearchAlgorithm.Tests
{
    public class BinarySearchAlgorithmTests
    {
        [TestCase(new[] { 1,2,3,5,6 }, 0, -1)]
        [TestCase(new[] { 1,2,3,4,5,6}, 2, 1)]
        public void BinarySearch_Int_ExpectedResults(int[] array, int digit, int expected)
        {
            
            Assert.AreEqual(expected, BinarySearchAlgorithm<int>.BinarySearch(array, digit));
        }

        [TestCase(new[] { "1", "2", "3", "5", "6" }, "0", -1)]
        [TestCase(new[] { "1", "2", "3", "4", "5", "6" }, "2", 1)]


        public void BinarySearch_String_ExpectedResults(string[] array, string digit, int expected)
        {

            Assert.AreEqual(expected, BinarySearchAlgorithm<string>.BinarySearch(array, digit));
        }

       
        [Test]
        public void BinarySearch_Point_ExpectedResults()
        {
            Point[] arr = { new Point(1, 2), new Point(3, 4), new Point(-1, -2), new Point(), new Point(1, 2) };

            Array.Sort(arr, Comparer<Point>.Default.Compare);
          
            
            Point x = new Point(1, 2);
            
           Assert.AreEqual(2, BinarySearchAlgorithm<Point>.BinarySearch(arr, x));
        }

        [Test]
        public void FilterArrayByKey_Number_ExpectedResults()
        {
            Number[] arr = { new Number(1), new Number(3), new Number(-1), new Number() };

            Array.Sort(arr, new Number());

            Number x = new Number(1);

            Assert.AreEqual(2, BinarySearchAlgorithm<Number>.BinarySearch(arr, x, new Number()));
        }

        [Test]
        public void BinarySearch_Null_ExpectedResults()
        {
            Number[] arr = { new Number(), new Number(1), new Number(2), new Number(3) };

            Number x = new Number(1);
            Assert.Throws<ArgumentNullException>(() => BinarySearchAlgorithm<Number>.BinarySearch(arr, x, null));

        }
    }
}
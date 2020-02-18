using NUnit.Framework;
using System;

namespace FlaviusJosephusTask.Tests
{
    public class JosephusTaskTests
    {
        [TestCase(2, 1, ExpectedResult = 2)]
        [TestCase(5, 2, ExpectedResult = 3)]
        [TestCase(7,5, ExpectedResult = 6)]
        [TestCase(50,25, ExpectedResult = 5)]
        [TestCase(77,28,ExpectedResult = 50)]
        [TestCase(100, 99, ExpectedResult = 88)]
        [TestCase(256, 2, ExpectedResult = 1)]
        [TestCase(498, 68, ExpectedResult = 193)]
        [TestCase(6, 10, ExpectedResult = 2)]
        public int Josephus_WithSeveralNumbers(int a, int b) => JosephusTask.Josephus(a,b);

        [Test]
        public void Josephus_WithTwoZeros_ArgumentException() =>
           Assert.Throws<ArgumentException>(() => JosephusTask.Josephus(0, 0));

        [Test]
        public void Josephus_WithTwoNegative_ArgumentException() =>
           Assert.Throws<ArgumentException>(() => JosephusTask.Josephus(-5, -6));

        [Test]
        public void Josephus_WhenKIsZero_ArgumentException() =>
           Assert.Throws<ArgumentException>(() => JosephusTask.Josephus(100, 0));
        [Test]
        public void Josephus_WhenCountIsZero_ArgumentException() =>
           Assert.Throws<ArgumentException>(() => JosephusTask.Josephus(0, 100));
    }
}
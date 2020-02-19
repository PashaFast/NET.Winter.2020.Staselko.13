using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ValidParentheses.Tests
{
    public class BalanceTaskTests
    {
        [TestCase("()(){}[]", ExpectedResult = true)]
        [TestCase("))((", ExpectedResult = false)]
        [TestCase("[][]", ExpectedResult = true)]
        [TestCase("", ExpectedResult = true)]
        [TestCase("((hello))..({{[...]}})", ExpectedResult = true)]
        [TestCase("[[((.....)])]", ExpectedResult = false)]
        [TestCase("(x +(x-y) * (x[1] + x[2]))", ExpectedResult = true)]
        [TestCase("[[[[((({{{9}}})))]]]]", ExpectedResult = true)]
        [TestCase("((hello))..({[...]}})", ExpectedResult = false)]
        public bool Balance_WithSeveralNumbers(string str)
        {
            var brackets = new List<Bracket>();
            brackets.Add(new Bracket('(', ')'));
            brackets.Add(new Bracket('[', ']'));
            brackets.Add(new Bracket('{', '}'));

            return BalanceTask.Balance(str, brackets);

        }

        [Test]
        public void Balance_WithNullString_ArgumentNullException() =>
           Assert.Throws<ArgumentNullException>(() => BalanceTask.Balance(null, new List<Bracket>()));

        [Test]
        public void Balance_WithStringWithoutBrackets_True()
        {
            bool actual = BalanceTask.Balance("123456789", new List<Bracket>());
            Assert.IsTrue(actual);
        }

    }
}
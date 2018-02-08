using AdventOfCode2015Day5.Core.Rules;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2015Day5.Test
{
    [TestFixture()]
    public class LettersTwiceInARowTests
    {
        [Test]
        [TestCase("aaa", true)]
        [TestCase("aa", true)]
        [TestCase("abcd", false)]
        [TestCase("aba", false)]
        public void LettersTwiceInARowRule_Should_Verify_Letters_Twice_In_A_Row(string input, bool expectedResult)
        {
            new LettersAtLeastTwiceInARowRule().IsNice(input).Should().Be(expectedResult);
        }
    }
}

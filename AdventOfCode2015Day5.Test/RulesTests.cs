using AdventOfCode2015Day5.Core.Rules;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2015Day5.Test
{
    public class RulesTests
    {
        [Test]
        [TestCase("ugknbfddgicrmopn", true)]
        [TestCase("aaa", true)]
        [TestCase("aa", false)]
        [TestCase("uasd", false)]
        public void VowelsRule_Should_Verify_Minimum_Number_Of_Vowels(string input, bool expectedResult)
        {
            new VowelsRule().IsNice(input).Should().Be(expectedResult);
        }

        [Test]
        [TestCase("aaa", true)]
        [TestCase("aa", true)]
        [TestCase("abcd", false)]
        [TestCase("aba", false)]
        public void LettersTwiceInARowRule_Should_Verify_Letters_Twice_In_A_Row(string input, bool expectedResult)
        {
            new LettersAtLeastTwiceInARowRule().IsNice(input).Should().Be(expectedResult);
        }

        [Test]
        [TestCase("ugknbfddgicrmopn", true)]
        [TestCase("aaa", true)]
        [TestCase("uydafcd", false)]
        [TestCase("aiusdpqasd", false)]
        public void DisallowedLettersRule_Should_Verify_Disallowed_Letters(string input, bool expectedResult)
        {
            new DisallowedLettersRule().IsNice(input).Should().Be(expectedResult);
        }
    }
}

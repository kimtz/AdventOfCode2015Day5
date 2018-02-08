using AdventOfCode2015Day5.Core.Rules;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2015Day5.Test
{
    [TestFixture()]
    public class DisallowedLettersRuleTests
    {
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

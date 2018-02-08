using AdventOfCode2015Day5.Core.Rules;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2015Day5.Test
{
    [TestFixture]
    public class VowelsRuleTests
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
    }
}

using System.Collections.Generic;
using AdventOfCode2015Day5.Core;
using AdventOfCode2015Day5.Core.Rules;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2015Day5.Test
{
    [TestFixture()]
    public class StringAnalyzerTests
    {
        private StringAnalyzer _stringAnalyzer;

        [SetUp]
        public void SetUp()
        {
            var rules = new List<IRule>() { new VowelsRule(), new LettersAtLeastTwiceInARowRule(), new DisallowedLettersRule() };
            _stringAnalyzer = new StringAnalyzer(rules);
        }

        [Test]
        public void Find_Number_Of_Nice_Strings_PartOne()
        {
            _stringAnalyzer.GetNumberOfNiceStringsFromSantasList().Should().Be(255);
        }

        [Test]
        [TestCase("ugknbfddgicrmopn")]
        [TestCase("aaa")]
        public void Should_Determine_Nice_Strings(string input)
        {
            _stringAnalyzer.StringIsNice(input).Should().BeTrue();
        }

        [Test]
        [TestCase("jchzalrnumimnmhp")]
        [TestCase("haegwjzuvuyypxyu")]
        [TestCase("dvszwmarrgswjxmb")]
        public void Should_Determine_Naughty_Strings(string input)
        {
            _stringAnalyzer.StringIsNice(input).Should().BeFalse();
        }

        [Test]
        public void Should_Determine_Amount_Of_Nice_Strings_In_List()
        {
            var list = new List<string>() { "ugknbfddgicrmopn", "aaa", "jchzalrnumimnmhp", "haegwjzuvuyypxyu", "dvszwmarrgswjxmb" };
            _stringAnalyzer.GetNumberOfNiceStringsFromList(list).Should().Be(2);
        }
    }
}

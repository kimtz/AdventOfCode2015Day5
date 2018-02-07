using System.Collections.Generic;
using System.Linq;
using AdventOfCode2015Day5.Core.Rules;

namespace AdventOfCode2015Day5.Rules
{
    public class DisallowedLettersRule : IRule
    {
        private readonly List<string> _disallowedStrings = new List<string>() { "ab", "cd", "pq", "xy" };
        public bool IsNice(string input)
        {
            return !_disallowedStrings.Any(input.Contains);
        }
    }
}

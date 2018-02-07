using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2015Day5.Core.Rules
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

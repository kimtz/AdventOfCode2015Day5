using AdventOfCode2015Day5.Core.Rules;

namespace AdventOfCode2015Day5.Rules
{
    public class LettersAtLeastTwiceInARowRule : IRule
    {
        public bool IsNice(string input)
        {
            var lastCharacter = '\0';
            foreach (var ch in input.ToCharArray())
            {
                if (ch.Equals(lastCharacter))
                    return true;
                lastCharacter = ch;
            }
            return false;
        }
    }
}

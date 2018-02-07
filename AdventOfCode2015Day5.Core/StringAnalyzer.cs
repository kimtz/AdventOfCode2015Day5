using System.Collections.Generic;
using System.Linq;
using AdventOfCode2015Day5.Core.Rules;

namespace AdventOfCode2015Day5.Core
{
    public class StringAnalyzer
    {
        private readonly IEnumerable<IRule> _rules;
        private readonly Elf _elf;

        public StringAnalyzer(IEnumerable<IRule> rules)
        {
            _rules = rules;
            _elf = new Elf();
        }

        public bool StringIsNice(string input)
        {
            return _rules.All(x => x.IsNice(input));
        }

        public int GetNumberOfNiceStringsFromSantasList()
        {
            return GetNumberOfNiceStringsFromList(ReadSantasStringList());
        }

        public int GetNumberOfNiceStringsFromList(IEnumerable<string> stringList)
        {
            return stringList.Count(StringIsNice);
        }

        private IEnumerable<string> ReadSantasStringList()
        {
            return _elf.ReadSantasStringList();
        }
    }
}

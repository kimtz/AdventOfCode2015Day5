using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace AdventOfCode2015Day5.Core
{
    public class Elf
    {
        public IEnumerable<string> ReadSantasStringList()
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Brannstrom.AdventOfCode.Day5.input.txt"))
            using (var reader = new StreamReader(stream))
                while (reader.Peek() >= 0)
                    yield return reader.ReadLine();
        }
    }
}

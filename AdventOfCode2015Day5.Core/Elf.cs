using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace AdventOfCode2015Day5.Core
{
    public class Elf
    {
        public IEnumerable<string> ReadSantasStringList()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "input.txt");
            using (var reader = new StreamReader(path))
                while (reader.Peek() >= 0)
                    yield return reader.ReadLine();
        }
    }
}

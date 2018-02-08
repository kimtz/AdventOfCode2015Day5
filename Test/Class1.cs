using System;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void herp()
        {
            var test = 1;
            Assert.AreEqual(1,test);
        }
    }
}

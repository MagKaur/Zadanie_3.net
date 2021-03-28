using System;
using NUnit.Framework;

namespace TestConsoleApp
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.True(true);
            Hours godz = new Hours();
            godz.Hour = 0; 
            Console.WriteLine(godz);
        }
    }
}
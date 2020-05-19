using NUnit.Framework;
using SoftDev;

namespace SoftDev.Tests
{
    public class CounterTest
    {
        private Counter counter;

        [SetUp]
        public void Setup()
        {
            counter = new Counter();
        }

        [Test]
        public void GetValue()
        {
            int v = counter.GetValue();
            Assert.AreEqual(0, v);
        }
    }
}
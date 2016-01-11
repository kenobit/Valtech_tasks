using Graphs;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nUnitTests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        [TestCase()]
        public void ToStringNull_error()
        {
            Graph1 g = null;
            Assert.Throws(typeof(NullReferenceException), () => g.ToString());
        }

        [Test]
        [TestCase()]
        public void ToStringEmpty_error()
        {
            Graph1 g = new Graph1();
            Assert.Throws(typeof(InvalidOperationException), () => g.ToString());
        }

        [Test]
        [TestCase()]
        public void ToString_error()
        {
            Graph1 g = new Graph1();
            g.AddNode("Kyiv");
            g.AddNode("Lviv");
            Assert.AreEqual("Kyiv Lviv ", g.ToString());
        }

        [Test]
        [TestCase()]
        public void AddNode_exception_error()
        {
            Graph1 g = new Graph1();
            Assert.Throws(typeof(ArgumentException), () => g.AddNode(""));
        }

        [Test]
        [TestCase()]
        public void AddNode_error()
        {
            Graph1 g = new Graph1();
            g.AddNode("Kyiv");
            g.AddNode("Lviv");
            g.AddNode("Donetsk");
            Assert.AreEqual(3, g.nodes.Length);
        }
    }
}

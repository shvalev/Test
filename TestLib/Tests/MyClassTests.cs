using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLib;

namespace Tests
{
    [TestClass]
    public class MyClassTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new MyClass();
            var res = c.GetData();

            res.Should().Be("Hello!!!");
        }
    }
}

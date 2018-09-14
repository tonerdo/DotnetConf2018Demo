using DotnetConf2018Demo.Lib;
using Xunit;

namespace DotnetConf2018Demo.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAdd()
        {
            Assert.Equal(20, Math.Add(10, 10));
        }

        [Fact]
        public void TestSub()
        {
            Assert.Equal(0, Math.Sub(10, 10));
            Assert.Equal(0, Math.Sub(10, 0));
        }

        [Fact]
        public void TestMul()
        {
            Assert.Equal(100, Math.Mul(10, 10));
        }

        [Fact]
        public void TestDiv()
        {
            Assert.Equal(100, Math.Div(100, 1));
        }
    }
}

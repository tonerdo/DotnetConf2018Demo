using DotnetConf2018Demo.Lib;
using Xunit;

namespace DotnetConf2018Demo.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAdd()
        {
            Assert.Equal(Math.Add(10, 10), 20);
        }

        [Fact]
        public void TestSub()
        {
            Assert.Equal(Math.Sub(10, 10), 0);
        }

        [Fact]
        public void TestMul()
        {
            Assert.Equal(Math.Mul(10, 10), 100);
        }
    }
}

using System;
using Xunit;

namespace DevTooling.Demo.Tests
{
    public class SomeUnitTests
    {
        [Fact]
        public void TestThatTrueIsTrue()
        {
            Assert.True(true);
        }

        [Fact]
        public void SomeFailingTest()
        {
            var firstName = "John";
            var lastName = "Doe";
            var name = firstName + " " + lastName;

            Assert.Equal("Jon Doe", name);
        }
    }
}

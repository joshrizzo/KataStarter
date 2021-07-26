using System;
using Xunit;

namespace Kata.Tests
{
    public class UnitTest1
    {
        private Class1 target;

        [Fact]
        public void Test1()
        {
            // Arrange
            target = new Class1();

            // Act
            var result = target.Method1();

            // Assert
            Assert.True(result);
        }
    }
}

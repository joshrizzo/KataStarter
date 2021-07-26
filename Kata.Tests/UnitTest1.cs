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
            var number = 3;

            // Act
            var result = target.Method1(number);

            // Assert
            Assert.Equals("III", result);
        }
    }
}

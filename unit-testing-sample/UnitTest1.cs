using System;
using Xunit;

namespace unit_testing_sample
{
    public class UnitTest1
    {
        [Fact]
        public void AddIntegers()
        {
            Assert.Equal(9, new Calculator().add(4, 5));
        }
        [Fact]
        public void SubtractIntegers()
        {
            Assert.Equal(-1, new Calculator().subtract(4, 5));
        }
        [Fact]
        public void MultiplyIntegers()
        {
            Assert.Equal(20, new Calculator().multiply(4, 5));
        }
        [Fact]
        public void DivideIntegers()
        {
            Assert.Equal(3, new Calculator().divide(9, 3));
        }
        [Fact]
        public void DivideByZero()
        {
            Assert.Equal(0, new Calculator().divide(9, 0));
        }
    }
}

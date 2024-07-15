using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(0, 1, 1, 2)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(-1, -1, -1, -3)]
        [InlineData(-2, 1, 1, 0)]
        public void Add_Test(int num1, int num2, int num3, int expected)
        {
            var c = new Calculator();

            int actual = c.Add(num1, num2, num3);

            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(0, 1, -1)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, 1, -2)]
        [InlineData(2, 1, 1)]
        public void Subtract_Test(int num1, int num2, int expected)
        {
            var c = new Calculator();

            int actual = c.Subtract(num1, num2);

            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(3, 2, 6)]
        [InlineData(4, 3, 12)]
        [InlineData(5, 6, 30)]
        [InlineData(2, -1, -2)]
        public void Multiply_Test(int num1, int num2, int expected)
        {
            var c = new Calculator();

            int actual = c.Multiply(num1, num2);

            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(9, 3, 3)]
        [InlineData(12, 4, 3)]
        [InlineData(15, 5, 3)]
        [InlineData(45, 9, 5)]
        public void Divide_Test(int num1, int num2, int expected)
        {
            var c = new Calculator();

            int actual = c.Divide(num1, num2);

            Assert.Equal(expected, actual);
        }
    }
}

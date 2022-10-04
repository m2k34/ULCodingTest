using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULCodingTest.Objects;

namespace ULCodingTest.Tests
{
    public class CalculatorTests
    {

        [Fact]
        public void Test_Can_Evaluate_Addition_Expression()
        {
            var expression = new Expression(2, 3, "+");
            var result = Calculator.Evaluate(expression);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Test_Can_Evaluate_Multiplication_Expression()
        {
            var expression = new Expression(2, 3, "*");
            var result = Calculator.Evaluate(expression);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Test_Can_Evaluate_Subtraction_Expression()
        {
            var expression = new Expression(2, 3, "-");
            var result = Calculator.Evaluate(expression);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Test_Can_Evaluate_Division_Expression()
        {
            var expression = new Expression(3, 2, "/");
            var result = Calculator.Evaluate(expression);
            Assert.Equal((decimal)1.5, result);
        }

        [Fact]
        public void Test_Can_Add_Two_Operands()
        {
            List<string> testData = new List<string> { "1", "+", "2" };
            var result = Calculator.Calculate(testData);
            Assert.Equal(3, result);
        }
        [Fact]
        public void Test_Can_Subtract_Two_Operands()
        {
            List<string> testData = new List<string> { "1", "-", "2" };
            var result = Calculator.Calculate(testData);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Test_Can_Subtract_Three_Operands()
        {
            List<string> testData = new List<string> { "3", "-", "2", "-", "1" };
            var result = Calculator.Calculate(testData);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test_Can_Add_Three_Operands()
        {
            List<string> testData = new List<string> { "1", "+", "2", "+", "3" };
            var result = Calculator.Calculate(testData);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Test_Can_Multiply_Two_Operands()
        {
            List<string> testData = new List<string> { "1", "*", "2"};
            var result = Calculator.Calculate(testData);
            Assert.Equal(2, result);
        }
        [Fact]
        public void Test_Can_Multiply_Three_Operands()
        {
            List<string> testData = new List<string> { "1", "*", "2", "*", "3" };
            var result = Calculator.Calculate(testData);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Test_Can_Add_And_Subtract_Three_Operands()
        {
            List<string> testData = new List<string> { "1", "+", "2", "-", "3" };
            var result = Calculator.Calculate(testData);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test_Can_Divide_And_Multiply_Three_Operands_In_CorrectOrder()
        {
            List<string> testData = new List<string> { "1", "*", "6", "/", "3" };
            var result = Calculator.Calculate(testData);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test_Can_Divide_And_Add_Three_Operands_In_CorrectOrder()
        {
            List<string> testData = new List<string> { "1", "+", "6", "/", "3" };
            var result = Calculator.Calculate(testData);
            Assert.Equal(3, result);
        }

        [Fact]
        public void Test_Can_Calculate_More_Than_Five_Operands_In_CorrectOrder()
        {
            List<string> testData = new List<string> { "1", "+", "6", "/", "3", "/", "5", "*", "10" };
            var result = Calculator.Calculate(testData);
            Assert.Equal(5, result);
        }

    }
}

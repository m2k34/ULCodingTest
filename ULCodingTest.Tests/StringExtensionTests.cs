using ULCodingTest.ExtensionMethods;

namespace ULCodingTest.Tests
{
    public class StringExtensionTests
    {
        [Fact]
        public void Test_String_Contains_Letters()
        {
            var testData = "abc";
            var val = testData.Parse();
            Assert.Empty(val);
        }

        [Fact]
        public void Test_String_Contains_Punctuation()
        {
            var testData = ".,.}{";
            var val = testData.Parse();
            Assert.Empty(val);
        }

        [Fact]
        public void Test_String_Format_Incorrect()
        {
            var testData = "1+1++";
            var val1 = StringExtensions.SplitString(testData);
            var val2 = StringExtensions.IsCorrectFormat(val1);
            Assert.False(val2);

        }

        [Fact]
        public void Test_String_Format_Incorrect2()
        {
            var testData = "1++1";
            var val1 = StringExtensions.SplitString(testData);
            var val2 = StringExtensions.IsCorrectFormat(val1);
            Assert.False(val2);
        }

        [Fact]
        public void Test_String_Format_Incorrect3()
        {
            var testData = "++11";
            var val1 = StringExtensions.SplitString(testData);
            var val2 = StringExtensions.IsCorrectFormat(val1);
            Assert.False(val2);
        }

        [Fact]
        public void Test_String_Format_Correct()
        {
            var testData = "1+1";
            var val1 = StringExtensions.SplitString(testData);
            var val2 = StringExtensions.IsCorrectFormat(val1);
            Assert.True(val2);
        }

        [Fact]
        public void Test_String_Format_Correct2()
        {
            var testData = "1+1*6/4";
            var val1 = StringExtensions.SplitString(testData);
            var val2 = StringExtensions.IsCorrectFormat(val1);
            Assert.True(val2);
        }
    }
}
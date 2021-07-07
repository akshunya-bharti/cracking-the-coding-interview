using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringBuilder = CrackingTheCodingInterview.chapter1.StringBuilder;

namespace CrackingTheCodingInterviewTest.chapter1
{
    [TestClass]
    public class StringBuilderTest
    {
        [TestMethod]
        public void TestEmptyStringBuilder()
        {
            var stringBuilder = new StringBuilder();
            Assert.AreEqual("", stringBuilder.ToString());
        }

        [TestMethod]
        public void TestAppendSingleChar()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("a");
            Assert.AreEqual("a", stringBuilder.ToString());
        }

        [TestMethod]
        public void TestAppendStringLength2()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("ab");
            Assert.AreEqual("ab", stringBuilder.ToString());
        }

        [TestMethod]
        public void TestAppendStringLength4()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("abcd");
            Assert.AreEqual("abcd", stringBuilder.ToString());
        }

        [TestMethod]
        public void TestAppendStringLength6()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("abcdef");
            Assert.AreEqual("abcdef", stringBuilder.ToString());
        }

        [TestMethod]
        public void TestAppendStringLength15()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("abcdeabcdeabcde");
            Assert.AreEqual("abcdeabcdeabcde", stringBuilder.ToString());
        }

        [TestMethod]
        public void TestAppendStringLength1And1()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("a");
            stringBuilder.Append("a");
            Assert.AreEqual("aa", stringBuilder.ToString());
        }

        [TestMethod]
        public void TestAppendStringLength1And1And1()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("a");
            stringBuilder.Append("b");
            stringBuilder.Append("c");
            Assert.AreEqual("abc", stringBuilder.ToString());
        }

        [TestMethod]
        public void TestAppendStringLength4And6()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("abcd");
            stringBuilder.Append("abcdef");
            Assert.AreEqual("abcdabcdef", stringBuilder.ToString());
        }

        [TestMethod]
        public void TestAppendStringLength4And6And8And1()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("abcd");
            stringBuilder.Append("abcdef");
            stringBuilder.Append("abcdefgh");
            stringBuilder.Append("a");
            Assert.AreEqual("abcdabcdefabcdefgha", stringBuilder.ToString());
        }
    }
}

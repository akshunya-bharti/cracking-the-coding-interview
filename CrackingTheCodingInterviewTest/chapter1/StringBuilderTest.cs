using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using CrackingTheCodingInterview.chapter1;
using StringBuilder = CrackingTheCodingInterview.chapter1.StringBuilder;

namespace CrackingTheCodingInterviewTest.chapter1
{
    [TestClass]
    public class StringBuilderTest
    {
        [TestMethod]
        public void TestAddTwo()
        {
            var cl = new StringBuilder();
            var o = cl.AddTwo(3);
            Assert.AreEqual(5, o);
        }
    }
}

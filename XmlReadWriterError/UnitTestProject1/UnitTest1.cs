using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlDotNetSandardClass;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DotNetStandardClass failingClass = new DotNetStandardClass();
            failingClass.MethodThatFails();
        }
    }
}

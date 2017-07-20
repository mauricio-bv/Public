using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlDotNetSandardClass;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
         DotNetStandardClass failingClass = new DotNetStandardClass();

        [TestMethod]
        public void TestMethodThatFails()
        {
            // Put a Break in the next line. I will show more information about the issue.
            // The error is below:
            // System.IO.FileNotFoundException: 'Could not load file or assembly 'System.Xml.ReaderWriter, Version = 4.1.0.0, Culture = neutral, PublicKeyToken = b03f5f7f11d50a3a' or one of its dependencies. The system cannot find the file specified.'
            failingClass.MethodThatFails();
        }


        [TestMethod]
        public void TestMethodThatDoesNotFail()
        {
            failingClass.MethodDoesNotFail();
            Assert.IsTrue(true);
        }



    }
}

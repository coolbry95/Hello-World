using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HelloWorldApp.Tests
{
    [TestClass()]
    public class HelloWorldTests
    {
        [TestMethod()]
        public void HelloWorldTest()
        {
            try
            {
                HelloWorld app = new HelloWorld(null);
            } catch  (ArgumentException e)
            {
                return;
            }
            Assert.Fail();
        }

        [TestMethod()]
        public void ToStringTest()
        {
            HelloWorld app = new HelloWorld(Console.Out);
            string output = app.ToString();
            if (output == "Hello World!")
            {
                return;
            }
            Assert.Fail();
        }

        [TestMethod()]
        public void WriteTest()
        {
            try
            {
                HelloWorld app = new HelloWorld(Console.Out);
            }
            catch (IOException e)
            {
                Assert.Fail();
            }
            return;
        }
    }
}
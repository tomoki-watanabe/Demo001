using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Tests
{
    [TestClass()]
    public class SampleTests
    {
        [TestMethod()]
        public void DoSometingTest()
        {
            Assert.AreEqual(3, Sample.DoSometing(1, 2));
        }
    }
}
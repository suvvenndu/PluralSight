using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox;

namespace TestSandbox
{
    [TestClass]
    public class TestSandBox
    {
        [TestMethod]
        public void TestFoo()
        {

            Leakage leake = new Leakage();
            Console.WriteLine(leake.FormatPoint(new Point { X = 60, Y = 70 }));
    
        }
    }
}

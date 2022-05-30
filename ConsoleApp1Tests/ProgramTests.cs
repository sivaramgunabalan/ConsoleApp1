using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void BigNumberTest()
        {
            Program p = new Program();
            Assert.IsTrue(p.BigNumber(102));
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomSquares;

namespace TestStuff
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cell = new ScreenCell();
            cell.AddLowerLeftCorner();
            cell.AddVertical();
            Assert.AreEqual('├', cell.GetCharacter());
        }
    }
}

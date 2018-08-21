using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static KinhDichCommon.DiaChi;

namespace KinhDichCommon.Tests
{
    [TestClass]
    public class DiaChiTests
    {
        [TestMethod]
        public void TestHopXung()
        {
            Assert.AreEqual(Ti.Hop, Suu);
            Assert.AreEqual(Ti.Xung, Ngo);

            Assert.AreEqual(Suu.Hop, Ti);
            Assert.AreEqual(Suu.Xung, Mui);

            Assert.AreEqual(Dan.Hop, Hoi);
            Assert.AreEqual(Dan.Xung, Than);

            Assert.AreEqual(Mao.Hop, Tuat);
            Assert.AreEqual(Mao.Xung, Dau);

            Assert.AreEqual(Thin.Hop, Dau);
            Assert.AreEqual(Thin.Xung, Tuat);

            Assert.AreEqual(Ty.Hop, Than);
            Assert.AreEqual(Ty.Xung, Hoi);

            Assert.AreEqual(Ngo.Hop, Mui);
            Assert.AreEqual(Ngo.Xung, Ti);

            Assert.AreEqual(Mui.Hop, Ngo);
            Assert.AreEqual(Mui.Xung, Suu);

            Assert.AreEqual(Than.Hop, Ty);
            Assert.AreEqual(Than.Xung, Dan);

            Assert.AreEqual(Dau.Hop, Thin);
            Assert.AreEqual(Dau.Xung, Mao);

            Assert.AreEqual(Tuat.Hop, Mao);
            Assert.AreEqual(Tuat.Xung, Thin);

            Assert.AreEqual(Hoi.Hop, Dan);
            Assert.AreEqual(Hoi.Xung, Ty);
        }

    }
}

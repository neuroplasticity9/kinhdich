using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static KinhDichCommon.DiaChi;
using static KinhDichCommon.ThienCan;

namespace KinhDichCommon.Tests
{
    [TestClass]
    public class AmLichTests
    {
        [TestMethod]
        public void TestNamAm()
        {
            DateTime duongLich = new DateTime(1992, 1, 1);
            CanChi namAm = duongLich.GetNamAm();
            Assert.AreEqual(namAm.Can, Nham);
            Assert.AreEqual(namAm.Chi, Than);

            duongLich = new DateTime(1983, 1, 1);
            namAm = duongLich.GetNamAm();
            Assert.AreEqual(namAm.Can, Quy);
            Assert.AreEqual(namAm.Chi, Hoi);

            duongLich = new DateTime(1986, 1, 1);
            namAm = duongLich.GetNamAm();
            Assert.AreEqual(namAm.Can, Binh);
            Assert.AreEqual(namAm.Chi, Dan);
        }

    }
}

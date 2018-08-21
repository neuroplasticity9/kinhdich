using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static KinhDichCommon.DiaChi;
using static KinhDichCommon.NguHanh;

namespace KinhDichCommon.Tests
{
    [TestClass]
    public class HaoTests
    {
        [TestMethod]
        public void TestLucThanCuaHao()
        {
            var hao = new Hao { Chi = Hoi, HanhCuaQue = Kim };
            Assert.AreEqual(hao.LucThan, TuTon);

            hao = new Hao { Chi = Hoi, HanhCuaQue = Thuy };
            Assert.AreEqual(hao.LucThan, HuynhDe);

            hao = new Hao { Chi = Hoi, HanhCuaQue = Moc };
            Assert.AreEqual(hao.LucThan, PhuMau);

            hao = new Hao { Chi = Hoi, HanhCuaQue = Hoa };
            Assert.AreEqual(hao.LucThan, QuanQuy);

            hao = new Hao { Chi = Hoi, HanhCuaQue = Tho };
            Assert.AreEqual(hao.LucThan, TheTai);

        }

    }
}

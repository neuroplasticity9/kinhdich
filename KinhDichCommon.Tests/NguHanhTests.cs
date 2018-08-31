using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static KinhDichCommon.NguHanh;

namespace KinhDichCommon.Tests
{
    [TestClass]
    public class NguHanhTests
    {
        [TestMethod]
        public void TestNguHanh()
        {
            Assert.AreEqual(Kim.Sinh, Thuy);
            Assert.AreEqual(Kim.Khac, Moc);
            Assert.AreEqual(Kim.SinhBoi, Tho);
            Assert.AreEqual(Kim.KhacBoi, Hoa);

            Assert.AreEqual(Thuy.Sinh, Moc);
            Assert.AreEqual(Thuy.Khac, Hoa);
            Assert.AreEqual(Thuy.SinhBoi, Kim);
            Assert.AreEqual(Thuy.KhacBoi, Tho);

            Assert.AreEqual(Moc.Sinh, Hoa);
            Assert.AreEqual(Moc.Khac, Tho);
            Assert.AreEqual(Moc.SinhBoi, Thuy);
            Assert.AreEqual(Moc.KhacBoi, Kim);

            Assert.AreEqual(Hoa.Sinh, Tho);
            Assert.AreEqual(Hoa.Khac, Kim);
            Assert.AreEqual(Hoa.SinhBoi, Moc);
            Assert.AreEqual(Hoa.KhacBoi, Thuy);

            Assert.AreEqual(Tho.Sinh, Kim);
            Assert.AreEqual(Tho.Khac, Thuy);
            Assert.AreEqual(Tho.SinhBoi, Hoa);
            Assert.AreEqual(Tho.KhacBoi, Moc);
        }

        [TestMethod]
        public void TestLucThan()
        {
            Assert.AreEqual(QuanQuy.Sinh, PhuMau);
            Assert.AreEqual(QuanQuy.Khac, HuynhDe);
            Assert.AreEqual(QuanQuy.SinhBoi, TheTai);
            Assert.AreEqual(QuanQuy.KhacBoi, TuTon);

            Assert.AreEqual(PhuMau.Sinh, HuynhDe);
            Assert.AreEqual(PhuMau.Khac, TuTon);
            Assert.AreEqual(PhuMau.SinhBoi, QuanQuy);
            Assert.AreEqual(PhuMau.KhacBoi, TheTai);

            Assert.AreEqual(HuynhDe.Sinh, TuTon);
            Assert.AreEqual(HuynhDe.Khac, TheTai);
            Assert.AreEqual(HuynhDe.SinhBoi, PhuMau);
            Assert.AreEqual(HuynhDe.KhacBoi, QuanQuy);

            Assert.AreEqual(TuTon.Sinh, TheTai);
            Assert.AreEqual(TuTon.Khac, QuanQuy);
            Assert.AreEqual(TuTon.SinhBoi, HuynhDe);
            Assert.AreEqual(TuTon.KhacBoi, PhuMau);

            Assert.AreEqual(TheTai.Sinh, QuanQuy);
            Assert.AreEqual(TheTai.Khac, PhuMau);
            Assert.AreEqual(TheTai.SinhBoi, TuTon);
            Assert.AreEqual(TheTai.KhacBoi, HuynhDe);
        }

    }
}

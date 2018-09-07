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
            DateTime duongLich = new DateTime(1992, 7, 1);
            AmLich amLich = Calendar.ConvertSolar2Lunar(duongLich);
            Assert.AreEqual(amLich.NamAm.Can, Nham);
            Assert.AreEqual(amLich.NamAm.Chi, Than);

            duongLich = new DateTime(1983, 3, 13);
            amLich = Calendar.ConvertSolar2Lunar(duongLich);
            Assert.AreEqual(amLich.NamAm.Can, Quy);
            Assert.AreEqual(amLich.NamAm.Chi, Hoi);

            duongLich = new DateTime(1986, 4, 14);
            amLich = Calendar.ConvertSolar2Lunar(duongLich);
            Assert.AreEqual(amLich.NamAm.Can, Binh);
            Assert.AreEqual(amLich.NamAm.Chi, Dan);
        }

        [TestMethod]
        public void TestThangAm()
        {
            DateTime duongLich = new DateTime(2018, 8, 28);
            AmLich amLich = Calendar.ConvertSolar2Lunar(duongLich);
            Assert.AreEqual(amLich.ThangAm.Can, Canh);
            Assert.AreEqual(amLich.ThangAm.Chi, Than);

            duongLich = new DateTime(1983, 3, 13);
            amLich = Calendar.ConvertSolar2Lunar(duongLich);
            Assert.AreEqual(amLich.ThangAm.Can, Giap);
            Assert.AreEqual(amLich.ThangAm.Chi, Dan);
        }

        [TestMethod]
        public void TestNgayAm()
        {
            DateTime duongLich = new DateTime(2018, 8, 28);
            AmLich amLich = Calendar.ConvertSolar2Lunar(duongLich);
            Assert.AreEqual(amLich.NgayAm.Can, Nham);
            Assert.AreEqual(amLich.NgayAm.Chi, Thin);

            duongLich = new DateTime(1983, 3, 13);
            amLich = Calendar.ConvertSolar2Lunar(duongLich);
            Assert.AreEqual(amLich.NgayAm.Can, Canh);
            Assert.AreEqual(amLich.NgayAm.Chi, Ti);
        }

        [TestMethod]
        public void TestGioAm()
        {
            DateTime duongLich = new DateTime(2018, 8, 28);
            Can canGioTi = duongLich.ToAmLich().GetCanGioTi();
            Assert.AreEqual(canGioTi, Canh);

            duongLich = new DateTime(2018, 8, 29);
            canGioTi = duongLich.ToAmLich().GetCanGioTi();
            Assert.AreEqual(canGioTi, Nham);

            duongLich = new DateTime(2018, 8, 30);
            canGioTi = duongLich.ToAmLich().GetCanGioTi();
            Assert.AreEqual(canGioTi, Giap);

            duongLich = new DateTime(1983, 3, 13);
            canGioTi = duongLich.ToAmLich().GetCanGioTi();
            Assert.AreEqual(canGioTi, Binh);
        }

        [TestMethod]
        public void TestCanGioAm()
        {
            DateTime duongLich = new DateTime(2018, 8, 30);
            AmLich amLich = duongLich.ToAmLich();

            Can canGioTi = amLich.GetCanGioTi();

            Can can = amLich.GetCanCuaGio(Ti);
            Assert.AreEqual(canGioTi, can);

            can = amLich.GetCanCuaGio(Suu);
            Assert.AreEqual(can, At);

            can = amLich.GetCanCuaGio(Ngo);
            Assert.AreEqual(can, Canh);

            can = amLich.GetCanCuaGio(Dau);
            Assert.AreEqual(can, Quy);

            can = amLich.GetCanCuaGio(Hoi);
            Assert.AreEqual(can, At);
        }
        
        [TestMethod]
        public void TestDoiNgayDoGioTi()
        {
            DateTime duongLichGoc = new DateTime(2018, 8, 30);
            AmLich amLichGoc = duongLichGoc.ToAmLich();

            DateTime duongLichCuoiNgay = duongLichGoc.AddHours(23);
            AmLich amLichPlus1 = duongLichCuoiNgay.ToAmLich();

            Assert.AreEqual(amLichGoc.NgayAm.Can, Nham);
            Assert.AreEqual(amLichGoc.NgayAm.Chi, Thin);

            // Do đã qua giờ Tí nên phải ra âm lịch của ngày kế tiếp.
            Assert.AreEqual(amLichPlus1.NgayAm.Can, Quy);
            Assert.AreEqual(amLichPlus1.NgayAm.Chi, Ty);
        }
    }
}

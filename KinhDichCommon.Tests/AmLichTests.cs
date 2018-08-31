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
            CanChi namAm = amLich.GetCanChiNam();
            Assert.AreEqual(namAm.Can, Nham);
            Assert.AreEqual(namAm.Chi, Than);

            duongLich = new DateTime(1983, 3, 13);
            amLich = Calendar.ConvertSolar2Lunar(duongLich);
            namAm = amLich.GetCanChiNam();
            Assert.AreEqual(namAm.Can, Quy);
            Assert.AreEqual(namAm.Chi, Hoi);

            duongLich = new DateTime(1986, 4, 14);
            amLich = Calendar.ConvertSolar2Lunar(duongLich);
            namAm = amLich.GetCanChiNam();
            Assert.AreEqual(namAm.Can, Binh);
            Assert.AreEqual(namAm.Chi, Dan);
        }

        [TestMethod]
        public void TestThangAm()
        {
            DateTime duongLich = new DateTime(2018, 8, 28);
            AmLich amLich = Calendar.ConvertSolar2Lunar(duongLich);
            CanChi thangAm = amLich.GetCanChiThang();
            Assert.AreEqual(thangAm.Can, Canh);
            Assert.AreEqual(thangAm.Chi, Than);

            duongLich = new DateTime(1983, 3, 13);
            amLich = Calendar.ConvertSolar2Lunar(duongLich);
            thangAm = amLich.GetCanChiThang();
            Assert.AreEqual(thangAm.Can, Giap);
            Assert.AreEqual(thangAm.Chi, Dan);
        }

        [TestMethod]
        public void TestNgayAm()
        {
            DateTime duongLich = new DateTime(2018, 8, 28);
            AmLich amLich = Calendar.ConvertSolar2Lunar(duongLich);
            CanChi ngayAm = amLich.GetCanChiNgay();
            Assert.AreEqual(ngayAm.Can, Nham);
            Assert.AreEqual(ngayAm.Chi, Thin);

            duongLich = new DateTime(1983, 3, 13);
            amLich = Calendar.ConvertSolar2Lunar(duongLich);
            ngayAm = amLich.GetCanChiNgay();
            Assert.AreEqual(ngayAm.Can, Canh);
            Assert.AreEqual(ngayAm.Chi, Ti);
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
    }
}

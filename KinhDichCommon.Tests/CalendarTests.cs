using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KinhDichCommon.Tests
{
    [TestClass]
    public class CalendarTests
    {
        [TestMethod]
        public void TestSolarLunar()
        {
            DateTime duongLich = new DateTime(1983, 3, 13);
            AmLich amlich = Calendar.ConvertSolar2Lunar(duongLich.Year, duongLich.Month, duongLich.Day, 7);
            Assert.AreEqual(amlich.LunarMonth, 1);
            Assert.AreEqual(amlich.LunarDay, 29);

            duongLich = new DateTime(2016, 8, 16);
            amlich = Calendar.ConvertSolar2Lunar(duongLich, 7);
            Assert.AreEqual(amlich.LunarMonth, 7);
            Assert.AreEqual(amlich.LunarDay, 14);
        }

    }
}

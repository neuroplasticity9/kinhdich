using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static KinhDichCommon.DiaChi;

namespace KinhDichCommon.Tests
{
    [TestClass]
    public class HoaGiapTests
    {
        [TestMethod]
        public void TestLamKhong()
        {
            // Tuần Giáp Tí lâm không ở Tuất và Hợi.
            Assert.AreEqual(HoaGiap.All[0].Khong1, Tuat);
            Assert.AreEqual(HoaGiap.All[0].Khong2, Hoi);

            // Tuần Giáp Tuất lâm không ở Thân và Dậu.
            Assert.AreEqual(HoaGiap.All[1].Khong1, Than);
            Assert.AreEqual(HoaGiap.All[1].Khong2, Dau);

            // Tuần Giáp Thân lâm không ở Ngọ và Mùi.
            Assert.AreEqual(HoaGiap.All[2].Khong1, Ngo);
            Assert.AreEqual(HoaGiap.All[2].Khong2, Mui);

            // Tuần Giáp Ngọ lâm không ở Thìn và Tỵ.
            Assert.AreEqual(HoaGiap.All[3].Khong1, Thin);
            Assert.AreEqual(HoaGiap.All[3].Khong2, Ty);

            // Tuần Giáp Thìn lâm không ở Dần và Mão.
            Assert.AreEqual(HoaGiap.All[4].Khong1, Dan);
            Assert.AreEqual(HoaGiap.All[4].Khong2, Mao);

            // Tuần Giáp Dần lâm không ở Tí và Sửu.
            Assert.AreEqual(HoaGiap.All[5].Khong1, Ti);
            Assert.AreEqual(HoaGiap.All[5].Khong2, Suu);
        }

    }
}

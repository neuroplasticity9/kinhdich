using Microsoft.VisualStudio.TestTools.UnitTesting;
using static KinhDichCommon.DiaChi;

namespace KinhDichCommon.Tests
{
    [TestClass]
    public class TanThoaiTests
    {
        [TestMethod]
        public void TestTanThoai()
        {
            Assert.AreEqual(Hoi.Tan, Ti);
            Assert.AreEqual(Hoi.Thoai, null);
            Assert.AreEqual(Ti.Tan, null);
            Assert.AreEqual(Ti.Thoai, Hoi);

            Assert.AreEqual(Dan.Tan, Mao);
            Assert.AreEqual(Dan.Thoai, null);
            Assert.AreEqual(Mao.Tan, null);
            Assert.AreEqual(Mao.Thoai, Dan);

            Assert.AreEqual(Ty.Tan, Ngo);
            Assert.AreEqual(Ty.Thoai, null);
            Assert.AreEqual(Ngo.Tan, null);
            Assert.AreEqual(Ngo.Thoai, Ty);

            Assert.AreEqual(Than.Tan, Dau);
            Assert.AreEqual(Than.Thoai, null);
            Assert.AreEqual(Dau.Tan, null);
            Assert.AreEqual(Dau.Thoai, Than);

            Assert.AreEqual(Suu.Tan, Thin);
            Assert.AreEqual(Suu.Thoai, Tuat);
            Assert.AreEqual(Thin.Tan, Mui);
            Assert.AreEqual(Thin.Thoai, Suu);
            Assert.AreEqual(Mui.Tan, Tuat);
            Assert.AreEqual(Mui.Thoai, Thin);
            Assert.AreEqual(Tuat.Tan, Suu);
            Assert.AreEqual(Tuat.Thoai, Mui);

        }

    }
}

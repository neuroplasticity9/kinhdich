using Microsoft.VisualStudio.TestTools.UnitTesting;
using static KinhDichCommon.ThienCan;
using static KinhDichCommon.LucThu;

namespace KinhDichCommon.Tests
{
    [TestClass]
    public class LucThanTests
    {
        [TestMethod]
        public void TestLucThan()
        {
            Assert.AreEqual(GetLucThu(Giap)[0], ThanhLong);
            Assert.AreEqual(GetLucThu(At)[0], ThanhLong);

            Assert.AreEqual(GetLucThu(Binh)[0], ChuTuoc);
            Assert.AreEqual(GetLucThu(Dinh)[0], ChuTuoc);

            Assert.AreEqual(GetLucThu(Mau)[0], CauTran);

            Assert.AreEqual(GetLucThu(Ky)[0], PhiXa);

            Assert.AreEqual(GetLucThu(Canh)[0], BachHo);
            Assert.AreEqual(GetLucThu(Tan)[0], BachHo);

            Assert.AreEqual(GetLucThu(Nham)[0], HuyenVu);
            Assert.AreEqual(GetLucThu(Quy)[0], HuyenVu);
        }

    }
}

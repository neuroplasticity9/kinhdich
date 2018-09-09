using Microsoft.VisualStudio.TestTools.UnitTesting;
using static KinhDichCommon.ThienCan;
using static KinhDichCommon.LucThan;

namespace KinhDichCommon.Tests
{
    [TestClass]
    public class LucThanTests
    {
        [TestMethod]
        public void TestLucThan()
        {
            Assert.AreEqual(GetLucThan(Giap)[0], ThanhLong);
            Assert.AreEqual(GetLucThan(At)[0], ThanhLong);

            Assert.AreEqual(GetLucThan(Binh)[0], ChuTuoc);
            Assert.AreEqual(GetLucThan(Dinh)[0], ChuTuoc);

            Assert.AreEqual(GetLucThan(Mau)[0], CauTran);

            Assert.AreEqual(GetLucThan(Ky)[0], PhiXa);

            Assert.AreEqual(GetLucThan(Canh)[0], BachHo);
            Assert.AreEqual(GetLucThan(Tan)[0], BachHo);

            Assert.AreEqual(GetLucThan(Nham)[0], HuyenVu);
            Assert.AreEqual(GetLucThan(Quy)[0], HuyenVu);
        }

    }
}

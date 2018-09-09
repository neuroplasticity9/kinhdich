using Microsoft.VisualStudio.TestTools.UnitTesting;
using static KinhDichCommon.Que;

namespace KinhDichCommon.Tests
{
    [TestClass]
    public class QueThuanTests
    {
        [TestMethod]
        public void TestCacQueThuan()
        {
            Assert.AreEqual(QueKien.NoiQuai, BatQuai.Kien);
            Assert.AreEqual(QueKien.NgoaiQuai, BatQuai.Kien);

            Assert.AreEqual(QueDoai.NoiQuai, BatQuai.Doai);
            Assert.AreEqual(QueDoai.NgoaiQuai, BatQuai.Doai);

            Assert.AreEqual(QueLy.NoiQuai, BatQuai.Ly);
            Assert.AreEqual(QueLy.NgoaiQuai, BatQuai.Ly);

            Assert.AreEqual(QueChan.NoiQuai, BatQuai.Chan);
            Assert.AreEqual(QueChan.NgoaiQuai, BatQuai.Chan);

            Assert.AreEqual(QueTon.NoiQuai, BatQuai.Ton);
            Assert.AreEqual(QueTon.NgoaiQuai, BatQuai.Ton);

            Assert.AreEqual(QueKham.NoiQuai, BatQuai.Kham);
            Assert.AreEqual(QueKham.NgoaiQuai, BatQuai.Kham);

            Assert.AreEqual(QueCan.NoiQuai, BatQuai.Can);
            Assert.AreEqual(QueCan.NgoaiQuai, BatQuai.Can);

            Assert.AreEqual(QueKhon.NoiQuai, BatQuai.Khon);
            Assert.AreEqual(QueKhon.NgoaiQuai, BatQuai.Khon);
        }

    }
}

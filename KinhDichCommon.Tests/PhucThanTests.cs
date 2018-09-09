using Microsoft.VisualStudio.TestTools.UnitTesting;
using static KinhDichCommon.NguHanh;
using static KinhDichCommon.BatQuai;

namespace KinhDichCommon.Tests
{
    [TestClass]
    public class PhucThanTests
    {
        [TestMethod]
        public void TestPhucThanCuaQue()
        {
            // Son Hoa Bi
            var que = Que.GetQue(BatQuai.Can, Ly);
            Assert.AreEqual(que.HaoPhuc.LucThan, TuTon);

            // Dia Loi Phuc
            que = Que.GetQue(BatQuai.Khon, Chan);
            Assert.AreEqual(que.HaoPhuc.LucThan, PhuMau);
        }

    }
}

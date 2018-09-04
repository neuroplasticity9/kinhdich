using Microsoft.VisualStudio.TestTools.UnitTesting;
using static KinhDichCommon.BatQuai;
using static KinhDichCommon.QueDich;

namespace KinhDichCommon.Tests
{
    [TestClass]
    public class GetQueTests
    {
        [TestMethod]
        public void GetQue()
        {
            // Can Vi Thien
            Que que = QueDich.GetQue(true, true, true, true, true, true);
            Assert.AreEqual(que, QueKien);

            // Khon Vi Dia
            que = QueDich.GetQue(Khon);
            Assert.AreEqual(que, QueKhon);

            // Dia Thien Thai
            que = QueDich.GetQue(Khon, Kien);
            Assert.AreEqual(que.NgoaiQuai, Khon);
            Assert.AreEqual(que.NoiQuai, Kien);
        }
        
        [TestMethod]
        public void GetQueBienTest()
        {
            // Dia Thien Thai
            Que queThai = QueDich.GetQue(Khon, Kien);

            // Thuy Thien Nhu
            var queNhu = QueDich.GetQue(Kham, Kien);

            // Động hào 5 của quẻ Thái được quẻ Nhu.
            var queBien = QueDich.GetQueBien(queThai, dongHao5: true);
            
            Assert.AreEqual(queNhu.NoiQuai, queBien.NoiQuai);
            Assert.AreEqual(queNhu.NgoaiQuai, queBien.NgoaiQuai);
        }

    }
}

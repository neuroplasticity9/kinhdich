using Microsoft.VisualStudio.TestTools.UnitTesting;
using static KinhDichCommon.BatQuai;
using static KinhDichCommon.Que;

namespace KinhDichCommon.Tests
{
    [TestClass]
    public class GetQueTests
    {
        [TestMethod]
        public void GetQue()
        {
            // Can Vi Thien
            Que que = Que.GetQue(true, true, true, true, true, true);
            Assert.AreEqual(que, QueKien);

            // Khon Vi Dia
            que = Que.GetQue(Khon);
            Assert.AreEqual(que, QueKhon);

            // Dia Thien Thai
            que = Que.GetQue(Khon, Kien);
            Assert.AreEqual(que.NgoaiQuai, Khon);
            Assert.AreEqual(que.NoiQuai, Kien);
        }
        
        [TestMethod]
        public void GetQueBienTest()
        {
            // Dia Thien Thai
            Que queThai = Que.GetQue(Khon, Kien);

            // Thuy Thien Nhu
            var queNhu = Que.GetQue(Kham, Kien);

            // Động hào 5 của quẻ Thái được quẻ Nhu.
            var queBien = Que.GetQueBien(queThai, dongHao5: true);
            
            Assert.AreEqual(queNhu.NoiQuai, queBien.NoiQuai);
            Assert.AreEqual(queNhu.NgoaiQuai, queBien.NgoaiQuai);
        }

    }
}

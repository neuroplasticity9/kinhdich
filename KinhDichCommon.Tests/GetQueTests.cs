using Microsoft.VisualStudio.TestTools.UnitTesting;
using static KinhDichCommon.BatQuai;
using static KinhDichCommon.QueDich;
using static KinhDichCommon.ThienCan;
using static KinhDichCommon.DiaChi;

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

            var a = que.GetLucThan();

            // Khon Vi Dia
            que = QueDich.GetQue(Khon, Khon);
            Assert.AreEqual(que, QueKhon);

        }

        [TestMethod]
        public void GetQueDiaThienThai()
        {
            var nhatThan = new CanChi { Can = Canh, Chi = Ti };
            var nguyetKien = new CanChi { Can = Giap, Chi = Dan };

            // Dia Thien Thai
            Que que = QueDich.GetQue(Khon, Kien);

            var aasdfds = que.GetLucThan(nhatThan, nguyetKien);

            // Thuy Thien Nhu
            que = QueDich.GetQue(Kham, Kien);
            var csdffd = que.GetLucThan(nhatThan, nguyetKien);
        }


        [TestMethod]
        public void GetQueTest()
        {
            var nhatThan = new CanChi { Can = Ky, Chi = Suu };
            var nguyetKien = new CanChi { Can = Quy, Chi = Hoi };

            // Dia Phong Thang
            var que = QueDich.GetQue(Doai, Doai);
            var csdffdfaa = que.GetLucThan(nhatThan, nguyetKien);
        }
    }
}

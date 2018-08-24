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

            // Khon Vi Dia
            que = QueDich.GetQue(Khon);
            Assert.AreEqual(que, QueKhon);

            // Dia Thien Thai
            que = QueDich.GetQue(Khon, Kien);
            Assert.AreEqual(que.NgoaiQuai, Khon);
            Assert.AreEqual(que.NoiQuai, Kien);
        }

        [TestMethod]
        public void GetQueDiaThienThai()
        {
            var nhatThan = new CanChi { Can = Canh, Chi = Ti };
            var nguyetKien = new CanChi { Can = Giap, Chi = Dan };

            // Dia Thien Thai
            Que queThai = QueDich.GetQue(Khon, Kien);

            var aasdfds = queThai.GetLucThan(nhatThan, nguyetKien);

            // Thuy Thien Nhu
            var queNhu = QueDich.GetQue(Kham, Kien);
            var csdffd = queNhu.GetLucThan(nhatThan, nguyetKien);


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

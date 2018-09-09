using Microsoft.VisualStudio.TestTools.UnitTesting;
using static KinhDichCommon.BatQuai;
using static KinhDichCommon.NguHanh;

namespace KinhDichCommon.Tests
{
    [TestClass]
    public class QueBienTests
    {
        [TestMethod]
        public void TestLucThanCuaQueThuanKien()
        {
            // Can Vi Thien
            Que que = Que.TamQueThuocKien[0];
            Assert.AreEqual(que.Hao6.LucThan, PhuMau);
            Assert.AreEqual(que.Hao5.LucThan, HuynhDe);
            Assert.AreEqual(que.Hao4.LucThan, QuanQuy);
            Assert.AreEqual(que.Hao3.LucThan, PhuMau);
            Assert.AreEqual(que.Hao2.LucThan, TheTai);
            Assert.AreEqual(que.Hao1.LucThan, TuTon);

            Assert.AreEqual(que.NgoaiQuai, Kien);
            Assert.AreEqual(que.NoiQuai, Kien);
        }

        [TestMethod]
        public void TestLucThanCuaQueKienBien1()
        {
            // Thiên Phong Cấu
            Que que = Que.TamQueThuocKien[1];
            Assert.AreEqual(que.Hao6.LucThan, PhuMau);
            Assert.AreEqual(que.Hao5.LucThan, HuynhDe);
            Assert.AreEqual(que.Hao4.LucThan, QuanQuy);
            Assert.AreEqual(que.Hao3.LucThan, HuynhDe);
            Assert.AreEqual(que.Hao2.LucThan, TuTon);
            Assert.AreEqual(que.Hao1.LucThan, PhuMau);

            Assert.AreEqual(que.NgoaiQuai, Kien);
            Assert.AreEqual(que.NoiQuai, Ton);
        }

        [TestMethod]
        public void TestLucThanCuaQueKienBien2()
        {
            // Thiên Sơn Độn
            Que que = Que.TamQueThuocKien[2];
            Assert.AreEqual(que.Hao6.LucThan, PhuMau);
            Assert.AreEqual(que.Hao5.LucThan, HuynhDe);
            Assert.AreEqual(que.Hao4.LucThan, QuanQuy);
            Assert.AreEqual(que.Hao3.LucThan, HuynhDe);
            Assert.AreEqual(que.Hao2.LucThan, QuanQuy);
            Assert.AreEqual(que.Hao1.LucThan, PhuMau);

            Assert.AreEqual(que.NgoaiQuai, Kien);
            Assert.AreEqual(que.NoiQuai, BatQuai.Can);
        }

        [TestMethod]
        public void TestLucThanCuaQueKienBien3()
        {
            // Thiên Địa Phủ
            Que que = Que.TamQueThuocKien[3];
            Assert.AreEqual(que.Hao6.LucThan, PhuMau);
            Assert.AreEqual(que.Hao5.LucThan, HuynhDe);
            Assert.AreEqual(que.Hao4.LucThan, QuanQuy);
            Assert.AreEqual(que.Hao3.LucThan, TheTai);
            Assert.AreEqual(que.Hao2.LucThan, QuanQuy);
            Assert.AreEqual(que.Hao1.LucThan, PhuMau);

            Assert.AreEqual(que.NgoaiQuai, Kien);
            Assert.AreEqual(que.NoiQuai, BatQuai.Khon);
        }

        [TestMethod]
        public void TestLucThanCuaQueKienBien4()
        {
            // Phong Địa Quan
            Que que = Que.TamQueThuocKien[4];
            Assert.AreEqual(que.Hao6.LucThan, TheTai);
            Assert.AreEqual(que.Hao5.LucThan, QuanQuy);
            Assert.AreEqual(que.Hao4.LucThan, PhuMau);
            Assert.AreEqual(que.Hao3.LucThan, TheTai);
            Assert.AreEqual(que.Hao2.LucThan, QuanQuy);
            Assert.AreEqual(que.Hao1.LucThan, PhuMau);

            Assert.AreEqual(que.NgoaiQuai, Ton);
            Assert.AreEqual(que.NoiQuai, BatQuai.Khon);
        }

        [TestMethod]
        public void TestLucThanCuaQueKienBien5()
        {
            // Sơn Địa Bốc
            Que que = Que.TamQueThuocKien[5];
            Assert.AreEqual(que.Hao6.LucThan, TheTai);
            Assert.AreEqual(que.Hao5.LucThan, TuTon);
            Assert.AreEqual(que.Hao4.LucThan, PhuMau);
            Assert.AreEqual(que.Hao3.LucThan, TheTai);
            Assert.AreEqual(que.Hao2.LucThan, QuanQuy);
            Assert.AreEqual(que.Hao1.LucThan, PhuMau);

            Assert.AreEqual(que.NgoaiQuai, BatQuai.Can);
            Assert.AreEqual(que.NoiQuai, BatQuai.Khon);
        }

        [TestMethod]
        public void TestLucThanCuaQueKienBien6()
        {
            // Hỏa Địa Tấn
            Que que = Que.TamQueThuocKien[6];
            Assert.AreEqual(que.Hao6.LucThan, QuanQuy);
            Assert.AreEqual(que.Hao5.LucThan, PhuMau);
            Assert.AreEqual(que.Hao4.LucThan, HuynhDe);
            Assert.AreEqual(que.Hao3.LucThan, TheTai);
            Assert.AreEqual(que.Hao2.LucThan, QuanQuy);
            Assert.AreEqual(que.Hao1.LucThan, PhuMau);

            Assert.AreEqual(que.NgoaiQuai, BatQuai.Ly);
            Assert.AreEqual(que.NoiQuai, BatQuai.Khon);
        }

        [TestMethod]
        public void TestLucThanCuaQueKienBien7()
        {
            // Hỏa Thiên Đại Hữu
            Que que = Que.TamQueThuocKien[7];
            Assert.AreEqual(que.Hao6.LucThan, QuanQuy);
            Assert.AreEqual(que.Hao5.LucThan, PhuMau);
            Assert.AreEqual(que.Hao4.LucThan, HuynhDe);
            Assert.AreEqual(que.Hao3.LucThan, PhuMau);
            Assert.AreEqual(que.Hao2.LucThan, TheTai);
            Assert.AreEqual(que.Hao1.LucThan, TuTon);

            Assert.AreEqual(que.NgoaiQuai, BatQuai.Ly);
            Assert.AreEqual(que.NoiQuai, BatQuai.Kien);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using static KinhDichCommon.VongTruongSinh;
using static KinhDichCommon.DiaChi;
using static KinhDichCommon.NguHanh;

namespace KinhDichCommon.Tests
{
    [TestClass]
    public class VongTruongSinhTests
    {
        [TestMethod]
        public void TestVongTruongSinhNguHanh()
        {
            Assert.AreEqual(MocTruongSinh.DiaChi[0], Hoi); // Mộc trường sinh ở Hợi âm Thủy
            Assert.AreEqual(MocTruongSinh.DiaChi[11], Tuat); // Mộc dưỡng ở Tuất dương Thổ

            Assert.AreEqual(HoaTruongSinh.DiaChi[0], Dan); // Hỏa trường sinh ở Dần âm Kim
            Assert.AreEqual(HoaTruongSinh.DiaChi[11], Suu); // Hỏa dưỡng ở Sửu âm Thổ
            Assert.AreEqual(ThoTruongSinh.DiaChi[0], Dan); // Thổ trường sinh ở Dần âm Kim
            Assert.AreEqual(ThoTruongSinh.DiaChi[11], Suu); // Thổ dưỡng ở Sửu âm Thổ

            Assert.AreEqual(KimTruongSinh.DiaChi[0], Ty); // Kim trường sinh ở Tỵ âm Hỏa
            Assert.AreEqual(KimTruongSinh.DiaChi[11], Thin); // Kim dưỡng ở Thìn dương Thổ

            Assert.AreEqual(ThuyTruongSinh.DiaChi[0], Than); // Thủy trường sinh ở Thân dương Kim
            Assert.AreEqual(ThuyTruongSinh.DiaChi[11], Mui); // Thủy dưỡng ở Mùi âm Thổ
        }

        [TestMethod]
        public void TestGetThoiKi()
        {
            // Mùa xuân, vượng ở Mão.
            var thoiKi = GetThoiKi(Moc, Mao);
            Assert.AreEqual(thoiKi, DeVuong);

            // Mùa hạ, vượng ở Ngọ.
            thoiKi = GetThoiKi(Hoa, Ngo);
            Assert.AreEqual(thoiKi, DeVuong);
        }

        [TestMethod]
        public void TestMo()
        {
            // Hành Kim, trường sinh ở Tỵ, mộ ở Sửu.
            Assert.IsTrue(IsMo(Kim, Suu));

            // Hành Thủy, trường sinh ở Thân, mộ ở Thìn.
            Assert.IsTrue(IsMo(Thuy, Thin));

            // Hành Mộc, trường sinh ở Hợi, mộ ở Mùi.
            Assert.IsTrue(IsMo(Moc, Mui));

            // Hành Hỏa, trường sinh ở Dần, mộ ở Tuất.
            Assert.IsTrue(IsMo(Hoa, Tuat));

            // Hành Thổ
            // Tăng san bốc dịch: giống hành Thủy, nghĩa là Thìn là mộ của Thủy và Thổ.
            // Thiệu Vỹ Hoa: giống hành Hỏa, nghĩa là Tuất là mộ của Hỏa và Thổ.
            Assert.IsTrue(IsMo(Tho, Tuat));
        }
    }
}

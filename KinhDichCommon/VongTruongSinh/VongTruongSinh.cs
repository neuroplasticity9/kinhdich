using System.Collections.Generic;
using static KinhDichCommon.NguHanh;
using static KinhDichCommon.DiaChi;
using System.Diagnostics;

namespace KinhDichCommon
{
    /// <summary>
    /// Vòng trường sinh.
    /// </summary>
    [DebuggerDisplay("{Name,nq}")]
    public class VongTruongSinh : BaseItem
    {
        public static readonly VongTruongSinh TruongSinh = new VongTruongSinh { Id = 1, Name = "Trường Sinh", NameChinese = "", Desc = "Sinh ra và bắt đầu cuộc sống. Thể hiện nếp sống và phát triển mọi mặt của con người." };
        public static readonly VongTruongSinh MocDuc = new VongTruongSinh { Id = 2, Name = "Mộc Dục", NameChinese = "", Desc = "Con người đã thích nghi với môi trường xung quanh, tâm sinh lý đã hình thành. Tượng trưng như được tắm gội." };
        public static readonly VongTruongSinh QuanDoi = new VongTruongSinh { Id = 3, Name = "Quan Đới", NameChinese = "", Desc = "Bước vào ngưỡng của của sự trưởng thành. Con người có đủ khả năng để lập nghiệp." };
        public static readonly VongTruongSinh LamQuan = new VongTruongSinh { Id = 4, Name = "Lâm Quan", NameChinese = "", Desc = "Con người đã chủ động tự lập sự nghiệp và thành đạt trong cuộc sống mang tính tự hào, kiêu hãnh." };
        public static readonly VongTruongSinh DeVuong = new VongTruongSinh { Id = 5, Name = "Đế Vượng", NameChinese = "", Desc = "Giai đoạn tốt đẹp, thành công nhất trong cuộc đời. Song dự báo đã ở đỉnh điểm, chuẩn bị cho sự suy giảm." };
        public static readonly VongTruongSinh Suy = new VongTruongSinh { Id = 6, Name = "Suy", NameChinese = "", Desc = "Giai đoạn bắt đầu suy giảm mọi mặt, biểu hiện sự trì trệ, bảo thủ, mất ý chí chiến đấu." };
        public static readonly VongTruongSinh Benh = new VongTruongSinh { Id = 7, Name = "Bệnh", NameChinese = "", Desc = "Sức khoẻ kém dần, sinh bệnh tật đau yếu, biểu thị sự cầu an. Thâm tâm tiều tuỵ, mất ý chí chiến đấu." };
        public static readonly VongTruongSinh Tu = new VongTruongSinh { Id = 8, Name = "Tử", NameChinese = "", Desc = "Coi như chết, biểu thị sự đình đốn, bế tắc, không còn khả năng quyết đoán." };
        public static readonly VongTruongSinh Mo = new VongTruongSinh { Id = 9, Name = "Mộ", NameChinese = "", Desc = "Đã chết được chôn thành mộ. Biểu thị sự thu tàng, tính thích thu nhận mọi thứ. Đặc trưng cho sự kín đáo, kiệt sỉ." };
        public static readonly VongTruongSinh Tuyet = new VongTruongSinh { Id = 10, Name = "Tuyệt", NameChinese = "", Desc = "Người đã chết mục rữa hết, chỉ còn linh hồn chờ sang kiếp khác. Biểu thị bóng tối mịt mùng, không có một tia sáng. Tượng trưng cho sự tuyệt vọng, hành động nông nổi không có chiều sâu." };
        public static readonly VongTruongSinh Thai = new VongTruongSinh { Id = 11, Name = "Thai", NameChinese = "", Desc = "Linh hồn của người đã chết lâu, thu khí thành thai trở thành một sinh mệnh mới. Biểu thị một ngày mới bắt đầu, tượng trưng cho sức sống hy vọng và tiến triển." };
        public static readonly VongTruongSinh Duong = new VongTruongSinh { Id = 12, Name = "Dưỡng", NameChinese = "", Desc = "Thụ thai được nuôi dưỡng trong bụng mẹ, chờ ngày sinh nở. Đại biểu cho sự phát triển sáng tạo và ý chí độc lập. " };

        // Id order and adding order must be the same.
        public static List<VongTruongSinh> All = new List<VongTruongSinh> { TruongSinh, MocDuc, QuanDoi, LamQuan, DeVuong, Suy, Benh, Tu, Mo, Tuyet, Thai, Duong };

        public static readonly TruongSinhNguHanh MocTruongSinh = new TruongSinhNguHanh(Moc, Hoi); // Xuân, Mộc trường sinh ở Hợi
        public static readonly TruongSinhNguHanh HoaTruongSinh = new TruongSinhNguHanh(Hoa, Dan); // Hạ, Hỏa trường sinh ở Dần
        public static readonly TruongSinhNguHanh KimTruongSinh = new TruongSinhNguHanh(Kim, Ty); // Thu, Kim trường sinh ở Tỵ
        public static readonly TruongSinhNguHanh ThuyTruongSinh = new TruongSinhNguHanh(Thuy, Than); // Đông, Thủy trường sinh ở Thân
        public static readonly TruongSinhNguHanh ThoTruongSinh = new TruongSinhNguHanh(Tho, Than); // Thổ giống Thủy, trường sinh ở Thân

        public static readonly List<TruongSinhNguHanh> TruongSinhList = new List<TruongSinhNguHanh> { MocTruongSinh, HoaTruongSinh, ThoTruongSinh, KimTruongSinh, ThuyTruongSinh };

        /// <summary>
        /// Từ ngũ hành của nguyệt kiến kiểm tra xem địa chi thuộc thời kì nào của vòng trường sinh.
        /// </summary>
        /// <param name="hanh">ngũ hành của tháng</param>
        /// <param name="chi">địa chi của hào</param>
        /// <returns></returns>
        public static VongTruongSinh GetThoiKi(NguHanh hanh, DiaChi chi)
        {
            foreach (var truongSinh in TruongSinhList)
            {
                if (hanh == truongSinh.NguHanh)
                {
                    for (int i = 0; i < truongSinh.DiaChi.Count; i++)
                    {
                        if (chi == truongSinh.DiaChi[i])
                        {
                            return All[i];
                        }
                    }
                }
            }

            throw new System.Exception("Wrong code in VongTruongSinh.");
        }

        /// <summary>
        /// Từ hành của hào, kiểm tra xem nhật thìn hay nguyệt kiến có bị mộ.
        /// Giai đoạn mộ sẽ rơi vào thìn tuất sửu mùi.
        /// </summary>
        /// <param name="hanh"></param>
        /// <param name="chi"></param>
        /// <returns></returns>
        public static bool IsMo(NguHanh hanh, DiaChi chi)
        {
            if (hanh == Tho)
            {
                // Hành thổ không thể có mộ ở Thìn giống Thủy, 
                // vì không lẽ Thìn thổ (nhật kiến, nguyệt kiến) cũng mộ ở Thìn?
                return false;
            }

            return GetThoiKi(hanh, chi) == Mo;
        }

    }
}

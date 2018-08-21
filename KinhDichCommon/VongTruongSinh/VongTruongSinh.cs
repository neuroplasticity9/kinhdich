using System.Collections.Generic;
using static KinhDichCommon.NguHanh;
using static KinhDichCommon.DiaChi;

namespace KinhDichCommon
{
    /// <summary>
    /// Vòng trường sinh.
    /// </summary>
    public static class VongTruongSinh
    {
        public static readonly ThoiKi TruongSinh = new ThoiKi { Id = 1, Name = "Trường Sinh", NameChinese = "", Desc= "Sinh ra và bắt đầu cuộc sống. Thể hiện nếp sống và phát triển mọi mặt của con người." };
        public static readonly ThoiKi MocDuc = new ThoiKi { Id = 2, Name = "Mộc Dục", NameChinese = "", Desc = "Con người đã thích nghi với môi trường xung quanh, tâm sinh lý đã hình thành. Tượng trưng như được tắm gội." };
        public static readonly ThoiKi QuanDoi = new ThoiKi { Id = 3, Name = "Quan Đới", NameChinese = "", Desc = "Bước vào ngưỡng của của sự trưởng thành. Con người có đủ khả năng để lập nghiệp." };
        public static readonly ThoiKi LamQuan = new ThoiKi { Id = 4, Name = "Lâm Quan", NameChinese = "", Desc = "Con người đã chủ động tự lập sự nghiệp và thành đạt trong cuộc sống mang tính tự hào, kiêu hãnh." };
        public static readonly ThoiKi DeVuong = new ThoiKi { Id = 5, Name = "Đế Vượng", NameChinese = "", Desc = "Giai đoạn tốt đẹp, thành công nhất trong cuộc đời. Song dự báo đã ở đỉnh điểm, chuẩn bị cho sự suy giảm." };
        public static readonly ThoiKi Suy = new ThoiKi { Id = 6, Name = "Suy", NameChinese = "", Desc = "Giai đoạn bắt đầu suy giảm mọi mặt, biểu hiện sự trì trệ, bảo thủ, mất ý chí chiến đấu." };
        public static readonly ThoiKi Benh = new ThoiKi { Id = 7, Name = "Bệnh", NameChinese = "", Desc = "Sức khoẻ kém dần, sinh bệnh tật đau yếu, biểu thị sự cầu an. Thâm tâm tiều tuỵ, mất ý chí chiến đấu." };
        public static readonly ThoiKi Tu = new ThoiKi { Id = 8, Name = "Tử", NameChinese = "", Desc = "Coi như chết, biểu thị sự đình đốn, bế tắc, không còn khả năng quyết đoán." };
        public static readonly ThoiKi Mo = new ThoiKi { Id = 9, Name = "Mộ", NameChinese = "", Desc = "Đã chết được chôn thành mộ. Biểu thị sự thu tàng, tính thích thu nhận mọi thứ. Đặc trưng cho sự kín đáo, kiệt sỉ." };
        public static readonly ThoiKi Tuyet = new ThoiKi { Id = 10, Name = "Tuyệt", NameChinese = "", Desc = "Người đã chết mục rữa hết, chỉ còn linh hồn chờ sang kiếp khác. Biểu thị bóng tối mịt mùng, không có một tia sáng. Tượng trưng cho sự tuyệt vọng, hành động nông nổi không có chiều sâu." };
        public static readonly ThoiKi Thai = new ThoiKi { Id = 11, Name = "Thai", NameChinese = "", Desc = "Linh hồn của người đã chết lâu, thu khí thành thai trở thành một sinh mệnh mới. Biểu thị một ngày mới bắt đầu, tượng trưng cho sức sống hy vọng và tiến triển." };
        public static readonly ThoiKi Duong = new ThoiKi { Id = 12, Name = "Dưỡng", NameChinese = "", Desc = "Thụ thai được nuôi dưỡng trong bụng mẹ, chờ ngày sinh nở. Đại biểu cho sự phát triển sáng tạo và ý chí độc lập. " };

        // Id order and adding order must be the same.
        public static List<ThoiKi> All = new List<ThoiKi> { TruongSinh, MocDuc, QuanDoi, LamQuan, DeVuong, Suy, Benh, Tu, Mo, Tuyet, Thai, Duong };

        public static readonly TruongSinhNguHanh MocTruongSinh = new TruongSinhNguHanh(Moc, Hoi); // Xuân, Mộc trường sinh ở Hợi
        public static readonly TruongSinhNguHanh HoaTruongSinh = new TruongSinhNguHanh(Hoa, Dan); // Hạ, Hỏa trường sinh ở Dần
        public static readonly TruongSinhNguHanh ThoTruongSinh = new TruongSinhNguHanh(Tho, Dan); // Hạ, Hỏa trường sinh ở Dần
        public static readonly TruongSinhNguHanh KimTruongSinh = new TruongSinhNguHanh(Kim, Ty); // Thu, Kim trường sinh ở Tỵ
        public static readonly TruongSinhNguHanh ThuyTruongSinh = new TruongSinhNguHanh(Thuy, Than); // Đông, Thủy trường sinh ở Thân

        public static readonly List<TruongSinhNguHanh> TruongSinhList = new List<TruongSinhNguHanh> { MocTruongSinh, HoaTruongSinh, ThoTruongSinh, KimTruongSinh, ThuyTruongSinh };

        /// <summary>
        /// Từ ngũ hành của nguyệt kiến kiểm tra xem địa chi thuộc thời kì nào của vòng trường sinh.
        /// </summary>
        /// <param name="hanh">ngũ hành của tháng</param>
        /// <param name="chi">địa chi của hào</param>
        /// <returns></returns>
        public static ThoiKi GetThoiKi(Hanh hanh, Chi chi)
        {
            foreach (var truongSinh in TruongSinhList)
            {
                if (hanh == truongSinh.Hanh)
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


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using static KinhDichCommon.ThienCan;

namespace KinhDichCommon
{
    /// <summary>
    /// Lục thần.
    /// </summary>
    public class LucThu : BaseItem
    {
        public static readonly LucThu ThanhLong = new LucThu { Id = 1, Name = "Thanh Long", NameChinese = "", Desc="Thuộc MỘC - Tiền bạc, vui vẻ, hỉ tín, ..." };
        public static readonly LucThu ChuTuoc = new LucThu { Id = 2, Name = "Chu Tước", NameChinese = "", Desc="Thuộc HỎA - Báo tin, văn chương, nghệ thuật, ..." };
        public static readonly LucThu CauTran = new LucThu { Id = 3, Name = "Câu Trần", NameChinese = "", Desc="Thuộc THỔ - Chậm chạp, lâu dài, ..." };
        public static readonly LucThu PhiXa = new LucThu { Id = 4, Name = "Đằng Xà", NameChinese = "", Desc="Thuộc HỎA - Nhanh lẹ, quái dị, ..." };
        public static readonly LucThu BachHo = new LucThu { Id = 5, Name = "Bạch Hổ", NameChinese = "", Desc="Thuộc KIM - Cứng mạnh, hung bạo, ..." };
        public static readonly LucThu HuyenVu = new LucThu { Id = 6, Name = "Huyền Vũ", NameChinese = "", Desc="Thuộc THỦY - Mờ ám, chưa rõ, ..." };

        public static readonly List<LucThu> NgayGiapAt = new List<LucThu> { ThanhLong, ChuTuoc, CauTran, PhiXa, BachHo, HuyenVu };

        public static readonly List<LucThu> NgayBinhDinh = new List<LucThu> { ChuTuoc, CauTran, PhiXa, BachHo, HuyenVu, ThanhLong };

        public static readonly List<LucThu> NgayMau = new List<LucThu> { CauTran, PhiXa, BachHo, HuyenVu, ThanhLong, ChuTuoc };

        public static readonly List<LucThu> NgayKy = new List<LucThu> { PhiXa, BachHo, HuyenVu, ThanhLong, ChuTuoc, CauTran };

        public static readonly List<LucThu> NgayCanhTan = new List<LucThu> { BachHo, HuyenVu, ThanhLong, ChuTuoc, CauTran, PhiXa };

        public static readonly List<LucThu> NgayNhamQuy = new List<LucThu> { HuyenVu, ThanhLong, ChuTuoc, CauTran, PhiXa, BachHo };

        public static List<LucThu> GetLucThuList(ThienCan canCuaNgay)
        {
            if (canCuaNgay == Giap || canCuaNgay == At)
            {
                return NgayGiapAt;
            }
            else if (canCuaNgay == Binh || canCuaNgay == Dinh)
            {
                return NgayBinhDinh;
            }
            else if (canCuaNgay == Mau)
            {
                return NgayMau;
            }
            else if (canCuaNgay == Ky)
            {
                return NgayKy;
            }
            else if (canCuaNgay == Canh || canCuaNgay == Tan)
            {
                return NgayCanhTan;
            }
            else
            {
                return NgayNhamQuy;
            }
        }

        public static LucThu GetLucThu(ThienCan canCuaNgay, int haoDongIndex)
        {
            var list = GetLucThuList(canCuaNgay);

            return list[haoDongIndex];
        }
    }
}

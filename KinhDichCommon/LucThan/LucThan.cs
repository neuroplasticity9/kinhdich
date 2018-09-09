using System;
using System.Collections.Generic;
using System.Linq;
using static KinhDichCommon.ThienCan;

namespace KinhDichCommon
{
    /// <summary>
    /// Lục thần.
    /// </summary>
    public class LucThan : BaseItem
    {
        public static readonly LucThan ThanhLong = new LucThan { Id = 1, Name = "Thanh Long", NameChinese = "" };
        public static readonly LucThan ChuTuoc = new LucThan { Id = 2, Name = "Chu Tước", NameChinese = "" };
        public static readonly LucThan CauTran = new LucThan { Id = 3, Name = "Câu Trần", NameChinese = "" };
        public static readonly LucThan PhiXa = new LucThan { Id = 4, Name = "Phi Xà", NameChinese = "" };
        public static readonly LucThan BachHo = new LucThan { Id = 5, Name = "Bạch Hổ", NameChinese = "" };
        public static readonly LucThan HuyenVu = new LucThan { Id = 6, Name = "Huyền Vũ", NameChinese = "" };

        public static readonly List<LucThan> NgayGiapAt = new List<LucThan> { ThanhLong, ChuTuoc, CauTran, PhiXa, BachHo, HuyenVu };

        public static readonly List<LucThan> NgayBinhDinh = new List<LucThan> { ChuTuoc, CauTran, PhiXa, BachHo, HuyenVu, ThanhLong };

        public static readonly List<LucThan> NgayMau = new List<LucThan> { CauTran, PhiXa, BachHo, HuyenVu, ThanhLong, ChuTuoc };

        public static readonly List<LucThan> NgayKy = new List<LucThan> { PhiXa, BachHo, HuyenVu, ThanhLong, ChuTuoc, CauTran };

        public static readonly List<LucThan> NgayCanhTan = new List<LucThan> { BachHo, HuyenVu, ThanhLong, ChuTuoc, CauTran, PhiXa };

        public static readonly List<LucThan> NgayNhamQuy = new List<LucThan> { HuyenVu, ThanhLong, ChuTuoc, CauTran, PhiXa, BachHo };

        public static List<LucThan> GetLucThan(ThienCan canCuaNgay)
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
    }
}

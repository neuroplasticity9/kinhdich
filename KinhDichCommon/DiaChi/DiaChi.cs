using System;
using System.Collections.Generic;
using System.Linq;
using static KinhDichCommon.NguHanh;

namespace KinhDichCommon
{
    /// <summary>
    /// Muoi hai dia chi.
    /// </summary>
    public static class DiaChi
    {
        public static readonly Chi Ti = new Chi { Id = 1, Name = "Tí", NameChinese = "", Hanh = Thuy, Duong = true };
        public static readonly Chi Suu = new Chi { Id = 2, Name = "Sửu", NameChinese = "", Hanh = Tho, Duong = false };
        public static readonly Chi Dan = new Chi { Id = 3, Name = "Dần", NameChinese = "", Hanh = Moc, Duong = true };
        public static readonly Chi Mao = new Chi { Id = 4, Name = "Mão", NameChinese = "", Hanh = Moc, Duong = false };
        public static readonly Chi Thin = new Chi { Id = 5, Name = "Thìn", NameChinese = "", Hanh = Tho, Duong = true };
        public static readonly Chi Ty = new Chi { Id = 6, Name = "Tỵ", NameChinese = "", Hanh = Hoa, Duong = false };
        public static readonly Chi Ngo = new Chi { Id = 7, Name = "Ngọ", NameChinese = "", Hanh = Hoa, Duong = true };
        public static readonly Chi Mui = new Chi { Id = 8, Name = "Mùi", NameChinese = "", Hanh = Tho, Duong = false };
        public static readonly Chi Than = new Chi { Id = 9, Name = "Thân", NameChinese = "", Hanh = Kim, Duong = true };
        public static readonly Chi Dau = new Chi { Id = 10, Name = "Dậu", NameChinese = "", Hanh = Kim, Duong = false };
        public static readonly Chi Tuat = new Chi { Id = 11, Name = "Tuất", NameChinese = "", Hanh = Tho, Duong = true };
        public static readonly Chi Hoi = new Chi { Id = 12, Name = "Hợi", NameChinese = "", Hanh = Thuy, Duong = false };

        // Id order and adding order must be the same.
        public static readonly List<Chi> All = new List<Chi> { Ti, Suu, Dan, Mao, Thin, Ty, Ngo, Mui, Than, Dau, Tuat, Hoi };

        public static readonly List<Chi> ThuyCuc = new List<Chi> { Than, Ti, Thin };
        public static readonly List<Chi> MocCuc = new List<Chi> { Hoi, Mao, Mui };
        public static readonly List<Chi> HoaCuc = new List<Chi> { Dan, Ngo, Tuat };
        public static readonly List<Chi> KimCuc = new List<Chi> { Ty, Dau, Suu };

        static DiaChi()
        {
            SetHopXung(All);
            SetTanThoai();
        }

        /// <summary>
        /// Set tấn thần và thoái thần cho địa chi.
        /// </summary>
        private static void SetTanThoai()
        {
            Hoi.Tan = Ti;
            Ti.Thoai = Hoi;

            Dan.Tan = Mao;
            Mao.Thoai = Dan;

            Ty.Tan = Ngo;
            Ngo.Thoai = Ty;

            Than.Tan = Dau;
            Dau.Thoai = Than;

            Suu.Tan = Thin;
            Thin.Thoai = Suu;

            Thin.Tan = Mui;
            Mui.Thoai = Thin;

            Mui.Tan = Tuat;
            Tuat.Thoai = Mui;

            Tuat.Tan = Suu;
            Suu.Thoai = Tuat;
        }

        public static Chi GetChi(int chiId)
        {
            return All.FirstOrDefault(c => c.Id == chiId);
        }

        private static void SetHopXung(List<Chi> list)
        {
            var maxIndex = list.Count - 1;

            for (int i = 0; i <= maxIndex; i++)
            {
                var diaChi = list[i];
                diaChi.Hop = list[GetHopIndex(i, maxIndex)];
                diaChi.Xung = list[GetXungIndex(i, maxIndex)];
            }
        }

        public static int GetHopIndex(int index, int maxIndex)
        {
            if (index <= 1)
            {
                // Ti or Suu case.
                return 1 - index;
            }

            return GetNewIndex(index, maxIndex, (i) => 13 - i);
        }

        public static int GetXungIndex(int index, int maxIndex)
        {
            return GetNewIndex(index, maxIndex, (i) => i + 6);
        }

    }
}

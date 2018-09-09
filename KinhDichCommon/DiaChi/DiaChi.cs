using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using static KinhDichCommon.NguHanh;

namespace KinhDichCommon
{
    /// <summary>
    /// Muoi hai dia chi.
    /// </summary>
    [DebuggerDisplay("{Name,nq} {NguHanh.Name,nq}, hợp {Hop.Name,nq}, xung {Xung.Name,nq}")]
    public class DiaChi : BaseItem
    {
        /// <summary>
        /// Địa chi xung.
        /// </summary>
        public DiaChi Xung { get; set; }

        /// <summary>
        /// Địa chi hợp.
        /// </summary>
        public DiaChi Hop { get; set; }

        /// <summary>
        /// Ngũ hành của địa chi.
        /// </summary>
        public NguHanh NguHanh { get; set; }

        /// <summary>
        /// Âm hay dương.
        /// </summary>
        public bool Duong { get; set; }

        /// <summary>
        /// Tấn thần là địa chi nào.
        /// </summary>
        public DiaChi Tan { get; set; }

        /// <summary>
        /// Thoái thần là địa chi nào.
        /// </summary>
        public DiaChi Thoai { get; set; }

        public static readonly DiaChi Ti = new DiaChi { Id = 1, Name = "Tí", NameChinese = "", NguHanh = Thuy, Duong = true };
        public static readonly DiaChi Suu = new DiaChi { Id = 2, Name = "Sửu", NameChinese = "", NguHanh = Tho, Duong = false };
        public static readonly DiaChi Dan = new DiaChi { Id = 3, Name = "Dần", NameChinese = "", NguHanh = Moc, Duong = true };
        public static readonly DiaChi Mao = new DiaChi { Id = 4, Name = "Mão", NameChinese = "", NguHanh = Moc, Duong = false };
        public static readonly DiaChi Thin = new DiaChi { Id = 5, Name = "Thìn", NameChinese = "", NguHanh = Tho, Duong = true };
        public static readonly DiaChi Ty = new DiaChi { Id = 6, Name = "Tỵ", NameChinese = "", NguHanh = Hoa, Duong = false };
        public static readonly DiaChi Ngo = new DiaChi { Id = 7, Name = "Ngọ", NameChinese = "", NguHanh = Hoa, Duong = true };
        public static readonly DiaChi Mui = new DiaChi { Id = 8, Name = "Mùi", NameChinese = "", NguHanh = Tho, Duong = false };
        public static readonly DiaChi Than = new DiaChi { Id = 9, Name = "Thân", NameChinese = "", NguHanh = Kim, Duong = true };
        public static readonly DiaChi Dau = new DiaChi { Id = 10, Name = "Dậu", NameChinese = "", NguHanh = Kim, Duong = false };
        public static readonly DiaChi Tuat = new DiaChi { Id = 11, Name = "Tuất", NameChinese = "", NguHanh = Tho, Duong = true };
        public static readonly DiaChi Hoi = new DiaChi { Id = 12, Name = "Hợi", NameChinese = "", NguHanh = Thuy, Duong = false };

        // Id order and adding order must be the same.
        public static readonly List<DiaChi> All = new List<DiaChi> { Ti, Suu, Dan, Mao, Thin, Ty, Ngo, Mui, Than, Dau, Tuat, Hoi };

        public static readonly List<DiaChi> ThuyCuc = new List<DiaChi> { Than, Ti, Thin };
        public static readonly List<DiaChi> MocCuc = new List<DiaChi> { Hoi, Mao, Mui };
        public static readonly List<DiaChi> HoaCuc = new List<DiaChi> { Dan, Ngo, Tuat };
        public static readonly List<DiaChi> KimCuc = new List<DiaChi> { Ty, Dau, Suu };

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

        public static DiaChi GetChi(int chiId)
        {
            return All.FirstOrDefault(c => c.Id == chiId);
        }

        private static void SetHopXung(List<DiaChi> list)
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

using System;
using System.Collections.Generic;
using System.Linq;
using static KinhDichCommon.NguHanh;

namespace KinhDichCommon
{
    /// <summary>
    /// Muoi hai dia chi.
    /// </summary>
    public static class BatQuai
    {
        public static readonly Cung Kien = new  Cung { Id = 1, Name = "Càn", NameChinese = "乾", Hanh = Kim,
            Duong = true, Duong3 = true, Duong2 = true, Duong1 = true };

        public static readonly Cung Doai = new Cung { Id = 2, Name = "Đoài", NameChinese = "兌", Hanh = Kim,
            Duong = true, Duong3 = false, Duong2 = true, Duong1 = true };

        public static readonly Cung Ly = new Cung { Id = 3, Name = "Ly", NameChinese = "離", Hanh = Hoa,
            Duong = true, Duong3 = true, Duong2 = false, Duong1 = true };

        public static readonly Cung Chan = new Cung { Id = 4, Name = "Chấn", NameChinese = "震", Hanh = Moc,
            Duong = true, Duong3 = false, Duong2 = false, Duong1 = true };

        public static readonly Cung Ton = new Cung { Id = 5, Name = "Tốn", NameChinese = "巽", Hanh = Moc,
            Duong = false, Duong3 = true, Duong2 = true, Duong1 = false };

        public static readonly Cung Kham = new Cung { Id = 6, Name = "Khảm", NameChinese = "坎", Hanh = Thuy,
            Duong = false, Duong3 = false, Duong2 = true, Duong1 = false };

        public static readonly Cung Can = new Cung { Id = 7, Name = "Cấn", NameChinese = "艮", Hanh = Tho,
            Duong = false, Duong3 = true, Duong2 = false, Duong1 = false };

        public static readonly Cung Khon = new Cung { Id = 8, Name = "Khôn", NameChinese = "坤", Hanh = Tho,
            Duong = false, Duong3 = false, Duong2 = false, Duong1 = false };

        // Id order and adding order must be the same.
        public static List<Cung> All = new List<Cung> { Kien, Doai, Ly, Chan, Ton, Kham, Can, Khon };
                
        static BatQuai()
        {
        }

        public static Cung GetCung(bool duongTam, bool duongNhi, bool duongNhat)
        {
            return All.FirstOrDefault(c => c.Duong1 == duongNhat && c.Duong2 == duongNhi && c.Duong3 == duongTam);
        }

    }
}

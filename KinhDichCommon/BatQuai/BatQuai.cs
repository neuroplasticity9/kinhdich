using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using static KinhDichCommon.NguHanh;

namespace KinhDichCommon
{
    /// <summary>
    /// Cung bát quái.
    /// </summary>
    [DebuggerDisplay("{Name,nq} {NguHanh.Name,nq}")]
    public class BatQuai : BaseItem
    {
        /// <summary>
        /// Ngũ hành của cung.
        /// </summary>
        public NguHanh NguHanh { get; internal set; }

        /// <summary>
        /// Âm dương của cung.
        /// </summary>
        public bool Duong { get; internal set; }

        /// <summary>
        /// Dương tam, ở trên cùng.
        /// </summary>
        public bool Duong3 { get; internal set; }

        /// <summary>
        /// Dương nhị, ở giữa.
        /// </summary>
        public bool Duong2 { get; internal set; }

        /// <summary>
        /// Dương nhất, ở dưới cùng.
        /// </summary>
        public bool Duong1 { get; internal set; }

        /// <summary>
        /// Quẻ thể hay quẻ dụng.
        /// </summary>
        public bool QueThe { get; set; }

        /// <summary>
        /// Tượng của bát quái.
        /// </summary>
        public string Tuong { get; set; }

        public static readonly BatQuai Kien = new  BatQuai { Id = 1, Name = "Càn", NameChinese = "乾", Tuong = "Thiên", NguHanh = Kim,
            Duong = true, Duong3 = true, Duong2 = true, Duong1 = true };

        public static readonly BatQuai Doai = new BatQuai { Id = 2, Name = "Đoài", NameChinese = "兌", Tuong = "Trạch", NguHanh = Kim,
            Duong = true, Duong3 = false, Duong2 = true, Duong1 = true };

        public static readonly BatQuai Ly = new BatQuai { Id = 3, Name = "Ly", NameChinese = "離", Tuong = "Hỏa", NguHanh = Hoa,
            Duong = true, Duong3 = true, Duong2 = false, Duong1 = true };

        public static readonly BatQuai Chan = new BatQuai { Id = 4, Name = "Chấn", NameChinese = "震", Tuong = "Lôi", NguHanh = Moc,
            Duong = true, Duong3 = false, Duong2 = false, Duong1 = true };

        public static readonly BatQuai Ton = new BatQuai { Id = 5, Name = "Tốn", NameChinese = "巽", Tuong = "Phong", NguHanh = Moc,
            Duong = false, Duong3 = true, Duong2 = true, Duong1 = false };

        public static readonly BatQuai Kham = new BatQuai { Id = 6, Name = "Khảm", NameChinese = "坎", Tuong = "Thủy", NguHanh = Thuy,
            Duong = false, Duong3 = false, Duong2 = true, Duong1 = false };

        public static readonly BatQuai Can = new BatQuai { Id = 7, Name = "Cấn", NameChinese = "艮", Tuong = "Sơn", NguHanh = Tho,
            Duong = false, Duong3 = true, Duong2 = false, Duong1 = false };

        public static readonly BatQuai Khon = new BatQuai { Id = 8, Name = "Khôn", NameChinese = "坤", Tuong = "Địa", NguHanh = Tho,
            Duong = false, Duong3 = false, Duong2 = false, Duong1 = false };

        // Id order and adding order must be the same.
        public static List<BatQuai> All = new List<BatQuai> { Kien, Doai, Ly, Chan, Ton, Kham, Can, Khon };
                
        static BatQuai()
        {
        }

        public static BatQuai GetCung(bool duongTam, bool duongNhi, bool duongNhat)
        {
            return All.FirstOrDefault(c => c.Duong1 == duongNhat && c.Duong2 == duongNhi && c.Duong3 == duongTam);
        }

    }
}

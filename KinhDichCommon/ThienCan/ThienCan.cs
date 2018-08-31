using System.Collections.Generic;
using System.Linq;

namespace KinhDichCommon
{
    /// <summary>
    /// Mười thiên can.
    /// </summary>
    public static class ThienCan
    {
        public static readonly Can Giap = new Can { Id = 1, Name = "Giáp", NameChinese = "", Hanh = NguHanh.Moc, Duong = true };
        public static readonly Can At = new Can { Id = 2, Name = "Ất", NameChinese = "", Hanh = NguHanh.Moc, Duong = false };
        public static readonly Can Binh = new Can { Id = 3, Name = "Bính", NameChinese = "", Hanh = NguHanh.Hoa, Duong = true };
        public static readonly Can Dinh = new Can { Id = 4, Name = "Đinh", NameChinese = "", Hanh = NguHanh.Hoa, Duong = false };
        public static readonly Can Mau = new Can { Id = 5, Name = "Mậu", NameChinese = "", Hanh = NguHanh.Tho, Duong = true };
        public static readonly Can Ky = new Can { Id = 6, Name = "Kỷ", NameChinese = "", Hanh = NguHanh.Tho, Duong = false };
        public static readonly Can Canh = new Can { Id = 7, Name = "Canh", NameChinese = "", Hanh = NguHanh.Kim, Duong = true };
        public static readonly Can Tan = new Can { Id = 8, Name = "Tân", NameChinese = "", Hanh = NguHanh.Kim, Duong = false };
        public static readonly Can Nham = new Can { Id = 9, Name = "Nhâm", NameChinese = "", Hanh = NguHanh.Thuy, Duong = true };
        public static readonly Can Quy = new Can { Id = 10, Name = "Quý", NameChinese = "", Hanh = NguHanh.Thuy, Duong = false };

        // Id order and adding order must be the same.
        public static readonly List<Can> All = new List<Can> { Giap, At, Binh, Dinh, Mau, Ky, Canh, Tan, Nham, Quy };

        public static Can GetCan(int canId)
        {
            return All.FirstOrDefault(c => c.Id == canId);
        }
    }
}

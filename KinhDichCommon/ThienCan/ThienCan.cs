using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace KinhDichCommon
{
    /// <summary>
    /// Mười thiên can.
    /// </summary>
    [DebuggerDisplay("{Name,nq} {NguHanh.Name,nq}, hợp {Hop.Name,nq}, xung {Xung.Name,nq}")]
    public class ThienCan : BaseItem
    {
        public NguHanh NguHanh { get; internal set; }
        public bool Duong { get; internal set; }

        public static readonly ThienCan Giap = new ThienCan { Id = 1, Name = "Giáp", NameChinese = "", NguHanh = NguHanh.Moc, Duong = true };
        public static readonly ThienCan At = new ThienCan { Id = 2, Name = "Ất", NameChinese = "", NguHanh = NguHanh.Moc, Duong = false };
        public static readonly ThienCan Binh = new ThienCan { Id = 3, Name = "Bính", NameChinese = "", NguHanh = NguHanh.Hoa, Duong = true };
        public static readonly ThienCan Dinh = new ThienCan { Id = 4, Name = "Đinh", NameChinese = "", NguHanh = NguHanh.Hoa, Duong = false };
        public static readonly ThienCan Mau = new ThienCan { Id = 5, Name = "Mậu", NameChinese = "", NguHanh = NguHanh.Tho, Duong = true };
        public static readonly ThienCan Ky = new ThienCan { Id = 6, Name = "Kỷ", NameChinese = "", NguHanh = NguHanh.Tho, Duong = false };
        public static readonly ThienCan Canh = new ThienCan { Id = 7, Name = "Canh", NameChinese = "", NguHanh = NguHanh.Kim, Duong = true };
        public static readonly ThienCan Tan = new ThienCan { Id = 8, Name = "Tân", NameChinese = "", NguHanh = NguHanh.Kim, Duong = false };
        public static readonly ThienCan Nham = new ThienCan { Id = 9, Name = "Nhâm", NameChinese = "", NguHanh = NguHanh.Thuy, Duong = true };
        public static readonly ThienCan Quy = new ThienCan { Id = 10, Name = "Quý", NameChinese = "", NguHanh = NguHanh.Thuy, Duong = false };

        // Id order and adding order must be the same.
        public static readonly List<ThienCan> All = new List<ThienCan> { Giap, At, Binh, Dinh, Mau, Ky, Canh, Tan, Nham, Quy };

        public static ThienCan GetCan(int canId)
        {
            return All.FirstOrDefault(c => c.Id == canId);
        }
    }
}

using System.Collections.Generic;
using System.Diagnostics;

namespace KinhDichCommon
{
    /// <summary>
    /// 1 tuan cua 1 hoa giap co 10 ngay.
    /// </summary>
    [DebuggerDisplay("Tuần {All[0].Can.Name,nq} {All[0].Chi.Name,nq}")]
    public class Tuan
    {
        public const int SoNgay = 10;

        public DiaChi Khong1 { get; private set; }
        public DiaChi Khong2 { get; private set; }

        // Id order and adding order must be the same.
        public List<CanChi> All = new List<CanChi>();

        
        public Tuan(CanChi canChiBatDau)
        {
            Add10CanChi(canChiBatDau);
        }

        private void Add10CanChi(CanChi canChiBatDau)
        {
            All.Add(canChiBatDau);

            CanChi canChiTruoc = canChiBatDau;
            CanChi canChi;

            // Add other 9 CanChi.
            for (int i = 0; i < SoNgay - 1; i++)
            {
                canChi = canChiTruoc.Next();

                All.Add(canChi);
                canChiTruoc = canChi;
            }

            Khong1 = canChiTruoc.Chi.Next();
            Khong2 = Khong1.Next();
        }

        public bool IsCanChiInThisTuan(CanChi canChi)
        {
            return All.Exists(c => c.Can == canChi.Can && c.Chi == canChi.Chi);
        }
        
    }
}

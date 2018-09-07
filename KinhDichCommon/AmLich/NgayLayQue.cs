using System;

namespace KinhDichCommon
{
    /// <summary>
    /// Ngay am lich.
    /// </summary>
    public class NgayLayQue
    {
        public DateTime SolarDate { get; set; }

        public int LunarYear { get; set; }
        public int LunarMonth { get; set; }
        public int LunarDay { get; set; }
        public int LunarLeap { get; set; }

        public CanChi NamAm { get; set; }
        public CanChi ThangAm { get; set; }
        public CanChi NgayAm { get; set; }
        public CanChi GioAm { get; set; }


        public NgayLayQue(CanChi nhatThan, CanChi nguyetKien)
        {
            NgayAm = nhatThan;
            ThangAm = nguyetKien;
        }

        public NgayLayQue(AmLich amLich)
        {
            SolarDate = amLich.SolarDate;
            LunarYear = amLich.LunarYear;
            LunarMonth = amLich.LunarMonth;
            LunarDay = amLich.LunarDay;
            LunarLeap = amLich.LunarLeap;

            NamAm = amLich.NamAm;
            ThangAm = amLich.ThangAm;
            NgayAm = amLich.NgayAm;
            GioAm = amLich.GioAm;
        }
    }
}

using System;
using System.Text;
using KinhDichCommon;
using static KinhDichCommon.NguHanh;

namespace DoanQueKinhDich.Business
{
    public abstract class QueService
    {
        public IQueLayDuoc Que { get; set; }
        public Que QueChu { get; }
        public Que QueHo { get; }
        public Que QueBien { get; }
               
        public QueService(IQueLayDuoc que)
        {
            Que = que;

            QueChu = QueDich.GetQue(que.Hao6, que.Hao5, que.Hao4, que.Hao3, que.Hao2, que.Hao1);

            QueHo = QueDich.GetQue(que.Hao5, que.Hao4, que.Hao3, que.Hao4, que.Hao3, que.Hao2);

            if (que.CoQueBien())
            {
                QueBien = QueDich.GetQueBien(QueChu, que.Hao6Dong, que.Hao5Dong, que.Hao4Dong, que.Hao3Dong, que.Hao2Dong, que.Hao1Dong);
            }

        }

        /// <summary>
        /// Return the desc of que.
        /// </summary>
        /// <returns></returns>
        public abstract string GetQueDesc();


        #region "Private methods"


        protected string GetNgayThang(NgayLayQue ngayLayQue, CachLayQue cachLayQue)
        {
            var nhatThan = ngayLayQue.NgayAm;
            var nguyetKien = ngayLayQue.ThangAm;
            var result = "";

            switch (cachLayQue)
            {
                case CachLayQue.None:
                    break;

                case CachLayQue.Manual:
                    result = $"   Tháng: {nguyetKien.Name} - Ngày: {nhatThan.Name} ({nhatThan.Khong1.Name} {nhatThan.Khong2.Name} lâm không)";
                    break;

                case CachLayQue.TungXu:
                case CachLayQue.MaiHoaTienThien1:
                case CachLayQue.MaiHoaTienThien2:
                case CachLayQue.MaiHoaTienThien3:
                    var sb = new StringBuilder();
                    var columnLen = 17;
                    sb.Append($"   Năm {ngayLayQue.LunarYear}".PadRight(columnLen + 2));
                    sb.Append($"Tháng {ngayLayQue.LunarMonth}".PadRight(columnLen));
                    sb.Append($"Ngày {ngayLayQue.LunarDay}".PadRight(columnLen));
                    sb.Append($"Giờ {ngayLayQue.GioAm.Chi.Name} (dương lịch: {ngayLayQue.SolarDate.ToString("yyyy-MM-dd")})");
                    sb.AppendLine();

                    sb.Append($"   {ngayLayQue.NamAm.Name}".PadRight(columnLen + 2));
                    sb.Append($"{ngayLayQue.ThangAm.Name}".PadRight(columnLen));
                    sb.Append($"{ngayLayQue.NgayAm.Name}".PadRight(columnLen));
                    sb.Append($"{ngayLayQue.GioAm.Name} ({nhatThan.Khong1.Name} {nhatThan.Khong2.Name} lâm không)");

                    result = sb.ToString();

                    break;
                default:
                    break;
            }

            return result;
        }

        protected string GetTenQueLong(Que que)
        {
            if (que == null)
            {
                return "";
            }

            return $"   {que.Name} ({que.HanhQueThuan.Name}), {que.NgoaiQuai.Name} {que.NgoaiQuai.Hanh.Name} / {que.NoiQuai.Name} {que.NoiQuai.Hanh.Name}{GetHopXungString(que)}";
        }

        protected string GetTenQueShort(Que que)
        {
            if (que == null)
            {
                return "";
            }

            return $"   {que.Name} ({que.HanhQueThuan.Name}), {que.NgoaiQuai.Name} {que.NgoaiQuai.Hanh.Name} / {que.NoiQuai.Name} {que.NoiQuai.Hanh.Name}";
        }

        protected string GetChiChuCuaQue(Que que)
        {
            if (que == null)
            {
                return "";
            }

            return $"   {que.Desc}";
        }


        protected string GetHopXungString(Que que)
        {
            if (que == null)
            {
                return "";
            }

            if (que.IsLucHop())
            {
                return ", quẻ lục hợp";
            }
            else if (que.IsLucXung())
            {
                return ", quẻ lục xung";
            }

            return "";
        }


        #endregion

    }
}
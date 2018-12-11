using System;
using System.Text;
using KinhDichCommon;

namespace DoanQueKinhDich.Business
{
    public abstract class QueService
    {
        private const char HRChar = '—';

        public IQueLayDuoc Que { get; set; }
        public Que QueChu { get; }
        public Que QueHo { get; }
        public Que QueBien { get; }
               
        public QueService(IQueLayDuoc que)
        {
            Que = que;

            QueChu = KinhDichCommon.Que.GetQue(que.Hao6, que.Hao5, que.Hao4, que.Hao3, que.Hao2, que.Hao1);

            QueHo = KinhDichCommon.Que.GetQueHo(QueChu);

            if (que.CoQueBien())
            {
                QueBien = KinhDichCommon.Que.GetQueBien(QueChu, que.Hao6Dong, que.Hao5Dong, que.Hao4Dong, que.Hao3Dong, que.Hao2Dong, que.Hao1Dong);
            }

            SetTheQuai();
        }

        private void SetTheQuai()
        {
            if (!IsTrenDong() && IsDuoiDong())
            {
                // dưới động thì thể quái ở trên.
                QueChu.IsTheQuaiOTren = true;
            }
            else if (IsTrenDong() && !IsDuoiDong())
            {
                // trên động thì thể quái ở dưới.
                QueChu.IsTheQuaiOTren = false;
            }
            else
            {
                // Nội quái và ngoại quái cùng động hoặc cùng tĩnh, tìm hào thế và hào ứng.
                QueChu.IsTheQuaiOTren = IsHaoTheOTren();
            }
        }

        private bool IsTrenDong()
        {
            return Que.Hao6Dong || Que.Hao5Dong || Que.Hao4Dong;
        }

        private bool IsDuoiDong()
        {
            return Que.Hao3Dong || Que.Hao2Dong || Que.Hao1Dong;
        }

        private bool IsHaoTheOTren()
        {
            return QueChu.Hao6.The || QueChu.Hao5.The || QueChu.Hao4.The;
        }

        /// <summary>
        /// Return the desc of que.
        /// </summary>
        /// <returns></returns>
        public abstract string GetQueDesc();


        #region "protected methods"


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
                    var columnLen = 11;
                    sb.Append($"   Năm {ngayLayQue.LunarYear}".PadRight(columnLen + 2));
                    sb.Append($"Tháng {ngayLayQue.LunarMonth}".PadRight(columnLen));
                    sb.Append($"Ngày {ngayLayQue.LunarDay}".PadRight(columnLen));
                    sb.Append($"Giờ {ngayLayQue.GioAm.Chi.Name} (dương lịch: {ngayLayQue.SolarDate.ToString("yyyy-MM-dd")})");
                    sb.AppendLine();

                    sb.Append($"   {ngayLayQue.NamAm.Name}".PadRight(columnLen + 2));
                    sb.Append($"{ngayLayQue.ThangAm.Name}".PadRight(columnLen));
                    sb.Append($"{ngayLayQue.NgayAm.Name}".PadRight(columnLen));
                    sb.Append($"{ngayLayQue.GioAm.Name}");

                    result = sb.ToString();

                    break;
                default:
                    break;
            }

            return result;
        }

        protected string GetTenQueLucHao(Que que)
        {
            if (que == null)
            {
                return "";
            }

            return $"   {que.Name} ({que.QueThuan.NguHanh.Name}), {que.NgoaiQuai.Name} {que.NgoaiQuai.NguHanh.Name} / {que.NoiQuai.Name} {que.NoiQuai.NguHanh.Name}{GetHopXungString(que)}";
        }

        protected string GetTenQueMaiHoa(Que que)
        {
            if (que == null)
            {
                return "";
            }

            return $"   {que.Name} ({que.QueThuan.NguHanh.Name}), {que.NgoaiQuai.Name} {que.NgoaiQuai.NguHanh.Name} / {que.NoiQuai.Name} {que.NoiQuai.NguHanh.Name}";
        }

        protected string GetTenQueVietDich(Que que)
        {
            if (que == null)
            {
                return "";
            }

            return $"   {que.Name}";
        }

        protected string GetCachCuaQue(Que que)
        {
            if (que == null)
            {
                return "";
            }

            return $"   {que.Cach}";
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
        
        protected void AddTuongQue(StringBuilder sb, Que queChu, Que queHo, Que queBien)
        {
            sb.AppendLine(GetTuongQueString(queChu));
            sb.AppendLine();
            if (queHo != null && queHo.Id != queChu.Id)
            {
                sb.AppendLine(GetTuongQueString(queHo));
                sb.AppendLine();
            }
            if (queBien != null)
            {
                sb.AppendLine(GetTuongQueString(queBien));
                sb.AppendLine();
            }
        }

        private string GetTuongQueString(Que que)
        {
            return $"{que.Name} ({que.EnglishName} - {que.TuongQue}): {que.YNghia}{Environment.NewLine}{que.ViDu}";
        }

        protected void AddLongHR(int padRight, StringBuilder sb)
        {
            sb.AppendLine("".PadRight(padRight * 3, HRChar));
        }

        protected void AddShortHR(int padRight, StringBuilder sb)
        {
            sb.AppendLine("".PadRight(padRight * 2, HRChar));
        }

        #endregion

    }
}
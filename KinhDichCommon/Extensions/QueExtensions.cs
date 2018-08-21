using System;
using System.Text;

namespace KinhDichCommon
{
    public static class QueExtensions
    {
        public static string GetLucThan(this Que que)
        {
            var sb = new StringBuilder();

            sb.AppendLine(GetHaoDesc(que.Hao6));
            sb.AppendLine(GetHaoDesc(que.Hao5));
            sb.AppendLine(GetHaoDesc(que.Hao4));
            sb.AppendLine(GetHaoDesc(que.Hao3));
            sb.AppendLine(GetHaoDesc(que.Hao2));
            sb.AppendLine(GetHaoDesc(que.Hao1));

            return sb.ToString();
        }

        private static string GetHaoDesc(Hao hao)
        {
            var result = $"{hao.LucThan.Name} {hao.Chi.Name} {hao.Chi.Hanh.Name}";
            if (hao.The)
            {
                result = result + ", thế";
            }
            else if (hao.Ung)
            {
                result = result + ", ứng";
            }

            return result;
        }


        public static string GetLucThan(this Que que, CanChi nhatThan, CanChi nguyetKien)
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{que.Name}, {que.Hanh.Name}");
            sb.AppendLine($"Nhật thần {nhatThan.Name} ({nhatThan.Khong1.Name} {nhatThan.Khong2.Name} lâm không), nguyệt kiến {nguyetKien.Name}");
            sb.AppendLine();

            sb.AppendLine(GetHaoDesc(que.Hao6, nhatThan, nguyetKien));
            sb.AppendLine(GetHaoDesc(que.Hao5, nhatThan, nguyetKien));
            sb.AppendLine(GetHaoDesc(que.Hao4, nhatThan, nguyetKien));
            sb.AppendLine(GetHaoDesc(que.Hao3, nhatThan, nguyetKien));
            sb.AppendLine(GetHaoDesc(que.Hao2, nhatThan, nguyetKien));
            sb.AppendLine(GetHaoDesc(que.Hao1, nhatThan, nguyetKien));

            return sb.ToString();
        }

        private static string GetHaoDesc(Hao hao, CanChi nhatThan, CanChi nguyetKien)
        {
            var result = $"{hao.LucThan.Name} {hao.Chi.Name} {hao.Chi.Hanh.Name} \t";
            if (hao.The)
            {
                result = result + ", hào thế\t";
            }
            else if (hao.Ung)
            {
                result = result + ", hào ứng\t";
            }
            else
            {
                result = result + "\t\t\t";
            }
            
            // Nhật thần
            if (nhatThan.IsLamKhong(hao.Chi))
            {
                result = result + ", lâm không";
            }
            if (nhatThan.Chi.Xung == hao.Chi)
            {
                result = result + ", ám động";
            }

            if (nhatThan.Chi.Hanh.Khac == hao.Chi.Hanh)
            {
                result = result + ", nhật khắc";
            }
            else if (nhatThan.Chi.Hanh.Sinh == hao.Chi.Hanh)
            {
                result = result + ", nhật sinh";
            }

            // Nguyệt kiến
            if (nguyetKien.Chi.Xung == hao.Chi)
            {
                result = result + ", nguyệt phá";
            }
            else if (nguyetKien.Chi.Hop == hao.Chi)
            {
                result = result + ", nguyệt hợp";
            }

            if (nguyetKien.IsVuong(hao.Chi))
            {
                result = result + ", nguyệt vượng";
            }
            else if (nguyetKien.IsTuong(hao.Chi))
            {
                result = result + ", nguyệt tướng";
            }
            else if (nguyetKien.IsHuu(hao.Chi))
            {
                result = result + ", nguyệt hưu";
            }
            else if (nguyetKien.IsTu(hao.Chi))
            {
                result = result + ", nguyệt tù";
            }
            else if (nguyetKien.IsTuyet(hao.Chi))
            {
                result = result + ", nguyệt tử";
            }

            return result;
        }
    }
}

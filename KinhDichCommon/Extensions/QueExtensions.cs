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


        public static string GetQueDesc(this Que que, 
                                        CanChi nhatThan, CanChi nguyetKien,
                                        bool isHao6Dong = false, bool isHao5Dong = false, bool isHao4Dong = false,
                                        bool isHao3Dong = false, bool isHao2Dong = false, bool isHao1Dong = false)
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{que.Name}, {que.Hanh.Name}{GetHopXungString(que)}");
            sb.AppendLine($"Ngày: {nhatThan.Name} ({nhatThan.Khong1.Name} {nhatThan.Khong2.Name} lâm không) - Tháng: {nguyetKien.Name}");
            sb.AppendLine();

            sb.AppendLine(GetHaoDesc(que.Hao6, nhatThan, nguyetKien, isHao6Dong));
            sb.AppendLine(GetHaoDesc(que.Hao5, nhatThan, nguyetKien, isHao5Dong));
            sb.AppendLine(GetHaoDesc(que.Hao4, nhatThan, nguyetKien, isHao4Dong));
            sb.AppendLine(GetHaoDesc(que.Hao3, nhatThan, nguyetKien, isHao3Dong));
            sb.AppendLine(GetHaoDesc(que.Hao2, nhatThan, nguyetKien, isHao2Dong));
            sb.AppendLine(GetHaoDesc(que.Hao1, nhatThan, nguyetKien, isHao1Dong));

            return sb.ToString();
        }

        private static string GetHopXungString(Que que)
        {
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

        private static string GetHaoDesc(Hao hao, CanChi nhatThan, CanChi nguyetKien, bool isHaoDong)
        {
            var result = "";
            if (isHaoDong)
            {
                if (hao.Duong)
                {
                    result = result + "o\t";
                }
                else
                {
                    result = result + "x\t";
                }
            }
            else
            {
                result = result + "\t";
            }
            result = result  + $"{hao.Chi.Name} {hao.Chi.Hanh.Name}\t\t{hao.LucThan.Name}      \t";

            if (hao.The)
            {
                result = result + "THẾ\t";
            }
            else if (hao.Ung)
            {
                result = result + "ỨNG\t";
            }
            else
            {
                result = result + "\t";
            }
            
            if (nhatThan.IsLamKhong(hao.Chi))
            {
                result = result + ", lâm không";
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

            if (nguyetKien.IsVuongTuong(hao.Chi))
            {
                result = result + ", nguyệt vượng";
            }
            else if (nguyetKien.IsHuuTu(hao.Chi))
            {
                result = result + ", nguyệt tù";
            }

            // Nhật thần
            if (nhatThan.Chi.Xung == hao.Chi)
            {
                if (nhatThan.IsVuongTuong(hao.Chi))
                {
                    result = result + ", ám động";
                }
                else if (nhatThan.IsHuuTu(hao.Chi))
                {
                    result = result + ", nhật phá";
                }
            }
            else
            {
                if (nhatThan.IsVuongTuong(hao.Chi))
                {
                    result = result + ", nhật vượng";
                }
                else if (nhatThan.IsHuuTu(hao.Chi))
                {
                    result = result + ", nhật tù";
                }
            }

            return result;
        }
    }
}

using System;
using System.Text;
using static KinhDichCommon.NguHanh;

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
                result += ", thế";
            }
            else if (hao.Ung)
            {
                result += ", ứng";
            }

            return result;
        }

        /// <summary>
        /// Get que desc.
        /// </summary>
        /// <param name="que"></param>
        /// <param name="nhatThan"></param>
        /// <param name="nguyetKien"></param>
        /// <param name="isHao6Dong"></param>
        /// <param name="isHao5Dong"></param>
        /// <param name="isHao4Dong"></param>
        /// <param name="isHao3Dong"></param>
        /// <param name="isHao2Dong"></param>
        /// <param name="isHao1Dong"></param>
        /// <returns></returns>
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
            var isAmDong = IsAmDong(hao, nhatThan, nguyetKien);

            result += GetDiaChiVaLucThanCuaHao(hao, isHaoDong, isAmDong);
            result += GetSuyVuongCuaHao(hao, nhatThan, nguyetKien);

            return result;
        }

        /// <summary>
        /// Hào ám động là hào tĩnh, vượng tướng và xung với nhật thần.
        /// </summary>
        /// <param name="hao"></param>
        /// <param name="nhatThan"></param>
        /// <param name="nguyetKien"></param>
        /// <returns></returns>
        private static bool IsAmDong(Hao hao, CanChi nhatThan, CanChi nguyetKien)
        {
            if (nhatThan.Chi.Xung == hao.Chi)
            {
                if (nhatThan.IsVuongTuong(hao.Chi) || nguyetKien.IsVuongTuong(hao.Chi))
                {
                    return true;
                }
            }

            return false;
        }

        private static string GetDiaChiVaLucThanCuaHao(Hao hao, bool isHaoDong, bool isAmDong = false)
        {
            string result = "";

            if (isHaoDong)
            {
                if (hao.Duong)
                {
                    result += "o\t"; // Dương động biến âm.
                }
                else
                {
                    result += "x\t"; // Âm động biến dương.
                }
            }
            else
            {
                if (isAmDong)
                {
                    result += "+\t"; // Ám động.
                }
                else
                {
                    result += "\t";
                }
            }
            result += $"{hao.Chi.Name} {hao.Chi.Hanh.Name}    \t{hao.LucThan.Name}    \t";

            if (hao.The)
            {
                result += "THẾ\t";
            }
            else if (hao.Ung)
            {
                result += "ỨNG\t";
            }
            else
            {
                result += "\t";
            }

            return result;
        }

        private static string GetSuyVuongCuaHao(Hao hao, CanChi nhatThan, CanChi nguyetKien)
        {
            var result = "";
            if (nhatThan.IsLamKhong(hao.Chi))
            {
                result += ", lâm không";
            }

            // Nguyệt kiến
            if (nguyetKien.Chi.Xung == hao.Chi)
            {
                result += ", nguyệt phá";
            }
            else if (nguyetKien.Chi.Hop == hao.Chi)
            {
                result += ", nguyệt hợp";
            }

            if (nguyetKien.IsVuongTuong(hao.Chi))
            {
                result += ", nguyệt vượng";
            }
            else if (nguyetKien.IsHuuTu(hao.Chi))
            {
                result += ", nguyệt tù";
            }

            // Tháng thổ (thìn tuất sửu mùi) sẽ có hào gặp mộ.
            if (nguyetKien.Chi.Hanh == Tho)
            {
                if (VongTruongSinh.IsMo(hao.Chi.Hanh, nguyetKien.Chi))
                {
                    result += ", nguyệt mộ";
                }
            }

            // Nhật thần
            if (nhatThan.Chi.Xung == hao.Chi)
            {
                if (nhatThan.IsVuongTuong(hao.Chi) || nguyetKien.IsVuongTuong(hao.Chi))
                {
                    result += ", ám động";
                }
                else
                {
                    result += ", nhật phá";
                }
            }
            else
            {
                if (nhatThan.IsVuongTuong(hao.Chi))
                {
                    result += ", nhật vượng";
                }
                else if (nhatThan.IsHuuTu(hao.Chi))
                {
                    result += ", nhật tù";
                }
            }

            // Ngày thổ (thìn tuất sửu mùi) sẽ có hào gặp mộ.
            if (nhatThan.Chi.Hanh == Tho)
            {
                if (VongTruongSinh.IsMo(hao.Chi.Hanh, nhatThan.Chi))
                {
                    result += ", nhật mộ";
                }
            }

            return result;
        }

        /// <summary>
        /// Get que desc.
        /// </summary>
        /// <param name="queChu"></param>
        /// <param name="nhatThan"></param>
        /// <param name="nguyetKien"></param>
        /// <param name="isHao6Dong"></param>
        /// <param name="isHao5Dong"></param>
        /// <param name="isHao4Dong"></param>
        /// <param name="isHao3Dong"></param>
        /// <param name="isHao2Dong"></param>
        /// <param name="isHao1Dong"></param>
        /// <returns></returns>
        public static string GetQueBienDesc(this Que queBien, Que queChu,
                                            CanChi nhatThan, CanChi nguyetKien,
                                            bool isHao6Dong = false, bool isHao5Dong = false, bool isHao4Dong = false,
                                            bool isHao3Dong = false, bool isHao2Dong = false, bool isHao1Dong = false)
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{queBien.Name}, {queBien.Hanh.Name}{GetHopXungString(queBien)}");
            sb.AppendLine($"Ngày: {nhatThan.Name} ({nhatThan.Khong1.Name} {nhatThan.Khong2.Name} lâm không) - Tháng: {nguyetKien.Name}");
            sb.AppendLine();

            sb.AppendLine(GetHaoBienDesc(queBien.Hao6, queChu.Hao6, nhatThan, nguyetKien, isHao6Dong));
            sb.AppendLine(GetHaoBienDesc(queBien.Hao5, queChu.Hao5, nhatThan, nguyetKien, isHao5Dong));
            sb.AppendLine(GetHaoBienDesc(queBien.Hao4, queChu.Hao4, nhatThan, nguyetKien, isHao4Dong));
            sb.AppendLine(GetHaoBienDesc(queBien.Hao3, queChu.Hao3, nhatThan, nguyetKien, isHao3Dong));
            sb.AppendLine(GetHaoBienDesc(queBien.Hao2, queChu.Hao2, nhatThan, nguyetKien, isHao2Dong));
            sb.AppendLine(GetHaoBienDesc(queBien.Hao1, queChu.Hao1, nhatThan, nguyetKien, isHao1Dong));

            return sb.ToString();
        }

        private static string GetHaoBienDesc(Hao haoBien, Hao haoGoc, CanChi nhatThan, CanChi nguyetKien, bool isHaoDong)
        {
            var result = "";
            result = GetDiaChiVaLucThanCuaHao(haoBien, isHaoDong);

            if (!isHaoDong)
            {
                return result;
            }

            result += GetHaoBienExtraDesc(haoBien, haoGoc);

            result += GetSuyVuongCuaHao(haoBien, nhatThan, nguyetKien);

            return result;
        }

        private static string GetHaoBienExtraDesc(Hao haoBien, Hao haoGoc)
        {
            var result = "";
            if (haoBien.Hanh.Sinh == haoGoc.Hanh)
            {
                result += ", hồi đầu sinh";
            }
            else if (haoBien.Hanh.Khac == haoGoc.Hanh)
            {
                result += ", hồi đầu khắc";
            }

            if (haoBien.Chi.Xung == haoGoc.Chi)
            {
                result += ", hồi đầu xung";
            }
            if (VongTruongSinh.IsMo(haoBien.Chi.Hanh, haoGoc.Chi))
            {
                result += ", biến mộ";
            }

            if (haoBien.Chi == haoGoc.Chi.Tan)
            {
                result += ", tấn thần";
            }
            else if (haoBien.Chi == haoGoc.Chi.Thoai)
            {
                result += ", thoái thần";
            }

            return result;
        }

    }
}

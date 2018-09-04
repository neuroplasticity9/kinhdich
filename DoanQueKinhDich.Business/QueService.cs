using System;
using System.Text;
using KinhDichCommon;
using static KinhDichCommon.NguHanh;

namespace DoanQueKinhDich.Business
{
    public class QueService
    {
        private readonly IQue _que;

        public Que QueChu { get; }
        public Que QueBien { get; }

        public QueService(IQue que)
        {
            _que = que;

            QueChu = QueDich.GetQue(que.Hao6, que.Hao5, que.Hao4, que.Hao3, que.Hao2, que.Hao1);

            if (CoQueBien(que))
            {
                QueBien = QueDich.GetQueBien(QueChu, que.Hao6Dong, que.Hao5Dong, que.Hao4Dong, que.Hao3Dong, que.Hao2Dong, que.Hao1Dong);
            }

        }

        /// <summary>
        /// Nếu trong 6 hào có 1 hào động thì ta có quẻ biến.
        /// </summary>
        /// <param name="que"></param>
        /// <returns></returns>
        private bool CoQueBien(IQue que)
        {
            return que.Hao6Dong || que.Hao5Dong || que.Hao4Dong || que.Hao3Dong || que.Hao2Dong || que.Hao1Dong;
        }

        public string GetQueDesc()
        {
            return GetQueDesc(QueChu, _que.NgayAm, _que.ThangAm,
                              _que.Hao6Dong, _que.Hao5Dong, _que.Hao4Dong,
                              _que.Hao3Dong, _que.Hao2Dong, _que.Hao1Dong);
        }

        public string GetQueChuVaQueBienDesc()
        {
            return GetQueChuVaQueBienDesc(QueChu, QueBien, _que.NgayAm, _que.ThangAm,
                                          _que.Hao6Dong, _que.Hao5Dong, _que.Hao4Dong,
                                          _que.Hao3Dong, _que.Hao2Dong, _que.Hao1Dong);
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
        private string GetQueDesc(Que queChu, 
                                    CanChi nhatThan, CanChi nguyetKien,
                                    bool isHao6Dong = false, bool isHao5Dong = false, bool isHao4Dong = false,
                                    bool isHao3Dong = false, bool isHao2Dong = false, bool isHao1Dong = false)
        {
            var sb = new StringBuilder();

            sb.AppendLine(GetNgayThang(nhatThan, nguyetKien));
            sb.AppendLine();
            sb.AppendLine(GetTenQue(queChu));
            sb.AppendLine();

            sb.AppendLine(GetHaoDesc(queChu.Hao6, nhatThan, nguyetKien, isHao6Dong));
            sb.AppendLine(GetHaoDesc(queChu.Hao5, nhatThan, nguyetKien, isHao5Dong));
            sb.AppendLine(GetHaoDesc(queChu.Hao4, nhatThan, nguyetKien, isHao4Dong));
            sb.AppendLine(GetHaoDesc(queChu.Hao3, nhatThan, nguyetKien, isHao3Dong));
            sb.AppendLine(GetHaoDesc(queChu.Hao2, nhatThan, nguyetKien, isHao2Dong));
            sb.AppendLine(GetHaoDesc(queChu.Hao1, nhatThan, nguyetKien, isHao1Dong));

            sb.AppendLine();
            sb.AppendLine(GetHaoPhucDesc(queChu));
            sb.AppendLine();
            sb.AppendLine(GetTamHopCuc(queChu));

            return sb.ToString();
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
        private string GetQueChuVaQueBienDesc(Que queChu, Que queBien,
                                                CanChi nhatThan, CanChi nguyetKien,
                                                bool isHao6Dong = false, bool isHao5Dong = false, bool isHao4Dong = false,
                                                bool isHao3Dong = false, bool isHao2Dong = false, bool isHao1Dong = false)
        {
            var padRight = 80;
            var sb = new StringBuilder();

            sb.AppendLine(GetNgayThang(nhatThan, nguyetKien));
            sb.AppendLine();

            sb.Append(GetTenQue(queChu).PadRight(padRight));
            sb.Append(GetTenQue(queBien));
            sb.AppendLine();
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu.Hao6, nhatThan, nguyetKien, isHao6Dong).PadRight(padRight));
            sb.Append(GetHaoBienDesc(queBien.Hao6, queChu.Hao6, nhatThan, nguyetKien, isHao6Dong));
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu.Hao5, nhatThan, nguyetKien, isHao5Dong).PadRight(padRight));
            sb.Append(GetHaoBienDesc(queBien.Hao5, queChu.Hao5, nhatThan, nguyetKien, isHao5Dong));
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu.Hao4, nhatThan, nguyetKien, isHao4Dong).PadRight(padRight));
            sb.Append(GetHaoBienDesc(queBien.Hao4, queChu.Hao4, nhatThan, nguyetKien, isHao4Dong));
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu.Hao3, nhatThan, nguyetKien, isHao3Dong).PadRight(padRight));
            sb.Append(GetHaoBienDesc(queBien.Hao3, queChu.Hao3, nhatThan, nguyetKien, isHao3Dong));
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu.Hao2, nhatThan, nguyetKien, isHao2Dong).PadRight(padRight));
            sb.Append(GetHaoBienDesc(queBien.Hao2, queChu.Hao2, nhatThan, nguyetKien, isHao2Dong));
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu.Hao1, nhatThan, nguyetKien, isHao1Dong).PadRight(padRight));
            sb.Append(GetHaoBienDesc(queBien.Hao1, queChu.Hao1, nhatThan, nguyetKien, isHao1Dong));
            sb.AppendLine();

            sb.AppendLine();
            sb.AppendLine(GetHaoPhucDesc(queChu));
            sb.AppendLine();
            sb.AppendLine(GetTamHopCuc(queChu));

            return sb.ToString();
        }

        #region "Private methods"

        private string GetHaoPhucDesc(Que que)
        {
            if (que.ViTriHaoPhuc != ViTriHao.None)
            {
                return $"{que.HaoPhuc.LucThan.Name} {que.HaoPhuc.Chi.Name} {que.HaoPhuc.Hanh.Name} phục thần ở hào {(int)que.ViTriHaoPhuc}.";
            }

            return "";
        }

        private string GetNgayThang(CanChi nhatThan, CanChi nguyetKien)
        {
            return $"Tháng: {nguyetKien.Name} - Ngày: {nhatThan.Name} ({nhatThan.Khong1.Name} {nhatThan.Khong2.Name} lâm không)";
        }

        private string GetTenQue(Que que)
        {
            return $"   {que.Name} ({que.Desc}), {que.HanhQueThuan.Name}{GetHopXungString(que)}, trên {que.NgoaiQuai.Name} dưới {que.NoiQuai.Name}";
        }

        private string GetTamHopCuc(Que que)
        {
            if (que.IsThuyCuc())
            {
                return "Thân Tí Thìn hợp thành Thủy cục.";
            }
            if (que.IsMocCuc())
            {
                return "Hợi Mão Mùi hợp thành Mộc cục.";
            }
            if (que.IsHoaCuc())
            {
                return "Dần Ngọ Tuất hợp thành Hỏa cục.";
            }
            if (que.IsKimCuc())
            {
                return "Tỵ Dậu Sửu hợp thành Kim cục.";
            }

            return "";
        }

        private string GetHopXungString(Que que)
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

        private string GetHaoDesc(Hao hao, CanChi nhatThan, CanChi nguyetKien, bool isHaoDong)
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
        private bool IsAmDong(Hao hao, CanChi nhatThan, CanChi nguyetKien)
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

        private string GetDiaChiVaLucThanCuaHao(Hao hao, bool isHaoDong, bool isAmDong = false)
        {
            string result = "";
            if (isHaoDong)
            {
                if (hao.Duong)
                {
                    result = "o"; // Dương động biến âm.
                }
                else
                {
                    result += "x"; // Âm động biến dương.
                }
            }
            else
            {
                if (isAmDong)
                {
                    result += "+"; // Ám động.
                }
            }

            result = result.PadRight(3);

            result += $"{hao.Chi.Name} {hao.Chi.Hanh.Name}";
            result = result.PadRight(13);

            result += $"{hao.AmDuongString}";
            result = result.PadRight(18);
            
            result += $"{hao.LucThan.Name}";
            result = result.PadRight(28);

            if (hao.The)
            {
                result += "THẾ";
            }
            else if (hao.Ung)
            {
                result += "ỨNG";
            }
            else
            {
                result += "   ";
            }

            return result;
        }

        private string GetSuyVuongCuaHao(Hao hao, CanChi nhatThan, CanChi nguyetKien)
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

            if (nguyetKien.Chi  == hao.Chi)
            {
                result += ", nguyệt kiến";
            }
            else if (nguyetKien.IsVuongTuong(hao.Chi))
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
            if (nhatThan.Chi == hao.Chi)
            {
                result += ", nhật kiến";
            }
            else if (nhatThan.Chi.Xung == hao.Chi)
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

        private string GetHaoBienDesc(Hao haoBien, Hao haoGoc, CanChi nhatThan, CanChi nguyetKien, bool isHaoDong)
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

        private string GetHaoBienExtraDesc(Hao haoBien, Hao haoGoc)
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

        #endregion

    }
}
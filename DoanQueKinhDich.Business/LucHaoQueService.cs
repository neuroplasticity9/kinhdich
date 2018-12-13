using System;
using System.Collections.Generic;
using System.Text;
using KinhDichCommon;
using static KinhDichCommon.NguHanh;

namespace DoanQueKinhDich.Business
{
    public class LucHaoQueService : QueService
    {
        public LucHaoQueService(IQueLayDuoc que) : base(que)
        {
        }

        public override string GetQueDesc()
        {
            return GetQueChuVaQueBienDesc(QueChu, QueBien, Que.NgayLayQue, Que.CachLayQue,
                                          Que.Hao6Dong, Que.Hao5Dong, Que.Hao4Dong,
                                          Que.Hao3Dong, Que.Hao2Dong, Que.Hao1Dong);
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
        private string GetQueChuVaQueBienDesc(Que queChu, Que queBien, NgayLayQue ngayLayQue, CachLayQue cachLayQue,
                                              bool isHao6Dong = false, bool isHao5Dong = false, bool isHao4Dong = false,
                                              bool isHao3Dong = false, bool isHao2Dong = false, bool isHao1Dong = false)
        {
            var nhatThan = ngayLayQue.NgayAm;
            var nguyetKien = ngayLayQue.ThangAm;
            var lucThu = LucThu.GetLucThuList(nhatThan.Can);

            var padRight = 94;
            var sb = new StringBuilder();

            sb.AppendLine(GetNgayThang(ngayLayQue, cachLayQue));
            sb.AppendLine();

            sb.Append("   QUẺ CHỦ".PadRight(padRight));
            sb.Append(queBien != null ? "   QUẺ BIẾN" : "");
            sb.AppendLine();

            sb.Append(GetTenQueLucHao(queChu).PadRight(padRight));
            sb.Append(GetTenQueLucHao(queBien));
            sb.AppendLine();

            sb.Append(GetCachCuaQue(queChu).PadRight(padRight));
            sb.Append(GetCachCuaQue(queBien));
            sb.AppendLine();
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu.Hao6, isHao6Dong, nhatThan, nguyetKien, lucThu).PadRight(padRight));
            sb.Append(queBien != null ? GetHaoBienDesc(queBien.Hao6, queChu.Hao6, isHao6Dong, nhatThan, nguyetKien) : "");
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu.Hao5, isHao5Dong, nhatThan, nguyetKien, lucThu).PadRight(padRight));
            sb.Append(queBien != null ? GetHaoBienDesc(queBien.Hao5, queChu.Hao5, isHao5Dong, nhatThan, nguyetKien) : "");
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu.Hao4, isHao4Dong, nhatThan, nguyetKien, lucThu).PadRight(padRight));
            sb.Append(queBien != null ? GetHaoBienDesc(queBien.Hao4, queChu.Hao4, isHao4Dong, nhatThan, nguyetKien) : "");
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu.Hao3, isHao3Dong, nhatThan, nguyetKien, lucThu).PadRight(padRight));
            sb.Append(queBien != null ? GetHaoBienDesc(queBien.Hao3, queChu.Hao3, isHao3Dong, nhatThan, nguyetKien) : "");
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu.Hao2, isHao2Dong, nhatThan, nguyetKien, lucThu).PadRight(padRight));
            sb.Append(queBien != null ? GetHaoBienDesc(queBien.Hao2, queChu.Hao2, isHao2Dong, nhatThan, nguyetKien) : "");
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu.Hao1, isHao1Dong, nhatThan, nguyetKien, lucThu).PadRight(padRight));
            sb.Append(queBien != null ? GetHaoBienDesc(queBien.Hao1, queChu.Hao1, isHao1Dong, nhatThan, nguyetKien) : "");
            sb.AppendLine();

            sb.AppendLine();
            sb.AppendLine(GetHaoPhucDesc(queChu));
            sb.AppendLine();
            sb.AppendLine(GetTamHopCuc(queChu));
            sb.AppendLine();

            return sb.ToString();
        }

        private string GetHaoDesc(Hao hao, bool isHaoDong, CanChi nhatThan, CanChi nguyetKien, List<LucThu> lucThan)
        {
            var result = "";
            var isAmDong = IsAmDong(hao, nhatThan, nguyetKien);

            result += GetDiaChiVaLucThanCuaHao(hao, isHaoDong, lucThan, isAmDong);
            result += GetSuyVuongCuaHao(hao, nhatThan, nguyetKien);

            return result;
        }

        private string GetHaoBienDesc(Hao haoBien, Hao haoGoc, bool isHaoDong, CanChi nhatThan, CanChi nguyetKien)
        {
            var result = "";
            result = GetDiaChiVaLucThanCuaHao(haoBien, isHaoDong, null);

            if (!isHaoDong)
            {
                return result;
            }

            result += GetHaoBienExtraDesc(haoBien, haoGoc);

            result += GetSuyVuongCuaHao(haoBien, nhatThan, nguyetKien);

            return result;
        }

        private string GetDiaChiVaLucThanCuaHao(Hao hao, bool isHaoDong, List<LucThu> lucThan, bool isAmDong = false)
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
                    result = "x"; // Âm động biến dương.
                }
            }
            else
            {
                if (isAmDong)
                {
                    result = "+"; // Ám động.
                }
            }

            result = result.PadRight(3);

            result += $"{hao.Chi.Name} {hao.Chi.NguHanh.Name}";
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

            if (lucThan != null)
            {
                result += $", {lucThan[hao.Id - 1].Name}";
                result = result.PadRight(43);
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

            if (nguyetKien.Chi == hao.Chi)
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
            if (nguyetKien.Chi.NguHanh == Tho)
            {
                if (VongTruongSinh.IsMo(hao.Chi.NguHanh, nguyetKien.Chi))
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
            if (nhatThan.Chi.NguHanh == Tho)
            {
                if (VongTruongSinh.IsMo(hao.Chi.NguHanh, nhatThan.Chi))
                {
                    result += ", nhật mộ";
                }
            }

            return result;
        }

        private string GetHaoBienExtraDesc(Hao haoBien, Hao haoGoc)
        {
            var result = "";
            if (haoBien.NguHanh.Sinh == haoGoc.NguHanh)
            {
                result += ", hồi đầu sinh";
            }
            else if (haoBien.NguHanh.Khac == haoGoc.NguHanh)
            {
                result += ", hồi đầu khắc";
            }

            if (haoBien.Chi.Xung == haoGoc.Chi)
            {
                result += ", hồi đầu xung";
            }
            if (VongTruongSinh.IsMo(haoBien.Chi.NguHanh, haoGoc.Chi))
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


        private string GetHaoPhucDesc(Que que)
        {
            if (que.ViTriHaoPhuc != ViTriHao.None)
            {
                return $"{que.HaoPhuc.LucThan.Name} {que.HaoPhuc.Chi.Name} {que.HaoPhuc.NguHanh.Name} phục thần ở hào {(int)que.ViTriHaoPhuc}.";
            }

            return "";
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


        protected string GetTamHopCuc(Que que)
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

    }
}
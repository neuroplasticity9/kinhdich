using System;
using System.Text;
using KinhDichCommon;
using static KinhDichCommon.NguHanh;

namespace DoanQueKinhDich.Business
{
    public class QueService
    {
        private readonly IQueLayDuoc _que;

        public Que QueChu { get; }
        public Que QueHo { get; }
        public Que QueBien { get; }
               
        public QueService(IQueLayDuoc que)
        {
            _que = que;

            QueChu = QueDich.GetQue(que.Hao6, que.Hao5, que.Hao4, que.Hao3, que.Hao2, que.Hao1);

            QueHo = QueDich.GetQue(que.Hao5, que.Hao4, que.Hao3, que.Hao4, que.Hao3, que.Hao2);

            if (que.CoQueBien())
            {
                QueBien = QueDich.GetQueBien(QueChu, que.Hao6Dong, que.Hao5Dong, que.Hao4Dong, que.Hao3Dong, que.Hao2Dong, que.Hao1Dong);
            }

        }

        public string GetLucHaoDesc(CanChi nhatThan, CanChi nguyetKien)
        {
            if (!_que.CoQueBien())
            {
                return GetQueDesc(QueChu, _que.NgayLayQue, _que.CachLayQue,
                                  _que.Hao6Dong, _que.Hao5Dong, _que.Hao4Dong,
                                  _que.Hao3Dong, _que.Hao2Dong, _que.Hao1Dong);
            }
            else
            {
                return GetQueChuVaQueBienDesc(QueChu, QueBien, _que.NgayLayQue, _que.CachLayQue,
                                              _que.Hao6Dong, _que.Hao5Dong, _que.Hao4Dong,
                                              _que.Hao3Dong, _que.Hao2Dong, _que.Hao1Dong);
            }

        }

        public string GetMaiHoaDesc(CanChi nhatThan, CanChi nguyetKien)
        {
            if (!_que.CoQueBien())
            {
                return GetQueDesc(QueChu, _que.NgayLayQue, _que.CachLayQue,
                                  _que.Hao6Dong, _que.Hao5Dong, _que.Hao4Dong,
                                  _que.Hao3Dong, _que.Hao2Dong, _que.Hao1Dong);
            }
            else
            {
                return GetQueChuQueHoQueBienDesc(QueChu, QueBien, QueHo, _que.NgayLayQue, _que.CachLayQue,
                                              _que.Hao6Dong, _que.Hao5Dong, _que.Hao4Dong,
                                              _que.Hao3Dong, _que.Hao2Dong, _que.Hao1Dong);
            }
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
        private string GetQueDesc(Que queChu, NgayLayQue ngayLayQue, CachLayQue cachLayQue,
                                  bool isHao6Dong = false, bool isHao5Dong = false, bool isHao4Dong = false,
                                  bool isHao3Dong = false, bool isHao2Dong = false, bool isHao1Dong = false)
        {
            var nhatThan = ngayLayQue.NgayAm;
            var nguyetKien = ngayLayQue.ThangAm;

            var sb = new StringBuilder();

            sb.AppendLine(GetNgayThang(ngayLayQue, cachLayQue));
            sb.AppendLine();
            sb.Append(GetTenQueLong(queChu));
            sb.AppendLine();
            sb.Append(GetChiChuCuaQue(queChu));
            sb.AppendLine();
            sb.AppendLine();

            sb.AppendLine(GetHaoDesc(queChu.Hao6, isHao6Dong, nhatThan, nguyetKien));
            sb.AppendLine(GetHaoDesc(queChu.Hao5, isHao5Dong, nhatThan, nguyetKien));
            sb.AppendLine(GetHaoDesc(queChu.Hao4, isHao4Dong, nhatThan, nguyetKien));
            sb.AppendLine(GetHaoDesc(queChu.Hao3, isHao3Dong, nhatThan, nguyetKien));
            sb.AppendLine(GetHaoDesc(queChu.Hao2, isHao2Dong, nhatThan, nguyetKien));
            sb.AppendLine(GetHaoDesc(queChu.Hao1, isHao1Dong, nhatThan, nguyetKien));

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
        private string GetQueChuVaQueBienDesc(Que queChu, Que queBien, NgayLayQue ngayLayQue, CachLayQue cachLayQue,
                                                bool isHao6Dong = false, bool isHao5Dong = false, bool isHao4Dong = false,
                                                bool isHao3Dong = false, bool isHao2Dong = false, bool isHao1Dong = false)
        {
            var nhatThan = ngayLayQue.NgayAm;
            var nguyetKien = ngayLayQue.ThangAm;

            var padRight = 80;
            var sb = new StringBuilder();

            sb.AppendLine(GetNgayThang(ngayLayQue, cachLayQue));
            sb.AppendLine();

            sb.Append(GetTenQueLong(queChu).PadRight(padRight));
            sb.Append(GetTenQueLong(queBien));
            sb.AppendLine();
            sb.Append(GetChiChuCuaQue(queChu).PadRight(padRight));
            sb.Append(GetChiChuCuaQue(queBien));
            sb.AppendLine();
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu.Hao6, isHao6Dong, nhatThan, nguyetKien).PadRight(padRight));
            sb.Append(GetHaoBienDesc(queBien.Hao6, queChu.Hao6, isHao6Dong, nhatThan, nguyetKien));
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu.Hao5, isHao5Dong, nhatThan, nguyetKien).PadRight(padRight));
            sb.Append(GetHaoBienDesc(queBien.Hao5, queChu.Hao5, isHao5Dong, nhatThan, nguyetKien));
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu.Hao4, isHao4Dong, nhatThan, nguyetKien).PadRight(padRight));
            sb.Append(GetHaoBienDesc(queBien.Hao4, queChu.Hao4, isHao4Dong, nhatThan, nguyetKien));
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu.Hao3, isHao3Dong, nhatThan, nguyetKien).PadRight(padRight));
            sb.Append(GetHaoBienDesc(queBien.Hao3, queChu.Hao3, isHao3Dong, nhatThan, nguyetKien));
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu.Hao2, isHao2Dong, nhatThan, nguyetKien).PadRight(padRight));
            sb.Append(GetHaoBienDesc(queBien.Hao2, queChu.Hao2, isHao2Dong, nhatThan, nguyetKien));
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu.Hao1, isHao1Dong, nhatThan, nguyetKien).PadRight(padRight));
            sb.Append(GetHaoBienDesc(queBien.Hao1, queChu.Hao1, isHao1Dong, nhatThan, nguyetKien));
            sb.AppendLine();

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
        private string GetQueChuQueHoQueBienDesc(Que queChu, Que queBien, Que queHo, NgayLayQue ngayLayQue, CachLayQue cachLayQue,
                                                    bool isHao6Dong = false, bool isHao5Dong = false, bool isHao4Dong = false,
                                                    bool isHao3Dong = false, bool isHao2Dong = false, bool isHao1Dong = false)
        {
            var nhatThan = ngayLayQue.NgayAm;
            var nguyetKien = ngayLayQue.ThangAm;

            var padRight = 50;
            var sb = new StringBuilder();

            sb.AppendLine(GetNgayThang(ngayLayQue, cachLayQue));
            sb.AppendLine();

            sb.Append(GetTenQueShort(queChu).PadRight(padRight));
            sb.Append(GetTenQueShort(queHo).PadRight(padRight));
            sb.Append(GetTenQueShort(queBien));
            sb.AppendLine();
            sb.Append(GetChiChuCuaQue(queChu).PadRight(padRight));
            sb.Append(GetChiChuCuaQue(queHo).PadRight(padRight));
            sb.Append(GetChiChuCuaQue(queBien));
            sb.AppendLine();
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu.Hao6, isHao6Dong).PadRight(padRight));
            sb.Append(GetHaoDesc(queHo.Hao6, false).PadRight(padRight));
            sb.Append(GetHaoDesc(queBien.Hao6, isHao6Dong));
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu.Hao5, isHao5Dong).PadRight(padRight));
            sb.Append(GetHaoDesc(queHo.Hao5, false).PadRight(padRight));
            sb.Append(GetHaoDesc(queBien.Hao5, isHao5Dong));
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu.Hao4, isHao4Dong).PadRight(padRight));
            sb.Append(GetHaoDesc(queHo.Hao4, false).PadRight(padRight));
            sb.Append(GetHaoDesc(queBien.Hao4, isHao4Dong));
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu.Hao3, isHao3Dong).PadRight(padRight));
            sb.Append(GetHaoDesc(queHo.Hao3, false).PadRight(padRight));
            sb.Append(GetHaoDesc(queBien.Hao3, isHao3Dong));
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu.Hao2, isHao2Dong).PadRight(padRight));
            sb.Append(GetHaoDesc(queHo.Hao2, false).PadRight(padRight));
            sb.Append(GetHaoDesc(queBien.Hao2, isHao2Dong));
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu.Hao1, isHao1Dong).PadRight(padRight));
            sb.Append(GetHaoDesc(queHo.Hao1, false).PadRight(padRight));
            sb.Append(GetHaoDesc(queBien.Hao1, isHao1Dong));

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

        private string GetNgayThang(NgayLayQue ngayLayQue, CachLayQue cachLayQue)
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

        private string GetTenQueLong(Que que)
        {
            return $"   {que.Name} ({que.HanhQueThuan.Name}), {que.NgoaiQuai.Name} {que.NgoaiQuai.Hanh.Name} / {que.NoiQuai.Name} {que.NoiQuai.Hanh.Name}{GetHopXungString(que)}";
        }

        private string GetTenQueShort(Que que)
        {
            return $"   {que.Name} ({que.HanhQueThuan.Name}), {que.NgoaiQuai.Name} {que.NgoaiQuai.Hanh.Name} / {que.NoiQuai.Name} {que.NoiQuai.Hanh.Name}";
        }

        private string GetChiChuCuaQue(Que que)
        {
            return $"   {que.Desc}";
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

        private string GetHaoDesc(Hao hao, bool isHaoDong, CanChi nhatThan, CanChi nguyetKien)
        {
            var result = "";
            var isAmDong = IsAmDong(hao, nhatThan, nguyetKien);

            result += GetDiaChiVaLucThanCuaHao(hao, isHaoDong, isAmDong);
            result += GetSuyVuongCuaHao(hao, nhatThan, nguyetKien);

            return result;
        }

        private string GetHaoDesc(Hao hao, bool isHaoDong)
        {
            return GetDiaChiVaLucThanCuaHao(hao, isHaoDong);
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

        private string GetHaoBienDesc(Hao haoBien, Hao haoGoc, bool isHaoDong, CanChi nhatThan, CanChi nguyetKien)
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
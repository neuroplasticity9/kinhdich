using KinhDichCommon;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoanQueKinhDich.Business
{
    public class VietDichQueService : QueService
    {
        public Que QueChuDoiDai { get; }
        public Que QueHoDoiDai { get; }
        public Que QueBienDoiDai { get; }

        public VietDichQueService(IQueLayDuoc que) : base(que)
        {
            QueChuDoiDai = KinhDichCommon.Que.GetQueDoiDai(QueChu);

            QueHoDoiDai = KinhDichCommon.Que.GetQueHo(QueChuDoiDai);

            if (que.CoQueBien())
            {
                QueBienDoiDai = KinhDichCommon.Que.GetQueDoiDai(QueBien);
            }
        }

        public override string GetQueDesc()
        {
            return GetQueChuQueHoQueBienDesc(QueChu, QueBien, QueHo, Que.NgayLayQue, Que.CachLayQue,
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
        private string GetQueChuQueHoQueBienDesc(Que queChu, Que queBien, Que queHo, NgayLayQue ngayLayQue, CachLayQue cachLayQue,
                                                     bool isHao6Dong = false, bool isHao5Dong = false, bool isHao4Dong = false,
                                                     bool isHao3Dong = false, bool isHao2Dong = false, bool isHao1Dong = false)
        {
            var nhatThan = ngayLayQue.NgayAm;
            var nguyetKien = ngayLayQue.ThangAm;
            var lucThan = LucThu.GetLucThuList(nhatThan.Can);

            var padRight = 25;
            var sb = new StringBuilder();

            sb.AppendLine(GetNgayThang(ngayLayQue, cachLayQue));
            sb.AppendLine();
            AddLongHR(padRight, sb);

            AddBodyDesc(queChu, queHo, queBien, isHao6Dong, isHao5Dong, isHao4Dong, isHao3Dong, isHao2Dong, isHao1Dong, sb, padRight, true, lucThan);
            sb.AppendLine();
            sb.AppendLine();
            AddLongHR(padRight, sb);

            AddYNghia(queChu, queHo, queBien, sb, padRight);
            AddLongHR(padRight, sb);

            //AddBodyDesc(QueChuDoiDai, QueHoDoiDai, QueBienDoiDai, isHao1Dong, isHao2Dong, isHao3Dong, isHao4Dong, isHao5Dong, isHao6Dong, sb, padRight, false, null);
            //sb.AppendLine();
            //sb.AppendLine();
            //AddLongHR(padRight, sb);

            AddTuongVaYNghiaCuaQue(sb, queChu, queHo, queBien);
            //AddLongHR(padRight, sb);
            //AddTuongQue(sb, QueChuDoiDai, QueHoDoiDai, QueBienDoiDai);

            return sb.ToString();
        }

        private void AddYNghia(Que queChu, Que queHo, Que queBien, StringBuilder sb, int padRight)
        {
            sb.Append("\t" + queChu.YNghiaNgan.PadRight(padRight));
            sb.Append(queHo.YNghiaNgan.PadRight(padRight));
            sb.Append(queBien != null ? queBien.YNghiaNgan : "");
            sb.AppendLine();
        }

        private void AddBodyDesc(Que queChu, Que queHo, Que queBien, bool isHao6Dong, bool isHao5Dong, bool isHao4Dong, bool isHao3Dong, bool isHao2Dong, bool isHao1Dong, StringBuilder sb, int padRight, bool addQueTheDungBienDesc, List<LucThu> lucThan)
        {
            sb.Append(GetTenQueVietDich(queChu).PadRight(padRight));
            sb.Append(GetTenQueVietDich(queHo).PadRight(padRight));
            sb.Append(GetTenQueVietDich(queBien));
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu, queChu.Hao6, isHao6Dong, addQueTheDungBienDesc, lucThan).PadRight(padRight));
            sb.Append(GetHaoDesc(queHo, queHo.Hao6, false, addQueTheDungBienDesc, lucThan).PadRight(padRight));
            sb.Append(queBien != null ? GetHaoDesc(queBien, queBien.Hao6, isHao6Dong, addQueTheDungBienDesc, lucThan) : "");
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu, queChu.Hao5, isHao5Dong, addQueTheDungBienDesc, lucThan).PadRight(padRight));
            sb.Append(GetHaoDesc(queHo, queHo.Hao5, false, addQueTheDungBienDesc, lucThan).PadRight(padRight));
            sb.Append(queBien != null ? GetHaoDesc(queBien, queBien.Hao5, isHao5Dong, addQueTheDungBienDesc, lucThan) : "");
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu, queChu.Hao4, isHao4Dong, addQueTheDungBienDesc, lucThan).PadRight(padRight));
            sb.Append(GetHaoDesc(queHo, queHo.Hao4, false, addQueTheDungBienDesc, lucThan).PadRight(padRight));
            sb.Append(queBien != null ? GetHaoDesc(queBien, queBien.Hao4, isHao4Dong, addQueTheDungBienDesc, lucThan) : "");
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu, queChu.Hao3, isHao3Dong, addQueTheDungBienDesc, lucThan).PadRight(padRight));
            sb.Append(GetHaoDesc(queHo, queHo.Hao3, false, addQueTheDungBienDesc, lucThan).PadRight(padRight));
            sb.Append(queBien != null ? GetHaoDesc(queBien, queBien.Hao3, isHao3Dong, addQueTheDungBienDesc, lucThan) : "");
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu, queChu.Hao2, isHao2Dong, addQueTheDungBienDesc, lucThan).PadRight(padRight));
            sb.Append(GetHaoDesc(queHo, queHo.Hao2, false, addQueTheDungBienDesc, lucThan).PadRight(padRight));
            sb.Append(queBien != null ? GetHaoDesc(queBien, queBien.Hao2, isHao2Dong, addQueTheDungBienDesc, lucThan) : "");
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu, queChu.Hao1, isHao1Dong, addQueTheDungBienDesc, lucThan).PadRight(padRight));
            sb.Append(GetHaoDesc(queHo, queHo.Hao1, false, addQueTheDungBienDesc, lucThan).PadRight(padRight));
            sb.Append(queBien != null ? GetHaoDesc(queBien, queBien.Hao1, isHao1Dong, addQueTheDungBienDesc, lucThan) : "");
        }

        protected string GetHaoDesc(Que que, Hao hao, bool isHaoDong, bool addQueTheDungBienDesc, List<LucThu> lucThan)
        {
            if (que == null)
            {
                return "";
            }

            string result = "\t";
            if (isHaoDong)
            {
                if (hao.Duong)
                {
                    result = "o\t"; // Dương động biến âm.
                }
                else
                {
                    result = "x\t"; // Âm động biến dương.
                }
            }
            //result = result.PadRight(3);

            result += $"{hao.AmDuongString}";
            result = result.PadRight(18);

            return result;
        }

    }
}
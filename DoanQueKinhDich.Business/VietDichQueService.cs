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

            var columnLen = DescColumnLen;
            var sb = new StringBuilder();

            sb.AppendLine();
            sb.AppendLine(GetNgayThang(ngayLayQue, cachLayQue));
            sb.AppendLine();

            AddLongHR(columnLen, sb);
            AddBodyDesc(queChu, queHo, queBien, isHao6Dong, isHao5Dong, isHao4Dong, isHao3Dong, isHao2Dong, isHao1Dong, sb, columnLen);
            sb.AppendLine();

            AddLongHR(columnLen, sb);
            AddTuongVaYNghiaCuaQue(sb, queChu, queHo, queBien);

            sb.AppendLine();
            sb.AppendLine();
            AddBodyDesc(QueChuDoiDai, QueHoDoiDai, QueBienDoiDai, isHao1Dong, isHao2Dong, isHao3Dong, isHao4Dong, isHao5Dong, isHao6Dong, sb, columnLen);
            sb.AppendLine();
            AddLongHR(columnLen, sb);
            AddTuongVaYNghiaCuaQue(sb, QueChuDoiDai, QueHoDoiDai, QueBienDoiDai);

            return sb.ToString();
        }

        private void AddBodyDesc(Que queChu, Que queHo, Que queBien, bool isHao6Dong, bool isHao5Dong, bool isHao4Dong, bool isHao3Dong, bool isHao2Dong, bool isHao1Dong, StringBuilder sb, int padRight)
        {
            var queChuList = GetListStringInQue(queChu, isHao6Dong, isHao5Dong, isHao4Dong, isHao3Dong, isHao2Dong, isHao1Dong);

            var queHoList = GetListStringInQue(queHo);

            var queBienList = GetListStringInQue(queBien, isHao6Dong, isHao5Dong, isHao4Dong, isHao3Dong, isHao2Dong, isHao1Dong);

            AddTextTo3Columns(sb, queChuList, queHoList, queBienList, DescColumnLen);
        }

        private List<string> GetListStringInQue(Que que, bool isHao6Dong = false, bool isHao5Dong = false, bool isHao4Dong = false, bool isHao3Dong = false, bool isHao2Dong = false, bool isHao1Dong = false)
        {
            var list = new List<string>();

            if (que != null)
            {
                list.Add(GetTenQueVietDich(que));
                list.Add(GetHaoDesc(que, que.Hao6, isHao6Dong));
                list.Add(GetHaoDesc(que, que.Hao5, isHao5Dong));
                list.Add(GetHaoDesc(que, que.Hao4, isHao4Dong));
                list.Add(GetHaoDesc(que, que.Hao3, isHao3Dong));
                list.Add(GetHaoDesc(que, que.Hao2, isHao2Dong));
                list.Add(GetHaoDesc(que, que.Hao1, isHao1Dong));

                list.Add(que.YNghiaNgan);
            }

            return list;
        }

        protected string GetHaoDesc(Que que, Hao hao, bool isHaoDong)
        {
            if (que == null)
            {
                return "";
            }

            string result = "";

            result += $"{hao.AmDuongString}";
            if (isHaoDong)
            {
                if (hao.Duong)
                {
                    result += " o"; // Dương động biến âm.
                }
                else
                {
                    result += " x"; // Âm động biến dương.
                }
            }

            return result;
        }

    }
}
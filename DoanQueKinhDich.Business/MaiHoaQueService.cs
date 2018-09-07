using KinhDichCommon;
using System;
using System.Text;

namespace DoanQueKinhDich.Business
{
    public class MaiHoaQueService : QueService
    {

        public MaiHoaQueService(IQueLayDuoc que) : base(que)
        {
        }

        public override string GetQueDesc()
        {
            return GetMaiHoaDesc();
        }

        public string GetMaiHoaDesc()
        {
            if (!QueLayDuoc.CoQueBien())
            {
                return GetQueDesc(QueChu, QueLayDuoc.NgayLayQue, QueLayDuoc.CachLayQue,
                                  QueLayDuoc.Hao6Dong, QueLayDuoc.Hao5Dong, QueLayDuoc.Hao4Dong,
                                  QueLayDuoc.Hao3Dong, QueLayDuoc.Hao2Dong, QueLayDuoc.Hao1Dong);
            }
            else
            {
                return GetQueChuQueHoQueBienDesc(QueChu, QueBien, QueHo, QueLayDuoc.NgayLayQue, QueLayDuoc.CachLayQue,
                                                 QueLayDuoc.Hao6Dong, QueLayDuoc.Hao5Dong, QueLayDuoc.Hao4Dong,
                                                 QueLayDuoc.Hao3Dong, QueLayDuoc.Hao2Dong, QueLayDuoc.Hao1Dong);
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
        protected string GetQueDesc(Que queChu, NgayLayQue ngayLayQue, CachLayQue cachLayQue,
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

            sb.AppendLine(GetHaoDesc(queChu.Hao6, isHao6Dong));
            sb.AppendLine(GetHaoDesc(queChu.Hao5, isHao5Dong));
            sb.AppendLine(GetHaoDesc(queChu.Hao4, isHao4Dong));
            sb.AppendLine(GetHaoDesc(queChu.Hao3, isHao3Dong));
            sb.AppendLine(GetHaoDesc(queChu.Hao2, isHao2Dong));
            sb.AppendLine(GetHaoDesc(queChu.Hao1, isHao1Dong));

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

        protected string GetHaoDesc(Hao hao, bool isHaoDong)
        {
            return GetDiaChiVaLucThanCuaHao(hao, isHaoDong);
        }


        private string GetDiaChiVaLucThanCuaHao(Hao hao, bool isHaoDong)
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
    }
}
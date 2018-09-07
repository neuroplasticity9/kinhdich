using KinhDichCommon;
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

            sb.Append(GetHaoDesc(queChu, queChu.Hao6, isHao6Dong).PadRight(padRight));
            sb.Append(GetHaoDesc(queHo, queHo.Hao6, false).PadRight(padRight));
            sb.Append(queBien != null ? GetHaoDesc(queBien, queBien.Hao6, isHao6Dong) : "");
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu, queChu.Hao5, isHao5Dong).PadRight(padRight));
            sb.Append(GetHaoDesc(queHo, queHo.Hao5, false).PadRight(padRight));
            sb.Append(queBien != null ? GetHaoDesc(queBien, queBien.Hao5, isHao5Dong) : "");
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu, queChu.Hao4, isHao4Dong).PadRight(padRight));
            sb.Append(GetHaoDesc(queHo, queHo.Hao4, false).PadRight(padRight));
            sb.Append(queBien != null ? GetHaoDesc(queBien, queBien.Hao4, isHao4Dong) : "");
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu, queChu.Hao3, isHao3Dong).PadRight(padRight));
            sb.Append(GetHaoDesc(queHo, queHo.Hao3, false).PadRight(padRight));
            sb.Append(queBien != null ? GetHaoDesc(queBien, queBien.Hao3, isHao3Dong) : "");
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu, queChu.Hao2, isHao2Dong).PadRight(padRight));
            sb.Append(GetHaoDesc(queHo, queHo.Hao2, false).PadRight(padRight));
            sb.Append(queBien != null ? GetHaoDesc(queBien, queBien.Hao2, isHao2Dong) : "");
            sb.AppendLine();

            sb.Append(GetHaoDesc(queChu, queChu.Hao1, isHao1Dong).PadRight(padRight));
            sb.Append(GetHaoDesc(queHo, queHo.Hao1, false).PadRight(padRight));
            sb.Append(queBien != null ? GetHaoDesc(queBien, queBien.Hao1, isHao1Dong) : "");

            return sb.ToString();
        }

        protected string GetHaoDesc(Que que, Hao hao, bool isHaoDong)
        {
            if (que == null)
            {
                return "";
            }

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

            if (hao.Id == 2)
            {
                result += $"{que.NoiQuai.Name} {que.NoiQuai.Hanh.Name}";
            }
            else if (hao.Id == 5)
            {
                result += $"{que.NgoaiQuai.Name} {que.NgoaiQuai.Hanh.Name}";
            }
            result = result.PadRight(13);

            result += $"{hao.AmDuongString}";
            result = result.PadRight(18);

            if (hao.Id == 2)
            {
                result += $"{que.NoiQuai.Name} {que.NoiQuai.Hanh.Name}";
            }
            else if (hao.Id == 5)
            {
                result += $"{que.NgoaiQuai.Name} {que.NgoaiQuai.Hanh.Name}";
            }
            result = result.PadRight(28);


            return result;
        }

    }
}
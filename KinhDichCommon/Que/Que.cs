using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace KinhDichCommon
{
    [DebuggerDisplay("{Name,nq}, thuộc {Hanh.Name,nq}")]
    public class Que : BaseItem
    {
        public int QueId { get; set; }
        public string Url { get; set; }

        public Que QueThuan { get; set; }
        public Hanh Hanh { get; set; }

        public Hao Hao6 { get; set; }
        public Hao Hao5 { get; set; }
        public Hao Hao4 { get; set; }
        public Hao Hao3 { get; set; }
        public Hao Hao2 { get; set; }
        public Hao Hao1 { get; set; }

        public Cung NgoaiQuai => BatQuai.GetCung(Hao6.Duong, Hao5.Duong, Hao4.Duong);
        public Cung NoiQuai => BatQuai.GetCung(Hao3.Duong, Hao2.Duong, Hao1.Duong);

        /// <summary>
        /// Quẻ lục hợp.
        /// </summary>
        /// <returns></returns>
        public bool IsLucHop()
        {
            return Hao1.Chi.Hop == Hao4.Chi && Hao2.Chi.Hop == Hao5.Chi && Hao3.Chi.Hop == Hao6.Chi;
        }

        /// <summary>
        /// Quẻ lục xung.
        /// </summary>
        /// <returns></returns>
        public bool IsLucXung()
        {
            return Hao1.Chi.Xung == Hao4.Chi && Hao2.Chi.Xung == Hao5.Chi && Hao3.Chi.Xung == Hao6.Chi;
        }

        public bool IsThuyCuc()
        {
            return IsHopCuc(DiaChi.ThuyCuc);
        }

        public bool IsMocCuc()
        {
            return IsHopCuc(DiaChi.MocCuc);
        }

        public bool IsHoaCuc()
        {
            return IsHopCuc(DiaChi.HoaCuc);
        }

        public bool IsKimCuc()
        {
            return IsHopCuc(DiaChi.KimCuc);
        }

        private bool IsHopCuc(List<Chi> tamHopCuc)
        {
            var sauHao = new List<Hao> { Hao6, Hao5, Hao4, Hao3, Hao2, Hao1 };
            int count = 0;
            for (int i = 0; i < tamHopCuc.Count; i++)
            {
                if (sauHao.Count(h => h.Chi == tamHopCuc[i]) == 1)
                {
                    count++;
                }
            }

            // Hop thanh cuc khi co va chi co 3 chi.
            return count == 3;
        }

        public string QueDesc => GetQueDesc();
        private string GetQueDesc()
        {
            var sb = new StringBuilder();
            GetAmDuongString(sb, Hao6.Duong);
            GetAmDuongString(sb, Hao5.Duong);
            GetAmDuongString(sb, Hao4.Duong);
            GetAmDuongString(sb, Hao3.Duong);
            GetAmDuongString(sb, Hao2.Duong);
            GetAmDuongString(sb, Hao1.Duong);

            return sb.ToString();
        }

        private void GetAmDuongString(StringBuilder sb, bool isDuong)
        {
            sb.AppendLine(isDuong ? "—" : "..");
        }
    }
}

using System.Diagnostics;
using System.Text;

namespace KinhDichCommon
{
    [DebuggerDisplay("{Name,nq}, thuộc {Hanh.Name,nq}")]
    public class Que : BaseItem
    {
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

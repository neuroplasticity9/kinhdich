using System.Diagnostics;

namespace KinhDichCommon
{
    [DebuggerDisplay("{LucThan.Name,nq} {Chi.Name,nq} {Chi.Hanh.Name,nq}")]
    public class Hao : BaseItem
    {
        public Chi Chi { get; set; }

        public Hanh HanhCuaQue { get; set; }

        public Hanh Hanh => Chi.Hanh;

        public Hanh LucThan => NguHanh.GetLucThan(HanhCuaQue, Hanh);

        public bool Duong { get; set; }

        public bool The { get; set; }

        public bool Ung { get; set; }

        public string AmDuongString => Duong ? Utils.Duong : Utils.Am;

        public Hao HaoPhuc { get; set; }

        internal Hao CloneBasic()
        {
            var hao = new Hao
            {
                HanhCuaQue = HanhCuaQue,
                Id = Id,
                Duong = Duong,
                Chi = Chi,
            };

            return hao;
        }

        internal Hao CloneChoQueBien(Hanh hanhCuaQue)
        {
            var hao = new Hao{
                HanhCuaQue = hanhCuaQue,
                Id = Id,
                Duong = Duong,
                Chi = Chi,
                The = The,
                Ung = Ung,
            };

            return hao;
        }
    }
}

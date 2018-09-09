using System.Diagnostics;

namespace KinhDichCommon
{
    [DebuggerDisplay("{AmDuongString} {LucThan.Name,nq} {Chi.Name,nq} {Chi.NguHanh.Name,nq}")]
    public class Hao : BaseItem
    {
        public DiaChi Chi { get; set; }

        public NguHanh NguHanh => Chi.NguHanh;

        public bool Duong { get; set; }

        public string AmDuongString => Duong ? Utils.Duong : Utils.Am;

        public NguHanh HanhCuaQue { get; set; }

        /// <summary>
        /// Lục thân (phụ mẫu, huynh đệ, tử tôn, thê tài, quan quỷ).
        /// </summary>
        public NguHanh LucThan => NguHanh.GetLucThan(HanhCuaQue, NguHanh);

        public bool The { get; set; }

        public bool Ung { get; set; }

        public Hao HaoPhuc { get; set; }

        public bool IsDongHao { get; set; }

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

        internal Hao CloneChoQueBien(NguHanh hanhCuaQue)
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

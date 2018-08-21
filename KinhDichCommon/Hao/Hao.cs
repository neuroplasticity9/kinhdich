using System;
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

        internal Hao Clone()
        {
            var hao = new Hao{
                Id = Id,
                Duong = Duong,
                Chi = Chi,
                HanhCuaQue = HanhCuaQue
            };

            return hao;
        }
    }
}

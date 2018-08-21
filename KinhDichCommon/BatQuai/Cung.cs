using System.Diagnostics;

namespace KinhDichCommon
{
    /// <summary>
    /// Cung bát quái.
    /// </summary>
    [DebuggerDisplay("{Name,nq} {Hanh.Name,nq}")]
    public class Cung: BaseItem
    {
        /// <summary>
        /// Ngũ hành của cung.
        /// </summary>
        public Hanh Hanh { get; internal set; }

        /// <summary>
        /// Âm dương của cung.
        /// </summary>
        public bool Duong { get; internal set; }

        /// <summary>
        /// Dương tam, ở trên cùng.
        /// </summary>
        public bool Duong3 { get; internal set; }

        /// <summary>
        /// Dương nhị, ở giữa.
        /// </summary>
        public bool Duong2 { get; internal set; }

        /// <summary>
        /// Dương nhất, ở dưới cùng.
        /// </summary>
        public bool Duong1 { get; internal set; }
    }
}

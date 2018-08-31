using System.Diagnostics;

namespace KinhDichCommon
{
    /// <summary>
    /// Địa chi.
    /// </summary>
    [DebuggerDisplay("{Name,nq} {Hanh.Name,nq}, hợp {Hop.Name,nq}, xung {Xung.Name,nq}")]
    public class Chi: BaseItem
    {
        /// <summary>
        /// Địa chi xung.
        /// </summary>
        public Chi Xung { get; set; }

        /// <summary>
        /// Địa chi hợp.
        /// </summary>
        public Chi Hop { get; set; }

        /// <summary>
        /// Ngũ hành của địa chi.
        /// </summary>
        public Hanh Hanh { get; set; }

        /// <summary>
        /// Âm hay dương.
        /// </summary>
        public bool Duong { get; set; }

        /// <summary>
        /// Tấn thần là địa chi nào.
        /// </summary>
        public Chi Tan { get; set; }

        /// <summary>
        /// Thoái thần là địa chi nào.
        /// </summary>
        public Chi Thoai { get; set; }
    }
}

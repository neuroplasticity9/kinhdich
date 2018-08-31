using System.Diagnostics;

namespace KinhDichCommon
{
    [DebuggerDisplay("{Name,nq} {Hanh.Name,nq}, hợp {Hop.Name,nq}, xung {Xung.Name,nq}")]
    public class Can: BaseItem
    {
        public Hanh Hanh { get; internal set; }
        public bool Duong { get; internal set; }
    }
}

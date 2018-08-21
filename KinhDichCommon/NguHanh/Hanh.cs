using System.Diagnostics;

namespace KinhDichCommon
{
    /// <summary>
    /// Ngũ hành.
    /// </summary>
    [DebuggerDisplay("{Name,nq}, sinh {Sinh.Name,nq}, khắc {Khac.Name,nq}, được {SinhBoi.Name,nq} sinh, bị {KhacBoi.Name,nq} khắc.")]
    public class Hanh: BaseItem
    {
        public Hanh Sinh { get; set; }
        public Hanh Khac { get; set; }
        public Hanh SinhBoi { get; set; }
        public Hanh KhacBoi { get; set; }
    }
}

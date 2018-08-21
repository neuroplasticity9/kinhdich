using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinhDichCommon
{
    /// <summary>
    /// Địa chi.
    /// </summary>
    [DebuggerDisplay("{Name,nq} {Hanh.Name,nq}, hợp {Hop.Name,nq}, xung {Xung.Name,nq}")]
    public class Chi: BaseItem
    {
        public Chi Xung { get; set; }
        public Chi Hop { get; set; }

        public Hanh Hanh { get; internal set; }
        public bool Duong { get; internal set; }

    }
}

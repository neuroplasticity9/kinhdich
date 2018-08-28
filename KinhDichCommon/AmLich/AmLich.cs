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
    [DebuggerDisplay("{Name,nq}")]
    public class AmLich
    {
        public CanChi Nam { get; set; }
        public CanChi Thang { get; set; }
        public CanChi Ngay { get; set; }
        public CanChi Gio { get; set; }

        public AmLich()
        {

        }

        public AmLich(DateTime dateTime)
        {

        }

    }
}

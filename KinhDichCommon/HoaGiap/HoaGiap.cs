using System.Collections.Generic;
using static KinhDichCommon.ThienCan;
using static KinhDichCommon.DiaChi;

namespace KinhDichCommon
{
    /// <summary>
    /// Một hoa giáp có 6 tuần, mỗi tuần mười ngày (or 10 năm).
    /// </summary>
    public static class HoaGiap
    {
        public static readonly List<Tuan> All = new List<Tuan>();
        
        static HoaGiap()
        {
            All.Add(new Tuan(new CanChi { Can = Giap, Chi = Ti }));
            All.Add(new Tuan(new CanChi { Can = Giap, Chi = Tuat }));
            All.Add(new Tuan(new CanChi { Can = Giap, Chi = Than }));
            All.Add(new Tuan(new CanChi { Can = Giap, Chi = Ngo }));
            All.Add(new Tuan(new CanChi { Can = Giap, Chi = Thin }));
            All.Add(new Tuan(new CanChi { Can = Giap, Chi = Dan }));
        }

    }
}

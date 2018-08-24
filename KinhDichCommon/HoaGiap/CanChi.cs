using System.Diagnostics;
using System.Linq;

namespace KinhDichCommon
{
    /// <summary>
    /// Can chi trong tu tru.
    /// </summary>
    [DebuggerDisplay("{Name,nq}")]
    public class CanChi
    {
        public Can Can { get; set; }
        public Chi Chi { get; set; }

        public string Name => Can.Name + " " + Chi.Name;

        private Tuan _tuan;
        public Tuan Tuan {
            get
            {
                if (_tuan == null)
                {
                    _tuan = HoaGiap.All.FirstOrDefault(t => t.IsCanChiInThisTuan(this));
                }
                return _tuan;
            }
        }

        public Chi Khong1 => Tuan.Khong1;
        public Chi Khong2 => Tuan.Khong2;

        /// <summary>
        /// Kiểm tra 1 địa chi có phải lâm không vào nhật thần hay không?
        /// </summary>
        /// <param name="nhatThan"></param>
        /// <param name="chi"></param>
        /// <returns></returns>
        public bool IsLamKhong(Chi chi)
        {
            return chi == Tuan.Khong1 || chi == Tuan.Khong2;
        }

        /// <summary>
        /// Vượng hoặc tướng.
        /// </summary>
        /// <param name="chi"></param>
        /// <returns></returns>
        public bool IsVuongTuong(Chi chi)
        {
            return IsVuong(chi) || IsTuong(chi);
        }

        /// <summary>
        /// Hưu tù.
        /// </summary>
        /// <param name="chi"></param>
        /// <returns></returns>
        public bool IsHuuTu(Chi chi)
        {
            return IsHuu(chi) || IsTu(chi) || IsTuyet(chi);
        }

        /// <summary>
        /// Vượng, cùng hành với nhật thìn hoặc nguyệt kiến.
        /// </summary>
        /// <param name="chi"></param>
        /// <returns></returns>
        public bool IsVuong(Chi chi)
        {
            return Chi.Hanh == chi.Hanh;
        }

        /// <summary>
        /// Tướng. Được nhật thìn hoặc nguyệt kiến sinh.
        /// </summary>
        /// <param name="chi"></param>
        /// <returns></returns>
        public bool IsTuong(Chi chi)
        {
            return Chi.Hanh.Sinh == chi.Hanh;
        }

        /// <summary>
        /// Hưu: sinh ra nhật thần hoặc nguyệt kiến nên mất lực.
        /// </summary>
        /// <param name="chi"></param>
        /// <returns></returns>
        public bool IsHuu(Chi chi)
        {
            return Chi.Hanh.SinhBoi == chi.Hanh;
        }

        /// <summary>
        /// Tù: khắc nhật thần hoặc nguyệt kiến nhưng nhật thần nguyệt kiến mạnh nên không khắc được.
        /// </summary>
        /// <param name="chi"></param>
        /// <returns></returns>
        public bool IsTu(Chi chi)
        {
            return Chi.Hanh.KhacBoi == chi.Hanh;
        }

        /// <summary>
        /// Tử: bị nhật thần hoặc nguyệt kiến khắc.
        /// </summary>
        /// <param name="chi"></param>
        /// <returns></returns>
        public bool IsTuyet(Chi chi)
        {
            return Chi.Hanh.Khac == chi.Hanh;
        }
    }
}

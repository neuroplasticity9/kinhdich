using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using static KinhDichCommon.DiaChi;
using static KinhDichCommon.NguHanh;
using static KinhDichCommon.ThienCan;

namespace KinhDichCommon
{
    /// <summary>
    /// Can chi trong tu tru.
    /// </summary>
    [DebuggerDisplay("{Name,nq}")]
    public class CanChi
    {
        public ThienCan Can { get; set; }
        public DiaChi Chi { get; set; }

        public string Name => Can.Name + " " + Chi.Name;

        private Tuan _tuan;
        public Tuan Tuan
        {
            get
            {
                if (_tuan == null)
                {
                    _tuan = HoaGiap.All.FirstOrDefault(t => t.IsCanChiInThisTuan(this));
                }
                return _tuan;
            }
        }

        public DiaChi Khong1 => Tuan.Khong1;
        public DiaChi Khong2 => Tuan.Khong2;

        public static List<ThienCan> CanDuong = new List<ThienCan> { Giap, Binh, Mau, Canh, Nham };
        public static List<ThienCan> CanAm = new List<ThienCan> { At, Dinh, Ky, Tan, Quy };
        public static List<DiaChi> ChiDuong = new List<DiaChi> { Ti, Dan, Thin, Ngo, Than, Tuat };
        public static List<DiaChi> ChiAm = new List<DiaChi> { Suu, Mao, Ty, Mui, Dau, Hoi };

        /// <summary>
        /// Chi dương (Tí, ...) sẽ đi với can dương là Giáp, Bính, Mậu, Canh và Nhâm.
        /// Chi âm (Hợi, ...) sẽ đi với can âm là Ất, Đinh, Kỷ, Tân, Quý.
        /// </summary>
        /// <param name="chi"></param>
        /// <returns></returns>
        public static ThienCan GetCanDauTienHopLe(DiaChi chi)
        {
            return chi.Duong ? CanDuong[0] : CanAm[0];
        }

        /// <summary>
        /// Can dương (Giáp, ...) sẽ đi với chi dương (Tí, Dần, Thìn, Ngọ, Thân và Tuất).
        /// Can âm (Ất, ...) sẽ đi với chi âm (Sửu, Mão, Tỵ, Mùi, Dậu và Hợi).
        /// </summary>
        /// <param name="can"></param>
        /// <returns></returns>
        public static DiaChi GetChiDauTienHopLe(ThienCan can)
        {
            return can.Duong ? ChiDuong[0] : ChiAm[0];
        }

        /// <summary>
        /// Kiểm tra 1 địa chi có phải lâm không vào nhật thần hay không?
        /// </summary>
        /// <param name="nhatThan"></param>
        /// <param name="chi"></param>
        /// <returns></returns>
        public bool IsLamKhong(DiaChi chi)
        {
            return chi == Tuan.Khong1 || chi == Tuan.Khong2;
        }

        /// <summary>
        /// Vượng hoặc tướng.
        /// </summary>
        /// <param name="chi"></param>
        /// <returns></returns>
        public bool IsVuongTuong(DiaChi chi)
        {
            return IsVuong(chi) || IsTuong(chi);
        }

        /// <summary>
        /// Hưu tù.
        /// </summary>
        /// <param name="chi"></param>
        /// <returns></returns>
        public bool IsHuuTu(DiaChi chi)
        {
            return IsHuu(chi) || IsTu(chi) || IsTuyet(chi);
        }

        /// <summary>
        /// Vượng, cùng hành với nhật thìn hoặc nguyệt kiến.
        /// </summary>
        /// <param name="chi"></param>
        /// <returns></returns>
        public bool IsVuong(DiaChi chi)
        {
            return Chi.NguHanh == chi.NguHanh;
        }

        /// <summary>
        /// Tướng. Được nhật thìn hoặc nguyệt kiến sinh.
        /// </summary>
        /// <param name="chi"></param>
        /// <returns></returns>
        public bool IsTuong(DiaChi chi)
        {
            return Chi.NguHanh.Sinh == chi.NguHanh;
        }

        /// <summary>
        /// Hưu: sinh ra nhật thần hoặc nguyệt kiến nên mất lực.
        /// </summary>
        /// <param name="chi"></param>
        /// <returns></returns>
        public bool IsHuu(DiaChi chi)
        {
            if (IsDuKhi(chi))
            {
                return false;
            }

            return Chi.NguHanh.SinhBoi == chi.NguHanh;
        }


        /// <summary>
        /// Tù: khắc nhật thần hoặc nguyệt kiến nhưng nhật thần nguyệt kiến mạnh nên không khắc được.
        /// </summary>
        /// <param name="chi"></param>
        /// <returns></returns>
        public bool IsTu(DiaChi chi)
        {
            if (IsDuKhi(chi))
            {
                return false;
            }

            return Chi.NguHanh.KhacBoi == chi.NguHanh;
        }

        /// <summary>
        /// Tử: bị nhật thần hoặc nguyệt kiến khắc.
        /// </summary>
        /// <param name="chi"></param>
        /// <returns></returns>
        public bool IsTuyet(DiaChi chi)
        {
            if (IsDuKhi(chi))
            {
                return false;
            }

            return Chi.NguHanh.Khac == chi.NguHanh;
        }

        private bool IsDuKhi(DiaChi chi)
        {
            // Tháng 3 kiến Thìn, Mộc còn dư khí mùa xuân.
            if (Chi == Thin && chi.NguHanh == Moc)
            {
                return true;
            }

            // Tháng 6 kiến Mùi, Hỏa còn dư khí mùa hạ.
            if (Chi == Mui && chi.NguHanh == Hoa)
            {
                return true;
            }

            // Tháng 9 kiến Tuất, Kim còn dư khí mùa thu.
            if (Chi == Tuat && chi.NguHanh == Kim)
            {
                return true;
            }

            // Tháng 12 kiến Sửu, Thủy còn dư khí mùa đông.
            if (Chi == Suu && chi.NguHanh == Thuy)
            {
                return true;
            }

            return false;
        }
    }
}

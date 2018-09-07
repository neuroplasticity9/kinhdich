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

        public static List<Can> CanDuong = new List<Can> { Giap, Binh, Mau, Canh, Nham };
        public static List<Can> CanAm = new List<Can> { At, Dinh, Ky, Tan, Quy };
        public static List<Chi> ChiDuong = new List<Chi> { Ti, Dan, Thin, Ngo, Than, Tuat };
        public static List<Chi> ChiAm = new List<Chi> { Suu, Mao, Ty, Mui, Dau, Hoi };

        /// <summary>
        /// Chi dương (Tí, ...) sẽ đi với can dương là Giáp, Bính, Mậu, Canh và Nhâm.
        /// Chi âm (Hợi, ...) sẽ đi với can âm là Ất, Đinh, Kỷ, Tân, Quý.
        /// </summary>
        /// <param name="chi"></param>
        /// <returns></returns>
        public static Can GetCanDauTienHopLe(Chi chi)
        {
            return chi.Duong ? CanDuong[0] : CanAm[0];
        }

        /// <summary>
        /// Can dương (Giáp, ...) sẽ đi với chi dương (Tí, Dần, Thìn, Ngọ, Thân và Tuất).
        /// Can âm (Ất, ...) sẽ đi với chi âm (Sửu, Mão, Tỵ, Mùi, Dậu và Hợi).
        /// </summary>
        /// <param name="can"></param>
        /// <returns></returns>
        public static Chi GetChiDauTienHopLe(Can can)
        {
            return can.Duong ? ChiDuong[0] : ChiAm[0];
        }

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
            if (IsDuKhi(chi))
            {
                return false;
            }

            return Chi.Hanh.SinhBoi == chi.Hanh;
        }


        /// <summary>
        /// Tù: khắc nhật thần hoặc nguyệt kiến nhưng nhật thần nguyệt kiến mạnh nên không khắc được.
        /// </summary>
        /// <param name="chi"></param>
        /// <returns></returns>
        public bool IsTu(Chi chi)
        {
            if (IsDuKhi(chi))
            {
                return false;
            }

            return Chi.Hanh.KhacBoi == chi.Hanh;
        }

        /// <summary>
        /// Tử: bị nhật thần hoặc nguyệt kiến khắc.
        /// </summary>
        /// <param name="chi"></param>
        /// <returns></returns>
        public bool IsTuyet(Chi chi)
        {
            if (IsDuKhi(chi))
            {
                return false;
            }

            return Chi.Hanh.Khac == chi.Hanh;
        }

        private bool IsDuKhi(Chi chi)
        {
            // Tháng 3 kiến Thìn, Mộc còn dư khí mùa xuân.
            if (Chi == Thin && chi.Hanh == Moc)
            {
                return true;
            }

            // Tháng 6 kiến Mùi, Hỏa còn dư khí mùa hạ.
            if (Chi == Mui && chi.Hanh == Hoa)
            {
                return true;
            }

            // Tháng 9 kiến Tuất, Kim còn dư khí mùa thu.
            if (Chi == Tuat && chi.Hanh == Kim)
            {
                return true;
            }

            // Tháng 12 kiến Sửu, Thủy còn dư khí mùa đông.
            if (Chi == Suu && chi.Hanh == Thuy)
            {
                return true;
             }

            return false;
        }
    }
}

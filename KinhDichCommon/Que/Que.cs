using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using static KinhDichCommon.NguHanh;

namespace KinhDichCommon
{
    public enum ViTriHao
    {
        None = 0,
        Hao1 = 1,
        Hao2 = 2,
        Hao3 = 3,
        Hao4 = 4,
        Hao5 = 5,
        Hao6 = 6,
    }

    /// <summary>
    /// 64 quẻ của Kinh Dịch.
    /// </summary>
    [DebuggerDisplay("{Name,nq}, thuộc {NguHanh.Name,nq}")]
    public partial class Que : BaseItem
    {
        public int QueId { get; set; }
        public string Cach { get; set; }
        public string YNghiaNgan { get; set; }
        public string YNghia { get; internal set; }
        public string ViDu { get; internal set; }
        public string TuongQue { get; internal set; }
        public string EnglishName { get; internal set; }
        public string Unicode { get; internal set; }

        public NguHanh NguHanh { get; set; }
        public Que QueThuan { get; set; }
        public Hao Hao6 { get; set; }
        public Hao Hao5 { get; set; }
        public Hao Hao4 { get; set; }
        public Hao Hao3 { get; set; }
        public Hao Hao2 { get; set; }
        public Hao Hao1 { get; set; }
        public BatQuai NgoaiQuai => BatQuai.GetCung(Hao6.Duong, Hao5.Duong, Hao4.Duong);
        public BatQuai NoiQuai => BatQuai.GetCung(Hao3.Duong, Hao2.Duong, Hao1.Duong);
        public bool IsTheQuaiOTren { get; set; } // Quẻ thể ở trên?
        public ViTriHao ViTriHaoPhuc { get; set; }
        public Hao HaoPhuc { get; set; }
        public List<Hao> SauHao;

        #region " Class methods "
        public void Init()
        {
            SauHao = new List<Hao> { Hao6, Hao5, Hao4, Hao3, Hao2, Hao1 };
            SetPhucThan();
        }

        /// <summary>
        /// Quẻ lục hợp.
        /// </summary>
        /// <returns></returns>
        public bool IsLucHop()
        {
            return Hao1.Chi.Hop == Hao4.Chi && Hao2.Chi.Hop == Hao5.Chi && Hao3.Chi.Hop == Hao6.Chi;
        }

        /// <summary>
        /// Quẻ lục xung.
        /// </summary>
        /// <returns></returns>
        public bool IsLucXung()
        {
            return Hao1.Chi.Xung == Hao4.Chi && Hao2.Chi.Xung == Hao5.Chi && Hao3.Chi.Xung == Hao6.Chi;
        }

        public bool IsThuyCuc()
        {
            return IsHopCuc(DiaChi.ThuyCuc);
        }

        public bool IsMocCuc()
        {
            return IsHopCuc(DiaChi.MocCuc);
        }

        public bool IsHoaCuc()
        {
            return IsHopCuc(DiaChi.HoaCuc);
        }

        public bool IsKimCuc()
        {
            return IsHopCuc(DiaChi.KimCuc);
        }

        private bool IsHopCuc(List<DiaChi> tamHopCuc)
        {
            int count = 0;
            for (int i = 0; i < tamHopCuc.Count; i++)
            {
                if (SauHao.Count(h => h.Chi == tamHopCuc[i]) == 1)
                {
                    count++;
                }
            }

            // Hop thanh cuc khi co va chi co 3 chi.
            return count == 3;
        }

        public string GetQueDesc()
        {
            return $"{this.EnglishName}{Environment.NewLine}{Environment.NewLine}{this.TuongQue}{Environment.NewLine}{Environment.NewLine}{this.YNghia}{Environment.NewLine}{Environment.NewLine}{this.ViDu}";
        }

        public void SetPhucThan()
        {
            var lucThanSauHao = new List<NguHanh> { Hao6.LucThan, Hao5.LucThan, Hao4.LucThan, Hao3.LucThan, Hao2.LucThan, Hao1.LucThan };
            if (!lucThanSauHao.Exists(lt => lt == TuTon))
            {
                SetPhucThan(TuTon);
            }
            else if (!lucThanSauHao.Exists(lt => lt == TheTai))
            {
                SetPhucThan(TheTai);
            }
            else if (!lucThanSauHao.Exists(lt => lt == QuanQuy))
            {
                SetPhucThan(QuanQuy);
            }
            else if (!lucThanSauHao.Exists(lt => lt == PhuMau))
            {
                SetPhucThan(PhuMau);
            }
            else if (!lucThanSauHao.Exists(lt => lt == HuynhDe))
            {
                SetPhucThan(HuynhDe);
            }
            else
            {
                ViTriHaoPhuc = ViTriHao.None;
                HaoPhuc = null;
            }
        }

        private void SetPhucThan(NguHanh lucThanBiThieu)
        {
            for (int i = QueThuan.SauHao.Count - 1; i >= 0; i--)
            {
                if (QueThuan.SauHao[i].LucThan == lucThanBiThieu)
                {
                    ViTriHaoPhuc = (ViTriHao)(6 - i);
                    HaoPhuc = QueThuan.SauHao[i];
                    break;
                }
            }
        }

        public void ClearTheUng()
        {
            Hao6.Ung = Hao6.The = false;
            Hao5.Ung = Hao5.The = false;
            Hao4.Ung = Hao4.The = false;
            Hao3.Ung = Hao3.The = false;
            Hao2.Ung = Hao2.The = false;
            Hao1.Ung = Hao1.The = false;
        }

        /// <summary>
        /// Clone que.
        /// </summary>
        /// <returns></returns>
        internal Que Clone()
        {
            return Clone(this.NguHanh);
        }

        /// <summary>
        /// Clone que.
        /// </summary>
        /// <returns></returns>
        internal Que Clone(NguHanh hanhCuaQue)
        {
            var que = new Que
            {
                Id = this.Id,
                Name = this.Name,
                NameShort = this.NameShort,
                NameChinese = this.NameChinese,
                Desc = this.Desc,
                QueId = this.QueId,
                Cach = this.Cach,
                YNghiaNgan = this.YNghiaNgan,
                EnglishName = this.EnglishName,
                Unicode = this.Unicode,
                YNghia = this.YNghia,
                ViDu = this.ViDu,
                TuongQue = this.TuongQue,
                QueThuan = this.QueThuan,
                NguHanh = hanhCuaQue,
                Hao6 = this.Hao6.CloneChoQueBien(hanhCuaQue),
                Hao5 = this.Hao5.CloneChoQueBien(hanhCuaQue),
                Hao4 = this.Hao4.CloneChoQueBien(hanhCuaQue),
                Hao3 = this.Hao3.CloneChoQueBien(hanhCuaQue),
                Hao2 = this.Hao2.CloneChoQueBien(hanhCuaQue),
                Hao1 = this.Hao1.CloneChoQueBien(hanhCuaQue),
            };

            return que;
        }
        #endregion

    }
}

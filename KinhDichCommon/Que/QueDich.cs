using System;
using System.Collections.Generic;
using System.Linq;
using static KinhDichCommon.DiaChi;
using static KinhDichCommon.NguHanh;

namespace KinhDichCommon
{
    /// <summary>
    /// 64 quẻ của Kinh Dịch.
    /// </summary>
    public static class QueDich
    {
        public static readonly Que QueKien;
        public static readonly Que QueDoai;
        public static readonly Que QueLy;
        public static readonly Que QueChan;
        public static readonly Que QueTon;
        public static readonly Que QueKham;
        public static readonly Que QueCan;
        public static readonly Que QueKhon; 

        public static readonly List<Que> QueThuan = new List<Que>();

        public static readonly List<Que> TamQueThuocKien = new List<Que>();
        public static readonly List<Que> TamQueThuocDoai = new List<Que>();
        public static readonly List<Que> TamQueThuocLy = new List<Que>();
        public static readonly List<Que> TamQueThuocChan = new List<Que>();
        public static readonly List<Que> TamQueThuocTon = new List<Que>();
        public static readonly List<Que> TamQueThuocKham = new List<Que>();
        public static readonly List<Que> TamQueThuocCan = new List<Que>();
        public static readonly List<Que> TamQueThuocKhon = new List<Que>();

        public static readonly List<Que> All = new List<Que>();

        static QueDich()
        {
            QueKien = new Que
            {
                Id = 1,
                Name = "Càn Vi Thiên",
                NameShort = "Càn",
                Hanh = Kim,
                Hao6 = new Hao { Id = 6, HanhCuaQue = Kim, Duong = true, Chi = Tuat, The = true },
                Hao5 = new Hao { Id = 5, HanhCuaQue = Kim, Duong = true, Chi = Than },
                Hao4 = new Hao { Id = 4, HanhCuaQue = Kim, Duong = true, Chi = Ngo },
                Hao3 = new Hao { Id = 3, HanhCuaQue = Kim, Duong = true, Chi = Thin, Ung = true },
                Hao2 = new Hao { Id = 2, HanhCuaQue = Kim, Duong = true, Chi = Dan },
                Hao1 = new Hao { Id = 1, HanhCuaQue = Kim, Duong = true, Chi = Ti },
            };

            QueDoai = new Que
            {
                Id = 2,
                Name = "Đoài Vi Trạch",
                NameShort = "Đoài",
                Hanh = Kim,
                Hao6 = new Hao { Id = 6, HanhCuaQue = Kim, Duong = false, Chi = Mui, The = true },
                Hao5 = new Hao { Id = 5, HanhCuaQue = Kim, Duong = true, Chi = Dau },
                Hao4 = new Hao { Id = 4, HanhCuaQue = Kim, Duong = true, Chi = Hoi },
                Hao3 = new Hao { Id = 3, HanhCuaQue = Kim, Duong = false, Chi = Suu, Ung = true },
                Hao2 = new Hao { Id = 2, HanhCuaQue = Kim, Duong = true, Chi = Mao },
                Hao1 = new Hao { Id = 1, HanhCuaQue = Kim, Duong = true, Chi = Ty },
            };

            QueLy = new Que
            {
                Id = 3,
                Name = "Ly Vi Hỏa",
                NameShort = "Ly",
                Hanh = Hoa,
                Hao6 = new Hao { Id = 6, HanhCuaQue = Hoa, Duong = true, Chi = Ty, The = true },
                Hao5 = new Hao { Id = 5, HanhCuaQue = Hoa, Duong = false, Chi = Mui },
                Hao4 = new Hao { Id = 4, HanhCuaQue = Hoa, Duong = true, Chi = Dau },
                Hao3 = new Hao { Id = 3, HanhCuaQue = Hoa, Duong = true, Chi = Hoi, Ung = true },
                Hao2 = new Hao { Id = 2, HanhCuaQue = Hoa, Duong = false, Chi = Suu },
                Hao1 = new Hao { Id = 1, HanhCuaQue = Hoa, Duong = true, Chi = Mao },
            };

            QueChan = new Que
            {
                Id = 4,
                Name = "Chấn Vi Lôi",
                NameShort = "Lôi",
                Hanh = Moc,
                Hao6 = new Hao { Id = 6, HanhCuaQue = Moc, Duong = false, Chi = Tuat, The = true },
                Hao5 = new Hao { Id = 5, HanhCuaQue = Moc, Duong = false, Chi = Than },
                Hao4 = new Hao { Id = 4, HanhCuaQue = Moc, Duong = true, Chi = Ngo },
                Hao3 = new Hao { Id = 3, HanhCuaQue = Moc, Duong = false, Chi = Thin, Ung = true },
                Hao2 = new Hao { Id = 2, HanhCuaQue = Moc, Duong = false, Chi = Dan },
                Hao1 = new Hao { Id = 1, HanhCuaQue = Moc, Duong = true, Chi = Ti },
            };

            QueTon = new Que
            {
                Id = 5,
                Name = "Tốn Vi Phong",
                NameShort = "Tốn",
                Hanh = Moc,
                Hao6 = new Hao { Id = 6, HanhCuaQue = Moc, Duong = true, Chi = Mao, The = true },
                Hao5 = new Hao { Id = 5, HanhCuaQue = Moc, Duong = true, Chi = Ty },
                Hao4 = new Hao { Id = 4, HanhCuaQue = Moc, Duong = false, Chi = Mui },
                Hao3 = new Hao { Id = 3, HanhCuaQue = Moc, Duong = true, Chi = Dau, Ung = true },
                Hao2 = new Hao { Id = 2, HanhCuaQue = Moc, Duong = true, Chi = Hoi },
                Hao1 = new Hao { Id = 1, HanhCuaQue = Moc, Duong = false, Chi = Suu },
            };

            QueKham = new Que
            {
                Id = 6,
                Name = "Khảm Vi Thủy",
                NameShort = "Khảm",
                Hanh = Thuy,
                Hao6 = new Hao { Id = 6, HanhCuaQue = Thuy, Duong = false, Chi = Ti, The = true },
                Hao5 = new Hao { Id = 5, HanhCuaQue = Thuy, Duong = true, Chi = Tuat },
                Hao4 = new Hao { Id = 4, HanhCuaQue = Thuy, Duong = false, Chi = Than },
                Hao3 = new Hao { Id = 3, HanhCuaQue = Thuy, Duong = false, Chi = Ngo, Ung = true },
                Hao2 = new Hao { Id = 2, HanhCuaQue = Thuy, Duong = true, Chi = Thin },
                Hao1 = new Hao { Id = 1, HanhCuaQue = Thuy, Duong = false, Chi = Dan },
            };

            QueCan = new Que
            {
                Id = 7,
                Name = "Cấn Vi Sơn",
                NameShort = "Cấn",
                Hanh = Tho,
                Hao6 = new Hao { Id = 6, HanhCuaQue = Tho, Duong = true, Chi = Dan, The = true },
                Hao5 = new Hao { Id = 5, HanhCuaQue = Tho, Duong = false, Chi = Ti },
                Hao4 = new Hao { Id = 4, HanhCuaQue = Tho, Duong = false, Chi = Tuat },
                Hao3 = new Hao { Id = 3, HanhCuaQue = Tho, Duong = true, Chi = Than, Ung = true },
                Hao2 = new Hao { Id = 2, HanhCuaQue = Tho, Duong = false, Chi = Ngo },
                Hao1 = new Hao { Id = 1, HanhCuaQue = Tho, Duong = false, Chi = Thin },
            };

            QueKhon = new Que
            {
                Id = 8,
                Name = "Khôn Vi Địa",
                NameShort = "Khôn",
                Hanh = Tho,
                Hao6 = new Hao { Id = 6, HanhCuaQue = Tho, Duong = false, Chi = Dau, The = true },
                Hao5 = new Hao { Id = 5, HanhCuaQue = Tho, Duong = false, Chi = Hoi },
                Hao4 = new Hao { Id = 4, HanhCuaQue = Tho, Duong = false, Chi = Suu },
                Hao3 = new Hao { Id = 3, HanhCuaQue = Tho, Duong = false, Chi = Mao, Ung = true },
                Hao2 = new Hao { Id = 2, HanhCuaQue = Tho, Duong = false, Chi = Ty },
                Hao1 = new Hao { Id = 1, HanhCuaQue = Tho, Duong = false, Chi = Mui },
            };

            //SetQueThuan(QueKien);
            //SetQueThuan(QueDoai);
            //SetQueThuan(QueLy);
            //SetQueThuan(QueChan);
            //SetQueThuan(QueTon);
            //SetQueThuan(QueKham);
            //SetQueThuan(QueCan);
            //SetQueThuan(QueKhon);

            QueThuan = new List<Que> { QueKien, QueDoai, QueLy, QueChan, QueTon, QueKham, QueCan, QueKhon };
            foreach (var queThuan in QueThuan)
            {
                SetQueThuan(queThuan);
            }

            AddQueBien(TamQueThuocKien, QueKien);
            AddQueBien(TamQueThuocDoai, QueDoai);
            AddQueBien(TamQueThuocLy, QueLy);
            AddQueBien(TamQueThuocChan, QueChan);
            AddQueBien(TamQueThuocTon, QueTon);
            AddQueBien(TamQueThuocKham, QueKham);
            AddQueBien(TamQueThuocCan, QueCan);
            AddQueBien(TamQueThuocKhon, QueKhon);

            All.AddRange(TamQueThuocKien);
            All.AddRange(TamQueThuocDoai);
            All.AddRange(TamQueThuocLy);
            All.AddRange(TamQueThuocChan);
            All.AddRange(TamQueThuocTon);
            All.AddRange(TamQueThuocKham);
            All.AddRange(TamQueThuocCan);
            All.AddRange(TamQueThuocKhon);

            InitAllQue();

            Sqlite.SetQueFromDb();
        }

        private static void SetQueThuan(Que que)
        {
            que.QueThuan = que;
        }

        private static void InitAllQue()
        {
            foreach (var que in All)
            {
                que.Init();
            }
        }

        private static void AddQueBien(List<Que> listQue, Que queThuan)
        {
            var bien1 = BienQue(queThuan, 1);
            var bien2 = BienQue(bien1, 2);
            var bien3 = BienQue(bien2, 3);
            var bien4 = BienQue(bien3, 4);
            var bien5 = BienQue(bien4, 5);
            var bien6 = BienQue(bien5, 6);
            var bien7 = BienQue(bien6, 7);

            listQue.Add(queThuan);
            listQue.Add(bien1);
            listQue.Add(bien2);
            listQue.Add(bien3);
            listQue.Add(bien4);
            listQue.Add(bien5);
            listQue.Add(bien6);
            listQue.Add(bien7);
        }

        private static Que BienQue(Que queTruoc, int soLanBien)
        {
            var que = queTruoc.Clone();
            que.ClearTheUng();

            if (soLanBien == 1)
            {
                que.Hao1.Duong = !que.Hao1.Duong;
                CapNhatChiChoQueNoi(que);
                que.Hao1.The = true;
                que.Hao4.Ung = true;
            }
            else if (soLanBien == 2)
            {
                que.Hao2.Duong = !que.Hao2.Duong;
                CapNhatChiChoQueNoi(que);
                que.Hao2.The = true;
                que.Hao5.Ung = true;
            }
            else if (soLanBien == 3)
            {
                que.Hao3.Duong = !que.Hao3.Duong;
                CapNhatChiChoQueNoi(que);
                que.Hao3.The = true;
                que.Hao6.Ung = true;
            }
            else if (soLanBien == 4)
            {
                que.Hao4.Duong = !que.Hao4.Duong;
                CapNhatChiChoQueNgoai(que);
                que.Hao4.The = true;
                que.Hao1.Ung = true;
            }
            else if (soLanBien == 5)
            {
                que.Hao5.Duong = !que.Hao5.Duong;
                CapNhatChiChoQueNgoai(que);
                que.Hao5.The = true;
                que.Hao2.Ung = true;
            }
            else if (soLanBien == 6)
            {
                // Du hon
                que.Hao4.Duong = !que.Hao4.Duong;
                CapNhatChiChoQueNgoai(que);
                que.Hao4.The = true;
                que.Hao1.Ung = true;
            }
            else if (soLanBien == 7)
            {
                // Quy hon
                que.Hao1.Duong = !que.Hao1.Duong;
                que.Hao2.Duong = !que.Hao2.Duong;
                que.Hao3.Duong = !que.Hao3.Duong;

                CapNhatChiChoQueNoi(que);
                que.Hao3.The = true;
                que.Hao6.Ung = true;
            }

            return que;
        }

        private static void CapNhatChiChoQueNoi(Que que)
        {
            var cung = BatQuai.GetCung(que.Hao3.Duong, que.Hao2.Duong, que.Hao1.Duong);
            var queThuan = QueThuan.FirstOrDefault(q => q.NoiQuai.Id == cung.Id && q.NgoaiQuai.Id == cung.Id);
            
            que.Hao3.Chi = queThuan.Hao3.Chi;
            que.Hao2.Chi = queThuan.Hao2.Chi;
            que.Hao1.Chi = queThuan.Hao1.Chi;
        }

        private static void CapNhatChiChoQueNgoai(Que que)
        {
            var cung = BatQuai.GetCung(que.Hao6.Duong, que.Hao5.Duong, que.Hao4.Duong);
            var queThuan = QueThuan.FirstOrDefault(q => q.NoiQuai.Id == cung.Id && q.NgoaiQuai.Id == cung.Id);

            que.Hao6.Chi = queThuan.Hao6.Chi;
            que.Hao5.Chi = queThuan.Hao5.Chi;
            que.Hao4.Chi = queThuan.Hao4.Chi;
        }

        /// <summary>
        /// Lấy quẻ dựa trên âm dương của 6 hào.
        /// </summary>
        /// <param name="duong6"></param>
        /// <param name="duong5"></param>
        /// <param name="duong4"></param>
        /// <param name="duong3"></param>
        /// <param name="duong2"></param>
        /// <param name="duong1"></param>
        /// <returns></returns>
        public static Que GetQue(bool duong6, bool duong5, bool duong4, bool duong3, bool duong2, bool duong1)
        {
            var que = All.FirstOrDefault(q => q.Hao6.Duong == duong6 && q.Hao5.Duong == duong5 && q.Hao4.Duong == duong4 &&
                                              q.Hao3.Duong == duong3 && q.Hao2.Duong == duong2 && q.Hao1.Duong == duong1);

            var queNew = que.Clone();
            queNew.Init();

            return queNew;
        }

        /// <summary>
        /// Lấy quẻ dựa trên ngoại quái và nội quái.
        /// </summary>
        /// <param name="ngoaiQuai"></param>
        /// <param name="noiQuai"></param>
        /// <returns></returns>
        public static Que GetQue(Cung ngoaiQuai, Cung noiQuai)
        {
            return GetQue(ngoaiQuai.Duong3, ngoaiQuai.Duong2, ngoaiQuai.Duong1, noiQuai.Duong3, noiQuai.Duong2, noiQuai.Duong1);
        }

        /// <summary>
        /// Lấy quẻ thuần (nội quái và ngoại quái giống nhau).
        /// </summary>
        /// <param name="cungThuan"></param>
        /// <returns></returns>
        public static Que GetQue(Cung cungThuan)
        {
            return GetQue(cungThuan, cungThuan);
        }

        /// <summary>
        /// Từ quẻ chủ lấy quẻ biến.
        /// </summary>
        /// <param name="queChu"></param>
        /// <param name="dongHao6"></param>
        /// <param name="dongHao5"></param>
        /// <param name="dongHao4"></param>
        /// <param name="dongHao3"></param>
        /// <param name="dongHao2"></param>
        /// <param name="dongHao1"></param>
        /// <returns></returns>
        public static Que GetQueBien(Que queChu, bool dongHao6 = false, bool dongHao5 = false, bool dongHao4 = false, bool dongHao3 = false, bool dongHao2 = false, bool dongHao1 = false)
        {
            var queBienGoc = GetQue(dongHao6 ? !queChu.Hao6.Duong : queChu.Hao6.Duong,
                                    dongHao5 ? !queChu.Hao5.Duong : queChu.Hao5.Duong,
                                    dongHao4 ? !queChu.Hao4.Duong : queChu.Hao4.Duong,
                                    dongHao3 ? !queChu.Hao3.Duong : queChu.Hao3.Duong,
                                    dongHao2 ? !queChu.Hao2.Duong : queChu.Hao2.Duong,
                                    dongHao1 ? !queChu.Hao1.Duong : queChu.Hao1.Duong);

            // Hành của quẻ biến sẽ theo quẻ chủ.
            var hanhQueChu = queChu.Hanh;
            var queBien = new Que
            {
                Id = queBienGoc.Id,
                QueId = queBienGoc.QueId,
                Name = queBienGoc.Name,
                NameShort = queBienGoc.NameShort,
                NameChinese = queBienGoc.NameChinese,
                Desc = queBienGoc.Desc,
                Url = queBienGoc.Url,
                QueThuan = queBienGoc.QueThuan,
                Hanh = hanhQueChu,
                Hao6 = queBienGoc.Hao6.CloneChoQueBien(hanhQueChu),
                Hao5 = queBienGoc.Hao5.CloneChoQueBien(hanhQueChu),
                Hao4 = queBienGoc.Hao4.CloneChoQueBien(hanhQueChu),
                Hao3 = queBienGoc.Hao3.CloneChoQueBien(hanhQueChu),
                Hao2 = queBienGoc.Hao2.CloneChoQueBien(hanhQueChu),
                Hao1 = queBienGoc.Hao1.CloneChoQueBien(hanhQueChu),
            };

            return queBien;
        }
    }
}

using System;
using System.Collections.Generic;

namespace KinhDichCommon
{
    public static class NguHanh
    {
        public static readonly Hanh Kim = new Hanh { Id = 1, Name = "Kim", NameChinese = "" };
        public static readonly Hanh Thuy = new Hanh { Id = 2, Name = "Thủy", NameChinese = "" };
        public static readonly Hanh Moc = new Hanh { Id = 3, Name = "Mộc", NameChinese = "" };
        public static readonly Hanh Hoa = new Hanh { Id = 4, Name = "Hỏa", NameChinese = "" };
        public static readonly Hanh Tho = new Hanh { Id = 5, Name = "Thổ", NameChinese = "" };

        // Id order and adding order must be the same.
        private static List<Hanh> _nguHanh = new List<Hanh> { Kim, Thuy, Moc, Hoa, Tho };

        public static readonly Hanh QuanQuy = new Hanh { Id = 1, Name = "Quan Quỷ", NameChinese = "" };
        public static readonly Hanh PhuMau = new Hanh { Id = 2, Name = "Phụ Mẫu", NameChinese = "" };
        public static readonly Hanh HuynhDe = new Hanh { Id = 3, Name = "Huynh Đệ", NameChinese = "" };
        public static readonly Hanh TuTon = new Hanh { Id = 4, Name = "Tử Tôn", NameChinese = "" };
        public static readonly Hanh TheTai = new Hanh { Id = 5, Name = "Thê Tài", NameChinese = "" };

        // Id order and adding order must be the same.
        private static List<Hanh> _lucThan = new List<Hanh> { QuanQuy, PhuMau, HuynhDe, TuTon, TheTai };

        static NguHanh()
        {
            SetSinhKhac(_nguHanh);
            SetSinhKhac(_lucThan);
        }

        private static void SetSinhKhac(List<Hanh> list)
        {
            var maxIndex = list.Count - 1;

            for (int i = 0; i <= maxIndex; i++)
            {
                var hanh = list[i];
                hanh.Sinh = list[GetSinhIndex(i, maxIndex)];
                hanh.Khac = list[GetKhacIndex(i, maxIndex)];
                hanh.SinhBoi = list[GetSinhBoiIndex(i, maxIndex)];
                hanh.KhacBoi = list[GetKhacBoiIndex(i, maxIndex)];
            }
        }

        public static int GetSinhIndex(int index, int maxIndex)
        {
            return GetNewIndex(index, maxIndex, (i) => i + 1);
        }

        public static int GetKhacIndex(int index, int maxIndex)
        {
            return GetNewIndex(index, maxIndex, (i) => i + 2);
        }

        public static int GetSinhBoiIndex(int index, int maxIndex)
        {
            return GetNewIndex(index, maxIndex, (i) => i - 1);
        }

        private static int GetKhacBoiIndex(int index, int maxIndex)
        {
            return GetNewIndex(index, maxIndex, (i) => i + 3);
        }

        public static int GetNewIndex(int id, int maxIndex, Func<int, int> func)
        {
            var newId = func(id);
            if (newId < 0)
            {
                newId = maxIndex;
            }
            else if (newId > maxIndex)
            {
                newId = newId - maxIndex - 1;
            }

            return newId;
        }


        /// <summary>
        /// Từ ngũ hành của quẻ và ngũ hành của hào, lấy ra lục thân.
        /// Hành của quẻ chính là đại diện cho ta.
        /// </summary>
        /// <param name="hanhCuaQue"></param>
        /// <param name="hanhCuaHao"></param>
        /// <returns>Lục thân</returns>
        public static Hanh GetLucThan(Hanh hanhCuaQue, Hanh hanhCuaHao)
        {
            // Nếu hào có cùng ngũ hành với ta thì là huynh đệ.
            if (hanhCuaHao.Id == hanhCuaQue.Id)
            {
                return NguHanh.HuynhDe;
            }
            else if (hanhCuaHao.Id == hanhCuaQue.Sinh.Id)
            {
                // Cái ta (huynh đệ) sinh ra là tử tôn.
                return NguHanh.TuTon;
            }
            else if (hanhCuaHao.Id == hanhCuaQue.Khac.Id)
            {
                // Cái ta (huynh đệ) khắc là thê tài.
                return NguHanh.TheTai;
            }
            else if (hanhCuaHao.Id == hanhCuaQue.SinhBoi.Id)
            {
                // Sinh ra ta (huynh đệ) là phụ mẫu.
                return NguHanh.PhuMau;
            }
            else if (hanhCuaHao.Id == hanhCuaQue.KhacBoi.Id)
            {
                // Cái khắc ta (huynh đệ) là quan quỷ.
                return NguHanh.QuanQuy;
            }
            else
            {
                throw new Exception("Invalid NguHanh.");
            }
        }

    }
}

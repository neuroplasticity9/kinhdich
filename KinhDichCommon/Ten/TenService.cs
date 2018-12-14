using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KinhDichCommon
{

    /// <summary>
    /// 
    /// </summary>
    public class TenService
    {
        private List<string> _allFemaleNames1Chu = new List<string>();
        private List<string> _allFemaleNames2Chu = new List<string>();

        private List<string> _nguyenAmHuyen = new List<string>() { "à", "ằ", "ầ", "è", "ề", "ì", "ò", "ồ", "ờ", "ù", "ừ", "ỳ", "À", "Ằ", "Ầ", "È", "Ề", "Ì", "Ò", "Ồ", "Ờ", "Ù", "Ừ", "Ỳ" };
        private List<string> _nguyenAmSac   = new List<string>() { "á", "ắ", "ấ", "é", "ế", "í", "ó", "ố", "ớ", "ú", "ứ", "ý", "Á", "Ắ", "Ấ", "É", "Ế", "Í", "Ó", "Ố", "Ớ", "Ú", "Ứ", "Ý" };
        private List<string> _nguyenAmHoi   = new List<string>() { "ả", "ẳ", "ẩ", "ẻ", "ể", "ỉ", "ỏ", "ổ", "ở", "ủ", "ử", "ỷ", "Ả", "Ẳ", "Ẩ", "Ẻ", "Ể", "Ỉ", "Ỏ", "Ổ", "Ở", "Ủ", "Ử", "Ỷ" };
        private List<string> _nguyenAmNga   = new List<string>() { "ã", "ẵ", "ẫ", "ẽ", "ễ", "ĩ", "õ", "ỗ", "ỡ", "ũ", "ữ", "ỹ", "Ã", "Ẵ", "Ẫ", "Ẽ", "Ễ", "Ĩ", "Õ", "Ỗ", "Ỡ", "Ũ", "Ữ", "Ỹ" };
        private List<string> _nguyenAmNang  = new List<string>() { "ạ", "ặ", "ậ", "ẹ", "ệ", "ị", "ọ", "ộ", "ợ", "ụ", "ự", "ỵ", "Ạ", "Ặ", "Ậ", "Ẹ", "Ệ", "Ị", "Ọ", "Ộ", "Ợ", "Ụ", "Ự", "Ỵ" };

        public TenService()
        {
            _allFemaleNames1Chu = GetAllFemaleNames1Chu();
            _allFemaleNames2Chu = GetAllFemaleNames2Chu();
        }

        public List<string> Get2ChuTenDep(int tongSo, TimTenOption lotOption, TimTenOption tenOption)
        {
            var list = new List<string>();

            foreach (var ten in _allFemaleNames2Chu)
            {
                if (ten.Replace(" ", "").Length != tongSo)
                {
                    continue;
                }

                // Không lấy chữ lót kỵ
                if (lotOption.KyList.Count > 0 && ContainLot(lotOption.KyList, ten))
                {
                    continue;
                }

                // Không lấy tên kỵ
                if (tenOption.KyList.Count > 0 && ContainTen(tenOption.KyList, ten))
                {
                    continue;
                }

                // Phải lấy chữ lót được chọn.
                if (lotOption.ChonList.Count > 0 && !ContainLot(lotOption.ChonList, ten))
                {
                    continue;
                }

                // Phải lấy tên được chọn.
                if (tenOption.ChonList.Count > 0 && !ContainTen(tenOption.ChonList, ten))
                {
                    continue;
                }

                list.Add(ten);
            }

            return list;
        }

        private bool ContainLot(List<string> lotList, string ten2Chu)
        {
            if (lotList.Count > 0)
            {
                foreach (var chuLot in lotList)
                {
                    if (ten2Chu.StartsWith($"{chuLot} "))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool ContainTen(List<string> tenList, string ten2Chu)
        {
            if (tenList.Count > 0)
            {
                foreach (var ten in tenList)
                {
                    if (ten2Chu.EndsWith($" {ten}"))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public List<string> Get2ChuRandom(int tongSo, TimTenOption lotOption, TimTenOption tenOption)
        {
            var list = new List<string>();

            for (int i = 0; i < tongSo; i++)
            {
                if (i >= lotOption.MinNameLength && i <= lotOption.MaxNameLength)
                {
                    int lenChuLot = i;
                    int lenTen = tongSo - i;

                    if (lenTen >= tenOption.MinNameLength)
                    {
                        list.AddRange(GetTenNu(tongSo, lenChuLot, lenTen, lotOption, tenOption));
                    }
                }
            }

            return list;
        }

        private List<string> GetTenNu(int tongSo, int tenLength1, int tenLength2, TimTenOption lotOption, TimTenOption tenOption)
        {
            return GetListTen(_allFemaleNames1Chu, tongSo, tenLength1, tenLength2, lotOption, tenOption);
        }

        public List<string> GetListTen(List<string> listAllTen, int tongSo, int tenLength1, int tenLength2, TimTenOption lotOption, TimTenOption tenOption)
        {
            var list = new List<string>();

            var listChuLot = lotOption.ChonList.Count > 0 ? lotOption.ChonList : GetAllNamesByLength(listAllTen, tenLength1);
            var listTen = tenOption.ChonList.Count > 0 ? tenOption.ChonList : (tenLength1 != tenLength2 ? GetAllNamesByLength(listAllTen, tenLength2) : listChuLot);

            list.AddRange(GetTenVaLot(tongSo, listChuLot, listTen, lotOption, tenOption));

            return list;
        }

        private List<string> GetTenVaLot(int tongSo, List<string> listTen1, List<string> listTen2, TimTenOption lotOption, TimTenOption tenOption)
        {
            var list = new List<string>();

            foreach (var chuLot in listTen1)
            {
                // Ignore these name.
                if (!IsValid(chuLot, lotOption))
                {
                    continue;
                }

                foreach (var ten in listTen2)
                {
                    // Ignore these name.
                    if (!IsValid(ten, tenOption))
                    {
                        continue;
                    }

                    if (chuLot.Length + ten.Length != tongSo)
                    {
                        continue;
                    }

                    list.Add($"{chuLot} {ten}");
                }
            }

            return list;
        }

        private bool IsChuKhongDau(string name)
        {
            if (IsChuCoDauHuyen(name) || IsChuCoDauSac(name) || 
                IsChuCoDauHoi(name) || IsChuCoDauNga(name) || IsChuCoDauNang(name))
            {
                return false;
            }

            return true;
        }

        private bool IsChuCoDauHuyen(string name)
        {
            return IsChuCoDau(name, _nguyenAmHuyen);
        }

        private bool IsChuCoDauSac(string name)
        {
            return IsChuCoDau(name, _nguyenAmSac);
        }

        private bool IsChuCoDauHoi(string name)
        {
            return IsChuCoDau(name, _nguyenAmHoi);
        }

        private bool IsChuCoDauNga(string name)
        {
            return IsChuCoDau(name, _nguyenAmNga);
        }

        private bool IsChuCoDauNang(string name)
        {
            return IsChuCoDau(name, _nguyenAmNang);
        }

        private bool IsChuCoDau(string name, List<string> nguyenAmCoDau)
        {
            foreach (var nguyenAm in nguyenAmCoDau)
            {
                if (name.Contains(nguyenAm))
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsValidTen(string ten, List<string> tenKy)
        {
            if (tenKy.Contains(ten))
            {
                return false;
            }

            if (IsChuCoDauHuyen(ten))
            {
                return false;
            }
            
            return true;
        }

        private bool IsValid(string ten, TimTenOption option)
        {
            if (option.KyList.Contains(ten))
            {
                return false;
            }

            if (option.DungKhongDau || option.DungDauHuyen || option.DungDauSac ||
                option.DungDauHoi || option.DungDauNga || option.DungDauNang)
            {
                if ((option.DungKhongDau && IsChuKhongDau(ten)) ||
                    (option.DungDauHuyen && IsChuCoDauHuyen(ten)) ||
                    (option.DungDauSac && IsChuCoDauSac(ten)) ||
                    (option.DungDauHoi && IsChuCoDauHoi(ten)) ||
                    (option.DungDauNga && IsChuCoDauNga(ten)) ||
                    (option.DungDauNang && IsChuCoDauNang(ten)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public List<string> GetAllNamesByLength(List<string> nameList, int nameLength)
        {
            return nameList.Where(name => name.Length == nameLength).ToList();
        }

        public List<string> GetAllFemaleNames1Chu()
        {
            var listName = GetAll1Chu(ListTenNu.All);

            var sortedNameList = listName.OrderBy(name => name).ToList();
            return sortedNameList;
        }

        public List<string> GetAllFemaleNames2Chu()
        {
            var listName = GetAll2ChuTenDep(ListTenNu.All);

            var sortedNameList = listName.OrderBy(name => name).ToList();
            return sortedNameList;
        }

        public string GetNamesInString(List<string> nameList)
        {
            var sb = new StringBuilder();

            foreach (var item in nameList)
            {
                sb.AppendLine(item);
            }

            return sb.ToString();
        }

        public static List<string> GetAll2ChuTenDep(string text)
        {
            var list = new List<string>();

            var names = text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var temp = "";
            for (int i = 0; i < names.Length; i++)
            {
                temp = names[i];

                if (!list.Contains(temp))
                {
                    list.Add(temp);
                }
            }

            return list;
        }

        public static List<string> GetAll1Chu(string text)
        {
            var list = new List<string>();

            var names = text.Split(new char[] { ' ', ',', ';', '|', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var temp = "";
            for (int i = 0; i < names.Length; i++)
            {
                temp = names[i];

                if (!list.Contains(temp))
                {
                    list.Add(temp);
                }
            }

            return list;
        }
    }

    public class TimTenOption
    {
        public int MinNameLength { get; set; } = 1;
        public int MaxNameLength { get; set; } = 6;

        public List<string> KyList { get; set; }
        public List<string> ChonList { get; set; }

        public bool DungKhongDau { get; set; }
        public bool DungDauHuyen { get; set; }
        public bool DungDauSac { get; set; }
        public bool DungDauHoi { get; set; }
        public bool DungDauNga { get; set; }
        public bool DungDauNang { get; set; }

        public TimTenOption(int minLen, int maxLen, string kyText, string chonText, bool dungKhongDau, bool dungDauHuyen, bool dungDauSac, bool dungDauHoi, bool dungDauNga, bool dungDauNang)
        {
            MinNameLength = minLen;
            MaxNameLength = maxLen;

            DungKhongDau = dungKhongDau;
            DungDauHuyen = dungDauHuyen;
            DungDauSac = dungDauSac;
            DungDauHoi = dungDauHoi;
            DungDauNga = dungDauNga;
            DungDauNang = dungDauNang;

            KyList = TenService.GetAll1Chu(kyText);
            ChonList = TenService.GetAll1Chu(chonText);
        }

    }
}

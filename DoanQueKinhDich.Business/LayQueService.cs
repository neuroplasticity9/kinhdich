using System;
using System.Collections.Generic;
using System.Text;
using KinhDichCommon;

namespace DoanQueKinhDich.Business
{
    public class LayQueService
    {
        public List<QueIndex> GetAllQueIndexesForADay(AmLich amLich, string extraText = "")
        {
            var queIndexes = new List<QueIndex>();

            for (int i = 0; i < DiaChi.All.Count; i++)
            {
                var solarDate = amLich.SolarDate.Date.AddHours(i * 2);
                var amLichNew = solarDate.ToAmLich();

                queIndexes.Add(GetQueIndexByTime(amLichNew, extraText));
            }

            return queIndexes;
        }

        public QueIndex GetQueIndexByTime(AmLich amLich, string extraText = "")
        {
            int soHoacChu = GetTongCuaQuai(extraText);
            int tongNgoaiQuai = GetTongNamThangNgay(amLich) + soHoacChu;
            int tongNoiQuai = GetTongNamThangNgayGio(amLich) + soHoacChu;
            var haoDongIndex = tongNoiQuai % 6;

            var queIndex = new QueIndex
            {
                NgoaiQuaiIndex = (tongNgoaiQuai - 1 + 8) % 8,
                NoiQuaiIndex = (tongNoiQuai - 1 + 8) % 8,
                HaoDongNumber = haoDongIndex == 0 ? 6 : haoDongIndex,
            };

            var sb = new StringBuilder();
            sb.AppendLine($"1. Ngoại quái: năm {amLich.NamAm.Chi.Name} {amLich.NamAm.Chi.Id} + tháng {amLich.LunarMonth} + ngày {amLich.LunarDay} + số {soHoacChu} = {tongNgoaiQuai} % 8 = {queIndex.NgoaiQuaiIndex + 1} = quẻ {BatQuai.All[queIndex.NgoaiQuaiIndex].Name}");
            sb.AppendLine();
            sb.AppendLine($"2. Nội quái:   năm {amLich.NamAm.Chi.Name} {amLich.NamAm.Chi.Id} + tháng {amLich.LunarMonth} + ngày {amLich.LunarDay} + số {soHoacChu} + giờ {amLich.GioAm.Chi.Name} {amLich.GioAm.Chi.Id} = {tongNoiQuai} % 8 = {queIndex.NoiQuaiIndex + 1} = quẻ {BatQuai.All[queIndex.NoiQuaiIndex].Name}");
            sb.AppendLine();
            sb.AppendLine($"3. Động hào:   tổng nội quái {tongNoiQuai} % 6 = {queIndex.HaoDongNumber}");

            queIndex.Desc = sb.ToString();

            return queIndex;
        }

        public QueIndex GetQueIndexBySoAndTime(AmLich amLich, string textCuaQuai)
        {
            int tongNgoaiQuai = GetTongNamThangNgayGio(amLich);
            int tongNoiQuai = GetTongCuaQuai(textCuaQuai);
            var haoDongIndex = (tongNgoaiQuai + tongNoiQuai) % 6;

            var queIndex = new QueIndex
            {
                NgoaiQuaiIndex = (tongNgoaiQuai - 1 + 8) % 8,
                NoiQuaiIndex = (tongNoiQuai - 1 + 8) % 8,
                HaoDongNumber = haoDongIndex == 0 ? 6 : haoDongIndex,
            };

            var sb = new StringBuilder();
            sb.AppendLine($"1. Ngoại quái: năm {amLich.NamAm.Chi.Name} {amLich.NamAm.Chi.Id} + tháng {amLich.LunarMonth} + ngày {amLich.LunarDay} + giờ {amLich.GioAm.Chi.Name} {amLich.GioAm.Chi.Id} = {tongNgoaiQuai} % 8 = {queIndex.NgoaiQuaiIndex + 1} = quẻ {BatQuai.All[queIndex.NgoaiQuaiIndex].Name}");
            sb.AppendLine();
            sb.AppendLine($"2. Nội quái:   số {tongNoiQuai} % 8 = {queIndex.NoiQuaiIndex + 1} = quẻ {BatQuai.All[queIndex.NoiQuaiIndex].Name}");
            sb.AppendLine();
            sb.AppendLine($"3. Động hào:   ngoại quái {tongNgoaiQuai} + nội quái {tongNoiQuai} = {tongNgoaiQuai + tongNoiQuai} % 6 = {queIndex.HaoDongNumber}");

            queIndex.Desc = sb.ToString();

            return queIndex;
        }

        public QueIndex GetQueIndexBySoAndSo(string textCuaNgoaiQuai, string textCuaNoiQuai, AmLich amLich, bool batThuong)
        {
            int tongNgoaiQuai = GetTongCuaQuai(textCuaNgoaiQuai);
            int tongNoiQuai = GetTongCuaQuai(textCuaNoiQuai);

            // Tiên thiên đoán bằng số nên không cần giờ. Hậu thiên đoán bằng bát quái nên cần thêm giờ vào để tìm hào động.
            int chiNumber = batThuong ? amLich.GioAm.Chi.Id : 0;
            var haoDongIndex = (tongNgoaiQuai + tongNoiQuai + chiNumber) % 6;

            var queIndex = new QueIndex
            {
                NgoaiQuaiIndex = (tongNgoaiQuai - 1 + 8) % 8,
                NoiQuaiIndex = (tongNoiQuai - 1 + 8) % 8,
                HaoDongNumber = haoDongIndex == 0 ? 6 : haoDongIndex,
            };

            var sb = new StringBuilder();
            sb.AppendLine($"1. Ngoại quái: số {tongNgoaiQuai} % 8 = {queIndex.NgoaiQuaiIndex + 1} = quẻ {BatQuai.All[queIndex.NgoaiQuaiIndex].Name}");
            sb.AppendLine();
            sb.AppendLine($"2. Nội quái:   số {tongNoiQuai} % 8 = {queIndex.NoiQuaiIndex + 1} = quẻ {BatQuai.All[queIndex.NoiQuaiIndex].Name}");
            sb.AppendLine();
            sb.AppendLine($"3. Động hào:   ngoại quái {tongNgoaiQuai} + nội quái {tongNoiQuai}{GetGioDescChoCongThucBatThuong(amLich.GioAm, batThuong)} = {tongNgoaiQuai + tongNoiQuai + chiNumber} % 6 = {queIndex.HaoDongNumber}");

            queIndex.Desc = sb.ToString();

            return queIndex;
        }

        private string GetGioDescChoCongThucBatThuong(CanChi gio, bool batThuong)
        {
            return batThuong ? $" + giờ {gio.Chi.Name} {gio.Chi.Id}" : "";
        }

        private int GetTongCuaQuai(string textCuaQuai)
        {
            if (int.TryParse(textCuaQuai, out int soCuaQuai))
            {
                // Nếu là 1 số thì lấy chính số đó.
                return soCuaQuai;
            }
            else
            {
                var newText = textCuaQuai.Replace(" ", "").ToUpperInvariant();

                // Đếm số chữ cái trong đoạn text.
                return newText.Length;

                //if (radAlphaId.Checked)
                //{
                //    return GetTotalOfCharacters(newText, i => i);
                //}
                //if (radIDHalf.Checked)
                //{
                //    return GetTotalOfCharacters(newText, i => i % 9 == 0 ? 9 : i % 9);
                //}
                //else
                //{
                //    // Đếm số chữ cái trong đoạn text.
                //    return newText.Length;
                //}
            }
        }

        private int GetTotalOfCharacters(string newText, Func<int, int> getCharInt)
        {
            var result = 0;
            foreach (var ch in newText.ToCharArray())
            {
                result += getCharInt((int)ch - 64);
            }

            return result;
        }
        
        private int GetTongNamThangNgay(AmLich amLich)
        {
            var tongNamThangNgay = amLich.NamAm.Chi.Id + amLich.LunarMonth + amLich.LunarDay;
            return tongNamThangNgay;
        }


        private int GetTongNamThangNgayGio(AmLich amLich)
        {
            DiaChi gioChi = DiaChi.All[amLich.GioAm.Chi.Id - 1];
            return GetTongNamThangNgay(amLich) + gioChi.Id;
        }

    }

}

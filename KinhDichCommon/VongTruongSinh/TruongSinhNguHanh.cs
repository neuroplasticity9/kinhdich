using System.Collections.Generic;

namespace KinhDichCommon
{
    public class TruongSinhNguHanh
    {
        public List<DiaChi> DiaChi = new List<DiaChi>();
        public NguHanh NguHanh { get; private set; }

        public TruongSinhNguHanh(NguHanh hanh, DiaChi chiBatDau)
        {
            NguHanh = hanh;
            var index = chiBatDau.Id - 1;
            var lastIndex = KinhDichCommon.DiaChi.All.Count - 1;

            for (int i = 0; i <= lastIndex; i++)
            {
                if (index > lastIndex)
                {
                    index = 0;
                }

                DiaChi.Add(KinhDichCommon.DiaChi.All[index]);
                index++;
            }
        }

    }
}

using KinhDichCommon;

namespace DoanQueKinhDich.Business
{
    public class QueIndex
    {
        private Que _queChu;
        private Que _queBien;

        public int NgoaiQuaiIndex { get; set; }
        public int NoiQuaiIndex { get; set; }
        public int HaoDongNumber { get; set; }

        public string Desc { get; set; }
               
        /// <summary>
        /// Get que chu.
        /// </summary>
        /// <returns></returns>
        public Que GetQueChu()
        {
            if (_queChu == null)
            {
                var ngoaiQuai = BatQuai.All[NgoaiQuaiIndex];
                var noiQuai = BatQuai.All[NoiQuaiIndex];

                _queChu = Que.GetQue(ngoaiQuai, noiQuai);
            }

            return _queChu;
        }

        /// <summary>
        /// Get que bien.
        /// </summary>
        /// <returns></returns>
        public Que GetQueBien()
        {
            if (_queBien == null)
            {
                var ngoaiQuai = BatQuai.All[NgoaiQuaiIndex];
                var noiQuai = BatQuai.All[NoiQuaiIndex];

                var hao1 = GetHao(1, noiQuai.Duong1);
                var hao2 = GetHao(2, noiQuai.Duong2);
                var hao3 = GetHao(3, noiQuai.Duong3);
                var hao4 = GetHao(4, ngoaiQuai.Duong1);
                var hao5 = GetHao(5, ngoaiQuai.Duong2);
                var hao6 = GetHao(6, ngoaiQuai.Duong3);

                _queBien = Que.GetQue(hao6, hao5, hao4, hao3, hao2, hao1);
            }

            return _queBien;
        }

        private bool GetHao(int haoIndex, bool haoDuong)
        {
            return HaoDongNumber == haoIndex ? !haoDuong : haoDuong;
        }
    }

}

using DoanQueKinhDich.Business;

namespace KinhDichCommon
{
    public static class IQueExtensions
    {
        /// <summary>
        /// Kiểm tra xem có quẻ biến hay không.
        /// Nếu trong 6 hào có 1 hào động thì ta có quẻ biến.
        /// </summary>
        /// <param name="que"></param>
        /// <returns></returns>
        public static bool CoQueBien(this IQue que)
        {
            return que.Hao6Dong || que.Hao5Dong || que.Hao4Dong || que.Hao3Dong || que.Hao2Dong || que.Hao1Dong;
        }

    }
}

using KinhDichCommon;

namespace DoanQueKinhDich
{
    public interface IQue
    {
        bool Hao1 { get; }
        bool Hao2 { get; }
        bool Hao3 { get; }
        bool Hao4 { get; }
        bool Hao5 { get; }
        bool Hao6 { get; }

        bool Hao1Dong { get; }
        bool Hao2Dong { get; }
        bool Hao3Dong { get; }
        bool Hao4Dong { get; }
        bool Hao5Dong { get; }
        bool Hao6Dong { get; }

        CanChi NgayAm { get; }
        CanChi ThangAm { get; }
    }
}
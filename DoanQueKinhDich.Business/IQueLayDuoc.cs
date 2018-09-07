using KinhDichCommon;

namespace DoanQueKinhDich.Business
{
    public interface IQueLayDuoc: IQue
    {
        NgayLayQue NgayLayQue { get; }
        CachLayQue CachLayQue { get; }
    }
}
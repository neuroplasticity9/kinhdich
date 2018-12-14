namespace KinhDichCommon
{
    /// <summary>
    /// Tim ten be trai.
    /// </summary>
    public class TenNamService : TenService
    {
        public TenNamService() : base(ListTenNam.All)
        {
        }
    }
}
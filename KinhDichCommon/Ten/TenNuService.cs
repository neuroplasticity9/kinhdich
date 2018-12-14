namespace KinhDichCommon
{
    /// <summary>
    /// Tim ten be gai.
    /// </summary>
    public class TenNuService : TenService
    {
        public TenNuService() : base(ListTenNu.All)
        {
        }
    }
}
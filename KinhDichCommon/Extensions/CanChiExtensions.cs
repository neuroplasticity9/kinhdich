namespace KinhDichCommon
{
    public static class CanChiExtensions
    {
        public static Chi Next(this Chi chi)
        {
            if (chi.Id == DiaChi.All.Count)
            {
                return DiaChi.All[0];
            }

            return DiaChi.All[chi.Id];
        }

        public static Can Next(this Can can)
        {
            if (can.Id == ThienCan.All.Count)
            {
                return ThienCan.All[0];
            }

            return ThienCan.All[can.Id];
        }

        public static CanChi Next(this CanChi canChi)
        {
            return new CanChi { Can = canChi.Can.Next(), Chi = canChi.Chi.Next() };
        }
    }
}

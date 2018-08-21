namespace KinhDichCommon
{
    public abstract class BaseItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string NameShort { get; set; } = "";
        public string NameChinese { get; set; } = "";
        public string Desc { get; set; } = "";
    }
}

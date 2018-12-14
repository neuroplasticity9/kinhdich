using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KinhDichCommon.Tests
{
    [TestClass]
    public class TenTests
    {
        [TestMethod]
        public void GetTen()
        {
            var tenService = new TenService();
            tenService.GetAllFemaleNames1Chu();
        }
        
    }
}

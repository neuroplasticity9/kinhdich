using System;
using System.Threading;

namespace DoanQueKinhDich
{
    /// <summary>
    /// Tung xu va lưu kết quả.
    /// </summary>
    public class TungXu
    {
        private const int SleepSeconds = 1;
        private const int MaxRandomNumber = 100000;

        public int Xu1 { get; set; }
        public int Xu2 { get; set; }
        public int Xu3 { get; set; }

        public int Tong3Xu => Xu1 + Xu2 + Xu3;

        public bool Duong => Tong3Xu % 2 == 1; // Chỉ có 1 đồng dương hoặc 3 đồng dương.
        public bool Dong => Tong3Xu % 3 == 0; // Cả 3 đồng tiền cùng loại (cùng âm hay cùng dương).

        public void Run()
        {
            // Sleep some seconds.
            Thread.Sleep(SleepSeconds * 1000);

            var random = new Random(DateTime.Now.Millisecond);

            Xu1 = random.Next(0, MaxRandomNumber) % 2;
            Xu2 = random.Next(0, MaxRandomNumber) % 2;
            Xu3 = random.Next(0, MaxRandomNumber) % 2;
        }

        public string GetKetQua()
        {
            string result = $"{GetXu(Xu1)} {GetXu(Xu2)} {GetXu(Xu3)} => được hào ";

            result += Duong ? "Dương" : "Âm";
            if (Dong)
            {
                result += " Động.";
            }
            else
            {
                result += ".";
            }

            return result;
        }

        private string GetXu(int xu)
        {
            return xu == 1 ? "Dương" : "Âm";
        }
    }

}
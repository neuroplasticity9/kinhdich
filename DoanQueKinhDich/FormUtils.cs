using System.Windows.Forms;
using KinhDichCommon;

namespace DoanQueKinhDich
{
    public static class FormUtils
    {
        public static void ChangeTextAmDuong(CheckBox chkHao)
        {
            chkHao.Text = chkHao.Checked ? Utils.Duong : Utils.Am;
        }

        public static void UpdateBatQuai(ComboBox batQuai, CheckBox haoThuong, CheckBox haoTrung, CheckBox haoHa)
        {
            if (haoThuong.Visible && haoTrung.Visible && haoHa.Visible)
            {
                Cung cung;
                for (int i = 0; i < BatQuai.All.Count; i++)
                {
                    cung = BatQuai.All[i];
                    if (cung.Duong3 == haoThuong.Checked &&
                        cung.Duong2 == haoTrung.Checked &&
                        cung.Duong1 == haoHa.Checked)
                    {
                        batQuai.SelectedIndex = i;
                        return;
                    }
                }
            }
        }
    }
}
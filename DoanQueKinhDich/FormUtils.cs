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

        public static void ChangeTextAmDuong(Label labelHaoBien, CheckBox chkHao, CheckBox chkHaoDong)
        {
            var amDuong = chkHaoDong.Checked ? !chkHao.Checked : chkHao.Checked;
            labelHaoBien.Text = amDuong ? Utils.Duong : Utils.Am;

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
                        batQuai.Visible = true;
                        return;
                    }
                }
            }
        }

        public static CanChi GetCanChi(ComboBox canCombobox, ComboBox chiCombobox)
        {
            return new CanChi
            {
                Can = ThienCan.GetCan(canCombobox.SelectedIndex + 1),
                Chi = DiaChi.GetChi(chiCombobox.SelectedIndex + 1),
            };
        }

    }
}
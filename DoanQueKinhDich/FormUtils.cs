using System.Windows.Forms;
using DoanQueKinhDich.UserControls;
using KinhDichCommon;

namespace DoanQueKinhDich
{
    public static class FormUtils
    {
        public static void ToggleTextAmDuong(Label label)
        {
            if (label.Text == Utils.Duong)
            {
                label.Text = Utils.Am;
            }
            else
            {
                label.Text = Utils.Duong;
            }
        }

        public static void ChangeTextAmDuong(ucLabel uiHao, CheckBox chkHaoDong, ucLabel uiHaoBien)
        {
            uiHaoBien.Checked = chkHaoDong.Checked ? !uiHao.Checked : uiHao.Checked;
        }

        public static void UpdateBatQuai(ComboBox batQuai, ucLabel haoThuong, ucLabel haoTrung, ucLabel haoHa)
        {
            if (haoThuong.Visible && haoTrung.Visible && haoHa.Visible)
            {
                BatQuai cung;
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
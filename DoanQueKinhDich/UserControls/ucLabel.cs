using System;
using System.Windows.Forms;
using KinhDichCommon;

namespace DoanQueKinhDich.UserControls
{
    public partial class ucLabel : Label
    {
        public event EventHandler CheckedChanged;
        public bool IsDuong => this.Text == Utils.Duong;
        public bool EnableClick { get; set; } = true;

        public bool Checked
        {
            get { return IsDuong; }
            set {
                this.Text = value ? Utils.Duong : Utils.Am;
                CheckedChanged?.Invoke(null, null);
            }
        }

        public ucLabel()
        {
            InitializeComponent();
        }

        private void uiHao_Click(object sender, EventArgs e)
        {
            ToggleAmDuongText();
        }

        private void ucLabel_Click(object sender, EventArgs e)
        {
            ToggleAmDuongText();
        }

        private void ToggleAmDuongText()
        {
            if (this.Enabled && EnableClick)
            {
                FormUtils.ToggleTextAmDuong(this);

                CheckedChanged?.Invoke(null, null);
            }
        }

    }
}

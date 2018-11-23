using System;
using System.Windows.Forms;
using DoanQueKinhDich.Business;
using DoanQueKinhDich.UserControls;
using KinhDichCommon;

namespace DoanQueKinhDich
{
    public partial class FormQueHoc : Form
    {
        private bool _luonHienKetQua = false;

        public FormQueHoc()
        {
            InitializeComponent();

            this.ucQueDon.CheckedChanged += new System.EventHandler(ucQueDon_CheckedChanged);
        }

        /// <summary>
        /// Form load event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            btnGo.PerformClick();
            btnShowResult.PerformClick();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            var rand = new Random(DateTime.Now.Millisecond);
            var index = rand.Next(100000) % 64;

            var que = Que.All[index];
            ucQueDon.SetQue(que);
        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            _luonHienKetQua = !_luonHienKetQua;

            UpdateKetQua();
        }

        private void UpdateKetQua()
        {
            if (_luonHienKetQua)
            {
                btnShowResult.Text = "Giấu kết quả (F2)";

                var que = ucQueDon.GetQue();
                labelKetQua.Text = $"{que.Name}";
                txtDesc.Text = que.GetQueDesc();
            }
            else
            {
                btnShowResult.Text = "Hiện kết quả (F2)";
                labelKetQua.Text = "";
                txtDesc.Text = "";
            }
        }

        private void FormQueHoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnGo.PerformClick();
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnShowResult.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void ucQueDon_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDesc.Text))
            {
                UpdateKetQua();
            }
        }
    }
}

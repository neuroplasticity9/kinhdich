using System;
using System.Text;
using System.Windows.Forms;
using DoanQueKinhDich.Business;
using DoanQueKinhDich.UserControls;
using KinhDichCommon;

namespace DoanQueKinhDich
{
    public partial class FormQueHoc : Form
    {
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
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            var rand = new Random(DateTime.Now.Millisecond);
            var index = rand.Next(100000) % 64;

            var que = Que.All[index];
            ucQueDon.SetQue(que);

            HienThiKetQua();
        }

        private void HienThiKetQua()
        {
            var que = ucQueDon.GetQue();
            //labelKetQua.Text = $"{que.Name}";
            txtDesc.Text = GetQueDescDeHoc(que);

        }

        private string GetQueDescDeHoc(Que que)
        {
            var sb = new StringBuilder();

            if (chkHienTenQue.Checked)
            {
                sb.AppendLine(que.Name);
                sb.AppendLine();
            }

            if (chkHienNghia.Checked)
            {
                sb.AppendLine(que.YNghia);
                sb.AppendLine();
            }

            if (chkHienTuong.Checked)
            {
                sb.AppendLine(que.TuongQue);
                sb.AppendLine();
            }

            return sb.ToString();
        }

        private void FormQueHoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnGo.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void ucQueDon_CheckedChanged(object sender, EventArgs e)
        {
            HienThiKetQua();
        }

        private void chkHienTuong_CheckedChanged(object sender, EventArgs e)
        {
            HienThiKetQua();
        }
    }
}

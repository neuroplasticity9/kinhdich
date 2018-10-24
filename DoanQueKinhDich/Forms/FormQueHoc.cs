using System;
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
            labelKetQua.Text = "";
            txtDesc.Text = "";

            var rand = new Random(DateTime.Now.Millisecond);
            var index = rand.Next(100000) % 64;

            var que = Que.All[index];
            ucQueDon.SetQue(que);
        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            var que = ucQueDon.GetQue();
            labelKetQua.Text = $"{que.Name}";

            txtDesc.Text = $"{que.EnglishName}{Environment.NewLine}{Environment.NewLine}{que.TuongQue}{Environment.NewLine}{Environment.NewLine}{que.YNghia}{Environment.NewLine}{Environment.NewLine}{que.ViDu}";
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
                btnShowResult.PerformClick();
            }
        }
    }
}

﻿using System;
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
            var id = rand.Next(100000) % 64;

            var que = Que.All[id];
            ucQueDon.SetQue(que);
        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            var que = ucQueDon.Que;
            labelKetQua.Text = $"{que.Name}";

            txtDesc.Text = $"{que.Name} ({que.EnglishName} - {que.TuongQue}): {que.YNghia}{Environment.NewLine}{que.ViDu}";
        }
    }
}

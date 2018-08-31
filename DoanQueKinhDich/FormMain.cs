﻿using System;
using System.Windows.Forms;
using KinhDichCommon;

namespace DoanQueKinhDich
{
    public partial class FormMain : Form
    {
        private string _queChuUrl;
        private string _queBienUrl;

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            CanChi nhatThan = GetNhatThan();
            CanChi nguyetKien = GetNguyetKien();

            Que queChu = QueDich.GetQue(chkHao6.Checked, chkHao5.Checked, chkHao4.Checked, chkHao3.Checked, chkHao2.Checked, chkHao1.Checked);
            linkQueChu.Visible = true;
            linkQueChu.Text = $"{queChu.NameShort} - Quẻ số {queChu.QueId}";
            _queChuUrl = GetUrl(queChu.Name, queChu.QueId);

            if (CoQueBien())
            {
                Que queBien = QueDich.GetQueBien(queChu, chkHao6Dong.Checked, chkHao5Dong.Checked, chkHao4Dong.Checked, chkHao3Dong.Checked, chkHao2Dong.Checked, chkHao1Dong.Checked);
                string queChuString = queChu.GetQueBienDesc(queBien, nhatThan, nguyetKien, chkHao6Dong.Checked, chkHao5Dong.Checked, chkHao4Dong.Checked, chkHao3Dong.Checked, chkHao2Dong.Checked, chkHao1Dong.Checked);
                txtQueChu.Text = queChuString;

                linkQueBien.Visible = true;
                linkQueBien.Text = $"{queBien.NameShort} - Quẻ số {queBien.QueId}";
                _queBienUrl = GetUrl(queBien.Name, queBien.QueId);
            }
            else
            {
                linkQueBien.Visible = false;
                string queChuString = queChu.GetQueDesc(nhatThan, nguyetKien, chkHao6Dong.Checked, chkHao5Dong.Checked, chkHao4Dong.Checked, chkHao3Dong.Checked, chkHao2Dong.Checked, chkHao1Dong.Checked);
                txtQueChu.Text = queChuString;
            }
        }

        private string GetUrl(string name, int queId)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return "http://cohoc.net/64-que-dich.html";
            }

            return $"http://cohoc.net/{name.Replace(" ", "-")}-kid-{queId}.html";
        }

        private bool CoQueBien()
        {
            return chkHao6Dong.Checked || chkHao5Dong.Checked || chkHao4Dong.Checked ||
                   chkHao3Dong.Checked || chkHao2Dong.Checked || chkHao1Dong.Checked;
        }

        private CanChi GetNguyetKien()
        {
            return GetCanChi(cbxThangCan.SelectedIndex, cbxThangChi.SelectedIndex);
        }

        private CanChi GetNhatThan()
        {
            return GetCanChi(cbxNgayCan.SelectedIndex, cbxNgayChi.SelectedIndex);
        }

        private CanChi GetCanChi(int canIndex, int chiIndex)
        {
            return new CanChi
            {
                Can = ThienCan.GetCan(canIndex + 1),
                Chi = DiaChi.GetChi(chiIndex + 1),
            };
        }

        /// <summary>
        /// Form load event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            linkQueChu.Visible = false;
            linkQueBien.Visible = false;

            cbxNgoaiQuai.SelectedIndex = 0;
            cbxNoiQuai.SelectedIndex = 0;

            SetNgayThangComboboxes(DateTime.Now);
        }

        private void SetNgayThangComboboxes(DateTime ngayLayQue)
        {
            CanChi ngayAm = ngayLayQue.ToAmLich().GetCanChiNgay();
            CanChi thangAm = ngayLayQue.ToAmLich().GetCanChiThang();

            cbxNgayCan.SelectedIndex = ngayAm.Can.Id - 1;
            cbxNgayChi.SelectedIndex = ngayAm.Chi.Id - 1;
            cbxThangCan.SelectedIndex = thangAm.Can.Id - 1;
            cbxThangChi.SelectedIndex = thangAm.Chi.Id - 1;
        }

        private void linkQueChu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(_queChuUrl);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void linkQueBien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(_queBienUrl);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void chkHao6_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(chkHao6);
            UpdateNgoaiQuai();
        }

        private void chkHao5_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(chkHao5);
            UpdateNgoaiQuai();
        }

        private void chkHao4_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(chkHao4);
            UpdateNgoaiQuai();
        }

        private void chkHao3_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(chkHao3);
            UpdateNoiQuai();
        }

        private void chkHao2_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(chkHao2);
            UpdateNoiQuai();
        }

        private void chkHao1_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(chkHao1);
            UpdateNoiQuai();
        }

        private void UpdateNgoaiQuai()
        {
            FormUtils.UpdateBatQuai(cbxNgoaiQuai, chkHao6, chkHao5, chkHao4);
        }

        private void UpdateNoiQuai()
        {
            FormUtils.UpdateBatQuai(cbxNoiQuai, chkHao3, chkHao2, chkHao1);
        }

        private void cbxNgoaiQuai_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cung cung = BatQuai.All[cbxNgoaiQuai.SelectedIndex];
            chkHao6.Checked = cung.Duong3;
            chkHao5.Checked = cung.Duong2;
            chkHao4.Checked = cung.Duong1;
        }

        private void cbxNoiQuai_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cung cung = BatQuai.All[cbxNoiQuai.SelectedIndex];
            chkHao3.Checked = cung.Duong3;
            chkHao2.Checked = cung.Duong2;
            chkHao1.Checked = cung.Duong1;
        }

        private void LoadQue(IQue que)
        {
            if (que.IsDone)
            {
                chkHao6.Checked = que.Hao6;
                chkHao5.Checked = que.Hao5;
                chkHao4.Checked = que.Hao4;
                chkHao3.Checked = que.Hao3;
                chkHao2.Checked = que.Hao2;
                chkHao1.Checked = que.Hao1;

                chkHao6Dong.Checked = que.Hao6Dong;
                chkHao5Dong.Checked = que.Hao5Dong;
                chkHao4Dong.Checked = que.Hao4Dong;
                chkHao3Dong.Checked = que.Hao3Dong;
                chkHao2Dong.Checked = que.Hao2Dong;
                chkHao1Dong.Checked = que.Hao1Dong;

                cbxNgayCan.SelectedIndex = que.NgayAm.Can.Id - 1;
                cbxNgayChi.SelectedIndex = que.NgayAm.Chi.Id - 1;

                cbxThangCan.SelectedIndex = que.ThangAm.Can.Id - 1;
                cbxThangChi.SelectedIndex = que.ThangAm.Chi.Id - 1;

                btnGo.PerformClick();
            }
        }

        private void linkAmLich_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://lichvannien.vietbao.vn/");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtQueChu.Text);
        }

        private void btnLayQue_Click(object sender, EventArgs e)
        {
            var formLayQue = new FormQueTungXu();

            formLayQue.ShowDialog(this);

            LoadQue(formLayQue);
        }

        private void btnLayQueTheoNgay_Click(object sender, EventArgs e)
        {
            var formLayQue = new FormQueThoiGian();

            formLayQue.ShowDialog(this);

            LoadQue(formLayQue);
        }
    }
}
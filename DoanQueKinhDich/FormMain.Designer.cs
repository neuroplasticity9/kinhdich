﻿namespace DoanQueKinhDich
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnGo = new System.Windows.Forms.Button();
            this.txtQueChu = new System.Windows.Forms.RichTextBox();
            this.cbxNgayCan = new System.Windows.Forms.ComboBox();
            this.cbxNgayChi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxThangChi = new System.Windows.Forms.ComboBox();
            this.cbxThangCan = new System.Windows.Forms.ComboBox();
            this.linkQueChu = new System.Windows.Forms.LinkLabel();
            this.linkQueBien = new System.Windows.Forms.LinkLabel();
            this.btnLayQue = new System.Windows.Forms.Button();
            this.linkAmLich = new System.Windows.Forms.LinkLabel();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnLayQueTheoNgay = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ucQueDich = new DoanQueKinhDich.ucQue();
            this.chkNotUseNhatThanNguyetKien = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(1207, 114);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(156, 83);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Hiện Quẻ";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtQueChu
            // 
            this.txtQueChu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQueChu.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueChu.Location = new System.Drawing.Point(17, 241);
            this.txtQueChu.Margin = new System.Windows.Forms.Padding(2);
            this.txtQueChu.Name = "txtQueChu";
            this.txtQueChu.Size = new System.Drawing.Size(1737, 305);
            this.txtQueChu.TabIndex = 11;
            this.txtQueChu.Text = "";
            // 
            // cbxNgayCan
            // 
            this.cbxNgayCan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNgayCan.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNgayCan.FormattingEnabled = true;
            this.cbxNgayCan.Items.AddRange(new object[] {
            "Giáp",
            "Ất",
            "Bính",
            "Đinh",
            "Mậu",
            "Kỷ",
            "Canh",
            "Tân",
            "Nhâm",
            "Quý"});
            this.cbxNgayCan.Location = new System.Drawing.Point(33, 56);
            this.cbxNgayCan.Margin = new System.Windows.Forms.Padding(2);
            this.cbxNgayCan.MaxDropDownItems = 12;
            this.cbxNgayCan.Name = "cbxNgayCan";
            this.cbxNgayCan.Size = new System.Drawing.Size(92, 29);
            this.cbxNgayCan.TabIndex = 19;
            // 
            // cbxNgayChi
            // 
            this.cbxNgayChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNgayChi.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNgayChi.FormattingEnabled = true;
            this.cbxNgayChi.Items.AddRange(new object[] {
            "Tí",
            "Sửu",
            "Dần",
            "Mão",
            "Thìn",
            "Tỵ",
            "Ngọ",
            "Mùi",
            "Thân",
            "Dậu",
            "Tuất",
            "Hợi"});
            this.cbxNgayChi.Location = new System.Drawing.Point(144, 56);
            this.cbxNgayChi.Margin = new System.Windows.Forms.Padding(2);
            this.cbxNgayChi.MaxDropDownItems = 12;
            this.cbxNgayChi.Name = "cbxNgayChi";
            this.cbxNgayChi.Size = new System.Drawing.Size(92, 29);
            this.cbxNgayChi.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tháng";
            // 
            // cbxThangChi
            // 
            this.cbxThangChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxThangChi.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxThangChi.FormattingEnabled = true;
            this.cbxThangChi.Items.AddRange(new object[] {
            "Tí",
            "Sửu",
            "Dần",
            "Mão",
            "Thìn",
            "Tỵ",
            "Ngọ",
            "Mùi",
            "Thân",
            "Dậu",
            "Tuất",
            "Hợi"});
            this.cbxThangChi.Location = new System.Drawing.Point(144, 130);
            this.cbxThangChi.Margin = new System.Windows.Forms.Padding(2);
            this.cbxThangChi.MaxDropDownItems = 12;
            this.cbxThangChi.Name = "cbxThangChi";
            this.cbxThangChi.Size = new System.Drawing.Size(92, 29);
            this.cbxThangChi.TabIndex = 23;
            // 
            // cbxThangCan
            // 
            this.cbxThangCan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxThangCan.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxThangCan.FormattingEnabled = true;
            this.cbxThangCan.Items.AddRange(new object[] {
            "Giáp",
            "Ất",
            "Bính",
            "Đinh",
            "Mậu",
            "Kỷ",
            "Canh",
            "Tân",
            "Nhâm",
            "Quý"});
            this.cbxThangCan.Location = new System.Drawing.Point(33, 130);
            this.cbxThangCan.Margin = new System.Windows.Forms.Padding(2);
            this.cbxThangCan.MaxDropDownItems = 12;
            this.cbxThangCan.Name = "cbxThangCan";
            this.cbxThangCan.Size = new System.Drawing.Size(92, 29);
            this.cbxThangCan.TabIndex = 22;
            // 
            // linkQueChu
            // 
            this.linkQueChu.AutoSize = true;
            this.linkQueChu.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkQueChu.Location = new System.Drawing.Point(49, 213);
            this.linkQueChu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkQueChu.Name = "linkQueChu";
            this.linkQueChu.Size = new System.Drawing.Size(208, 21);
            this.linkQueChu.TabIndex = 27;
            this.linkQueChu.TabStop = true;
            this.linkQueChu.Text = "Xem quẻ chủ online";
            this.linkQueChu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkQueChu_LinkClicked);
            // 
            // linkQueBien
            // 
            this.linkQueBien.AutoSize = true;
            this.linkQueBien.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkQueBien.Location = new System.Drawing.Point(930, 213);
            this.linkQueBien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkQueBien.Name = "linkQueBien";
            this.linkQueBien.Size = new System.Drawing.Size(219, 21);
            this.linkQueBien.TabIndex = 28;
            this.linkQueBien.TabStop = true;
            this.linkQueBien.Text = "Xem quẻ biến online";
            this.linkQueBien.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkQueBien_LinkClicked);
            // 
            // btnLayQue
            // 
            this.btnLayQue.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayQue.Location = new System.Drawing.Point(17, 47);
            this.btnLayQue.Margin = new System.Windows.Forms.Padding(2);
            this.btnLayQue.Name = "btnLayQue";
            this.btnLayQue.Size = new System.Drawing.Size(240, 48);
            this.btnLayQue.TabIndex = 33;
            this.btnLayQue.Text = "Tung Xu Lấy Quẻ";
            this.btnLayQue.UseVisualStyleBackColor = true;
            this.btnLayQue.Click += new System.EventHandler(this.btnLayQue_Click);
            // 
            // linkAmLich
            // 
            this.linkAmLich.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkAmLich.AutoSize = true;
            this.linkAmLich.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAmLich.Location = new System.Drawing.Point(1486, 12);
            this.linkAmLich.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkAmLich.Name = "linkAmLich";
            this.linkAmLich.Size = new System.Drawing.Size(274, 21);
            this.linkAmLich.TabIndex = 34;
            this.linkAmLich.TabStop = true;
            this.linkAmLich.Text = "Xem lịch vạn niên online";
            this.linkAmLich.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAmLich_LinkClicked);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(1600, 186);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(154, 48);
            this.btnCopy.TabIndex = 35;
            this.btnCopy.Text = "Copy Quẻ";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnLayQueTheoNgay
            // 
            this.btnLayQueTheoNgay.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayQueTheoNgay.Location = new System.Drawing.Point(17, 121);
            this.btnLayQueTheoNgay.Margin = new System.Windows.Forms.Padding(2);
            this.btnLayQueTheoNgay.Name = "btnLayQueTheoNgay";
            this.btnLayQueTheoNgay.Size = new System.Drawing.Size(240, 48);
            this.btnLayQueTheoNgay.TabIndex = 36;
            this.btnLayQueTheoNgay.Text = "Lấy Quẻ Theo Ngày";
            this.btnLayQueTheoNgay.UseVisualStyleBackColor = true;
            this.btnLayQueTheoNgay.Click += new System.EventHandler(this.btnLayQueTheoNgay_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxNgayChi);
            this.groupBox2.Controls.Add(this.cbxNgayCan);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbxThangCan);
            this.groupBox2.Controls.Add(this.cbxThangChi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(290, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(269, 195);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // ucQueDich
            // 
            this.ucQueDich.Location = new System.Drawing.Point(592, 8);
            this.ucQueDich.Name = "ucQueDich";
            this.ucQueDich.Size = new System.Drawing.Size(585, 189);
            this.ucQueDich.TabIndex = 39;
            // 
            // chkNotUseNhatThanNguyetKien
            // 
            this.chkNotUseNhatThanNguyetKien.AutoSize = true;
            this.chkNotUseNhatThanNguyetKien.Font = new System.Drawing.Font("Courier New", 14F);
            this.chkNotUseNhatThanNguyetKien.Location = new System.Drawing.Point(1207, 62);
            this.chkNotUseNhatThanNguyetKien.Name = "chkNotUseNhatThanNguyetKien";
            this.chkNotUseNhatThanNguyetKien.Size = new System.Drawing.Size(414, 25);
            this.chkNotUseNhatThanNguyetKien.TabIndex = 42;
            this.chkNotUseNhatThanNguyetKien.Text = "Không dùng nhật thần và nguyệt kiến";
            this.chkNotUseNhatThanNguyetKien.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 566);
            this.Controls.Add(this.chkNotUseNhatThanNguyetKien);
            this.Controls.Add(this.ucQueDich);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLayQueTheoNgay);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.linkAmLich);
            this.Controls.Add(this.btnLayQue);
            this.Controls.Add(this.linkQueBien);
            this.Controls.Add(this.linkQueChu);
            this.Controls.Add(this.txtQueChu);
            this.Controls.Add(this.btnGo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Kinh Dịch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.RichTextBox txtQueChu;
        private System.Windows.Forms.ComboBox cbxNgayCan;
        private System.Windows.Forms.ComboBox cbxNgayChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxThangChi;
        private System.Windows.Forms.ComboBox cbxThangCan;
        private System.Windows.Forms.LinkLabel linkQueChu;
        private System.Windows.Forms.LinkLabel linkQueBien;
        private System.Windows.Forms.Button btnLayQue;
        private System.Windows.Forms.LinkLabel linkAmLich;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnLayQueTheoNgay;
        private System.Windows.Forms.GroupBox groupBox2;
        private ucQue ucQueDich;
        private System.Windows.Forms.CheckBox chkNotUseNhatThanNguyetKien;
    }
}


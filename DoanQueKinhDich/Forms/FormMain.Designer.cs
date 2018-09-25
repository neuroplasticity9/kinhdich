namespace DoanQueKinhDich
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
            this.txtQueDesc = new System.Windows.Forms.RichTextBox();
            this.cbxNgayCan = new System.Windows.Forms.ComboBox();
            this.cbxNgayChi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxThangChi = new System.Windows.Forms.ComboBox();
            this.cbxThangCan = new System.Windows.Forms.ComboBox();
            this.linkQueChu = new System.Windows.Forms.LinkLabel();
            this.linkQueBien = new System.Windows.Forms.LinkLabel();
            this.btnTungXuLayQue = new System.Windows.Forms.Button();
            this.linkAmLich = new System.Windows.Forms.LinkLabel();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnLayQueMaiHoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radLucHao = new System.Windows.Forms.RadioButton();
            this.radMaiHoa = new System.Windows.Forms.RadioButton();
            this.linkQueHo = new System.Windows.Forms.LinkLabel();
            this.ucQueDich = new DoanQueKinhDich.UserControls.ucQue();
            this.radVietDich = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQueDesc
            // 
            this.txtQueDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQueDesc.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueDesc.Location = new System.Drawing.Point(17, 266);
            this.txtQueDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtQueDesc.Name = "txtQueDesc";
            this.txtQueDesc.Size = new System.Drawing.Size(1737, 537);
            this.txtQueDesc.TabIndex = 10;
            this.txtQueDesc.TabStop = false;
            this.txtQueDesc.Text = "";
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
            this.cbxNgayCan.Location = new System.Drawing.Point(35, 127);
            this.cbxNgayCan.Margin = new System.Windows.Forms.Padding(2);
            this.cbxNgayCan.MaxDropDownItems = 12;
            this.cbxNgayCan.Name = "cbxNgayCan";
            this.cbxNgayCan.Size = new System.Drawing.Size(92, 29);
            this.cbxNgayCan.TabIndex = 2;
            this.cbxNgayCan.SelectedIndexChanged += new System.EventHandler(this.cbxNgayCan_SelectedIndexChanged);
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
            this.cbxNgayChi.Location = new System.Drawing.Point(146, 127);
            this.cbxNgayChi.Margin = new System.Windows.Forms.Padding(2);
            this.cbxNgayChi.MaxDropDownItems = 12;
            this.cbxNgayChi.Name = "cbxNgayChi";
            this.cbxNgayChi.Size = new System.Drawing.Size(92, 29);
            this.cbxNgayChi.TabIndex = 3;
            this.cbxNgayChi.SelectedIndexChanged += new System.EventHandler(this.cbxNgayChi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 101);
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
            this.label2.Location = new System.Drawing.Point(32, 27);
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
            this.cbxThangChi.Location = new System.Drawing.Point(146, 53);
            this.cbxThangChi.Margin = new System.Windows.Forms.Padding(2);
            this.cbxThangChi.MaxDropDownItems = 12;
            this.cbxThangChi.Name = "cbxThangChi";
            this.cbxThangChi.Size = new System.Drawing.Size(92, 29);
            this.cbxThangChi.TabIndex = 1;
            this.cbxThangChi.SelectedIndexChanged += new System.EventHandler(this.cbxThangChi_SelectedIndexChanged);
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
            this.cbxThangCan.Location = new System.Drawing.Point(35, 53);
            this.cbxThangCan.Margin = new System.Windows.Forms.Padding(2);
            this.cbxThangCan.MaxDropDownItems = 12;
            this.cbxThangCan.Name = "cbxThangCan";
            this.cbxThangCan.Size = new System.Drawing.Size(92, 29);
            this.cbxThangCan.TabIndex = 0;
            this.cbxThangCan.SelectedIndexChanged += new System.EventHandler(this.cbxThangCan_SelectedIndexChanged);
            // 
            // linkQueChu
            // 
            this.linkQueChu.AutoSize = true;
            this.linkQueChu.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkQueChu.Location = new System.Drawing.Point(49, 229);
            this.linkQueChu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkQueChu.Name = "linkQueChu";
            this.linkQueChu.Size = new System.Drawing.Size(264, 27);
            this.linkQueChu.TabIndex = 7;
            this.linkQueChu.TabStop = true;
            this.linkQueChu.Text = "Xem quẻ chủ online";
            this.linkQueChu.Visible = false;
            this.linkQueChu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkQueChu_LinkClicked);
            // 
            // linkQueBien
            // 
            this.linkQueBien.AutoSize = true;
            this.linkQueBien.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkQueBien.Location = new System.Drawing.Point(1081, 229);
            this.linkQueBien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkQueBien.Name = "linkQueBien";
            this.linkQueBien.Size = new System.Drawing.Size(278, 27);
            this.linkQueBien.TabIndex = 9;
            this.linkQueBien.TabStop = true;
            this.linkQueBien.Text = "Xem quẻ biến online";
            this.linkQueBien.Visible = false;
            this.linkQueBien.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkQueBien_LinkClicked);
            // 
            // btnTungXuLayQue
            // 
            this.btnTungXuLayQue.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTungXuLayQue.Location = new System.Drawing.Point(17, 47);
            this.btnTungXuLayQue.Margin = new System.Windows.Forms.Padding(2);
            this.btnTungXuLayQue.Name = "btnTungXuLayQue";
            this.btnTungXuLayQue.Size = new System.Drawing.Size(240, 48);
            this.btnTungXuLayQue.TabIndex = 0;
            this.btnTungXuLayQue.Text = "Tung Xu Lấy Quẻ";
            this.btnTungXuLayQue.UseVisualStyleBackColor = true;
            this.btnTungXuLayQue.Click += new System.EventHandler(this.btnTungXuLayQue_Click);
            // 
            // linkAmLich
            // 
            this.linkAmLich.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkAmLich.AutoSize = true;
            this.linkAmLich.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAmLich.Location = new System.Drawing.Point(1486, 10);
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
            // btnLayQueMaiHoa
            // 
            this.btnLayQueMaiHoa.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayQueMaiHoa.Location = new System.Drawing.Point(17, 121);
            this.btnLayQueMaiHoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnLayQueMaiHoa.Name = "btnLayQueMaiHoa";
            this.btnLayQueMaiHoa.Size = new System.Drawing.Size(240, 48);
            this.btnLayQueMaiHoa.TabIndex = 1;
            this.btnLayQueMaiHoa.Text = "Lấy Quẻ Mai Hoa";
            this.btnLayQueMaiHoa.UseVisualStyleBackColor = true;
            this.btnLayQueMaiHoa.Click += new System.EventHandler(this.btnLayQueMaiHoa_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(290, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(269, 208);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // radLucHao
            // 
            this.radLucHao.AutoSize = true;
            this.radLucHao.Checked = true;
            this.radLucHao.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLucHao.Location = new System.Drawing.Point(1309, 43);
            this.radLucHao.Name = "radLucHao";
            this.radLucHao.Size = new System.Drawing.Size(105, 25);
            this.radLucHao.TabIndex = 4;
            this.radLucHao.TabStop = true;
            this.radLucHao.Text = "Lục Hào";
            this.radLucHao.UseVisualStyleBackColor = true;
            this.radLucHao.CheckedChanged += new System.EventHandler(this.radMaiHoa_CheckedChanged);
            // 
            // radMaiHoa
            // 
            this.radMaiHoa.AutoSize = true;
            this.radMaiHoa.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMaiHoa.Location = new System.Drawing.Point(1309, 104);
            this.radMaiHoa.Name = "radMaiHoa";
            this.radMaiHoa.Size = new System.Drawing.Size(105, 25);
            this.radMaiHoa.TabIndex = 5;
            this.radMaiHoa.Text = "Mai Hoa";
            this.radMaiHoa.UseVisualStyleBackColor = true;
            this.radMaiHoa.CheckedChanged += new System.EventHandler(this.radMaiHoa_CheckedChanged);
            // 
            // linkQueHo
            // 
            this.linkQueHo.AutoSize = true;
            this.linkQueHo.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkQueHo.Location = new System.Drawing.Point(599, 229);
            this.linkQueHo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkQueHo.Name = "linkQueHo";
            this.linkQueHo.Size = new System.Drawing.Size(250, 27);
            this.linkQueHo.TabIndex = 8;
            this.linkQueHo.TabStop = true;
            this.linkQueHo.Text = "Xem quẻ hỗ online";
            this.linkQueHo.Visible = false;
            this.linkQueHo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkQueHo_LinkClicked);
            // 
            // ucQueDich
            // 
            this.ucQueDich.Location = new System.Drawing.Point(592, 8);
            this.ucQueDich.Name = "ucQueDich";
            this.ucQueDich.Size = new System.Drawing.Size(685, 210);
            this.ucQueDich.TabIndex = 3;
            // 
            // radVietDich
            // 
            this.radVietDich.AutoSize = true;
            this.radVietDich.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radVietDich.Location = new System.Drawing.Point(1309, 163);
            this.radVietDich.Name = "radVietDich";
            this.radVietDich.Size = new System.Drawing.Size(127, 25);
            this.radVietDich.TabIndex = 36;
            this.radVietDich.Text = "Việt Dịch";
            this.radVietDich.UseVisualStyleBackColor = true;
            this.radVietDich.CheckedChanged += new System.EventHandler(this.radMaiHoa_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 823);
            this.Controls.Add(this.radVietDich);
            this.Controls.Add(this.linkQueHo);
            this.Controls.Add(this.radMaiHoa);
            this.Controls.Add(this.radLucHao);
            this.Controls.Add(this.ucQueDich);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLayQueMaiHoa);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.linkAmLich);
            this.Controls.Add(this.btnTungXuLayQue);
            this.Controls.Add(this.linkQueBien);
            this.Controls.Add(this.linkQueChu);
            this.Controls.Add(this.txtQueDesc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Lấy Quẻ Kinh Dịch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtQueDesc;
        private System.Windows.Forms.ComboBox cbxNgayCan;
        private System.Windows.Forms.ComboBox cbxNgayChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxThangChi;
        private System.Windows.Forms.ComboBox cbxThangCan;
        private System.Windows.Forms.LinkLabel linkQueChu;
        private System.Windows.Forms.LinkLabel linkQueBien;
        private System.Windows.Forms.Button btnTungXuLayQue;
        private System.Windows.Forms.LinkLabel linkAmLich;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnLayQueMaiHoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private UserControls.ucQue ucQueDich;
        private System.Windows.Forms.RadioButton radLucHao;
        private System.Windows.Forms.RadioButton radMaiHoa;
        private System.Windows.Forms.LinkLabel linkQueHo;
        private System.Windows.Forms.RadioButton radVietDich;
    }
}


namespace DoanQueKinhDich
{
    partial class FormQueThoiGian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQueThoiGian));
            this.btnGo = new System.Windows.Forms.Button();
            this.cbxNgayCan = new System.Windows.Forms.ComboBox();
            this.cbxNgayChi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxThangChi = new System.Windows.Forms.ComboBox();
            this.cbxThangCan = new System.Windows.Forms.ComboBox();
            this.uiDate = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxNamChi = new System.Windows.Forms.ComboBox();
            this.cbxNamCan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxGioChi = new System.Windows.Forms.ComboBox();
            this.cbxGioCan = new System.Windows.Forms.ComboBox();
            this.chkUseNamCan = new System.Windows.Forms.CheckBox();
            this.uiDatePicker = new System.Windows.Forms.DateTimePicker();
            this.uiHour = new System.Windows.Forms.DateTimePicker();
            this.labelNgayAmLich = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ucQueDich = new DoanQueKinhDich.ucQue();
            this.labelNgayDuongLich = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(813, 306);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(140, 75);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Lấy Quẻ";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // cbxNgayCan
            // 
            this.cbxNgayCan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNgayCan.Enabled = false;
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
            this.cbxNgayCan.Location = new System.Drawing.Point(292, 209);
            this.cbxNgayCan.Margin = new System.Windows.Forms.Padding(2);
            this.cbxNgayCan.MaxDropDownItems = 12;
            this.cbxNgayCan.Name = "cbxNgayCan";
            this.cbxNgayCan.Size = new System.Drawing.Size(92, 29);
            this.cbxNgayCan.TabIndex = 19;
            // 
            // cbxNgayChi
            // 
            this.cbxNgayChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNgayChi.Enabled = false;
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
            this.cbxNgayChi.Location = new System.Drawing.Point(402, 209);
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
            this.label1.Location = new System.Drawing.Point(289, 183);
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
            this.label2.Location = new System.Drawing.Point(289, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tháng";
            // 
            // cbxThangChi
            // 
            this.cbxThangChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxThangChi.Enabled = false;
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
            this.cbxThangChi.Location = new System.Drawing.Point(402, 137);
            this.cbxThangChi.Margin = new System.Windows.Forms.Padding(2);
            this.cbxThangChi.MaxDropDownItems = 12;
            this.cbxThangChi.Name = "cbxThangChi";
            this.cbxThangChi.Size = new System.Drawing.Size(92, 29);
            this.cbxThangChi.TabIndex = 23;
            // 
            // cbxThangCan
            // 
            this.cbxThangCan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxThangCan.Enabled = false;
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
            this.cbxThangCan.Location = new System.Drawing.Point(292, 137);
            this.cbxThangCan.Margin = new System.Windows.Forms.Padding(2);
            this.cbxThangCan.MaxDropDownItems = 12;
            this.cbxThangCan.Name = "cbxThangCan";
            this.cbxThangCan.Size = new System.Drawing.Size(92, 29);
            this.cbxThangCan.TabIndex = 22;
            // 
            // uiDate
            // 
            this.uiDate.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.uiDate.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiDate.Location = new System.Drawing.Point(25, 76);
            this.uiDate.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.uiDate.MaxSelectionCount = 1;
            this.uiDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.uiDate.Name = "uiDate";
            this.uiDate.TabIndex = 1;
            this.uiDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.uiDate_DateChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(289, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 37;
            this.label5.Text = "Năm";
            // 
            // cbxNamChi
            // 
            this.cbxNamChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNamChi.Enabled = false;
            this.cbxNamChi.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNamChi.FormattingEnabled = true;
            this.cbxNamChi.Items.AddRange(new object[] {
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
            this.cbxNamChi.Location = new System.Drawing.Point(402, 61);
            this.cbxNamChi.Margin = new System.Windows.Forms.Padding(2);
            this.cbxNamChi.MaxDropDownItems = 12;
            this.cbxNamChi.Name = "cbxNamChi";
            this.cbxNamChi.Size = new System.Drawing.Size(92, 29);
            this.cbxNamChi.TabIndex = 36;
            // 
            // cbxNamCan
            // 
            this.cbxNamCan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNamCan.Enabled = false;
            this.cbxNamCan.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNamCan.FormattingEnabled = true;
            this.cbxNamCan.Items.AddRange(new object[] {
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
            this.cbxNamCan.Location = new System.Drawing.Point(292, 61);
            this.cbxNamCan.Margin = new System.Windows.Forms.Padding(2);
            this.cbxNamCan.MaxDropDownItems = 12;
            this.cbxNamCan.Name = "cbxNamCan";
            this.cbxNamCan.Size = new System.Drawing.Size(92, 29);
            this.cbxNamCan.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 255);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 21);
            this.label6.TabIndex = 40;
            this.label6.Text = "Giờ";
            // 
            // cbxGioChi
            // 
            this.cbxGioChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGioChi.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGioChi.FormattingEnabled = true;
            this.cbxGioChi.Items.AddRange(new object[] {
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
            this.cbxGioChi.Location = new System.Drawing.Point(403, 281);
            this.cbxGioChi.Margin = new System.Windows.Forms.Padding(2);
            this.cbxGioChi.MaxDropDownItems = 12;
            this.cbxGioChi.Name = "cbxGioChi";
            this.cbxGioChi.Size = new System.Drawing.Size(92, 29);
            this.cbxGioChi.TabIndex = 39;
            this.cbxGioChi.SelectedIndexChanged += new System.EventHandler(this.cbxGioChi_SelectedIndexChanged);
            // 
            // cbxGioCan
            // 
            this.cbxGioCan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGioCan.Enabled = false;
            this.cbxGioCan.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGioCan.FormattingEnabled = true;
            this.cbxGioCan.Items.AddRange(new object[] {
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
            this.cbxGioCan.Location = new System.Drawing.Point(293, 281);
            this.cbxGioCan.Margin = new System.Windows.Forms.Padding(2);
            this.cbxGioCan.MaxDropDownItems = 12;
            this.cbxGioCan.Name = "cbxGioCan";
            this.cbxGioCan.Size = new System.Drawing.Size(92, 29);
            this.cbxGioCan.TabIndex = 38;
            // 
            // chkUseNamCan
            // 
            this.chkUseNamCan.AutoSize = true;
            this.chkUseNamCan.Font = new System.Drawing.Font("Courier New", 14F);
            this.chkUseNamCan.Location = new System.Drawing.Point(724, 258);
            this.chkUseNamCan.Name = "chkUseNamCan";
            this.chkUseNamCan.Size = new System.Drawing.Size(348, 25);
            this.chkUseNamCan.TabIndex = 41;
            this.chkUseNamCan.Text = "Dùng Can của năm để tính quẻ.";
            this.chkUseNamCan.UseVisualStyleBackColor = true;
            this.chkUseNamCan.CheckedChanged += new System.EventHandler(this.chkUseNamCan_CheckedChanged);
            // 
            // uiDatePicker
            // 
            this.uiDatePicker.CalendarFont = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiDatePicker.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.uiDatePicker.Location = new System.Drawing.Point(25, 36);
            this.uiDatePicker.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.uiDatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.uiDatePicker.Name = "uiDatePicker";
            this.uiDatePicker.Size = new System.Drawing.Size(227, 29);
            this.uiDatePicker.TabIndex = 42;
            this.uiDatePicker.ValueChanged += new System.EventHandler(this.uiDatePicker_ValueChanged);
            // 
            // uiHour
            // 
            this.uiHour.CalendarFont = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiHour.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uiHour.Location = new System.Drawing.Point(25, 281);
            this.uiHour.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.uiHour.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.uiHour.Name = "uiHour";
            this.uiHour.Size = new System.Drawing.Size(227, 29);
            this.uiHour.TabIndex = 43;
            this.uiHour.ValueChanged += new System.EventHandler(this.uiHour_ValueChanged);
            // 
            // labelNgayAmLich
            // 
            this.labelNgayAmLich.AutoSize = true;
            this.labelNgayAmLich.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayAmLich.Location = new System.Drawing.Point(21, 338);
            this.labelNgayAmLich.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNgayAmLich.Name = "labelNgayAmLich";
            this.labelNgayAmLich.Size = new System.Drawing.Size(153, 21);
            this.labelNgayAmLich.TabIndex = 44;
            this.labelNgayAmLich.Text = "Ngày âm lịch:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelNgayDuongLich);
            this.groupBox2.Controls.Add(this.cbxGioChi);
            this.groupBox2.Controls.Add(this.cbxNgayCan);
            this.groupBox2.Controls.Add(this.labelNgayAmLich);
            this.groupBox2.Controls.Add(this.cbxNgayChi);
            this.groupBox2.Controls.Add(this.uiHour);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.uiDatePicker);
            this.groupBox2.Controls.Add(this.cbxThangCan);
            this.groupBox2.Controls.Add(this.cbxThangChi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.uiDate);
            this.groupBox2.Controls.Add(this.cbxGioCan);
            this.groupBox2.Controls.Add(this.cbxNamCan);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbxNamChi);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(527, 414);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            // 
            // ucQueDich
            // 
            this.ucQueDich.Location = new System.Drawing.Point(564, 40);
            this.ucQueDich.Name = "ucQueDich";
            this.ucQueDich.Size = new System.Drawing.Size(608, 189);
            this.ucQueDich.TabIndex = 47;
            // 
            // labelNgayDuongLich
            // 
            this.labelNgayDuongLich.AutoSize = true;
            this.labelNgayDuongLich.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayDuongLich.Location = new System.Drawing.Point(21, 375);
            this.labelNgayDuongLich.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNgayDuongLich.Name = "labelNgayDuongLich";
            this.labelNgayDuongLich.Size = new System.Drawing.Size(186, 21);
            this.labelNgayDuongLich.TabIndex = 45;
            this.labelNgayDuongLich.Text = "Ngày dương lịch:";
            // 
            // FormQueThoiGian
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 445);
            this.Controls.Add(this.ucQueDich);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chkUseNamCan);
            this.Controls.Add(this.btnGo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQueThoiGian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lấy Quẻ Thời Gian";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ComboBox cbxNgayCan;
        private System.Windows.Forms.ComboBox cbxNgayChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxThangChi;
        private System.Windows.Forms.ComboBox cbxThangCan;
        private System.Windows.Forms.MonthCalendar uiDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxNamChi;
        private System.Windows.Forms.ComboBox cbxNamCan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxGioChi;
        private System.Windows.Forms.ComboBox cbxGioCan;
        private System.Windows.Forms.CheckBox chkUseNamCan;
        private System.Windows.Forms.DateTimePicker uiDatePicker;
        private System.Windows.Forms.DateTimePicker uiHour;
        private System.Windows.Forms.Label labelNgayAmLich;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelNgayDuongLich;
        private ucQue ucQueDich;
    }
}


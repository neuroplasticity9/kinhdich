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
            this.labelNgayDuongLich = new System.Windows.Forms.Label();
            this.radNgoaiSo = new System.Windows.Forms.RadioButton();
            this.radThoiGian = new System.Windows.Forms.RadioButton();
            this.radioNgoaiSoNoiSo = new System.Windows.Forms.RadioButton();
            this.txtQueNgoai1 = new System.Windows.Forms.TextBox();
            this.txtQueNgoai2 = new System.Windows.Forms.TextBox();
            this.txtQueNoi2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoHoacChu = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radHauThien = new System.Windows.Forms.RadioButton();
            this.radTienThien = new System.Windows.Forms.RadioButton();
            this.ucQueDich = new DoanQueKinhDich.UserControls.ucQue();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(922, 449);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(140, 47);
            this.btnGo.TabIndex = 3;
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
            this.cbxGioChi.TabIndex = 3;
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
            this.chkUseNamCan.Location = new System.Drawing.Point(192, 59);
            this.chkUseNamCan.Name = "chkUseNamCan";
            this.chkUseNamCan.Size = new System.Drawing.Size(348, 25);
            this.chkUseNamCan.TabIndex = 1;
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
            this.uiDatePicker.TabIndex = 0;
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
            this.uiHour.TabIndex = 2;
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
            this.groupBox2.Location = new System.Drawing.Point(730, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(522, 419);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
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
            // radNgoaiSo
            // 
            this.radNgoaiSo.AutoSize = true;
            this.radNgoaiSo.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNgoaiSo.Location = new System.Drawing.Point(28, 134);
            this.radNgoaiSo.Name = "radNgoaiSo";
            this.radNgoaiSo.Size = new System.Drawing.Size(479, 25);
            this.radNgoaiSo.TabIndex = 2;
            this.radNgoaiSo.Text = "Quẻ ngoại dùng số, quẻ nội dùng thời gian";
            this.radNgoaiSo.UseVisualStyleBackColor = true;
            this.radNgoaiSo.CheckedChanged += new System.EventHandler(this.radNgoaiSo_CheckedChanged);
            // 
            // radThoiGian
            // 
            this.radThoiGian.AutoSize = true;
            this.radThoiGian.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radThoiGian.Location = new System.Drawing.Point(29, 28);
            this.radThoiGian.Name = "radThoiGian";
            this.radThoiGian.Size = new System.Drawing.Size(182, 25);
            this.radThoiGian.TabIndex = 0;
            this.radThoiGian.Text = "Dùng thời gian";
            this.radThoiGian.UseVisualStyleBackColor = true;
            this.radThoiGian.CheckedChanged += new System.EventHandler(this.radThoiGian_CheckedChanged);
            // 
            // radioNgoaiSoNoiSo
            // 
            this.radioNgoaiSoNoiSo.AutoSize = true;
            this.radioNgoaiSoNoiSo.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNgoaiSoNoiSo.Location = new System.Drawing.Point(28, 208);
            this.radioNgoaiSoNoiSo.Name = "radioNgoaiSoNoiSo";
            this.radioNgoaiSoNoiSo.Size = new System.Drawing.Size(402, 25);
            this.radioNgoaiSoNoiSo.TabIndex = 4;
            this.radioNgoaiSoNoiSo.Text = "Quẻ ngoại dùng số, quẻ nội dùng số";
            this.radioNgoaiSoNoiSo.UseVisualStyleBackColor = true;
            this.radioNgoaiSoNoiSo.CheckedChanged += new System.EventHandler(this.radioNgoaiSoNoiSo_CheckedChanged);
            // 
            // txtQueNgoai1
            // 
            this.txtQueNgoai1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueNgoai1.Location = new System.Drawing.Point(192, 170);
            this.txtQueNgoai1.Name = "txtQueNgoai1";
            this.txtQueNgoai1.Size = new System.Drawing.Size(444, 29);
            this.txtQueNgoai1.TabIndex = 3;
            this.txtQueNgoai1.TextChanged += new System.EventHandler(this.txtQueNgoai1_TextChanged);
            // 
            // txtQueNgoai2
            // 
            this.txtQueNgoai2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueNgoai2.Location = new System.Drawing.Point(192, 241);
            this.txtQueNgoai2.Name = "txtQueNgoai2";
            this.txtQueNgoai2.Size = new System.Drawing.Size(444, 29);
            this.txtQueNgoai2.TabIndex = 5;
            this.txtQueNgoai2.TextChanged += new System.EventHandler(this.txtQueNgoai1_TextChanged);
            // 
            // txtQueNoi2
            // 
            this.txtQueNoi2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueNoi2.Location = new System.Drawing.Point(192, 276);
            this.txtQueNoi2.Name = "txtQueNoi2";
            this.txtQueNoi2.Size = new System.Drawing.Size(444, 29);
            this.txtQueNoi2.TabIndex = 6;
            this.txtQueNoi2.TextChanged += new System.EventHandler(this.txtQueNgoai1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 46;
            this.label3.Text = "Quẻ ngoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 21);
            this.label4.TabIndex = 54;
            this.label4.Text = "Quẻ ngoại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(89, 279);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 21);
            this.label7.TabIndex = 55;
            this.label7.Text = "Quẻ nội:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtSoHoacChu);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.radThoiGian);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkUseNamCan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radNgoaiSo);
            this.groupBox1.Controls.Add(this.txtQueNoi2);
            this.groupBox1.Controls.Add(this.radioNgoaiSoNoiSo);
            this.groupBox1.Controls.Add(this.txtQueNgoai2);
            this.groupBox1.Controls.Add(this.txtQueNgoai1);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(678, 439);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 21);
            this.label8.TabIndex = 57;
            this.label8.Text = "Số hoặc chữ:";
            // 
            // txtSoHoacChu
            // 
            this.txtSoHoacChu.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoHoacChu.Location = new System.Drawing.Point(192, 94);
            this.txtSoHoacChu.Name = "txtSoHoacChu";
            this.txtSoHoacChu.Size = new System.Drawing.Size(444, 29);
            this.txtSoHoacChu.TabIndex = 56;
            this.txtSoHoacChu.TextChanged += new System.EventHandler(this.txtSoHoacChu_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radHauThien);
            this.panel1.Controls.Add(this.radTienThien);
            this.panel1.Location = new System.Drawing.Point(192, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 67);
            this.panel1.TabIndex = 48;
            // 
            // radHauThien
            // 
            this.radHauThien.AutoSize = true;
            this.radHauThien.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHauThien.Location = new System.Drawing.Point(249, 21);
            this.radHauThien.Name = "radHauThien";
            this.radHauThien.Size = new System.Drawing.Size(127, 25);
            this.radHauThien.TabIndex = 1;
            this.radHauThien.Text = "Hậu thiên";
            this.radHauThien.UseVisualStyleBackColor = true;
            this.radHauThien.CheckedChanged += new System.EventHandler(this.radTienThien_CheckedChanged);
            // 
            // radTienThien
            // 
            this.radTienThien.AutoSize = true;
            this.radTienThien.Checked = true;
            this.radTienThien.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTienThien.Location = new System.Drawing.Point(68, 21);
            this.radTienThien.Name = "radTienThien";
            this.radTienThien.Size = new System.Drawing.Size(138, 25);
            this.radTienThien.TabIndex = 0;
            this.radTienThien.TabStop = true;
            this.radTienThien.Text = "Tiên thiên";
            this.radTienThien.UseVisualStyleBackColor = true;
            this.radTienThien.CheckedChanged += new System.EventHandler(this.radTienThien_CheckedChanged);
            // 
            // ucQueDich
            // 
            this.ucQueDich.Location = new System.Drawing.Point(20, 473);
            this.ucQueDich.Name = "ucQueDich";
            this.ucQueDich.Size = new System.Drawing.Size(698, 201);
            this.ucQueDich.TabIndex = 2;
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(730, 513);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(522, 148);
            this.txtDesc.TabIndex = 11;
            this.txtDesc.TabStop = false;
            this.txtDesc.Text = "";
            // 
            // FormQueThoiGian
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 684);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucQueDich);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQueThoiGian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lấy Quẻ Theo Mai Hoa Dịch Số";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private UserControls.ucQue ucQueDich;
        private System.Windows.Forms.RadioButton radNgoaiSo;
        private System.Windows.Forms.RadioButton radThoiGian;
        private System.Windows.Forms.RadioButton radioNgoaiSoNoiSo;
        private System.Windows.Forms.TextBox txtQueNgoai1;
        private System.Windows.Forms.TextBox txtQueNgoai2;
        private System.Windows.Forms.TextBox txtQueNoi2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radHauThien;
        private System.Windows.Forms.RadioButton radTienThien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoHoacChu;
        private System.Windows.Forms.RichTextBox txtDesc;
    }
}


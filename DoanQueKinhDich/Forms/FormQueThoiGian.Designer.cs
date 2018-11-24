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
            this.uiDatePicker = new System.Windows.Forms.DateTimePicker();
            this.uiHour = new System.Windows.Forms.DateTimePicker();
            this.labelNgayAmLich = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn12Hoi = new System.Windows.Forms.Button();
            this.btn11Tuat = new System.Windows.Forms.Button();
            this.btn10Dau = new System.Windows.Forms.Button();
            this.btn9Than = new System.Windows.Forms.Button();
            this.btn8Mui = new System.Windows.Forms.Button();
            this.btn7Ngo = new System.Windows.Forms.Button();
            this.btn6Ty = new System.Windows.Forms.Button();
            this.btn5Thin = new System.Windows.Forms.Button();
            this.btn4Mao = new System.Windows.Forms.Button();
            this.btn3Dan = new System.Windows.Forms.Button();
            this.btn2Suu = new System.Windows.Forms.Button();
            this.btn1Ti = new System.Windows.Forms.Button();
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
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.btnLoadCurrentDateTime = new System.Windows.Forms.Button();
            this.ucQueDich = new DoanQueKinhDich.UserControls.ucQue();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(1009, 463);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(202, 47);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Lấy Quẻ (F1)";
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
            this.cbxNgayCan.Location = new System.Drawing.Point(276, 182);
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
            this.cbxNgayChi.Location = new System.Drawing.Point(386, 182);
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
            this.label1.Location = new System.Drawing.Point(273, 156);
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
            this.label2.Location = new System.Drawing.Point(273, 93);
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
            this.cbxThangChi.Location = new System.Drawing.Point(386, 119);
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
            this.cbxThangCan.Location = new System.Drawing.Point(276, 119);
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
            this.uiDate.Location = new System.Drawing.Point(25, 73);
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
            this.label5.Location = new System.Drawing.Point(273, 30);
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
            this.cbxNamChi.Location = new System.Drawing.Point(386, 56);
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
            this.cbxNamCan.Location = new System.Drawing.Point(276, 56);
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
            this.label6.Location = new System.Drawing.Point(274, 220);
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
            this.cbxGioChi.Location = new System.Drawing.Point(387, 246);
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
            this.cbxGioCan.Location = new System.Drawing.Point(277, 246);
            this.cbxGioCan.Margin = new System.Windows.Forms.Padding(2);
            this.cbxGioCan.MaxDropDownItems = 12;
            this.cbxGioCan.Name = "cbxGioCan";
            this.cbxGioCan.Size = new System.Drawing.Size(92, 29);
            this.cbxGioCan.TabIndex = 38;
            // 
            // uiDatePicker
            // 
            this.uiDatePicker.CalendarFont = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiDatePicker.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.uiDatePicker.Location = new System.Drawing.Point(25, 33);
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
            this.uiHour.Location = new System.Drawing.Point(25, 246);
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
            this.labelNgayAmLich.Location = new System.Drawing.Point(21, 343);
            this.labelNgayAmLich.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNgayAmLich.Name = "labelNgayAmLich";
            this.labelNgayAmLich.Size = new System.Drawing.Size(153, 21);
            this.labelNgayAmLich.TabIndex = 44;
            this.labelNgayAmLich.Text = "Ngày âm lịch:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btn12Hoi);
            this.groupBox2.Controls.Add(this.btn11Tuat);
            this.groupBox2.Controls.Add(this.btn10Dau);
            this.groupBox2.Controls.Add(this.btn9Than);
            this.groupBox2.Controls.Add(this.btn8Mui);
            this.groupBox2.Controls.Add(this.btn7Ngo);
            this.groupBox2.Controls.Add(this.btn6Ty);
            this.groupBox2.Controls.Add(this.btn5Thin);
            this.groupBox2.Controls.Add(this.btn4Mao);
            this.groupBox2.Controls.Add(this.btn3Dan);
            this.groupBox2.Controls.Add(this.btn2Suu);
            this.groupBox2.Controls.Add(this.btn1Ti);
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
            this.groupBox2.Location = new System.Drawing.Point(717, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(845, 447);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btn12Hoi
            // 
            this.btn12Hoi.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn12Hoi.Location = new System.Drawing.Point(579, 404);
            this.btn12Hoi.Name = "btn12Hoi";
            this.btn12Hoi.Size = new System.Drawing.Size(260, 36);
            this.btn12Hoi.TabIndex = 56;
            this.btn12Hoi.Text = "Hợi (21h-23h)";
            this.btn12Hoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn12Hoi.UseVisualStyleBackColor = true;
            this.btn12Hoi.Click += new System.EventHandler(this.btn12DiaChi_Click);
            this.btn12Hoi.Enter += new System.EventHandler(this.btn12DiaChi_Enter);
            // 
            // btn11Tuat
            // 
            this.btn11Tuat.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn11Tuat.Location = new System.Drawing.Point(579, 369);
            this.btn11Tuat.Name = "btn11Tuat";
            this.btn11Tuat.Size = new System.Drawing.Size(260, 36);
            this.btn11Tuat.TabIndex = 55;
            this.btn11Tuat.Text = "Tuất (19h-21h)";
            this.btn11Tuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn11Tuat.UseVisualStyleBackColor = true;
            this.btn11Tuat.Click += new System.EventHandler(this.btn12DiaChi_Click);
            this.btn11Tuat.Enter += new System.EventHandler(this.btn12DiaChi_Enter);
            // 
            // btn10Dau
            // 
            this.btn10Dau.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10Dau.Location = new System.Drawing.Point(579, 334);
            this.btn10Dau.Name = "btn10Dau";
            this.btn10Dau.Size = new System.Drawing.Size(260, 36);
            this.btn10Dau.TabIndex = 54;
            this.btn10Dau.Text = "Dậu (17h-19h)";
            this.btn10Dau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn10Dau.UseVisualStyleBackColor = true;
            this.btn10Dau.Click += new System.EventHandler(this.btn12DiaChi_Click);
            this.btn10Dau.Enter += new System.EventHandler(this.btn12DiaChi_Enter);
            // 
            // btn9Than
            // 
            this.btn9Than.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9Than.Location = new System.Drawing.Point(579, 299);
            this.btn9Than.Name = "btn9Than";
            this.btn9Than.Size = new System.Drawing.Size(260, 36);
            this.btn9Than.TabIndex = 53;
            this.btn9Than.Text = "Thân (15h-17h)";
            this.btn9Than.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn9Than.UseVisualStyleBackColor = true;
            this.btn9Than.Click += new System.EventHandler(this.btn12DiaChi_Click);
            this.btn9Than.Enter += new System.EventHandler(this.btn12DiaChi_Enter);
            // 
            // btn8Mui
            // 
            this.btn8Mui.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8Mui.Location = new System.Drawing.Point(579, 264);
            this.btn8Mui.Name = "btn8Mui";
            this.btn8Mui.Size = new System.Drawing.Size(260, 36);
            this.btn8Mui.TabIndex = 52;
            this.btn8Mui.Text = "Mùi (13h-15h)";
            this.btn8Mui.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn8Mui.UseVisualStyleBackColor = true;
            this.btn8Mui.Click += new System.EventHandler(this.btn12DiaChi_Click);
            this.btn8Mui.Enter += new System.EventHandler(this.btn12DiaChi_Enter);
            // 
            // btn7Ngo
            // 
            this.btn7Ngo.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7Ngo.Location = new System.Drawing.Point(579, 229);
            this.btn7Ngo.Name = "btn7Ngo";
            this.btn7Ngo.Size = new System.Drawing.Size(260, 36);
            this.btn7Ngo.TabIndex = 51;
            this.btn7Ngo.Text = "Ngọ (11h-13h)";
            this.btn7Ngo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn7Ngo.UseVisualStyleBackColor = true;
            this.btn7Ngo.Click += new System.EventHandler(this.btn12DiaChi_Click);
            this.btn7Ngo.Enter += new System.EventHandler(this.btn12DiaChi_Enter);
            // 
            // btn6Ty
            // 
            this.btn6Ty.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6Ty.Location = new System.Drawing.Point(579, 194);
            this.btn6Ty.Name = "btn6Ty";
            this.btn6Ty.Size = new System.Drawing.Size(260, 36);
            this.btn6Ty.TabIndex = 50;
            this.btn6Ty.Text = "Tỵ (9h-11h)";
            this.btn6Ty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn6Ty.UseVisualStyleBackColor = true;
            this.btn6Ty.Click += new System.EventHandler(this.btn12DiaChi_Click);
            this.btn6Ty.Enter += new System.EventHandler(this.btn12DiaChi_Enter);
            // 
            // btn5Thin
            // 
            this.btn5Thin.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5Thin.Location = new System.Drawing.Point(579, 159);
            this.btn5Thin.Name = "btn5Thin";
            this.btn5Thin.Size = new System.Drawing.Size(260, 36);
            this.btn5Thin.TabIndex = 49;
            this.btn5Thin.Text = "Thìn (7h-9h)";
            this.btn5Thin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn5Thin.UseVisualStyleBackColor = true;
            this.btn5Thin.Click += new System.EventHandler(this.btn12DiaChi_Click);
            this.btn5Thin.Enter += new System.EventHandler(this.btn12DiaChi_Enter);
            // 
            // btn4Mao
            // 
            this.btn4Mao.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4Mao.Location = new System.Drawing.Point(579, 124);
            this.btn4Mao.Name = "btn4Mao";
            this.btn4Mao.Size = new System.Drawing.Size(260, 36);
            this.btn4Mao.TabIndex = 48;
            this.btn4Mao.Text = "Mão (5h-7h)";
            this.btn4Mao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn4Mao.UseVisualStyleBackColor = true;
            this.btn4Mao.Click += new System.EventHandler(this.btn12DiaChi_Click);
            this.btn4Mao.Enter += new System.EventHandler(this.btn12DiaChi_Enter);
            // 
            // btn3Dan
            // 
            this.btn3Dan.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Dan.Location = new System.Drawing.Point(579, 89);
            this.btn3Dan.Name = "btn3Dan";
            this.btn3Dan.Size = new System.Drawing.Size(260, 36);
            this.btn3Dan.TabIndex = 47;
            this.btn3Dan.Text = "Dần (3h-5h)";
            this.btn3Dan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3Dan.UseVisualStyleBackColor = true;
            this.btn3Dan.Click += new System.EventHandler(this.btn12DiaChi_Click);
            this.btn3Dan.Enter += new System.EventHandler(this.btn12DiaChi_Enter);
            // 
            // btn2Suu
            // 
            this.btn2Suu.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Suu.Location = new System.Drawing.Point(579, 54);
            this.btn2Suu.Name = "btn2Suu";
            this.btn2Suu.Size = new System.Drawing.Size(260, 36);
            this.btn2Suu.TabIndex = 46;
            this.btn2Suu.Text = "Sửu (1h-3h)";
            this.btn2Suu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2Suu.UseVisualStyleBackColor = true;
            this.btn2Suu.Click += new System.EventHandler(this.btn12DiaChi_Click);
            this.btn2Suu.Enter += new System.EventHandler(this.btn12DiaChi_Enter);
            // 
            // btn1Ti
            // 
            this.btn1Ti.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Ti.Location = new System.Drawing.Point(579, 19);
            this.btn1Ti.Name = "btn1Ti";
            this.btn1Ti.Size = new System.Drawing.Size(260, 36);
            this.btn1Ti.TabIndex = 13;
            this.btn1Ti.Text = "Tí (23h-1h)";
            this.btn1Ti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1Ti.UseVisualStyleBackColor = true;
            this.btn1Ti.Click += new System.EventHandler(this.btn12DiaChi_Click);
            this.btn1Ti.Enter += new System.EventHandler(this.btn12DiaChi_Enter);
            // 
            // labelNgayDuongLich
            // 
            this.labelNgayDuongLich.AutoSize = true;
            this.labelNgayDuongLich.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayDuongLich.Location = new System.Drawing.Point(21, 307);
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
            this.radNgoaiSo.Location = new System.Drawing.Point(28, 118);
            this.radNgoaiSo.Name = "radNgoaiSo";
            this.radNgoaiSo.Size = new System.Drawing.Size(479, 25);
            this.radNgoaiSo.TabIndex = 2;
            this.radNgoaiSo.Text = "Quẻ ngoại dùng thời gian, quẻ nội dùng số";
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
            this.txtQueNgoai1.Location = new System.Drawing.Point(192, 154);
            this.txtQueNgoai1.Name = "txtQueNgoai1";
            this.txtQueNgoai1.Size = new System.Drawing.Size(444, 29);
            this.txtQueNgoai1.TabIndex = 3;
            this.txtQueNgoai1.Click += new System.EventHandler(this.onTextBoxEntered);
            this.txtQueNgoai1.TextChanged += new System.EventHandler(this.txtQueNgoai1_TextChanged);
            this.txtQueNgoai1.Enter += new System.EventHandler(this.onTextBoxEntered);
            // 
            // txtQueNgoai2
            // 
            this.txtQueNgoai2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueNgoai2.Location = new System.Drawing.Point(192, 241);
            this.txtQueNgoai2.Name = "txtQueNgoai2";
            this.txtQueNgoai2.Size = new System.Drawing.Size(444, 29);
            this.txtQueNgoai2.TabIndex = 5;
            this.txtQueNgoai2.Click += new System.EventHandler(this.onTextBoxEntered);
            this.txtQueNgoai2.TextChanged += new System.EventHandler(this.txtQueNgoai1_TextChanged);
            this.txtQueNgoai2.Enter += new System.EventHandler(this.onTextBoxEntered);
            // 
            // txtQueNoi2
            // 
            this.txtQueNoi2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueNoi2.Location = new System.Drawing.Point(192, 276);
            this.txtQueNoi2.Name = "txtQueNoi2";
            this.txtQueNoi2.Size = new System.Drawing.Size(444, 29);
            this.txtQueNoi2.TabIndex = 6;
            this.txtQueNoi2.Click += new System.EventHandler(this.onTextBoxEntered);
            this.txtQueNoi2.TextChanged += new System.EventHandler(this.txtQueNgoai1_TextChanged);
            this.txtQueNoi2.Enter += new System.EventHandler(this.onTextBoxEntered);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 46;
            this.label3.Text = "Quẻ nội:";
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
            this.groupBox1.Size = new System.Drawing.Size(675, 448);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 21);
            this.label8.TabIndex = 57;
            this.label8.Text = "Số hoặc chữ:";
            // 
            // txtSoHoacChu
            // 
            this.txtSoHoacChu.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoHoacChu.Location = new System.Drawing.Point(192, 61);
            this.txtSoHoacChu.Name = "txtSoHoacChu";
            this.txtSoHoacChu.Size = new System.Drawing.Size(444, 29);
            this.txtSoHoacChu.TabIndex = 56;
            this.txtSoHoacChu.Click += new System.EventHandler(this.onTextBoxEntered);
            this.txtSoHoacChu.TextChanged += new System.EventHandler(this.txtSoHoacChu_TextChanged);
            this.txtSoHoacChu.Enter += new System.EventHandler(this.onTextBoxEntered);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radHauThien);
            this.panel1.Controls.Add(this.radTienThien);
            this.panel1.Location = new System.Drawing.Point(192, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 46);
            this.panel1.TabIndex = 48;
            // 
            // radHauThien
            // 
            this.radHauThien.AutoSize = true;
            this.radHauThien.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHauThien.Location = new System.Drawing.Point(249, 11);
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
            this.radTienThien.Location = new System.Drawing.Point(68, 11);
            this.radTienThien.Name = "radTienThien";
            this.radTienThien.Size = new System.Drawing.Size(138, 25);
            this.radTienThien.TabIndex = 0;
            this.radTienThien.TabStop = true;
            this.radTienThien.Text = "Tiên thiên";
            this.radTienThien.UseVisualStyleBackColor = true;
            this.radTienThien.CheckedChanged += new System.EventHandler(this.radTienThien_CheckedChanged);
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtDesc.Location = new System.Drawing.Point(717, 515);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(845, 161);
            this.txtDesc.TabIndex = 11;
            this.txtDesc.TabStop = false;
            this.txtDesc.Text = "";
            // 
            // btnLoadCurrentDateTime
            // 
            this.btnLoadCurrentDateTime.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadCurrentDateTime.Location = new System.Drawing.Point(717, 463);
            this.btnLoadCurrentDateTime.Name = "btnLoadCurrentDateTime";
            this.btnLoadCurrentDateTime.Size = new System.Drawing.Size(268, 47);
            this.btnLoadCurrentDateTime.TabIndex = 12;
            this.btnLoadCurrentDateTime.Text = "Ngày giờ hiện tại (F2)";
            this.btnLoadCurrentDateTime.UseVisualStyleBackColor = true;
            this.btnLoadCurrentDateTime.Click += new System.EventHandler(this.btnLoadCurrentDateTime_Click);
            // 
            // ucQueDich
            // 
            this.ucQueDich.Location = new System.Drawing.Point(18, 472);
            this.ucQueDich.Name = "ucQueDich";
            this.ucQueDich.Size = new System.Drawing.Size(695, 214);
            this.ucQueDich.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(510, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 21);
            this.label9.TabIndex = 57;
            this.label9.Text = "Tí:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(510, 62);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 21);
            this.label10.TabIndex = 58;
            this.label10.Text = "Sửu:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(510, 132);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 21);
            this.label11.TabIndex = 60;
            this.label11.Text = "Mão:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(510, 97);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 21);
            this.label12.TabIndex = 59;
            this.label12.Text = "Dần:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(510, 272);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 21);
            this.label13.TabIndex = 64;
            this.label13.Text = "Mùi:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(510, 237);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 21);
            this.label14.TabIndex = 63;
            this.label14.Text = "Ngọ:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(510, 202);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 21);
            this.label15.TabIndex = 62;
            this.label15.Text = "Tỵ:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(510, 167);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 21);
            this.label16.TabIndex = 61;
            this.label16.Text = "Thìn:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(510, 412);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 21);
            this.label17.TabIndex = 68;
            this.label17.Text = "Hợi:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(510, 377);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 21);
            this.label18.TabIndex = 67;
            this.label18.Text = "Tuất:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(510, 342);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 21);
            this.label19.TabIndex = 66;
            this.label19.Text = "Dậu:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(510, 307);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 21);
            this.label20.TabIndex = 65;
            this.label20.Text = "Thân:";
            // 
            // FormQueThoiGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 692);
            this.Controls.Add(this.btnLoadCurrentDateTime);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucQueDich);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQueThoiGian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lấy Quẻ Theo Thời Gian";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormQueThoiGian_KeyDown);
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
        private System.Windows.Forms.Button btnLoadCurrentDateTime;
        private System.Windows.Forms.Button btn12Hoi;
        private System.Windows.Forms.Button btn11Tuat;
        private System.Windows.Forms.Button btn10Dau;
        private System.Windows.Forms.Button btn9Than;
        private System.Windows.Forms.Button btn8Mui;
        private System.Windows.Forms.Button btn7Ngo;
        private System.Windows.Forms.Button btn6Ty;
        private System.Windows.Forms.Button btn5Thin;
        private System.Windows.Forms.Button btn4Mao;
        private System.Windows.Forms.Button btn3Dan;
        private System.Windows.Forms.Button btn2Suu;
        private System.Windows.Forms.Button btn1Ti;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}


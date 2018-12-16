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
            this.uiDate = new System.Windows.Forms.MonthCalendar();
            this.uiDatePicker = new System.Windows.Forms.DateTimePicker();
            this.uiHour = new System.Windows.Forms.DateTimePicker();
            this.labelNgayAmLich = new System.Windows.Forms.Label();
            this.labelNgayDich = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.radThoiGian = new System.Windows.Forms.RadioButton();
            this.radioNgoaiSoNoiSo = new System.Windows.Forms.RadioButton();
            this.txtQueNgoai2 = new System.Windows.Forms.TextBox();
            this.txtQueNoi2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCongChiGio = new System.Windows.Forms.CheckBox();
            this.btnTimTen = new System.Windows.Forms.Button();
            this.txtCalculationDesc = new System.Windows.Forms.RichTextBox();
            this.btnLoadCurrentDateTime = new System.Windows.Forms.Button();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.btnHoc = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtQueDesc = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ucQueDich = new DoanQueKinhDich.UserControls.ucQue();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiDate
            // 
            this.uiDate.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.uiDate.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.uiDate.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiDate.Location = new System.Drawing.Point(-5, 207);
            this.uiDate.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.uiDate.MaxSelectionCount = 1;
            this.uiDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.uiDate.Name = "uiDate";
            this.uiDate.TabIndex = 1;
            this.uiDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.uiDate_DateChanged);
            // 
            // uiDatePicker
            // 
            this.uiDatePicker.CalendarFont = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiDatePicker.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.uiDatePicker.Location = new System.Drawing.Point(453, 207);
            this.uiDatePicker.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.uiDatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.uiDatePicker.Name = "uiDatePicker";
            this.uiDatePicker.Size = new System.Drawing.Size(176, 29);
            this.uiDatePicker.TabIndex = 0;
            this.uiDatePicker.ValueChanged += new System.EventHandler(this.uiDatePicker_ValueChanged);
            // 
            // uiHour
            // 
            this.uiHour.CalendarFont = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiHour.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uiHour.Location = new System.Drawing.Point(453, 251);
            this.uiHour.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.uiHour.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.uiHour.Name = "uiHour";
            this.uiHour.Size = new System.Drawing.Size(176, 29);
            this.uiHour.TabIndex = 2;
            this.uiHour.ValueChanged += new System.EventHandler(this.uiHour_ValueChanged);
            // 
            // labelNgayAmLich
            // 
            this.labelNgayAmLich.AutoSize = true;
            this.labelNgayAmLich.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayAmLich.Location = new System.Drawing.Point(43, 411);
            this.labelNgayAmLich.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNgayAmLich.Name = "labelNgayAmLich";
            this.labelNgayAmLich.Size = new System.Drawing.Size(153, 21);
            this.labelNgayAmLich.TabIndex = 44;
            this.labelNgayAmLich.Text = "Ngày âm lịch:";
            // 
            // labelNgayDich
            // 
            this.labelNgayDich.AutoSize = true;
            this.labelNgayDich.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayDich.ForeColor = System.Drawing.Color.Red;
            this.labelNgayDich.Location = new System.Drawing.Point(43, 443);
            this.labelNgayDich.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNgayDich.Name = "labelNgayDich";
            this.labelNgayDich.Size = new System.Drawing.Size(65, 21);
            this.labelNgayDich.TabIndex = 69;
            this.labelNgayDich.Text = "Ngày:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(22, 876);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(175, 21);
            this.label17.TabIndex = 68;
            this.label17.Text = "Hợi  (21 - 23h)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(22, 841);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(175, 21);
            this.label18.TabIndex = 67;
            this.label18.Text = "Tuất (19 - 21h)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(22, 806);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(175, 21);
            this.label19.TabIndex = 66;
            this.label19.Text = "Dậu  (17 - 19h)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(22, 771);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(175, 21);
            this.label20.TabIndex = 65;
            this.label20.Text = "Thân (15 - 17h)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(33, 736);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(164, 21);
            this.label13.TabIndex = 64;
            this.label13.Text = "Mùi (13 - 15h)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(33, 701);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 21);
            this.label14.TabIndex = 63;
            this.label14.Text = "Ngọ (11 - 13h)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(33, 666);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 21);
            this.label15.TabIndex = 62;
            this.label15.Text = "Tỵ   (9 - 11h)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(33, 631);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(153, 21);
            this.label16.TabIndex = 61;
            this.label16.Text = "Thìn (7 - 9h)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 596);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 21);
            this.label11.TabIndex = 60;
            this.label11.Text = "Mão  (5 - 7h)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 561);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 21);
            this.label12.TabIndex = 59;
            this.label12.Text = "Dần  (3 - 5h)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 526);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 21);
            this.label10.TabIndex = 58;
            this.label10.Text = "Sửu  (1 - 3h)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 491);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 21);
            this.label9.TabIndex = 57;
            this.label9.Text = "Tí  (23 - 1h)";
            // 
            // btn12Hoi
            // 
            this.btn12Hoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn12Hoi.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn12Hoi.Location = new System.Drawing.Point(210, 868);
            this.btn12Hoi.Name = "btn12Hoi";
            this.btn12Hoi.Size = new System.Drawing.Size(419, 36);
            this.btn12Hoi.TabIndex = 56;
            this.btn12Hoi.Text = "Hợi (21h-23h)";
            this.btn12Hoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn12Hoi.UseVisualStyleBackColor = true;
            this.btn12Hoi.Click += new System.EventHandler(this.btn12DiaChi_Click);
            this.btn12Hoi.Enter += new System.EventHandler(this.btn12DiaChi_Enter);
            // 
            // btn11Tuat
            // 
            this.btn11Tuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn11Tuat.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn11Tuat.Location = new System.Drawing.Point(210, 833);
            this.btn11Tuat.Name = "btn11Tuat";
            this.btn11Tuat.Size = new System.Drawing.Size(419, 36);
            this.btn11Tuat.TabIndex = 55;
            this.btn11Tuat.Text = "Tuất (19h-21h)";
            this.btn11Tuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn11Tuat.UseVisualStyleBackColor = true;
            this.btn11Tuat.Click += new System.EventHandler(this.btn12DiaChi_Click);
            this.btn11Tuat.Enter += new System.EventHandler(this.btn12DiaChi_Enter);
            // 
            // btn10Dau
            // 
            this.btn10Dau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn10Dau.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10Dau.Location = new System.Drawing.Point(210, 798);
            this.btn10Dau.Name = "btn10Dau";
            this.btn10Dau.Size = new System.Drawing.Size(419, 36);
            this.btn10Dau.TabIndex = 54;
            this.btn10Dau.Text = "Dậu (17h-19h)";
            this.btn10Dau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn10Dau.UseVisualStyleBackColor = true;
            this.btn10Dau.Click += new System.EventHandler(this.btn12DiaChi_Click);
            this.btn10Dau.Enter += new System.EventHandler(this.btn12DiaChi_Enter);
            // 
            // btn9Than
            // 
            this.btn9Than.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn9Than.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9Than.Location = new System.Drawing.Point(210, 763);
            this.btn9Than.Name = "btn9Than";
            this.btn9Than.Size = new System.Drawing.Size(419, 36);
            this.btn9Than.TabIndex = 53;
            this.btn9Than.Text = "Thân (15h-17h)";
            this.btn9Than.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn9Than.UseVisualStyleBackColor = true;
            this.btn9Than.Click += new System.EventHandler(this.btn12DiaChi_Click);
            this.btn9Than.Enter += new System.EventHandler(this.btn12DiaChi_Enter);
            // 
            // btn8Mui
            // 
            this.btn8Mui.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn8Mui.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8Mui.Location = new System.Drawing.Point(210, 728);
            this.btn8Mui.Name = "btn8Mui";
            this.btn8Mui.Size = new System.Drawing.Size(419, 36);
            this.btn8Mui.TabIndex = 52;
            this.btn8Mui.Text = "Mùi (13h-15h)";
            this.btn8Mui.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn8Mui.UseVisualStyleBackColor = true;
            this.btn8Mui.Click += new System.EventHandler(this.btn12DiaChi_Click);
            this.btn8Mui.Enter += new System.EventHandler(this.btn12DiaChi_Enter);
            // 
            // btn7Ngo
            // 
            this.btn7Ngo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn7Ngo.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7Ngo.Location = new System.Drawing.Point(210, 693);
            this.btn7Ngo.Name = "btn7Ngo";
            this.btn7Ngo.Size = new System.Drawing.Size(419, 36);
            this.btn7Ngo.TabIndex = 51;
            this.btn7Ngo.Text = "Ngọ (11h-13h)";
            this.btn7Ngo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn7Ngo.UseVisualStyleBackColor = true;
            this.btn7Ngo.Click += new System.EventHandler(this.btn12DiaChi_Click);
            this.btn7Ngo.Enter += new System.EventHandler(this.btn12DiaChi_Enter);
            // 
            // btn6Ty
            // 
            this.btn6Ty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn6Ty.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6Ty.Location = new System.Drawing.Point(210, 658);
            this.btn6Ty.Name = "btn6Ty";
            this.btn6Ty.Size = new System.Drawing.Size(419, 36);
            this.btn6Ty.TabIndex = 50;
            this.btn6Ty.Text = "Tỵ (9h-11h)";
            this.btn6Ty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn6Ty.UseVisualStyleBackColor = true;
            this.btn6Ty.Click += new System.EventHandler(this.btn12DiaChi_Click);
            this.btn6Ty.Enter += new System.EventHandler(this.btn12DiaChi_Enter);
            // 
            // btn5Thin
            // 
            this.btn5Thin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn5Thin.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5Thin.Location = new System.Drawing.Point(210, 623);
            this.btn5Thin.Name = "btn5Thin";
            this.btn5Thin.Size = new System.Drawing.Size(419, 36);
            this.btn5Thin.TabIndex = 49;
            this.btn5Thin.Text = "Thìn (7h-9h)";
            this.btn5Thin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn5Thin.UseVisualStyleBackColor = true;
            this.btn5Thin.Click += new System.EventHandler(this.btn12DiaChi_Click);
            this.btn5Thin.Enter += new System.EventHandler(this.btn12DiaChi_Enter);
            // 
            // btn4Mao
            // 
            this.btn4Mao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn4Mao.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4Mao.Location = new System.Drawing.Point(210, 588);
            this.btn4Mao.Name = "btn4Mao";
            this.btn4Mao.Size = new System.Drawing.Size(419, 36);
            this.btn4Mao.TabIndex = 48;
            this.btn4Mao.Text = "Mão (5h-7h)";
            this.btn4Mao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn4Mao.UseVisualStyleBackColor = true;
            this.btn4Mao.Click += new System.EventHandler(this.btn12DiaChi_Click);
            this.btn4Mao.Enter += new System.EventHandler(this.btn12DiaChi_Enter);
            // 
            // btn3Dan
            // 
            this.btn3Dan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn3Dan.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Dan.Location = new System.Drawing.Point(210, 553);
            this.btn3Dan.Name = "btn3Dan";
            this.btn3Dan.Size = new System.Drawing.Size(419, 36);
            this.btn3Dan.TabIndex = 47;
            this.btn3Dan.Text = "Dần (3h-5h)";
            this.btn3Dan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3Dan.UseVisualStyleBackColor = true;
            this.btn3Dan.Click += new System.EventHandler(this.btn12DiaChi_Click);
            this.btn3Dan.Enter += new System.EventHandler(this.btn12DiaChi_Enter);
            // 
            // btn2Suu
            // 
            this.btn2Suu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn2Suu.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Suu.Location = new System.Drawing.Point(210, 518);
            this.btn2Suu.Name = "btn2Suu";
            this.btn2Suu.Size = new System.Drawing.Size(419, 36);
            this.btn2Suu.TabIndex = 46;
            this.btn2Suu.Text = "Sửu (1h-3h)";
            this.btn2Suu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2Suu.UseVisualStyleBackColor = true;
            this.btn2Suu.Click += new System.EventHandler(this.btn12DiaChi_Click);
            this.btn2Suu.Enter += new System.EventHandler(this.btn12DiaChi_Enter);
            // 
            // btn1Ti
            // 
            this.btn1Ti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1Ti.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Ti.Location = new System.Drawing.Point(210, 483);
            this.btn1Ti.Name = "btn1Ti";
            this.btn1Ti.Size = new System.Drawing.Size(419, 36);
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
            this.labelNgayDuongLich.Location = new System.Drawing.Point(43, 378);
            this.labelNgayDuongLich.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNgayDuongLich.Name = "labelNgayDuongLich";
            this.labelNgayDuongLich.Size = new System.Drawing.Size(186, 21);
            this.labelNgayDuongLich.TabIndex = 45;
            this.labelNgayDuongLich.Text = "Ngày dương lịch:";
            // 
            // radThoiGian
            // 
            this.radThoiGian.AutoSize = true;
            this.radThoiGian.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radThoiGian.Location = new System.Drawing.Point(16, 28);
            this.radThoiGian.Name = "radThoiGian";
            this.radThoiGian.Size = new System.Drawing.Size(259, 25);
            this.radThoiGian.TabIndex = 0;
            this.radThoiGian.Text = "Công thức hữu thường:";
            this.radThoiGian.UseVisualStyleBackColor = true;
            this.radThoiGian.CheckedChanged += new System.EventHandler(this.radThoiGian_CheckedChanged);
            // 
            // radioNgoaiSoNoiSo
            // 
            this.radioNgoaiSoNoiSo.AutoSize = true;
            this.radioNgoaiSoNoiSo.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNgoaiSoNoiSo.Location = new System.Drawing.Point(15, 69);
            this.radioNgoaiSoNoiSo.Name = "radioNgoaiSoNoiSo";
            this.radioNgoaiSoNoiSo.Size = new System.Drawing.Size(259, 25);
            this.radioNgoaiSoNoiSo.TabIndex = 4;
            this.radioNgoaiSoNoiSo.Text = "Công thức bất thường:";
            this.radioNgoaiSoNoiSo.UseVisualStyleBackColor = true;
            this.radioNgoaiSoNoiSo.CheckedChanged += new System.EventHandler(this.radioNgoaiSoNoiSo_CheckedChanged);
            // 
            // txtQueNgoai2
            // 
            this.txtQueNgoai2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQueNgoai2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueNgoai2.Location = new System.Drawing.Point(179, 102);
            this.txtQueNgoai2.Name = "txtQueNgoai2";
            this.txtQueNgoai2.Size = new System.Drawing.Size(450, 29);
            this.txtQueNgoai2.TabIndex = 5;
            this.txtQueNgoai2.Click += new System.EventHandler(this.onTextBoxEntered);
            this.txtQueNgoai2.TextChanged += new System.EventHandler(this.txtQueNgoai1_TextChanged);
            this.txtQueNgoai2.Enter += new System.EventHandler(this.onTextBoxEntered);
            // 
            // txtQueNoi2
            // 
            this.txtQueNoi2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQueNoi2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueNoi2.Location = new System.Drawing.Point(179, 137);
            this.txtQueNoi2.Name = "txtQueNoi2";
            this.txtQueNoi2.Size = new System.Drawing.Size(450, 29);
            this.txtQueNoi2.TabIndex = 6;
            this.txtQueNoi2.Click += new System.EventHandler(this.onTextBoxEntered);
            this.txtQueNoi2.TextChanged += new System.EventHandler(this.txtQueNgoai1_TextChanged);
            this.txtQueNoi2.Enter += new System.EventHandler(this.onTextBoxEntered);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 21);
            this.label4.TabIndex = 54;
            this.label4.Text = "Ngoại quái:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 21);
            this.label7.TabIndex = 55;
            this.label7.Text = "Nội quái:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkCongChiGio);
            this.groupBox1.Controls.Add(this.labelNgayDich);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.labelNgayDuongLich);
            this.groupBox1.Controls.Add(this.labelNgayAmLich);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.radThoiGian);
            this.groupBox1.Controls.Add(this.uiHour);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.uiDatePicker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.uiDate);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtQueNoi2);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.radioNgoaiSoNoiSo);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtQueNgoai2);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btn1Ti);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.btn2Suu);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.btn3Dan);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btn4Mao);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btn5Thin);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btn6Ty);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btn7Ngo);
            this.groupBox1.Controls.Add(this.btn12Hoi);
            this.groupBox1.Controls.Add(this.btn8Mui);
            this.groupBox1.Controls.Add(this.btn11Tuat);
            this.groupBox1.Controls.Add(this.btn9Than);
            this.groupBox1.Controls.Add(this.btn10Dau);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, -7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(634, 910);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chkCongChiGio
            // 
            this.chkCongChiGio.AutoSize = true;
            this.chkCongChiGio.Location = new System.Drawing.Point(179, 175);
            this.chkCongChiGio.Name = "chkCongChiGio";
            this.chkCongChiGio.Size = new System.Drawing.Size(348, 25);
            this.chkCongChiGio.TabIndex = 58;
            this.chkCongChiGio.Text = "Cộng chi giờ để tính hào động";
            this.chkCongChiGio.UseVisualStyleBackColor = true;
            this.chkCongChiGio.CheckedChanged += new System.EventHandler(this.chkCongChiGio_CheckedChanged);
            // 
            // btnTimTen
            // 
            this.btnTimTen.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTen.Location = new System.Drawing.Point(12, 129);
            this.btnTimTen.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimTen.Name = "btnTimTen";
            this.btnTimTen.Size = new System.Drawing.Size(268, 48);
            this.btnTimTen.TabIndex = 59;
            this.btnTimTen.Text = "Tìm tên (F3)";
            this.btnTimTen.UseVisualStyleBackColor = true;
            this.btnTimTen.Click += new System.EventHandler(this.btnTimTen_Click);
            // 
            // txtCalculationDesc
            // 
            this.txtCalculationDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCalculationDesc.Font = new System.Drawing.Font("Courier New", 14F);
            this.txtCalculationDesc.Location = new System.Drawing.Point(3, 3);
            this.txtCalculationDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtCalculationDesc.Name = "txtCalculationDesc";
            this.txtCalculationDesc.Size = new System.Drawing.Size(1173, 625);
            this.txtCalculationDesc.TabIndex = 11;
            this.txtCalculationDesc.TabStop = false;
            this.txtCalculationDesc.Text = "";
            // 
            // btnLoadCurrentDateTime
            // 
            this.btnLoadCurrentDateTime.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadCurrentDateTime.Location = new System.Drawing.Point(12, 10);
            this.btnLoadCurrentDateTime.Name = "btnLoadCurrentDateTime";
            this.btnLoadCurrentDateTime.Size = new System.Drawing.Size(268, 47);
            this.btnLoadCurrentDateTime.TabIndex = 12;
            this.btnLoadCurrentDateTime.Text = "Ngày giờ hiện tại (F1)";
            this.btnLoadCurrentDateTime.UseVisualStyleBackColor = true;
            this.btnLoadCurrentDateTime.Click += new System.EventHandler(this.btnLoadCurrentDateTime_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerMain.Location = new System.Drawing.Point(0, 1);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.btnHoc);
            this.splitContainerMain.Panel2.Controls.Add(this.btnCopy);
            this.splitContainerMain.Panel2.Controls.Add(this.tabControl1);
            this.splitContainerMain.Panel2.Controls.Add(this.ucQueDich);
            this.splitContainerMain.Panel2.Controls.Add(this.btnTimTen);
            this.splitContainerMain.Panel2.Controls.Add(this.btnLoadCurrentDateTime);
            this.splitContainerMain.Size = new System.Drawing.Size(1846, 908);
            this.splitContainerMain.SplitterDistance = 641;
            this.splitContainerMain.TabIndex = 60;
            // 
            // btnHoc
            // 
            this.btnHoc.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoc.Location = new System.Drawing.Point(12, 69);
            this.btnHoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnHoc.Name = "btnHoc";
            this.btnHoc.Size = new System.Drawing.Size(268, 48);
            this.btnHoc.TabIndex = 61;
            this.btnHoc.Text = "Học 64 Quẻ (F2)";
            this.btnHoc.UseVisualStyleBackColor = true;
            this.btnHoc.Click += new System.EventHandler(this.btnHoc_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(12, 188);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(268, 48);
            this.btnCopy.TabIndex = 60;
            this.btnCopy.Text = "Copy Kết Quả (F4)";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 241);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1188, 664);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtQueDesc);
            this.tabPage1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1180, 630);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kết quả";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtQueDesc
            // 
            this.txtQueDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQueDesc.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtQueDesc.Location = new System.Drawing.Point(3, 3);
            this.txtQueDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtQueDesc.Name = "txtQueDesc";
            this.txtQueDesc.Size = new System.Drawing.Size(1173, 625);
            this.txtQueDesc.TabIndex = 11;
            this.txtQueDesc.TabStop = false;
            this.txtQueDesc.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtCalculationDesc);
            this.tabPage2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1180, 630);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tính toán";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ucQueDich
            // 
            this.ucQueDich.Location = new System.Drawing.Point(290, 3);
            this.ucQueDich.Name = "ucQueDich";
            this.ucQueDich.Size = new System.Drawing.Size(695, 241);
            this.ucQueDich.TabIndex = 2;
            // 
            // FormQueThoiGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1848, 910);
            this.Controls.Add(this.splitContainerMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormQueThoiGian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lấy Quẻ Dịch";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormQueThoiGian_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MonthCalendar uiDate;
        private System.Windows.Forms.DateTimePicker uiDatePicker;
        private System.Windows.Forms.DateTimePicker uiHour;
        private System.Windows.Forms.Label labelNgayAmLich;
        private System.Windows.Forms.Label labelNgayDuongLich;
        private UserControls.ucQue ucQueDich;
        private System.Windows.Forms.RadioButton radThoiGian;
        private System.Windows.Forms.RadioButton radioNgoaiSoNoiSo;
        private System.Windows.Forms.TextBox txtQueNgoai2;
        private System.Windows.Forms.TextBox txtQueNoi2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtCalculationDesc;
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
        private System.Windows.Forms.Label labelNgayDich;
        private System.Windows.Forms.CheckBox chkCongChiGio;
        private System.Windows.Forms.Button btnTimTen;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox txtQueDesc;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnHoc;
    }
}


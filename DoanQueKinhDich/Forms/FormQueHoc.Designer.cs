namespace DoanQueKinhDich
{
    partial class FormQueHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQueHoc));
            this.btnGo = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.chkHienTuong = new System.Windows.Forms.CheckBox();
            this.chkHienNghia = new System.Windows.Forms.CheckBox();
            this.chkHienTenQue = new System.Windows.Forms.CheckBox();
            this.ucQueDon = new DoanQueKinhDich.UserControls.ucQueDon();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Courier New", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(25, 28);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(188, 103);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Random (F1)";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(358, 28);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(805, 362);
            this.txtDesc.TabIndex = 22;
            this.txtDesc.TabStop = false;
            this.txtDesc.Text = "";
            // 
            // chkHienTuong
            // 
            this.chkHienTuong.AutoSize = true;
            this.chkHienTuong.Checked = true;
            this.chkHienTuong.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHienTuong.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHienTuong.Location = new System.Drawing.Point(25, 304);
            this.chkHienTuong.Name = "chkHienTuong";
            this.chkHienTuong.Size = new System.Drawing.Size(227, 25);
            this.chkHienTuong.TabIndex = 36;
            this.chkHienTuong.Text = "Hiện tượng của quẻ";
            this.chkHienTuong.UseVisualStyleBackColor = true;
            this.chkHienTuong.CheckedChanged += new System.EventHandler(this.chkHienTuong_CheckedChanged);
            // 
            // chkHienNghia
            // 
            this.chkHienNghia.AutoSize = true;
            this.chkHienNghia.Checked = true;
            this.chkHienNghia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHienNghia.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHienNghia.Location = new System.Drawing.Point(25, 268);
            this.chkHienNghia.Name = "chkHienNghia";
            this.chkHienNghia.Size = new System.Drawing.Size(227, 25);
            this.chkHienNghia.TabIndex = 35;
            this.chkHienNghia.Text = "Hiện nghĩa của quẻ";
            this.chkHienNghia.UseVisualStyleBackColor = true;
            this.chkHienNghia.CheckedChanged += new System.EventHandler(this.chkHienTuong_CheckedChanged);
            // 
            // chkHienTenQue
            // 
            this.chkHienTenQue.AutoSize = true;
            this.chkHienTenQue.Checked = true;
            this.chkHienTenQue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHienTenQue.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHienTenQue.Location = new System.Drawing.Point(25, 232);
            this.chkHienTenQue.Name = "chkHienTenQue";
            this.chkHienTenQue.Size = new System.Drawing.Size(161, 25);
            this.chkHienTenQue.TabIndex = 34;
            this.chkHienTenQue.Text = "Hiện tên quẻ";
            this.chkHienTenQue.UseVisualStyleBackColor = true;
            this.chkHienTenQue.CheckedChanged += new System.EventHandler(this.chkHienTuong_CheckedChanged);
            // 
            // ucQueDon
            // 
            this.ucQueDon.Location = new System.Drawing.Point(251, 14);
            this.ucQueDon.Name = "ucQueDon";
            this.ucQueDon.Size = new System.Drawing.Size(84, 169);
            this.ucQueDon.TabIndex = 20;
            // 
            // FormQueHoc
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 401);
            this.Controls.Add(this.chkHienTuong);
            this.Controls.Add(this.chkHienNghia);
            this.Controls.Add(this.chkHienTenQue);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.ucQueDon);
            this.Controls.Add(this.btnGo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQueHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Học 64 quẻ dịch";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormQueHoc_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGo;
        private UserControls.ucQueDon ucQueDon;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.CheckBox chkHienTuong;
        private System.Windows.Forms.CheckBox chkHienNghia;
        private System.Windows.Forms.CheckBox chkHienTenQue;
    }
}


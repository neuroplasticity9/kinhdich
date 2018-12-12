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
            this.linkAmLich = new System.Windows.Forms.LinkLabel();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnLayQue = new System.Windows.Forms.Button();
            this.btnHoc = new System.Windows.Forms.Button();
            this.ucQueDich = new DoanQueKinhDich.UserControls.ucQue();
            this.SuspendLayout();
            // 
            // txtQueDesc
            // 
            this.txtQueDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQueDesc.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtQueDesc.Location = new System.Drawing.Point(17, 251);
            this.txtQueDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtQueDesc.Name = "txtQueDesc";
            this.txtQueDesc.Size = new System.Drawing.Size(1737, 552);
            this.txtQueDesc.TabIndex = 10;
            this.txtQueDesc.TabStop = false;
            this.txtQueDesc.Text = "";
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
            this.btnCopy.Location = new System.Drawing.Point(1600, 198);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(154, 48);
            this.btnCopy.TabIndex = 35;
            this.btnCopy.Text = "Copy Quẻ";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnLayQue
            // 
            this.btnLayQue.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayQue.Location = new System.Drawing.Point(17, 47);
            this.btnLayQue.Margin = new System.Windows.Forms.Padding(2);
            this.btnLayQue.Name = "btnLayQue";
            this.btnLayQue.Size = new System.Drawing.Size(269, 48);
            this.btnLayQue.TabIndex = 1;
            this.btnLayQue.Text = "Lấy Quẻ Thời Gian (F1)";
            this.btnLayQue.UseVisualStyleBackColor = true;
            this.btnLayQue.Click += new System.EventHandler(this.btnLayQue_Click);
            // 
            // btnHoc
            // 
            this.btnHoc.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoc.Location = new System.Drawing.Point(17, 120);
            this.btnHoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnHoc.Name = "btnHoc";
            this.btnHoc.Size = new System.Drawing.Size(269, 48);
            this.btnHoc.TabIndex = 37;
            this.btnHoc.Text = "Học 64 Quẻ (F2)";
            this.btnHoc.UseVisualStyleBackColor = true;
            this.btnHoc.Click += new System.EventHandler(this.btnHoc_Click);
            // 
            // ucQueDich
            // 
            this.ucQueDich.Location = new System.Drawing.Point(330, 6);
            this.ucQueDich.Name = "ucQueDich";
            this.ucQueDich.Size = new System.Drawing.Size(685, 240);
            this.ucQueDich.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 823);
            this.Controls.Add(this.btnHoc);
            this.Controls.Add(this.ucQueDich);
            this.Controls.Add(this.btnLayQue);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.linkAmLich);
            this.Controls.Add(this.txtQueDesc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Lấy Quẻ Dịch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtQueDesc;
        private System.Windows.Forms.LinkLabel linkAmLich;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnLayQue;
        private UserControls.ucQue ucQueDich;
        private System.Windows.Forms.Button btnHoc;
    }
}


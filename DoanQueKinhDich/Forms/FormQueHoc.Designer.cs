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
            this.labelKetQua = new System.Windows.Forms.Label();
            this.ucQueDon = new DoanQueKinhDich.UserControls.ucQueDon();
            this.btnShowResult = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Courier New", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(25, 45);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(188, 103);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Random";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // labelKetQua
            // 
            this.labelKetQua.AutoSize = true;
            this.labelKetQua.Font = new System.Drawing.Font("Courier New", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKetQua.Location = new System.Drawing.Point(355, 14);
            this.labelKetQua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKetQua.Name = "labelKetQua";
            this.labelKetQua.Size = new System.Drawing.Size(87, 21);
            this.labelKetQua.TabIndex = 19;
            this.labelKetQua.Text = "Kết quả";
            // 
            // ucQueDon
            // 
            this.ucQueDon.Location = new System.Drawing.Point(264, 90);
            this.ucQueDon.Name = "ucQueDon";
            this.ucQueDon.Size = new System.Drawing.Size(52, 154);
            this.ucQueDon.TabIndex = 20;
            // 
            // btnShowResult
            // 
            this.btnShowResult.Font = new System.Drawing.Font("Courier New", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowResult.Location = new System.Drawing.Point(25, 175);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Size = new System.Drawing.Size(188, 103);
            this.btnShowResult.TabIndex = 21;
            this.btnShowResult.Text = "Kết Quả";
            this.btnShowResult.UseVisualStyleBackColor = true;
            this.btnShowResult.Click += new System.EventHandler(this.btnShowResult_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(358, 45);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(915, 345);
            this.txtDesc.TabIndex = 22;
            this.txtDesc.TabStop = false;
            this.txtDesc.Text = "";
            // 
            // FormQueHoc
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 401);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnShowResult);
            this.Controls.Add(this.ucQueDon);
            this.Controls.Add(this.labelKetQua);
            this.Controls.Add(this.btnGo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQueHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Học 64 quẻ dịch";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label labelKetQua;
        private UserControls.ucQueDon ucQueDon;
        private System.Windows.Forms.Button btnShowResult;
        private System.Windows.Forms.RichTextBox txtDesc;
    }
}


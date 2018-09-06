namespace DoanQueKinhDich
{
    partial class FormQueTungXu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQueTungXu));
            this.btnGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelKetQua = new System.Windows.Forms.Label();
            this.ucQueDich = new DoanQueKinhDich.ucQue();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Courier New", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(72, 124);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(188, 103);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Tung Xu";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nghĩ về việc cần đoán rồi nhấn nút Tung Xu.";
            // 
            // labelKetQua
            // 
            this.labelKetQua.AutoSize = true;
            this.labelKetQua.Font = new System.Drawing.Font("Courier New", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKetQua.Location = new System.Drawing.Point(68, 293);
            this.labelKetQua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKetQua.Name = "labelKetQua";
            this.labelKetQua.Size = new System.Drawing.Size(208, 21);
            this.labelKetQua.TabIndex = 19;
            this.labelKetQua.Text = "Kết quả tung xu...";
            // 
            // ucQueDich
            // 
            this.ucQueDich.Location = new System.Drawing.Point(316, 75);
            this.ucQueDich.Name = "ucQueDich";
            this.ucQueDich.Size = new System.Drawing.Size(608, 189);
            this.ucQueDich.TabIndex = 40;
            // 
            // FormQueTungXu
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 338);
            this.Controls.Add(this.ucQueDich);
            this.Controls.Add(this.labelKetQua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQueTungXu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tung Xu Lấy Quẻ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelKetQua;
        private ucQue ucQueDich;
    }
}


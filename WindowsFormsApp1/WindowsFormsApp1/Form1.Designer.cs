namespace WindowsFormsApp1
{
    partial class Form1
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
            this.chieuCao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tinhChieuCao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chieuCao
            // 
            this.chieuCao.Location = new System.Drawing.Point(211, 48);
            this.chieuCao.Name = "chieuCao";
            this.chieuCao.Size = new System.Drawing.Size(421, 38);
            this.chieuCao.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chieu Cao";
            // 
            // tinhChieuCao
            // 
            this.tinhChieuCao.Location = new System.Drawing.Point(216, 145);
            this.tinhChieuCao.Name = "tinhChieuCao";
            this.tinhChieuCao.Size = new System.Drawing.Size(211, 47);
            this.tinhChieuCao.TabIndex = 2;
            this.tinhChieuCao.Text = "Tinh";
            this.tinhChieuCao.UseVisualStyleBackColor = true;
            this.tinhChieuCao.Click += new System.EventHandler(this.tinhChieuCao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tinhChieuCao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chieuCao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button tinhChieuCao;

        private System.Windows.Forms.TextBox chieuCao;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}
using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class tinhTong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.soA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.soB = new System.Windows.Forms.TextBox();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(61, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "a";
            // 
            // soA
            // 
            this.soA.Location = new System.Drawing.Point(164, 41);
            this.soA.Name = "soA";
            this.soA.Size = new System.Drawing.Size(279, 38);
            this.soA.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(54, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "b";
            // 
            // soB
            // 
            this.soB.Location = new System.Drawing.Point(162, 114);
            this.soB.Name = "soB";
            this.soB.Size = new System.Drawing.Size(280, 38);
            this.soB.TabIndex = 3;
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Location = new System.Drawing.Point(207, 257);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(145, 68);
            this.btnTinhTong.TabIndex = 4;
            this.btnTinhTong.Text = "Tong";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(54, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tong";
            // 
            // txtTong
            // 
            this.txtTong.Enabled = false;
            this.txtTong.Location = new System.Drawing.Point(162, 180);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(274, 38);
            this.txtTong.TabIndex = 6;
            // 
            // tinhTong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTinhTong);
            this.Controls.Add(this.soB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.soA);
            this.Controls.Add(this.label1);
            this.Name = "tinhTong";
            this.Text = "tinhTong";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTong;

        private System.Windows.Forms.TextBox soB;
        private System.Windows.Forms.Button btnTinhTong;

        private System.Windows.Forms.TextBox soA;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}
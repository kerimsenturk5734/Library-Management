﻿namespace Kütüphane_Otomasyon
{
    partial class OgrenciEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oe_tb_TC = new System.Windows.Forms.TextBox();
            this.oe_tb_ad = new System.Windows.Forms.TextBox();
            this.oe_tb_soyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.oe_btn_ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC:";
            // 
            // oe_tb_TC
            // 
            this.oe_tb_TC.Location = new System.Drawing.Point(233, 137);
            this.oe_tb_TC.MaxLength = 11;
            this.oe_tb_TC.Name = "oe_tb_TC";
            this.oe_tb_TC.Size = new System.Drawing.Size(165, 22);
            this.oe_tb_TC.TabIndex = 3;
            // 
            // oe_tb_ad
            // 
            this.oe_tb_ad.Location = new System.Drawing.Point(233, 188);
            this.oe_tb_ad.MaxLength = 20;
            this.oe_tb_ad.Name = "oe_tb_ad";
            this.oe_tb_ad.Size = new System.Drawing.Size(165, 22);
            this.oe_tb_ad.TabIndex = 4;
            // 
            // oe_tb_soyad
            // 
            this.oe_tb_soyad.Location = new System.Drawing.Point(233, 241);
            this.oe_tb_soyad.MaxLength = 20;
            this.oe_tb_soyad.Name = "oe_tb_soyad";
            this.oe_tb_soyad.Size = new System.Drawing.Size(165, 22);
            this.oe_tb_soyad.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(198, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "ÖĞRENCİ EKLE";
            // 
            // oe_btn_ekle
            // 
            this.oe_btn_ekle.Location = new System.Drawing.Point(323, 317);
            this.oe_btn_ekle.Name = "oe_btn_ekle";
            this.oe_btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.oe_btn_ekle.TabIndex = 7;
            this.oe_btn_ekle.Text = "Ekle";
            this.oe_btn_ekle.UseVisualStyleBackColor = true;
            this.oe_btn_ekle.Click += new System.EventHandler(this.oe_btn_ekle_Click);
            // 
            // OgrenciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(597, 407);
            this.Controls.Add(this.oe_btn_ekle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oe_tb_soyad);
            this.Controls.Add(this.oe_tb_ad);
            this.Controls.Add(this.oe_tb_TC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OgrenciEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OgrenciEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oe_tb_TC;
        private System.Windows.Forms.TextBox oe_tb_ad;
        private System.Windows.Forms.TextBox oe_tb_soyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button oe_btn_ekle;
    }
}
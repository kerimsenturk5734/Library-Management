namespace Kütüphane_Otomasyon
{
    partial class KitapGuncelle
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
            this.gu_btn_guncelle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gu_num_sayfa = new System.Windows.Forms.NumericUpDown();
            this.gu_tb_yazar = new System.Windows.Forms.TextBox();
            this.gu_tb_ad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gu_num_sayfa)).BeginInit();
            this.SuspendLayout();
            // 
            // gu_btn_guncelle
            // 
            this.gu_btn_guncelle.Location = new System.Drawing.Point(361, 354);
            this.gu_btn_guncelle.Name = "gu_btn_guncelle";
            this.gu_btn_guncelle.Size = new System.Drawing.Size(87, 31);
            this.gu_btn_guncelle.TabIndex = 13;
            this.gu_btn_guncelle.Text = "Güncelle";
            this.gu_btn_guncelle.UseVisualStyleBackColor = true;
            this.gu_btn_guncelle.Click += new System.EventHandler(this.gu_btn_guncelle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sayfa Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Yazar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kitap Adı:";
            // 
            // gu_num_sayfa
            // 
            this.gu_num_sayfa.Location = new System.Drawing.Point(211, 264);
            this.gu_num_sayfa.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.gu_num_sayfa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gu_num_sayfa.Name = "gu_num_sayfa";
            this.gu_num_sayfa.Size = new System.Drawing.Size(120, 22);
            this.gu_num_sayfa.TabIndex = 9;
            this.gu_num_sayfa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gu_tb_yazar
            // 
            this.gu_tb_yazar.Location = new System.Drawing.Point(211, 200);
            this.gu_tb_yazar.MaxLength = 30;
            this.gu_tb_yazar.Name = "gu_tb_yazar";
            this.gu_tb_yazar.Size = new System.Drawing.Size(237, 22);
            this.gu_tb_yazar.TabIndex = 8;
            // 
            // gu_tb_ad
            // 
            this.gu_tb_ad.Location = new System.Drawing.Point(211, 138);
            this.gu_tb_ad.MaxLength = 50;
            this.gu_tb_ad.Name = "gu_tb_ad";
            this.gu_tb_ad.Size = new System.Drawing.Size(237, 22);
            this.gu_tb_ad.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(228, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "GÜNCELLE";
            // 
            // KitapGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gu_btn_guncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gu_num_sayfa);
            this.Controls.Add(this.gu_tb_yazar);
            this.Controls.Add(this.gu_tb_ad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "KitapGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KitapGuncelle";
            this.Load += new System.EventHandler(this.KitapGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gu_num_sayfa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gu_btn_guncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown gu_num_sayfa;
        private System.Windows.Forms.TextBox gu_tb_yazar;
        private System.Windows.Forms.TextBox gu_tb_ad;
        private System.Windows.Forms.Label label4;
    }
}
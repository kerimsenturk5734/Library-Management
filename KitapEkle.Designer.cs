namespace Kütüphane_Otomasyon
{
    partial class KitapEkle
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
            this.tbKitapAd = new System.Windows.Forms.TextBox();
            this.tbKitapYazar = new System.Windows.Forms.TextBox();
            this.numKitapSayfa = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKitapSayfa)).BeginInit();
            this.SuspendLayout();
            // 
            // tbKitapAd
            // 
            this.tbKitapAd.Location = new System.Drawing.Point(153, 63);
            this.tbKitapAd.MaxLength = 50;
            this.tbKitapAd.Name = "tbKitapAd";
            this.tbKitapAd.Size = new System.Drawing.Size(237, 22);
            this.tbKitapAd.TabIndex = 0;
            // 
            // tbKitapYazar
            // 
            this.tbKitapYazar.Location = new System.Drawing.Point(153, 125);
            this.tbKitapYazar.MaxLength = 30;
            this.tbKitapYazar.Name = "tbKitapYazar";
            this.tbKitapYazar.Size = new System.Drawing.Size(237, 22);
            this.tbKitapYazar.TabIndex = 1;
            // 
            // numKitapSayfa
            // 
            this.numKitapSayfa.Location = new System.Drawing.Point(153, 189);
            this.numKitapSayfa.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numKitapSayfa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKitapSayfa.Name = "numKitapSayfa";
            this.numKitapSayfa.Size = new System.Drawing.Size(120, 22);
            this.numKitapSayfa.TabIndex = 2;
            this.numKitapSayfa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kitap Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yazar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sayfa Sayısı:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(315, 290);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // KitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(489, 378);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numKitapSayfa);
            this.Controls.Add(this.tbKitapYazar);
            this.Controls.Add(this.tbKitapAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "KitapEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kitap Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.numKitapSayfa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKitapAd;
        private System.Windows.Forms.TextBox tbKitapYazar;
        private System.Windows.Forms.NumericUpDown numKitapSayfa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle;
    }
}
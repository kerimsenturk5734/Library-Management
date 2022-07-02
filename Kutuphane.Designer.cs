
namespace Kütüphane_Otomasyon
{
    partial class Kutuphane
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kutuphane));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnkitapguncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.btnkayıtlist = new System.Windows.Forms.Button();
            this.btnogrencilist = new System.Windows.Forms.Button();
            this.btnkitaplist = new System.Windows.Forms.Button();
            this.btnkitapsil = new System.Windows.Forms.Button();
            this.btnkitapekle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_islem_yap = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ogr_ekle = new System.Windows.Forms.Button();
            this.btn_ogr_sil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Linen;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnkitapguncelle);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btncıkıs);
            this.groupBox1.Controls.Add(this.btnkayıtlist);
            this.groupBox1.Controls.Add(this.btnogrencilist);
            this.groupBox1.Controls.Add(this.btnkitaplist);
            this.groupBox1.Controls.Add(this.btnkitapsil);
            this.groupBox1.Controls.Add(this.btnkitapekle);
            this.groupBox1.Location = new System.Drawing.Point(40, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1147, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Kitap Güncelle";
            // 
            // btnkitapguncelle
            // 
            this.btnkitapguncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnkitapguncelle.BackgroundImage")));
            this.btnkitapguncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnkitapguncelle.FlatAppearance.BorderSize = 0;
            this.btnkitapguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkitapguncelle.Location = new System.Drawing.Point(231, 9);
            this.btnkitapguncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnkitapguncelle.Name = "btnkitapguncelle";
            this.btnkitapguncelle.Size = new System.Drawing.Size(85, 85);
            this.btnkitapguncelle.TabIndex = 12;
            this.btnkitapguncelle.UseVisualStyleBackColor = true;
            this.btnkitapguncelle.Click += new System.EventHandler(this.btnkitapguncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(643, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Kayıtları Göster";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(519, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Öğrenci Listesi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kitap Listesi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kitap Sil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kitap Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1069, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Çıkış Yap";
            // 
            // btncıkıs
            // 
            this.btncıkıs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncıkıs.BackgroundImage")));
            this.btncıkıs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncıkıs.FlatAppearance.BorderSize = 0;
            this.btncıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncıkıs.Location = new System.Drawing.Point(1073, 27);
            this.btncıkıs.Margin = new System.Windows.Forms.Padding(4);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(65, 53);
            this.btncıkıs.TabIndex = 5;
            this.btncıkıs.UseVisualStyleBackColor = true;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // btnkayıtlist
            // 
            this.btnkayıtlist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnkayıtlist.BackgroundImage")));
            this.btnkayıtlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnkayıtlist.FlatAppearance.BorderSize = 0;
            this.btnkayıtlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkayıtlist.Location = new System.Drawing.Point(647, 20);
            this.btnkayıtlist.Margin = new System.Windows.Forms.Padding(4);
            this.btnkayıtlist.Name = "btnkayıtlist";
            this.btnkayıtlist.Size = new System.Drawing.Size(80, 68);
            this.btnkayıtlist.TabIndex = 4;
            this.btnkayıtlist.UseVisualStyleBackColor = true;
            this.btnkayıtlist.Click += new System.EventHandler(this.btnkayıtlist_Click);
            // 
            // btnogrencilist
            // 
            this.btnogrencilist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnogrencilist.BackgroundImage")));
            this.btnogrencilist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnogrencilist.FlatAppearance.BorderSize = 0;
            this.btnogrencilist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnogrencilist.Location = new System.Drawing.Point(523, 20);
            this.btnogrencilist.Margin = new System.Windows.Forms.Padding(4);
            this.btnogrencilist.Name = "btnogrencilist";
            this.btnogrencilist.Size = new System.Drawing.Size(80, 68);
            this.btnogrencilist.TabIndex = 3;
            this.btnogrencilist.UseVisualStyleBackColor = true;
            this.btnogrencilist.Click += new System.EventHandler(this.btnogrencilist_Click);
            // 
            // btnkitaplist
            // 
            this.btnkitaplist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnkitaplist.BackgroundImage")));
            this.btnkitaplist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnkitaplist.FlatAppearance.BorderSize = 0;
            this.btnkitaplist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkitaplist.Location = new System.Drawing.Point(415, 16);
            this.btnkitaplist.Margin = new System.Windows.Forms.Padding(4);
            this.btnkitaplist.Name = "btnkitaplist";
            this.btnkitaplist.Size = new System.Drawing.Size(80, 68);
            this.btnkitaplist.TabIndex = 2;
            this.btnkitaplist.UseVisualStyleBackColor = true;
            this.btnkitaplist.Click += new System.EventHandler(this.btnkitaplist_Click);
            // 
            // btnkitapsil
            // 
            this.btnkitapsil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnkitapsil.BackgroundImage")));
            this.btnkitapsil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnkitapsil.FlatAppearance.BorderSize = 0;
            this.btnkitapsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkitapsil.Location = new System.Drawing.Point(138, 8);
            this.btnkitapsil.Margin = new System.Windows.Forms.Padding(4);
            this.btnkitapsil.Name = "btnkitapsil";
            this.btnkitapsil.Size = new System.Drawing.Size(85, 85);
            this.btnkitapsil.TabIndex = 1;
            this.btnkitapsil.UseVisualStyleBackColor = true;
            this.btnkitapsil.Click += new System.EventHandler(this.btnkitapsil_Click);
            // 
            // btnkitapekle
            // 
            this.btnkitapekle.BackColor = System.Drawing.Color.Linen;
            this.btnkitapekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnkitapekle.BackgroundImage")));
            this.btnkitapekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnkitapekle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnkitapekle.FlatAppearance.BorderSize = 0;
            this.btnkitapekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkitapekle.Location = new System.Drawing.Point(45, 8);
            this.btnkitapekle.Margin = new System.Windows.Forms.Padding(4);
            this.btnkitapekle.Name = "btnkitapekle";
            this.btnkitapekle.Size = new System.Drawing.Size(85, 85);
            this.btnkitapekle.TabIndex = 0;
            this.btnkitapekle.UseVisualStyleBackColor = false;
            this.btnkitapekle.Click += new System.EventHandler(this.btnkitapekle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Linen;
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btn_islem_yap);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_ogr_ekle);
            this.groupBox2.Controls.Add(this.btn_ogr_sil);
            this.groupBox2.Location = new System.Drawing.Point(875, 185);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(312, 709);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(121, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "İşlem Yap";
            // 
            // btn_islem_yap
            // 
            this.btn_islem_yap.BackColor = System.Drawing.Color.Linen;
            this.btn_islem_yap.BackgroundImage = global::Kütüphane_Otomasyon.Properties.Resources.doOperation;
            this.btn_islem_yap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_islem_yap.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_islem_yap.FlatAppearance.BorderSize = 0;
            this.btn_islem_yap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_islem_yap.Location = new System.Drawing.Point(113, 235);
            this.btn_islem_yap.Margin = new System.Windows.Forms.Padding(4);
            this.btn_islem_yap.Name = "btn_islem_yap";
            this.btn_islem_yap.Size = new System.Drawing.Size(85, 85);
            this.btn_islem_yap.TabIndex = 18;
            this.btn_islem_yap.UseVisualStyleBackColor = false;
            this.btn_islem_yap.Click += new System.EventHandler(this.btn_islem_yap_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(191, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Öğrenci Sil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Öğrenci Ekle";
            // 
            // btn_ogr_ekle
            // 
            this.btn_ogr_ekle.BackColor = System.Drawing.Color.Linen;
            this.btn_ogr_ekle.BackgroundImage = global::Kütüphane_Otomasyon.Properties.Resources.addStudetn;
            this.btn_ogr_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ogr_ekle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ogr_ekle.FlatAppearance.BorderSize = 0;
            this.btn_ogr_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ogr_ekle.Location = new System.Drawing.Point(43, 51);
            this.btn_ogr_ekle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ogr_ekle.Name = "btn_ogr_ekle";
            this.btn_ogr_ekle.Size = new System.Drawing.Size(85, 85);
            this.btn_ogr_ekle.TabIndex = 15;
            this.btn_ogr_ekle.UseVisualStyleBackColor = false;
            this.btn_ogr_ekle.Click += new System.EventHandler(this.btn_ogr_ekle_Click);
            // 
            // btn_ogr_sil
            // 
            this.btn_ogr_sil.BackColor = System.Drawing.Color.Linen;
            this.btn_ogr_sil.BackgroundImage = global::Kütüphane_Otomasyon.Properties.Resources.deleteStudent;
            this.btn_ogr_sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ogr_sil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ogr_sil.FlatAppearance.BorderSize = 0;
            this.btn_ogr_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ogr_sil.Location = new System.Drawing.Point(194, 51);
            this.btn_ogr_sil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ogr_sil.Name = "btn_ogr_sil";
            this.btn_ogr_sil.Size = new System.Drawing.Size(85, 85);
            this.btn_ogr_sil.TabIndex = 14;
            this.btn_ogr_sil.UseVisualStyleBackColor = false;
            this.btn_ogr_sil.Click += new System.EventHandler(this.btn_ogr_sil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 226);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(812, 668);
            this.dataGridView1.TabIndex = 3;
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(40, 185);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(812, 22);
            this.tb_search.TabIndex = 4;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // Kutuphane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1203, 906);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Kutuphane";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kutuphane_FormClosing);
            this.Load += new System.EventHandler(this.kutuphane_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnkayıtlist;
        private System.Windows.Forms.Button btnogrencilist;
        private System.Windows.Forms.Button btnkitaplist;
        private System.Windows.Forms.Button btnkitapsil;
        private System.Windows.Forms.Button btnkitapekle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btncıkıs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnkitapguncelle;
        private System.Windows.Forms.Button btn_islem_yap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ogr_ekle;
        private System.Windows.Forms.Button btn_ogr_sil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_search;
    }
}



namespace Kütüphane_Otomasyon
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbtekrarsifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbsifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbkadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnkayıt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.groupBox1.Controls.Add(this.tbtekrarsifre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbsifre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbkadi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnkayıt);
            this.groupBox1.Location = new System.Drawing.Point(178, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 302);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // tbtekrarsifre
            // 
            this.tbtekrarsifre.Location = new System.Drawing.Point(87, 109);
            this.tbtekrarsifre.Name = "tbtekrarsifre";
            this.tbtekrarsifre.PasswordChar = '*';
            this.tbtekrarsifre.Size = new System.Drawing.Size(100, 20);
            this.tbtekrarsifre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tekrar Şifre:";
            // 
            // tbsifre
            // 
            this.tbsifre.Location = new System.Drawing.Point(87, 70);
            this.tbsifre.Name = "tbsifre";
            this.tbsifre.PasswordChar = '*';
            this.tbsifre.Size = new System.Drawing.Size(100, 20);
            this.tbsifre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre:";
            // 
            // tbkadi
            // 
            this.tbkadi.Location = new System.Drawing.Point(87, 25);
            this.tbkadi.Name = "tbkadi";
            this.tbkadi.Size = new System.Drawing.Size(100, 20);
            this.tbkadi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // btnkayıt
            // 
            this.btnkayıt.Location = new System.Drawing.Point(112, 175);
            this.btnkayıt.Name = "btnkayıt";
            this.btnkayıt.Size = new System.Drawing.Size(75, 23);
            this.btnkayıt.TabIndex = 3;
            this.btnkayıt.Text = "Kayıt Ol";
            this.btnkayıt.UseVisualStyleBackColor = true;
            this.btnkayıt.Click += new System.EventHandler(this.btnkayıt_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(381, 347);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kayıt";
            this.Load += new System.EventHandler(this.register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbtekrarsifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbsifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbkadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnkayıt;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kütüphane_Otomasyon.DataBaseManager;

namespace Kütüphane_Otomasyon
{
    public partial class OgrenciEkle : Form
    {
        public OgrenciEkle()
        {
            InitializeComponent();
        }

        private void oe_btn_ekle_Click(object sender, EventArgs e)
        {
            String TC = oe_tb_TC.Text.Trim();
            String ad = oe_tb_ad.Text.Trim();
            String soyad = oe_tb_soyad.Text.Trim();

            if(!Student.isExist("ogrTC", TC))
            {

                if ((TC.Length==11) && (ad != "") && (soyad != ""))
                {
                    Student newStudent = new Student();
                    newStudent.TC = long.Parse(oe_tb_TC.Text);
                    newStudent.name = oe_tb_ad.Text;
                    newStudent.surname = oe_tb_soyad.Text;
                    newStudent.add();
                    DialogResult result = MessageBox.Show("İşlem Başarılı", "Başarılı",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                        this.Close();

                }
                else
                {
                    MessageBox.Show("Lütfen alanları doldurunuz \nve TC'nin 11 karakter olduğundan emin olunuz.", "Uyarı",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bu öğrenci zaten bulunmakta", "Uyarı",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}

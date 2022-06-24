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
    public partial class KitapGuncelle : Form
    {
        public Book selectedBook;
        public KitapGuncelle()
        {
            InitializeComponent();

        }

        private void KitapGuncelle_Load(object sender, EventArgs e)
        {
            gu_tb_ad.Text = selectedBook.bookName;
            gu_tb_yazar.Text = selectedBook.author;
            gu_num_sayfa.Text = selectedBook.pageNo.ToString();
        }

        private void gu_btn_guncelle_Click(object sender, EventArgs e)
        {
            if ((gu_tb_ad.Text.Trim() != "") && (gu_tb_yazar.Text.Trim() != ""))
            {

                selectedBook.bookName=gu_tb_ad.Text;
                selectedBook.author=gu_tb_yazar.Text;
                selectedBook.pageNo=short.Parse(gu_num_sayfa.Text);
                selectedBook.update(gu_tb_ad.Text,gu_tb_yazar.Text,gu_num_sayfa.Text);

                DialogResult result = MessageBox.Show("Kitap Başarıyla Güncellendi", "Başarılı",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                    this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen alanları tam doldurunuz", "Uyarı",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

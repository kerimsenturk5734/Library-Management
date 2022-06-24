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
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            String ad = tbKitapAd.Text.Trim();
            String yazar = tbKitapYazar.Text.Trim();
            short page = short.Parse(numKitapSayfa.Value.ToString().Trim());

            if ((ad != "") && (yazar != ""))
            {
                if (!(((int)numKitapSayfa.Value) <= 0))
                {

                    if ((!Book.isExist("kitapad", tbKitapAd.Text)) && 
                        (!Book.isExist("kitapsayfa", numKitapSayfa.Value.ToString())))
                    {
                        Book newBook = new Book(ad,yazar,page);
                        newBook.add();
                        DialogResult result = MessageBox.Show("İşlem Başarılı", "Başarılı",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                            this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Bu kitap zaten bulunmakta", "Uyarı",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Sayfa Sayısı 0'dan büyük olmalıdır", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen boşlukları doldurunuz","Uyarı",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           
        }

       
    }
}

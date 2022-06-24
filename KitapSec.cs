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
using System.Data.SqlClient;

namespace Kütüphane_Otomasyon
{
    public partial class KitapSec : Form
    {
        public Student selectedStudent;
        public KitapSec()
        {
            InitializeComponent();
        }

        private void KitapSec_Load(object sender, EventArgs e)
        {
            gridDoldur();
        }

        private void gridDoldur()
        {
            DataSet ds = Book.select(0);
           
            for (int i = 0; i < ds.Tables["tbl_kitaplar"].Rows.Count; i++)
            {

                bool confirm = Receive.isThatSo(
                    ds.Tables["tbl_kitaplar"].Rows[i].ItemArray[0].ToString(),true);
                ds.AcceptChanges();
                if (confirm)
                {
                    ds.Tables["tbl_kitaplar"].Rows.RemoveAt(i);
                    i = 0;
                    //satır silinince index kayıyor ve table satır sayısı azalıyor bu yüzden döngüyü başa alıyoruz
                }


            }

            dataGridView1.DataSource = ds.Tables["tbl_kitaplar"];
            dataGridView1.Columns[0].HeaderText = "Kitap No";
            dataGridView1.Columns[1].HeaderText = "Kitap Adı";
            dataGridView1.Columns[2].HeaderText = "Yazar";
            dataGridView1.Columns[3].HeaderText = "Sayfa";

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            
        }

        private void ks_btn_kitapver_Click(object sender, EventArgs e)
        {

            if (dateTimePicker1.Value.Day>DateTime.Now.Day)
            {
                if (dataGridView1.SelectedCells.Count>0)
                {
                    Receive receive = new Receive();
                    User user = new User();
                    Book book = new Book();
                    user.userName = Kutuphane.userName;
                    book.kitapid = short.Parse(
                        dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    //fillprop eklemeyi dene
                    receive.student = selectedStudent;
                    receive.book = book;
                    receive.user = user;
                    receive.state = true;


                    receive.add(dateTimePicker1.Value.Date.ToShortDateString());
                    gridDoldur();
                }
                else
                {
                    MessageBox.Show("Lütfen bir kitap seçiniz");
                }
            }
            else
            {
                MessageBox.Show("İade tarihi bugünden sonra olmalıdır");
            }
        }
    }
}
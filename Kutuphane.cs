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
    public partial class Kutuphane : Form
    {
        getData data = new getData();
        DataSet ds;
        Book book = new Book();
        Student student = new Student();
        public static string userName = "";

        public Kutuphane()
        {
            InitializeComponent();

        }

        private void kutuphane_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            btnkitaplist_Click(sender, e);

        }

        private void kutuphane_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnkitapekle_Click(object sender, EventArgs e)
        {
            KitapEkle kitapekle = new KitapEkle();
            kitapekle.ShowDialog();
            btnkitaplist_Click(sender, e);
        }

        private void btnkitapsil_Click(object sender, EventArgs e)
        {
            short kitapID = (short)dataGridView1.SelectedRows[0].Cells[0].Value;
            DialogResult result = MessageBox.Show("Bu kitaba ait tüm kayıtlar silinecektir.\n" +
                "Silmek istediğinize gerçekten emin misiniz ", "Siliniyor...",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (Receive.isExist("kitapID", Convert.ToString(kitapID)))
                    Receive.delete(kitapID);

                book.kitapid = kitapID;
                book.delete();
                btnkitaplist_Click(sender, e);
            }

        }

        private void btnkitaplist_Click(object sender, EventArgs e)
        {
            ds = Book.select(0);
            dataGridView1.DataSource = ds.Tables["tbl_kitaplar"];

            btn_ogr_ekle.Enabled = false;
            btn_ogr_sil.Enabled = false;
            btn_islem_yap.Enabled = false;
            btnkitapekle.Enabled = true;
            btnkitapsil.Enabled = true;
            btnkitapguncelle.Enabled = true;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnogrencilist_Click(object sender, EventArgs e)
        {
            ds = Student.select("*");

            dataGridView1.DataSource = ds.Tables["tbl_ogrenciler"];

            ds.Tables["tbl_ogrenciler"].Columns["ogrTC"].ColumnName = "TC";
            ds.Tables["tbl_ogrenciler"].Columns["ogrAd"].ColumnName = "Ad";
            ds.Tables["tbl_ogrenciler"].Columns["ogrSoyad"].ColumnName = "Soyad";

            btnkitapekle.Enabled = false;
            btnkitapsil.Enabled = false;
            btnkitapguncelle.Enabled = false;
            btn_ogr_ekle.Enabled = true;
            btn_ogr_sil.Enabled = true;
            btn_islem_yap.Enabled = true;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void btnkayıtlist_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Receive.select(0);

            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            btnkitapekle.Enabled = btnkitapsil.Enabled = btnkitapguncelle.Enabled =
                btn_ogr_ekle.Enabled = btn_ogr_sil.Enabled = btn_islem_yap.Enabled = false;

        }

        private void btnkitapguncelle_Click(object sender, EventArgs e)
        {
            Book updateBook = new Book();
            updateBook.kitapid = (short)dataGridView1.SelectedRows[0].Cells[0].Value;
            updateBook.bookName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            updateBook.author = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            updateBook.pageNo = (short)dataGridView1.SelectedRows[0].Cells[2].Value;

            KitapGuncelle kitapGuncelle = new KitapGuncelle()
            {
                selectedBook = updateBook
            };
            kitapGuncelle.ShowDialog();
            btnkitaplist_Click(sender, e);
        }

        private void btn_ogr_sil_Click(object sender, EventArgs e)
        {
            long ogrTC = (long)dataGridView1.SelectedRows[0].Cells[0].Value;
            DialogResult result = MessageBox.Show("Bu öğrenciyi silmek istediğinize emin misiniz?", "Siliniyor...",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                student.TC = ogrTC;
                student.delete();
                btnogrencilist_Click(sender, e);
            }
        }

        private void btn_ogr_ekle_Click(object sender, EventArgs e)
        {
            OgrenciEkle ogrenciEkle = new OgrenciEkle();
            ogrenciEkle.ShowDialog();
            btnogrencilist_Click(sender, e);
        }

        private void btn_islem_yap_Click(object sender, EventArgs e)
        {
            Student selectedStudent = new Student();
            selectedStudent.TC = (long)dataGridView1.SelectedRows[0].Cells[0].Value;
            selectedStudent.name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            selectedStudent.surname = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            IslemYap islemYap = new IslemYap()
            {
                selectedStudent = selectedStudent
            };
            islemYap.ShowDialog();

        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış Yapmak İstediğinize Emin Misiniz?",
                "Çıkış Yap", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            connector conn = new connector();
            SqlCommand cmd;
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            //aktif tablodan like ile veriler getirilecek
            if (dataGridView1.Columns[0].Name.Equals("TC"))
            {
                //ÖĞRENCİLERİ GETİRECEK
                DataView dv = Student.select().Tables["tbl_ogrenciler"].DefaultView;
                dv.RowFilter = String.Format("Ad LIKE '%{0}%'",tb_search.Text);

                dataGridView1.DataSource = dv;
            }
            else if (dataGridView1.Columns[0].Name.Equals("ID"))
            {
                //kitaplar
                DataView dv = Book.select(0).Tables["tbl_kitaplar"].DefaultView;
                dv.RowFilter = String.Format("Ad LIKE '%{0}%'", tb_search.Text);

                dataGridView1.DataSource = dv;
            }
            else
            {
                //kayıtlar
                DataView dv = Receive.select(0).DefaultView;
                dv.RowFilter = 
                    String.Format("CONVERT(OgrenciTC, System.String)  LIKE '%{0}%'", tb_search.Text);

                dataGridView1.DataSource = dv;
            }

            
        }
    }
}

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
using Microsoft.VisualBasic;

namespace Kütüphane_Otomasyon
{
    public partial class IslemYap : Form
    {
        List<Receive> receives;
        List<Book> books;
        List<User> users;

        public Student selectedStudent;
        
        public IslemYap()
        {
            InitializeComponent();
        }
        
        private void islemyap_Load(object sender, EventArgs e)
        {
            lbad.Text = selectedStudent.name;
            lbsoyad.Text = selectedStudent.surname;
            lbtc.Text = selectedStudent.TC.ToString();
            bilgileriCek();

            btnkitapal.Enabled = btnsureuzat.Enabled =
            iy_lb_sureuzat.Enabled = iy_num_sure.Enabled =
            label4.Enabled = false;
        }

        private void bilgileriCek()
        {
            books = new List<Book>();
            users=new List<User>();
            receives=new List<Receive>();
            TableManager tableManager = new TableManager("tbl_teslim");
            DataSet ds = tableManager.listData("*", "ogrTC", selectedStudent.TC.ToString());
            
            for(int i=0; i<ds.Tables["tbl_teslim"].Rows.Count; i++)
            {
                Receive receive = new Receive();
                
                //--------------TESLİM İÇİN GEREKLİ NESNELER DOLDURULUYOR----------------
                Student student = new Student();
                student.fillStudentProp((long) ds.Tables["tbl_teslim"].Rows[i].ItemArray[1]);
                Book book = new Book();
                book.fillBookProp((short)ds.Tables["tbl_teslim"].Rows[i].ItemArray[2]);
                User user=new User(ds.Tables["tbl_teslim"].Rows[i].ItemArray[3].ToString());
                user.fillUserProp();


                //-----------Teslim bilgileri dolduruluyor----------------
                receive.receiveID = (short)ds.Tables["tbl_teslim"].Rows[i].ItemArray[0];
                receive.book = book;
                receive.student = student;
                receive.user = user;


                //MessageBox.Show(ds.Tables["tbl_teslim"].Rows[i].ItemArray[4].ToString());
                String vTarih= ((DateTime)ds.Tables["tbl_teslim"].Rows[i].ItemArray[4]).ToShortDateString();
                String aTarih = ((DateTime)ds.Tables["tbl_teslim"].Rows[i].ItemArray[5]).ToShortDateString();

                receive.vTarih = Convert.ToDateTime(vTarih);
                receive.aTarih = Convert.ToDateTime(aTarih);
                receive.state =(bool) ds.Tables["tbl_teslim"].Rows[i].ItemArray[6];

                books.Add(book);
                users.Add(user);
                receives.Add(receive);



                //------------KİTAP RESİM VE ÖZELLİKLERİ LİSTVİEW'E ATILIYOR---------------
                ImageList imageList = new ImageList();
                imageList.Images.Add(Image.FromFile("icons/okundu.png"));
                imageList.Images.Add(Image.FromFile("icons/okunuyor.png"));
                imageList.Images.Add(Image.FromFile("icons/teslimedilmedi.png"));

                ListViewItem item = new ListViewItem();
                item.Text = book.bookName;
                if ((receive.aTarih <= DateTime.Now) && ((bool)ds.Tables["tbl_teslim"].Rows[i].ItemArray[6]))
                {
                    item.ImageIndex = 3;
                }

                else if (!(bool)ds.Tables["tbl_teslim"].Rows[i].ItemArray[6])
                    item.ImageIndex = 0;
                
                else 
                    item.ImageIndex = 1;
                listView1.Items.Add(item);
                listView1.LargeImageList = imageList;
     

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count>0)
            {
                int index = listView1.SelectedIndices[0];

                btnkitapal.Enabled = btnsureuzat.Enabled =
                iy_lb_sureuzat.Enabled= iy_num_sure.Enabled =
                label4.Enabled = receives[index].state;


                iy_lb_kitadi.Text = books[index].bookName;
                iy_lb_yazar.Text = books[index].author;
                iy_lb_sayfa.Text = books[index].pageNo.ToString();
                iy_lb_vTarihi.Text = Convert.ToDateTime(receives[index].vTarih).ToShortDateString();
                iy_lb_aTarihi.Text = Convert.ToDateTime(receives[index].aTarih).ToShortDateString();

            }
        }

        private void btnkitapver_Click(object sender, EventArgs e)
        {
            KitapSec kitapSec = new KitapSec()
            {
                selectedStudent = selectedStudent
            };
            kitapSec.ShowDialog();
            listView1.Items.Clear();
            bilgileriCek();
        }

        private void btnkitapal_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bu kitabı teslim almak istediğinize emin misiniz",
                     "Teslim Al", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int index = listView1.SelectedIndices[0];
                    //teslim tablosundaki ilgili kayıtın aTarihi bugün ayarlanacak ve durumu false yapılacak
                    receives[index].state = false;
                    receives[index].aTarih = DateTime.Now;
                    receives[index].update();
                    listView1.Items.Clear();
                    bilgileriCek();
                }
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir kitap seçiniz");
            }
        }

        private void btnsureuzat_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.SelectedIndices[0];
                //teslim tablosundaki ilgili kayıtın aTarihi bugün ayarlanacak ve durumu false yapılacak
                receives[index].state = true;
                receives[index].aTarih = receives[index].aTarih.AddDays(
                    Convert.ToDouble(iy_num_sure.Value));
                receives[index].update();
                listView1.Items.Clear();
                bilgileriCek();
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir kitap seçiniz");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kütüphane_Otomasyon
{
    public partial class Register : Form
    {
        connector conn = new connector();
        public Register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {
                    
        }

        private void btnkayıt_Click(object sender, EventArgs e)
        {
            if (userCheck())
            {
                if (passwordCheck(tbsifre.Text, tbtekrarsifre.Text))
                {

                    SqlCommand kayıtekle = new SqlCommand("insert into tbl_kullanicilar (kadi,ksifre) values (@kadi,@ksifre)", conn.connection());
                    kayıtekle.Parameters.AddWithValue("@kadi", tbkadi.Text);
                    kayıtekle.Parameters.AddWithValue("@ksifre", tbsifre.Text);
                    kayıtekle.ExecuteNonQuery();
                    MessageBox.Show("Kaydınız Başarıyla Yapılmıştır");
                    conn.connection().Close();
                    this.Close();
                }
            }

            else MessageBox.Show("Bu kullanıcı adı kullanımda, lütfen tekrar deneyiniz.");
        }

        public bool userCheck()
        {
            SqlCommand cmd = new SqlCommand("select * from tbl_kullanicilar where kadi=@kadi", conn.connection());
            cmd.Parameters.AddWithValue("@kadi", tbkadi.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            if (ds.Tables["kullanicilar"] != null) 
            { 
                ds.Tables["kullanicilar"].Clear(); 
            }
                da.Fill(ds,"kullanicilar");

            if (ds.Tables["kullanicilar"].Rows.Count <=0)  
                return true; 

            else  
                return false; 

        }

        public  bool passwordCheck(string paswword1,string password2)
        {
            if (paswword1!= password2)
            {
                MessageBox.Show("Şifre uyuşmamaktadır , lütfen tekrar kontrol ediniz");
                return false;
            }
            else return true;
            
            
        }

        
    }
}

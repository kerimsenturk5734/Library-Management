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
    
    public partial class Login : Form
    {
        public static int a;
        getData data = new getData();

        connector conn;
        Kutuphane kutuphane;
        
        public Login()
        {
            InitializeComponent();
            conn = new connector();
            kutuphane = new Kutuphane();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from tbl_kullanicilar where kadi=@kadi",conn.connection());
            cmd.Parameters.AddWithValue("@kadi", tbkadi.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            
            DataSet ds = new DataSet();
            da.Fill(ds, "kullanicilar");
            if (ds.Tables["kullanicilar"].Rows.Count <= 0) MessageBox.Show("Böyle bir kullanıcı bulunmamaktadır");
            else
            {
                if (tbsifre.Text == ds.Tables["kullanicilar"].Rows[0]["ksifre"].ToString())
                {
                    confirmClosing=false;
                    string userName=tbkadi.Text;
                    Kutuphane.userName = userName;
                    this.Close();      
                    
                }
                else MessageBox.Show("Şifre yanlış, lütfen tekrar deneyiniz");
            }

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnkayıtol_Click(object sender, EventArgs e)
        {
            Register yeni = new Register();
            yeni.ShowDialog();
        }

        bool confirmClosing=true;
        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(confirmClosing)
                Application.Exit();
           
            
        }
    }
}

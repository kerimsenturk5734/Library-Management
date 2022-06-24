using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Kütüphane_Otomasyon.DataBaseManager
{
    public class User
    {

        public String userName { get; set; }
        public String password { get; set; }
        public bool adminLevel { get; set; }

        static SqlCommand cmd = new SqlCommand();
        static connector conn = new connector();


        public User()
        {
            
        }
        public User(String userName)
        {
            this.userName = userName;
        }
        public void fillUserProp()
        {
            cmd = new SqlCommand("select * from tbl_kullanicilar where kadi=@kadi",conn.connection());

            cmd.Parameters.AddWithValue("@kadi", this.userName);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_kulanicilar");

            this.password = ds.Tables[0].Rows[0].ItemArray[1].ToString();

        }

    }
}

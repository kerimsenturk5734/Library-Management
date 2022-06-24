using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Kütüphane_Otomasyon.DataBaseManager
{
    internal class Receive : IManager
    {
        static SqlDataAdapter da;
        static SqlCommand cmd = new SqlCommand();
        static connector conn = new connector();

        public short receiveID { get; set; }
        public Student student { get; set; }
        public Book book { get; set; }
        public User user { get; set; }
        public DateTime vTarih { get; set; }
        public DateTime aTarih { get; set; }

        public bool state { get; set; }

        public void add()
        {

        }
        public void add(String dateTime)
        {
            cmd.Connection = conn.connection();
            cmd.CommandText =
                ("insert into tbl_teslim (ogrTC,kitapID,vTarihi,aTarihi,kAdi,tDurum) values (@ogrTC,@kitapID,@vTarihi,@aTarihi,@kAdi,@tDurum)");
            cmd.Parameters.AddWithValue("@ogrTC", student.TC);
            cmd.Parameters.AddWithValue("@kitapID", book.kitapid);
            cmd.Parameters.AddWithValue("@kAdi", user.userName);
            cmd.Parameters.AddWithValue("@vTarihi", DateTime.Now);
            cmd.Parameters.AddWithValue("@aTarihi", dateTime);
            cmd.Parameters.AddWithValue("@tDurum", state);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            cmd.Parameters.Clear();
        }

        public static void delete(short kitapID)
        {
            cmd.Connection = conn.connection();
            cmd.CommandText = "DELETE FROM tbl_teslim WHERE kitapID=@kitapID";

            cmd.Parameters.AddWithValue("@kitapID",Convert.ToString(kitapID));

            cmd.ExecuteNonQuery();

            cmd.Connection.Close();
            cmd.Parameters.Clear();
        }

        public void delete()
        {
            
        }
        public void update()
        {
            cmd.Connection = conn.connection();
            cmd.CommandText =
                "UPDATE tbl_teslim SET kAdi=@kAdi,vTarihi=@vTarihi,aTarihi=@aTarihi,tDurum=@tDurum " +
                "WHERE teslimID=@teslimID";

            cmd.Parameters.AddWithValue("@teslimID", this.receiveID);
            cmd.Parameters.AddWithValue("@ogrTC", this.student.TC);
            cmd.Parameters.AddWithValue("@kitapID", this.book.kitapid);
            cmd.Parameters.AddWithValue("@kAdi", this.user.userName);
            cmd.Parameters.AddWithValue("@vTarihi", this.vTarih);
            cmd.Parameters.AddWithValue("@aTarihi", this.aTarih);
            cmd.Parameters.AddWithValue("@tDurum", this.state);

            cmd.ExecuteNonQuery();

            cmd.Connection.Close();
            cmd.Parameters.Clear();

        }

        public static bool isExist(String field, String condition)
        {
            string query = "SELECT COUNT(@field) FROM tbl_teslim WHERE @field = @condition";

            cmd = new SqlCommand(query,conn.connection());

            cmd.Parameters.AddWithValue("@field", field);
            cmd.Parameters.AddWithValue("@condition", condition);

            int count = (int)cmd.ExecuteScalar();

            if (count > 0)
                return true;
            else
                return false;
        }
            
        public static bool isThatSo(String kitapID,bool tDurum)
        {
            string sql = "SELECT COUNT(*) FROM tbl_teslim WHERE kitapID=@kitapID AND tDurum=@tDurum";
            cmd = new SqlCommand(sql,conn.connection());

            cmd.Parameters.AddWithValue("@kitapID", kitapID);
            cmd.Parameters.AddWithValue("@tDurum", tDurum);

            int count = (int) cmd.ExecuteScalar();
            cmd.Parameters.Clear();

            if (count > 0)
                return true;
            else
                return false ;

        }

        public void select()
        {

        }
        public static DataTable select(int temp)
        {
           

            cmd = new SqlCommand("GetReceives",conn.connection());
            da=new SqlDataAdapter(cmd);

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            da.Fill(dt);
            
            return dt;
        }
    }
}

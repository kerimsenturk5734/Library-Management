using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Kütüphane_Otomasyon.DataBaseManager;
namespace Kütüphane_Otomasyon.DataBaseManager
{
    
    public class Student:IManager
    {
        public long TC { get; set; }
        public String name { get; set; }
        public String surname { get; set; }

       


        static SqlCommand cmd = new SqlCommand();
        static connector conn = new connector();


        public static DataSet select()
        {

            cmd = new SqlCommand("SELECT ogrTC AS TC,ogrAd AS Ad,ogrSoyad AS Soyad FROM tbl_ogrenciler", conn.connection());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_ogrenciler");
            
            return ds;

        }
        public static DataSet select(string field)
        {
            cmd = new SqlCommand("SELECT "+field+ " FROM tbl_ogrenciler", conn.connection());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_ogrenciler");

            return ds;
        }
       
       
        public void add()
        {
            cmd.Connection = conn.connection();
            cmd.CommandText = "insert into tbl_ogrenciler (ogrTC,ogrAd,ogrSoyad) values (@ogrTC,@ogrAd,@ogrSoyad)";

            cmd.Parameters.AddWithValue("@ogrTC", TC);
            cmd.Parameters.AddWithValue("@ogrAd", name);
            cmd.Parameters.AddWithValue("@ogrSoyad", surname);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void delete()
        {
            cmd.Connection = conn.connection();

            cmd.CommandText = "delete from tbl_ogrenciler where ogrTC=@ogrTC";
            cmd.Parameters.AddWithValue("@ogrTC", TC);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void update()
        {

        }

        public static bool isExist(String field, String condition)
        {
            string query = "select count(@field) from tbl_ogrenciler where @field = @condition";
            cmd = new SqlCommand(query, conn.connection());

            cmd.Parameters.AddWithValue("@field", field);
            cmd.Parameters.AddWithValue("@condition", condition);

            int count = (int)cmd.ExecuteScalar();

            if (count > 0)
                return true;
            else
                return false;
        }

        public void fillStudentProp(long TC)
        {
            cmd = new SqlCommand("select * from tbl_ogrenciler where ogrTC=@ogrTC",conn.connection());
            cmd.Parameters.AddWithValue("@ogrTC", TC);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_ogrenciler");

            this.TC = (long)ds.Tables["tbl_ogrenciler"].Rows[0].ItemArray[0];
            this.name = ds.Tables["tbl_ogrenciler"].Rows[0].ItemArray[1].ToString();
            this.surname = ds.Tables["tbl_ogrenciler"].Rows[0].ItemArray[2].ToString();


        }

        void IManager.select()
        {
            throw new NotImplementedException();
        }
    }
}

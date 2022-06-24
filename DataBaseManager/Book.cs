using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Kütüphane_Otomasyon.DataBaseManager
{
    public class Book : IManager
    {
         public short kitapid { get; set; }
         public String bookName { get; set; }
         public String author { get; set; }
         public short pageNo { get; set; }
        

        static SqlCommand cmd = new SqlCommand();
        static connector conn = new connector();

        public Book()
        { 
        }
        public Book(String _bookName, String _author, short _pageNo)
        {
            
            bookName = _bookName;
            author = _author;
            pageNo = _pageNo;
            
        }

       
        public void add()
        {
            string query= "insert into tbl_kitaplar (kitapad,kitapyazar,kitapsayfa) values (@bookname,@author,@pageNo)";

            cmd = new SqlCommand(query,conn.connection());
            

            cmd.Parameters.AddWithValue("@bookName",bookName);
            cmd.Parameters.AddWithValue("@author", author);
            cmd.Parameters.AddWithValue("@pageNo", pageNo);


            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            
        }

        public void delete()
        {
            cmd.Connection=conn.connection();

            cmd.CommandText = "delete from tbl_kitaplar where kitapID=@kitapID";
            cmd.Parameters.AddWithValue("@kitapID", this.kitapid);
            cmd.ExecuteNonQuery ();
            cmd.Connection.Close ();
        }
        
        public void update(string kitapad,string yazar,string sayfa)
        {
            string query = "update tbl_kitaplar set kitapad=@kitapad, kitapsayfa=@kitapsayfa, kitapyazar=@yazar WHERE kitapID=@kitapID";
            cmd = new SqlCommand(query, conn.connection());

            cmd.Parameters.AddWithValue("@kitapad", kitapad);
            cmd.Parameters.AddWithValue("@kitapsayfa", sayfa);
            cmd.Parameters.AddWithValue("@yazar", yazar);
            cmd.Parameters.AddWithValue("@kitapID", this.kitapid);

            cmd.ExecuteNonQuery(); 

            cmd.Connection.Close();
            cmd.Parameters.Clear();
        }

        public void select()
        {
            
        }
        public static DataSet select(int temp)
        {
            cmd = new SqlCommand("GetBooks",conn.connection());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_kitaplar");  
            
            return ds;
        }
       
        public static bool isExist(String field, String condition)
        {
            cmd = new SqlCommand
                ("select count(@field) from tbl_kitaplar where @field=@condition",
                conn.connection());
            cmd.Parameters.AddWithValue("@field", field);
            cmd.Parameters.AddWithValue("@condition", condition);

            int count = (int)cmd.ExecuteScalar();

            if (count > 0)
                return true;
            else
                return false;
        }

       
        public void fillBookProp(short kitapID)
        {
            cmd = new SqlCommand("select * from tbl_kitaplar where kitapID=@kitapID", conn.connection());
            cmd.Parameters.AddWithValue("@kitapID", kitapID);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_kitaplar");

            this.bookName = ds.Tables["tbl_kitaplar"].Rows[0].ItemArray[1].ToString();
            this.author = ds.Tables["tbl_kitaplar"].Rows[0].ItemArray[3].ToString();
            this.pageNo = (short)ds.Tables["tbl_kitaplar"].Rows[0].ItemArray[2];



        }

        public void update()
        {

        }
    }
}

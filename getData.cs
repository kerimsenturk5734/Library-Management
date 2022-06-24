using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Kütüphane_Otomasyon
{
    public class getData
    {
        
        connector conn = new connector();
        public DataSet verilericek(string table,string field)
        {
            SqlDataAdapter da = new SqlDataAdapter("select " + field + " from " + table, conn.connection());
            DataSet ds = new DataSet();
            da.Fill(ds,table);
            return ds;
        }
        
    }
}

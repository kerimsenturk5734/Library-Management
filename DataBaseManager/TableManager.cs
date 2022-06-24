using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Kütüphane_Otomasyon.DataBaseManager
{
     public  class TableManager
    {
        String table;
        public connector conn = new connector();
        public DataSet dataSet = new DataSet();
        public SqlDataAdapter da = new SqlDataAdapter();
        public SqlCommand cmd = new SqlCommand();


        public TableManager(String _table)
        {
            
            this.table = _table;
        }

        public  void updateData(String newData,String updatefields,String conditionField,String condition)
        {
            conn.connection().Open();
            cmd.Connection = conn.connection();
            cmd.CommandText = "update " + table + "set (" + updatefields + ") values (" + newData + ") where "+conditionField+"="+condition;
            cmd.ExecuteNonQuery();
            conn.connection().Close();

        }
        public  void removeData(String conditionField,String condition)
        {
            conn.connection().Open();
            cmd.Connection = conn.connection();
            cmd.CommandText = "delete from " + table + "where "+conditionField+"="+condition;
            cmd.ExecuteNonQuery();
            conn.connection().Close();

        }
        public  DataSet listData(String field)
        {
            da = new SqlDataAdapter("select "+field+" from "+table, conn.connection());
            da.Fill(dataSet);
            conn.connection().Close();
            return dataSet;
        }
        public DataSet listData(String field, String conditionField, String condition)
        {
            da = new SqlDataAdapter("select " + field + " from " + table+" where "+conditionField+"='"+condition+"'", conn.connection());
            da.Fill(dataSet,table);
            conn.connection().Close();
            return dataSet;
        }
    }
}

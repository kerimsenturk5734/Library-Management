using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Kütüphane_Otomasyon
{
    
    public class connector
    {
        
       public  SqlConnection connection()  

        {   
            SqlConnection conn = new SqlConnection(@"Data Source=.; Initial Catalog=kutuphane; Integrated Security=True");    
            conn.Open();
            return conn; 
        }
        
    }//Data Source=DESKTOP-JUJPK4E;Initial Catalog=dbo_yemektarifi;Integrated Security=True
    
}


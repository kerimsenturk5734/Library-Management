using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Kütüphane_Otomasyon
{
    
    public class connector
    {
        int authMode;
        string serverName, dbName, user, password;
        string connStr;

        public  SqlConnection connection()  
        {
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                string path = Application.StartupPath + @"\Properties.txt";

                //Open file
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);

                sr = new StreamReader(fs);
                
                string ln;
                int count = 1;
                //Read File
                while ((ln=sr.ReadLine())!=null)
                {
                    if (count == 1)
                    {
                        authMode = Convert.ToInt32(ln.Split('=')[1]);
                    }
                    else if (count == 2)
                    {
                        serverName = ln.Split('=')[1];
                    }
                    else if (count == 3)
                    {
                        dbName = ln.Split('=')[1];
                    }
                    else if (count == 4 && authMode == 1)
                    {
                        user= ln.Split('=')[1];
                    }
                    else if (count == 5 && authMode == 1)
                    {
                        password = ln.Split('=')[1];
                    }
                  
                    count++;
                }
               
               
            }
            catch (Exception ex)
            {
                string er = "\nPlease execute 'ConnectToDatabase.exe'.Cause properties.txt is corrupted";
                MessageBox.Show(ex.Message+er, "Error");
            }
            finally
            {
                sr.Close();
                fs.Close();
            }

            //Create connection string
            if (authMode==0)
                connStr = "Server=" + serverName + ";Database=" + dbName + ";" +
                        "Trusted_Connection=True;";
            else
                connStr = "Server=" + serverName + ";Database=" + dbName + ";" +
                        "User Id=" + user + ";Password=" + password + ";" +
                        "Trusted_Connection=False;";


            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                return conn;
            }
            catch(Exception ex)
            {
                string er = "\nPlease execute the 'ConnectToDatabase.exe' and configure database.\n" +
                            "Cause 'Properties.txt' is not right format";
                MessageBox.Show(ex.Message+er, "Error");
            }
            
            return null;
        }
        
    }
    
}


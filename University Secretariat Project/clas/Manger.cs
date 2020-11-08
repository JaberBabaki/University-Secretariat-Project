using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personnelMangement.clas
{
    class Manger:DataAcsess
    {
        private string path;
        public string Path
        {
            set { path = value; }
            get{return path;}
        }
        public int backUp(){
            string CommandText = "BACKUP_DATA";
            com.Parameters.AddWithValue("@path", Path);
            return command(CommandText);
        }
        public int bac()
        {
            string command = @"BACKUP DATABASE PSI TO DISK=N'" + path + "'";




            com = new SqlCommand(command, con);
            return com.ExecuteNonQuery();

           // MessageBox.Show("تهیه نسخه پشتیبان از اطلا عات با موفقیت انجام شد");
        }
    }
}

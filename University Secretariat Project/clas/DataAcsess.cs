
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
namespace personnelMangement.clas
{
    class DataAcsess
    {
        protected string num_Este;
        protected string name;
        protected string useName;
        protected string password;
        protected string picture;
        protected string family;


        protected string mainText;
        protected string titleMessage;
        protected string dateInsert;
        protected string timeInsert;
        protected string showMessage;
        protected string sendFrom;

        protected int id;






        string str_con = "Data Source=.;Initial Catalog=PerMange;Integrated Security=True";
        protected SqlConnection con = new SqlConnection();
        protected SqlCommand com = new SqlCommand();
        protected List<Input> input = new List<Input>();
        protected SqlDataReader reader;

        protected SqlDataAdapter da = new SqlDataAdapter();
        protected DataTable dt = new DataTable();
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public string MainText
        {
            set { mainText = value; }
            get { return mainText; }
        }
        public string Family
        {
            set { family = value; }
            get { return family; }
        }
        public string SendFrom
        {
            set { sendFrom = value; }
            get { return sendFrom; }
        }
        public string TitleMessage
        {
            set { titleMessage = value; }
            get { return titleMessage; }
        }
        public string DateInsert
        {
            set { dateInsert = value; }
            get { return dateInsert; }
        }
        public string TimeInsert
        {
            set { timeInsert = value; }
            get { return timeInsert; }
        }
        public string ShowMessage
        {
            set { showMessage = value; }
            get { return showMessage; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Picture
        {
            set { picture = value; }
            get { return picture; }
        }
        public string Num_Este
        {
            set { num_Este = value; }
            get { return num_Este; }
        }
        public string UseName
        {
            set { useName = value; }
            get { return useName; }
        }
        public string Password
        {
            set { password = value; }
            get { return password; }
        }

        public DataAcsess()
        {
            con.ConnectionString = str_con;
            con.Open();
        }
        protected int command( string strSql)
        {
            try
            {
                com.CommandText = strSql;
                com.Connection = con;
                com.CommandType = CommandType.StoredProcedure;
                com.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
            return 1;
        }
        protected void Operations(string strsql)
        {
            try
            {
                com.CommandText = strsql;

                com.Connection = con;
                com.CommandType = CommandType.StoredProcedure;
             
                reader = com.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        protected  DataTable selectAllOfData(string strsql)
        {
            com.Connection = con;
            com.CommandText = strsql;
            com.CommandType = CommandType.StoredProcedure;
            dt = new DataTable();
            da = new SqlDataAdapter(com);
            da.Fill(dt);
            return dt;
        }
        public List<Input> login()
        {
            string CommandText = "SELECT_LOGIN";
            //MessageBox.Show("" + Num_Este_Old);
            com.Parameters.AddWithValue("@name", Name);
          //  com.Parameters.AddWithValue("@userName", UseName);
            //com.Parameters.AddWithValue("@password ", Password);
            Operations(CommandText);
            while (reader.Read())
            {
                Input inpu = new Input();
                inpu.num_Este = reader["useName"].ToString();
                inpu.number_hokm = reader["password"].ToString();
                inpu.name = reader["esm"].ToString();
                inpu.family = reader["family"].ToString();
                inpu.pic = reader["pic"].ToString();

                input.Add(inpu);
            }
            reader.Close();
            return input;
        }
        public int updatePic()
        {
            string CommandText = "UPDATE_PIC";
            com.Parameters.AddWithValue("@name", Name);
            com.Parameters.AddWithValue("@pic", Picture);
            return command(CommandText);
        }
        public int insertMessage()
        {
            int a = 4;
            if (Name.Trim() == "مسئول ثبت")
            {
                a = 1;
            }
            else if (Name.Trim() == "مسئول حکم")
            {
                a = 2;
            }
            else if (Name.Trim() == "مدیر بخش")
            {
                a = 3;
            }
            //MessageBox.Show(a + "   " + MainText + "   " + TitleMessage);
            PersianCalendar pc = new PersianCalendar();

            string m = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now).ToString() + "/" + pc.GetDayOfMonth(DateTime.Now);
            string t = DateTime.Now.ToShortTimeString();
            string CommandText = "INSERT_MESSAGE";
            com.Parameters.AddWithValue("@Name", a);
            com.Parameters.AddWithValue("@mainText", MainText);
            com.Parameters.AddWithValue("@titleMessage", TitleMessage);
            com.Parameters.AddWithValue("@dateInsert", m);
            com.Parameters.AddWithValue("@timeInsert", t);
            com.Parameters.AddWithValue("@sendFrom", SendFrom);
            return command(CommandText);
        }
        public DataTable selectALLMessage()
        {
            int a = 4;
            if (Name.Trim() == "مسئول ثبت")
            {
                a = 1;
            }
            else if (Name.Trim() == "مسئول حکم")
            {
                a = 2;
            }
            else if (Name.Trim() == "مدیر بخش")
            {
                a = 3;
            }
            string CommandText = "SELECT_ALL_MESSAGE";
            com.Parameters.AddWithValue("@name", a);
            return selectAllOfData(CommandText);
        }
        public int updateShow()
        {
            int a = 4;
            if (Name.Trim() == "مسئول ثبت")
            {
                a = 1;
            }
            else if (Name.Trim() == "مسئول حکم")
            {
                a = 2;
            }
            else if (Name.Trim() == "مدیر بخش")
            {
                a = 3;
            }
           // MessageBox.Show("" + Id);
            string CommandText = "UPDATE_SHOW";
            com.Parameters.AddWithValue("@name",a);
            com.Parameters.AddWithValue("@id", Id);
            return command(CommandText);
        }
        public int selectNewMessage()
        {
            int a = 4;
            if (Name.Trim() == "مسئول ثبت")
            {
                a = 1;
            }
            else if (Name.Trim() == "مسئول حکم")
            {
                a = 2;
            }
            else if (Name.Trim() == "مدیر بخش")
            {
                a = 3;
            }

            string CommandText = "SELECT_NUMBER_NEW_MESSAGE";
            com.Parameters.AddWithValue("@name", a);
            Operations(CommandText);
            int t = 0;
            while (reader.Read())
            {
                t= Convert.ToInt16(reader.GetValue(0));
            }
            return t;
        }
        public int deleteMessage()
        {
            int a = 4;
            if (Name.Trim() == "مسئول ثبت")
            {
                a = 1;
            }
            else if (Name.Trim() == "مسئول حکم")
            {
                a = 2;
            }
            else if (Name.Trim() == "مدیر بخش")
            {
                a = 3;
            }

            string CommandText = "DELETE_MESSAGE";
            com.Parameters.AddWithValue("@name", a);
            com.Parameters.AddWithValue("@id", Id);
            return command(CommandText);
        }
        public int updateUsers()
        {
            string CommandText = "UPDATE_USERS";
            com.Parameters.AddWithValue("@name", Name);
            com.Parameters.AddWithValue("@family", Family);
            com.Parameters.AddWithValue("@userName", UseName);
            com.Parameters.AddWithValue("@passWord", Password);
            com.Parameters.AddWithValue("@num_Este", Num_Este);
            return command(CommandText);
        }
    }
}

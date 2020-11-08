using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personnelMangement.clas
{
    class WhereIs :DataAcsess
    {
        private int Id;
        public int setId
        {
            set { Id=value;}
            get { return Id; }
        }

        public List<Input> selectRecordOstan()
        {
            string CommandText ="GET_ALL_OSTAN";
            Operations(CommandText);
            while (reader.Read())
            {
                Input inpu = new Input();
                inpu.Id = Convert.ToInt16(reader.GetValue(0));
                inpu.nameOstan= reader.GetString(1);
                input.Add(inpu);
            }
            reader.Close();
            return input;
        }
        public List<Input> selectRecordSharstan()
        {
            
            string CommandText = "SELECT_SHARSTAN";
            com.Parameters.AddWithValue("@PK_OSTAN", setId);
            Operations(CommandText);
            while (reader.Read())
            {
                Input inpu = new Input();
                inpu.sharstan = reader.GetString(0);
                input.Add(inpu);
            }
            reader.Close();
            return input;
        }
    }
}

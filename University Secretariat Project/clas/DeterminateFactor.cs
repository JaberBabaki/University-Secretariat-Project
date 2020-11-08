using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personnelMangement.clas
{
    class DeterminateFactor:DataAcsess
    {
        private string degree;

        private string costBase;
        private string partical;
        private string absorption;
        private string mangment;
        private string helop;
        private string special;
        private string heat;




        public string CostBase
        {
            set { costBase = value; }
            get { return costBase; }
        }
        public string Partical
        {
            set { partical = value; }
            get { return partical; }
        }
        public string Absorption
        {
            set { absorption = value; }
            get { return absorption; }
        }
        public string Mangment
        {
            set { mangment = value; }
            get { return mangment; }
        }
        public string Helop
        {
            set { helop = value; }
            get { return helop; }
        }
        public string Special
        {
            set { special = value; }
            get { return special; }
        }
        public string Heat
        {
            set { heat = value; }
            get { return heat; }
        }
        public string Degree
        {
            set { degree = value; }
            get { return degree; }
        }
        public List<Input> getAllZareb()
        {
            string CommandText = "SELECT_DEGREE";
           // MessageBox.Show(Degree);
            com.Parameters.AddWithValue("@name", Degree);
            Operations(CommandText);
            while (reader.Read())
            {
                Input inpu = new Input();
                inpu.name = reader["name"].ToString();
                inpu.costBase = (float)(double)reader["costBase"];
                inpu.partical = (float)(double)reader["partical"];
                //MessageBox.Show("   " + (float)(double)reader["partical"] + "       " + (float)(double)reader["costBase"]);
                inpu.absorption = (float)(double)reader["absorption"];
                inpu.mangment = (float)(double)reader["mangment"];
                inpu.helop = (float)(double)reader["helop"];
                inpu.helpChild = (float)(double)reader["helpChild"];
                inpu.special = (float)(double)reader["special"];
                inpu.heat = (float)(double)reader["heat"];
                input.Add(inpu);               
            }
            reader.Close();
            return input;
        }
        public int updateAllZareb()
        {
            //MessageBox.Show(Degree+"  " + Convert.ToSingle(CostBase) + "    " + Convert.ToSingle(Partical) + "   " + Convert.ToSingle(Absorption) + "    " + Convert.ToSingle(Mangment) + "    " + Convert.ToSingle(Special) + "     " +Convert. ToSingle(Heat));
            string CommandText = "UPDATE_DEGREE";
            com.Parameters.AddWithValue("@name", Degree);


            com.Parameters.AddWithValue("@costBase",Math.Round(Convert.ToSingle( CostBase),2));
            com.Parameters.AddWithValue("@partical", Math.Round(Convert.ToSingle(Partical), 2));
            com.Parameters.AddWithValue("@absorption",Math.Round(Convert.ToSingle( Absorption),2));
            com.Parameters.AddWithValue("@mangment",Math.Round(Convert.ToSingle( Mangment),2));
            com.Parameters.AddWithValue("@special",Math.Round(Convert.ToSingle( Special),2));
            com.Parameters.AddWithValue("@heat",Math.Round(Convert.ToSingle( Heat),2));
            return command(CommandText);

        }
        public int incFromalBase()
        {
            string CommandText = "INC_FORMAL";
             return command(CommandText);   
        }
        public int incContractBase()
        {
            string CommandText = "INC_CONTRACT";
            return command(CommandText);
        }
    }
}

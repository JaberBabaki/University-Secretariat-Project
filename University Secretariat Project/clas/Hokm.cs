using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personnelMangement.clas
{
    class Hokm:DataAcsess
    {
        private string var_per;
      //  private string nume_Este;
        private string number_Hokm;
        private string date_run;
        private string date_sodor;
        private string num2str;
        private string tozehat;
        private string cost_base;
        private string partical;
        private string absorption;
        private string mangment;
        private string helop;
        private string helpChild;
        private string special;
        private string heat;
        private string add_all;
        private string job;
        private string super;
        private string expert;
        private string technic;
        private string childern;
        private string house;
        private string diff;
        private string turn;
        private string old_number_hokm;
        private string degree;
        private string bse;

        public string Degree
        {
            set { degree = value; }
            get { return degree; }
        }
        public string Bse
        {
            set { bse = value; }
            get { return bse; }
        }
        public string Var_per
        {
            set { var_per = value; }
            get { return var_per; }
        }
        public string Old_number_hokm
        {
            set { old_number_hokm = value; }
            get { return old_number_hokm; }
        }
        public string Number_Hokm
        {
            set { number_Hokm = value; }
            get { return number_Hokm; }
        }
        public string Date_run
        {
            set { date_run = value; }
            get { return date_run; }
        }
        public string Date_sodor
        {
            set { date_sodor = value; }
            get { return date_sodor; }
        }
        public string Num2str
        {
            set { num2str = value; }
            get { return num2str; }
        }
        public string Tozehat
        {
            set { tozehat = value; }
            get { return tozehat; }
        }
        public string Cost_base
        {
            set { cost_base = value; }
            get { return cost_base; }
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
        public string HelpChild
        {
            set { helpChild = value; }
            get { return helpChild; }
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
        public string Add_all
        {
            set { add_all = value; }
            get { return add_all; }
        }
        public string Job
        {
            set { job = value; }
            get { return job; }
        }
        public string Super
        {
            set { super = value; }
            get { return super; }
        }
        public string Expert
        {
            set { expert = value; }
            get { return expert; }
        }
        public string Technic
        {
            set { technic = value; }
            get { return technic; }
        }
        public string Childern
        {
            set { childern = value; }
            get { return childern; }
        }
        public string House
        {
            set { house = value; }
            get { return house; }
        }
        public string Diff
        {
            set { diff = value; }
            get { return diff; }
        }
        public string Turn
        {
            set { turn = value; }
            get { return turn; }
        }
        public int insertHokm()
        {

            if (Var_per == "1")
            {
                return insertHokmConFor("INSERT_RECORD_CONHOKM");
            }
            else if( Var_per == "2")
            {
                //MessageBox.Show("" + Var_per);
                return insertHokmConFor("INSERT_RECORD_FORHOKM");
            }
            else if (Var_per == "4")
            {
                //MessageBox.Show("" + Var_per);
                return insertHokmConFor("INSERT_RECORD_CONUALHOKM");
            }
            else
            {
                return insertHokmPesonel();
            }
        }
        public int insertHokmConFor(string str)
        {
            string CommandText = str;
            com.Parameters.AddWithValue("@num_Este", Num_Este);
            com.Parameters.AddWithValue("@var_per", Var_per);
            com.Parameters.AddWithValue("@number_Hokm", Number_Hokm);
            com.Parameters.AddWithValue("@date_run", Date_run);
            com.Parameters.AddWithValue("@date_sodor", Date_sodor);
            com.Parameters.AddWithValue("@num2str", Num2str);
            com.Parameters.AddWithValue("@tozehat", Tozehat);
            com.Parameters.AddWithValue("@cost_base",Convert.ToSingle( Cost_base) );
            com.Parameters.AddWithValue("@partical",Convert.ToSingle( Partical));
            com.Parameters.AddWithValue("@absorption",Convert.ToSingle( Absorption));
            com.Parameters.AddWithValue("@mangment",Convert.ToSingle( Mangment));
            com.Parameters.AddWithValue("@helop",Convert.ToSingle( Helop));
            com.Parameters.AddWithValue("@helpChild",Convert.ToSingle( HelpChild));
            com.Parameters.AddWithValue("@special",Convert.ToSingle( Special));
            com.Parameters.AddWithValue("@heat",Convert.ToSingle( Heat));
            com.Parameters.AddWithValue("@add_all", Convert.ToSingle(Add_all));
            com.Parameters.AddWithValue("@degree", Degree);
            com.Parameters.AddWithValue("@base", Convert.ToInt16(Bse));

            return command(CommandText);
        }
        public int insertHokmPesonel()
        {
            string CommandText = "INSERT_RECORD_PERHOKM";
            com.Parameters.AddWithValue("@num_Este", Num_Este);
            com.Parameters.AddWithValue("@var_per", Var_per);
            com.Parameters.AddWithValue("@number_Hokm", Number_Hokm);
            com.Parameters.AddWithValue("@date_run", Date_run);
            com.Parameters.AddWithValue("@date_sodor", Date_sodor);
            com.Parameters.AddWithValue("@num2str", Num2str);
            com.Parameters.AddWithValue("@tozehat", Tozehat);
            com.Parameters.AddWithValue("@cost_base",Convert.ToSingle( Cost_base));
            com.Parameters.AddWithValue("@job", Convert.ToSingle(Job));
            com.Parameters.AddWithValue("@manage",Convert.ToSingle( Mangment));
            com.Parameters.AddWithValue("@special", Convert.ToSingle(Special));
            com.Parameters.AddWithValue("@super", Convert.ToSingle(Super));
            com.Parameters.AddWithValue("@expert", Convert.ToSingle(Expert));
            com.Parameters.AddWithValue("@technic", Convert.ToSingle(Technic));
            com.Parameters.AddWithValue("@childern",Convert.ToSingle( Childern));
            com.Parameters.AddWithValue("@house", Convert.ToSingle(House));
            com.Parameters.AddWithValue("@diff", Convert.ToSingle(Diff));
            com.Parameters.AddWithValue("@turn", Convert.ToSingle(Turn));
            com.Parameters.AddWithValue("@add_all", Convert.ToSingle(Add_all));
            return command(CommandText);
        }
        public DataTable getAllHokm()
        {
            string CommandText = "SELECT_ALL_AHKAM";
            return selectAllOfData(CommandText);
        }
        public int deleteRecord()
        {
            string CommandText = "DELETE_RECORD_HOKM";
            com.Parameters.AddWithValue("@Number_Hokm", Number_Hokm);
            com.Parameters.AddWithValue("@Var_per", Var_per);
            return command(CommandText);
        }

        public List<Input> getRecordHokm()
        {

            string CommandText = "SELECT_RECORD_HOKM";
            com.Parameters.AddWithValue("@num_Este", Num_Este);
            com.Parameters.AddWithValue("@Var_per", Var_per);
            com.Parameters.AddWithValue("@number_Hokm", number_Hokm);
            //************MessageBox.Show("" + Num_Este + "   " + Var_per);
            Operations(CommandText);
            while (reader.Read())
            {
                Input inpu = new Input();

                    inpu.name = reader["name"].ToString();
                    inpu.family = reader["family"].ToString();
                    inpu.meli = reader["meli"].ToString();
                    inpu.date_run = reader["date_run"].ToString();
                    inpu.date_sodor = reader["date_sodor"].ToString();
                    inpu.num2str = reader["num2str"].ToString();
                    inpu.tozihat = reader["tozehat"].ToString();
                    inpu.costBase = Convert.ToSingle(reader["cost_base"].ToString());
                    inpu.add_all = Convert.ToSingle(reader["add_all"].ToString());
                    inpu.var_per = Var_per;
                    if (Var_per == "1" || Var_per == "2" || Var_per == "4")
                    {
                        inpu.partical= Convert.ToDouble( reader["partical"].ToString());
                        inpu.absorption = Convert.ToDouble(reader["absorption"].ToString());
                        inpu.mangment = Convert.ToDouble(reader["mangment"].ToString());
                        inpu.helop = Convert.ToDouble(reader["helop"].ToString());
                        inpu.helpChild = Convert.ToDouble(reader["helpChild"].ToString());
                        inpu.special = Convert.ToDouble(reader["special"].ToString());
                        inpu.heat = Convert.ToDouble(reader["heat"].ToString());
                        inpu.degree = reader["degree"].ToString();
                        inpu.Base= Convert.ToInt16(reader["base"].ToString());
                    }
                    else if (Var_per == "3")
                    {
                        inpu.degree = "";
                        inpu.Base = 0;
                        inpu.job = Convert.ToDouble(reader["job"].ToString());
                        inpu.mangment = Convert.ToDouble(reader["manage"].ToString());
                        inpu.special = Convert.ToDouble(reader["special"].ToString());
                        inpu.super = Convert.ToDouble(reader["super"].ToString());
                        inpu.expert = Convert.ToDouble(reader["expert"].ToString());
                        inpu.technic = Convert.ToDouble(reader["technic"].ToString());
                        inpu.childern = Convert.ToDouble(reader["childern"].ToString());
                        inpu.diff = Convert.ToDouble(reader["diff"].ToString());
                        inpu.house = Convert.ToDouble(reader["house"].ToString());
                        inpu.turn = Convert.ToDouble(reader["turn"].ToString());
                    }
                input.Add(inpu);
                }
            reader.Close();
            return input;
            }

        public int updateHokm()
        {
            string CommandText = "UPDATE_RECORD_HOKM";
            //MessageBox.Show("" + Num_Este_Old);
            com.Parameters.AddWithValue("@old_number_Hokm", Old_number_hokm);
            com.Parameters.AddWithValue("@number_Hokm", Number_Hokm);
            com.Parameters.AddWithValue("@date_run ", Date_run );
            com.Parameters.AddWithValue("@Date_sodor", Date_sodor);
            com.Parameters.AddWithValue("@num2str", Num2str);
            com.Parameters.AddWithValue("@tozehat", Tozehat);
            com.Parameters.AddWithValue("@cost_base",Convert.ToDouble( Cost_base));
            com.Parameters.AddWithValue("@add_all",Convert.ToDouble( Add_all));
            com.Parameters.AddWithValue("@var_per",Var_per);

            if (Var_per == "1" || Var_per == "2" || Var_per == "4")
            {
                    com.Parameters.AddWithValue("@partical",Convert.ToDouble( Partical));
                    com.Parameters.AddWithValue("@absorption",Convert.ToDouble( Absorption));
                    com.Parameters.AddWithValue("@mangment",Convert.ToDouble( Mangment));
                    com.Parameters.AddWithValue("@helop",Convert.ToDouble( Helop));
                    com.Parameters.AddWithValue("@helpChild ",Convert.ToDouble( HelpChild ));
                    com.Parameters.AddWithValue("@special",Convert.ToDouble( Heat));
                    com.Parameters.AddWithValue("@heat",Convert.ToDouble( Heat));

                    com.Parameters.AddWithValue("@job", Convert.ToDouble(0));
                    com.Parameters.AddWithValue("@super", Convert.ToDouble(0));
                    com.Parameters.AddWithValue("@expert ", Convert.ToDouble(0));
                    com.Parameters.AddWithValue("@technic", Convert.ToDouble(0));
                    com.Parameters.AddWithValue("@childern ", Convert.ToDouble(0));
                    com.Parameters.AddWithValue("@house", Convert.ToDouble(0));
                    com.Parameters.AddWithValue("@diff", Convert.ToDouble(0));
                    com.Parameters.AddWithValue("@turn", Convert.ToDouble(0));



            }          
            else if (Var_per == "3")
            {
                    com.Parameters.AddWithValue("@partical",Convert.ToDouble( 0));
                    com.Parameters.AddWithValue("@absorption",Convert.ToDouble( 0));
                    com.Parameters.AddWithValue("@helop",Convert.ToDouble( 0));
                    com.Parameters.AddWithValue("@helpChild ",Convert.ToDouble( 0));
                    com.Parameters.AddWithValue("@heat",Convert.ToDouble( 0));

                    com.Parameters.AddWithValue("@special",Convert.ToDouble( Heat));
                    com.Parameters.AddWithValue("@mangment",Convert.ToDouble( Mangment));
                    com.Parameters.AddWithValue("@job",Convert.ToDouble( Job));
                    com.Parameters.AddWithValue("@super",Convert.ToDouble( Super));
                    com.Parameters.AddWithValue("@expert ",Convert.ToDouble( Expert ));
                    com.Parameters.AddWithValue("@technic",Convert.ToDouble( Technic));
                    com.Parameters.AddWithValue("@childern ",Convert.ToDouble( Childern ));
                    com.Parameters.AddWithValue("@house",Convert.ToDouble( House));
                    com.Parameters.AddWithValue("@diff",Convert.ToDouble( Diff));
                    com.Parameters.AddWithValue("@turn",Convert.ToDouble( Turn));

            }
            return command(CommandText);
        }

    }
}

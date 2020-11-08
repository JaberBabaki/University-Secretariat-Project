using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personnelMangement.clas
{
    class Personnel:DataAcsess
    {
            private string name;
            private string family;
            private string bse;
            private int  salar;
            private string  iden;
            private string  meli;
            private string  born;
            private string  W_born;
            private string  ex_ostan;
            private string  ex_sharstan;
            private string w_Doc;
            private string     trai;
            private string  ser_ostan;
            private string ser_sharstan;
            private string organ;
            private string date_Start;
            private string date_End;
            private string situ;
            private string  degree;
            private string  marr;
            private int child;
            private string pic;
            private string  mobile;
            private int sex;
            private string date_reg;
            private string father;
            private string part;
            private string date_Este;
            private string year;
            private string var_per;
            private string num_Este_Old;
            public string Num_Este_Old
            {
                set { num_Este_Old = value; }
                get { return num_Este_Old; }
            }
            public string Base
            {
                set { bse = value; }
                get { return bse; }
            }
            public string Name
            {
                set { name = value; }
                get{return name; }
            }
            public string Family
            {
                set { family = value; }
                get { return family; }
            }

            public int Salar
            {
                set { salar = value; }
                get { return salar; }
            }
            public string Iden
            {
                set { iden = value; }
                get { return iden; }
            }
            public string Meli
            {
                set { meli = value; }
                get { return meli; }
            }
            public string Born
            {
                set { born = value; }
                get { return born; }
            }
            public string Father
            {
                set { father = value; }
                get { return father; }
            }
            public string w_born
            {
                set { W_born = value; }
                get { return W_born; }
            }
            public string Ex_ostan
            {
                set { ex_ostan = value; }
                get { return ex_ostan; }
            }
            public string Ex_sharstan
            {
                set { ex_sharstan = value; }
                get { return ex_sharstan; }
            }
            public string W_Doc
            {
                set { w_Doc = value; }
                get { return w_Doc; }
            }
            public string Trai
            {
                set { trai = value; }
                get { return trai; }
            }
            public string Ser_ostan
            {
                set { ser_ostan = value; }
                get { return ser_ostan; }
            }
            public string Ser_sharstan
            {
                set { ser_sharstan = value; }
                get { return ser_sharstan; }
            }
            public string Organ
            {
                set { organ = value; }
                get { return organ; }
            }
            public string Date_Start
            {
                set { date_Start = value; }
                get { return date_Start; }
            }
            public string Date_End
            {
                set { date_End = value; }
                get { return date_End; }
            }
            public string Situ
            {
                set { situ = value; }
                get { return situ; }
            }
            public string Degree
            {
                set { degree = value; }
                get { return degree; }
            }
            public string Marr
            {
                set { marr = value; }
                get { return marr; }
            }
            public int Child
            {
                set { child = value; }
                get { return child; }
            }
            public string Pic
            {
                set { pic = value; }
                get { return pic; }
            }
            public string Mobile
            {
                set { mobile = value; }
                get { return mobile; }
            }
            public int Sex
            {
                set { sex = value; }
                get { return sex; }
            }
            public string Date_reg
            {
                set { date_reg = value; }
                get { return date_reg; }
            }
            public string Part
            {
                set { part = value; }
                get { return part; }
            }
            public string Date_Este
            {
                set { date_Este = value; }
                get { return date_Este; }
            }
            public string Year
            {
                set { year = value; }
                get { return year; }
            }
            public string Var_per
            {
                set { var_per = value; }
                get { return var_per; }
            }
        public DataTable  getALLData(){

            string CommandText = "SELECT_ALL_TABLE";
            return selectAllOfData(CommandText);
        }
        public DataTable getALLContract()
        {

            string CommandText = "SELECT_ALL_CONTRACT";
            return selectAllOfData(CommandText);
        }
        public List<Input> selectRecorUser()
        {

            string CommandText = "SELECT_RECORD_USER";
            com.Parameters.AddWithValue("@num_Este", Num_Este);
            com.Parameters.AddWithValue("@Var_per", Var_per);
            //************MessageBox.Show("" + Num_Este + "   " + Var_per);
            Operations(CommandText);
            while (reader.Read())
            {
                Input inpu = new Input();
                if(!(Var_per == "5")){

                inpu.name = reader["name"].ToString();
                inpu.family = reader["family"].ToString();
                inpu.num_Este =reader["num_Este"].ToString();
                inpu.iden = reader["iden"].ToString();
                inpu.meli = reader["meli"].ToString();
                inpu.born = reader["born"].ToString();
                inpu.W_born = reader["W_born"].ToString();
                inpu.ex_ostan = reader["ex_ostan"].ToString();
                inpu.ex_sharstan = reader["ex_sharstan"].ToString();
                inpu.w_Doc = reader["w_Doc"].ToString();
                inpu.trai = reader["trai"].ToString();
                inpu.ser_ostan = reader["ser_ostan"].ToString();
                inpu.ser_sharstan = reader["ser_sharstan"].ToString();
                inpu.organ = reader["organ"].ToString();
                inpu.situ = reader["situ"].ToString();
                inpu.marr = reader["marr"].ToString();
                inpu.child = Convert.ToInt16(reader["child"].ToString());
                inpu.pic = reader["pic"].ToString();
                inpu.mobile = reader["mobile"].ToString();
                inpu.sex = Convert.ToInt16(reader["sex"].ToString());
                inpu.father = reader["father"].ToString();

                inpu.var_per = Var_per;
                if (Var_per == "1")
                {
                    inpu.date_Start = reader["date_Start"].ToString();
                    inpu.date_End = reader["date_End"].ToString();
                    inpu.degree = reader["degree"].ToString();
                    inpu.Base = Convert.ToInt16(reader["base"].ToString());
                    inpu.salar = Convert.ToInt16(reader["salar"].ToString());
                }
                else if (Var_per == "2")
                {
                    inpu.Base = Convert.ToInt16(reader["base"].ToString());
                    inpu.degree = reader["degree"].ToString();
                    inpu.salar = Convert.ToInt16(reader["salar"].ToString());
                }
                else if (Var_per == "3")
                {
                    inpu.part = reader["part"].ToString();
                    inpu.date_Este = reader["date_Este"].ToString();
                    inpu.year = reader["year_Es"].ToString();
                }
                else if (Var_per == "4")
                {
                   // inpu.date_Start = reader["date_Start"].ToString();
                   // inpu.date_End = reader["date_End"].ToString();
                    inpu.degree = reader["degree"].ToString();
                    inpu.Base = Convert.ToInt16(reader["base"].ToString());
                    inpu.salar = Convert.ToInt16(reader["salar"].ToString());
                }
                }else{
                    inpu.name = reader["name"].ToString();
                    inpu.family = reader["family"].ToString();
                    inpu.num_Este = reader["num_Este"].ToString();
                    inpu.meli = reader["meli"].ToString();
                    inpu.var_per = reader["var_per"].ToString();
                    if (reader["var_per"].ToString() == "3")
                    {

                        inpu.degree = "";
                        inpu.Base =0;
                    }
                    else
                    {
                        inpu.degree = reader["degree"].ToString();
                        inpu.Base = Convert.ToInt32(reader["base"].ToString());
                    }
                }



                

                input.Add(inpu);
            }
            reader.Close();
            return input;
        }
            public int  insertContract()
            {
                PersianCalendar pc = new PersianCalendar();

                string m = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now).ToString() + "/" + pc.GetDayOfMonth(DateTime.Now);

                string CommandText = "INSERT_PER_CONTRACT";
                com.Parameters.AddWithValue("@name", Name);       
                com.Parameters.AddWithValue("@family",Family);      
                com.Parameters.AddWithValue( "@num_Este",Num_Este);     
                com.Parameters.AddWithValue( "@salar", Salar);       
                com.Parameters.AddWithValue( "@iden",  Iden);       
                com.Parameters.AddWithValue( "@meli",  Meli);       
                com.Parameters.AddWithValue( "@born", Born);     
                com.Parameters.AddWithValue( "@W_born",w_born);       
                com.Parameters.AddWithValue( "@ex_ostan",Ex_ostan);     
                com.Parameters.AddWithValue( "@ex_sharstan",Ex_sharstan);  
                com.Parameters.AddWithValue( "@w_Doc", W_Doc);      
                com.Parameters.AddWithValue( "@trai",Trai);        
                com.Parameters.AddWithValue( "@ser_ostan",Ser_ostan);    
                com.Parameters.AddWithValue( "@ser_sharstan",Ser_sharstan); 
                com.Parameters.AddWithValue( "@organ",Organ);        
                com.Parameters.AddWithValue( "@date_Start",Date_Start);  
                com.Parameters.AddWithValue( "@date_End",Date_End);     
                com.Parameters.AddWithValue( "@situ",Situ);         
                com.Parameters.AddWithValue( "@degree",Degree);       
                com.Parameters.AddWithValue( "@marr",Marr);       
                com.Parameters.AddWithValue( "@child",Child);       
                com.Parameters.AddWithValue( "@pic",Pic);         
                com.Parameters.AddWithValue( "@mobile",Mobile);       
                com.Parameters.AddWithValue( "@sex", Sex);
                com.Parameters.AddWithValue("@date_reg",m);
                com.Parameters.AddWithValue("@father",Father);
                com.Parameters.AddWithValue("@base", Base);
                return command(CommandText);
            }
            public int insertContractual()
            {
                PersianCalendar pc = new PersianCalendar();

                string m = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now).ToString() + "/" + pc.GetDayOfMonth(DateTime.Now);

                string CommandText = "INSERT_PER_CONTRACTUAL";
                com.Parameters.AddWithValue("@name", Name);
                com.Parameters.AddWithValue("@family", Family);
                com.Parameters.AddWithValue("@num_Este", Num_Este);
                com.Parameters.AddWithValue("@salar", Salar);
                com.Parameters.AddWithValue("@iden", Iden);
                com.Parameters.AddWithValue("@meli", Meli);
                com.Parameters.AddWithValue("@born", Born);
                com.Parameters.AddWithValue("@W_born", w_born);
                com.Parameters.AddWithValue("@ex_ostan", Ex_ostan);
                com.Parameters.AddWithValue("@ex_sharstan", Ex_sharstan);
                com.Parameters.AddWithValue("@w_Doc", W_Doc);
                com.Parameters.AddWithValue("@trai", Trai);
                com.Parameters.AddWithValue("@ser_ostan", Ser_ostan);
                com.Parameters.AddWithValue("@ser_sharstan", Ser_sharstan);
                com.Parameters.AddWithValue("@organ", Organ);
               // com.Parameters.AddWithValue("@date_Start", Date_Start);
               // com.Parameters.AddWithValue("@date_End", Date_End);
                com.Parameters.AddWithValue("@situ", Situ);
                com.Parameters.AddWithValue("@degree", Degree);
                com.Parameters.AddWithValue("@marr", Marr);
                com.Parameters.AddWithValue("@child", Child);
                com.Parameters.AddWithValue("@pic", Pic);
                com.Parameters.AddWithValue("@mobile", Mobile);
                com.Parameters.AddWithValue("@sex", Sex);
                com.Parameters.AddWithValue("@date_reg", m);
                com.Parameters.AddWithValue("@father", Father);
                com.Parameters.AddWithValue("@base", Base);
                return command(CommandText);
            }
            public int insertFormal()
            {
                PersianCalendar pc = new PersianCalendar();

                string m = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now).ToString() + "/" + pc.GetDayOfMonth(DateTime.Now);
                string CommandText = "INSERT_PER_FORMAL";
                com.Parameters.AddWithValue("@name", Name);
                com.Parameters.AddWithValue("@family", Family);
                com.Parameters.AddWithValue("@num_Este", Num_Este);
                com.Parameters.AddWithValue("@salar", Salar);
                com.Parameters.AddWithValue("@iden", Iden);
                com.Parameters.AddWithValue("@meli", Meli);
                com.Parameters.AddWithValue("@born", Born);
                com.Parameters.AddWithValue("@W_born", w_born);
                com.Parameters.AddWithValue("@ex_ostan", Ex_ostan);
                com.Parameters.AddWithValue("@ex_sharstan", Ex_sharstan);
                com.Parameters.AddWithValue("@w_Doc", W_Doc);
                com.Parameters.AddWithValue("@trai", Trai);
                com.Parameters.AddWithValue("@ser_ostan", Ser_ostan);
                com.Parameters.AddWithValue("@ser_sharstan", Ser_sharstan);
                com.Parameters.AddWithValue("@organ", Organ);
                com.Parameters.AddWithValue("@situ", Situ);
                com.Parameters.AddWithValue("@degree", Degree);
                com.Parameters.AddWithValue("@marr", Marr);
                com.Parameters.AddWithValue("@child", Child);
                com.Parameters.AddWithValue("@pic", Pic);
                com.Parameters.AddWithValue("@mobile", Mobile);
                com.Parameters.AddWithValue("@sex", Sex);
                com.Parameters.AddWithValue("@date_reg",m);
                com.Parameters.AddWithValue("@father", Father);
                com.Parameters.AddWithValue("@base", Base);
                return command(CommandText);
            }
            public int insertPersonel()
            {
                PersianCalendar pc = new PersianCalendar();

                string m = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now).ToString() + "/" + pc.GetDayOfMonth(DateTime.Now);
                string CommandText = "INSERT_PER_PERSONEL";
                com.Parameters.AddWithValue("@name", Name);
                com.Parameters.AddWithValue("@family", Family);
                com.Parameters.AddWithValue("@num_Este", Num_Este);
                com.Parameters.AddWithValue("@iden", Iden);
                com.Parameters.AddWithValue("@meli", Meli);
                com.Parameters.AddWithValue("@born", Born);
                com.Parameters.AddWithValue("@W_born", w_born);
                com.Parameters.AddWithValue("@ex_ostan", Ex_ostan);
                com.Parameters.AddWithValue("@ex_sharstan", Ex_sharstan);
                com.Parameters.AddWithValue("@w_Doc", W_Doc);
                com.Parameters.AddWithValue("@trai", Trai);
                com.Parameters.AddWithValue("@ser_ostan", Ser_ostan);
                com.Parameters.AddWithValue("@ser_sharstan", Ser_sharstan);
                com.Parameters.AddWithValue("@organ", Organ);
                com.Parameters.AddWithValue("@situ", Situ);
                com.Parameters.AddWithValue("@marr", Marr);
                com.Parameters.AddWithValue("@child", Child);
                com.Parameters.AddWithValue("@pic", Pic);
                com.Parameters.AddWithValue("@mobile", Mobile);
                com.Parameters.AddWithValue("@sex", Sex);
                com.Parameters.AddWithValue("@date_reg",m);
                com.Parameters.AddWithValue("@father", Father);
                com.Parameters.AddWithValue("@part", Part);
                com.Parameters.AddWithValue("@year_Es", Year);
                com.Parameters.AddWithValue("@date_Este", Date_Este);
                return command(CommandText);
            }
        public int updateRecordUser(){
            string CommandText = "UPDATE_RECORD_USER";
           // MessageBox.Show("" + Num_Este_Old + "  " + Var_per);
            com.Parameters.AddWithValue("@num_Este_Old",Num_Este_Old);
            com.Parameters.AddWithValue("@var_per", Var_per);
            com.Parameters.AddWithValue("@name", Name);
            com.Parameters.AddWithValue("@family", Family);
            com.Parameters.AddWithValue("@num_Este", Num_Este);

            com.Parameters.AddWithValue("@iden", Iden);
            com.Parameters.AddWithValue("@meli", Meli);
            com.Parameters.AddWithValue("@born", Born);
            com.Parameters.AddWithValue("@W_born", w_born);
            com.Parameters.AddWithValue("@ex_ostan", Ex_ostan);
            com.Parameters.AddWithValue("@ex_sharstan", Ex_sharstan);
            com.Parameters.AddWithValue("@w_Doc", W_Doc);
            com.Parameters.AddWithValue("@trai", Trai);
            com.Parameters.AddWithValue("@ser_ostan", Ser_ostan);
            com.Parameters.AddWithValue("@ser_sharstan", Ser_sharstan);
            com.Parameters.AddWithValue("@organ", Organ);

            com.Parameters.AddWithValue("@situ", Situ);

            com.Parameters.AddWithValue("@marr", Marr);
            com.Parameters.AddWithValue("@child", Child);
            com.Parameters.AddWithValue("@pic", Pic);
            com.Parameters.AddWithValue("@mobile", Mobile);
            com.Parameters.AddWithValue("@sex", Sex);
            com.Parameters.AddWithValue("@father", Father);

            if (Var_per == "1")
            {
                com.Parameters.AddWithValue("@degree", Degree);
                com.Parameters.AddWithValue("@date_Start", Date_Start);
                com.Parameters.AddWithValue("@date_End", Date_End);
                com.Parameters.AddWithValue("@salar", Salar);
                com.Parameters.AddWithValue("@base", Base);

                com.Parameters.AddWithValue("@part", "");
                com.Parameters.AddWithValue("@date_Este", "");
                com.Parameters.AddWithValue("@year_Es", "");

            }else if (Var_per == "2")
            {
                com.Parameters.AddWithValue("@degree", Degree);
                com.Parameters.AddWithValue("@date_Start", "");
                com.Parameters.AddWithValue("@date_End", "");
                com.Parameters.AddWithValue("@salar", Salar);
                com.Parameters.AddWithValue("@base", Base);

                com.Parameters.AddWithValue("@part", "");
                com.Parameters.AddWithValue("@date_Este", "");
                com.Parameters.AddWithValue("@year_Es", "");
            }
            else if (Var_per == "3")
            {
                com.Parameters.AddWithValue("@degree", "");
                com.Parameters.AddWithValue("@date_Start", "");
                com.Parameters.AddWithValue("@date_End", "");
                com.Parameters.AddWithValue("@salar", "");
                com.Parameters.AddWithValue("@base","");

                com.Parameters.AddWithValue("@part", Part);
                com.Parameters.AddWithValue("@date_Este", Date_Este);
                com.Parameters.AddWithValue("@year_Es", Year);
            }else if (Var_per == "4")
            {
                com.Parameters.AddWithValue("@degree", Degree);
                com.Parameters.AddWithValue("@date_Start","");
                com.Parameters.AddWithValue("@date_End", "");
                com.Parameters.AddWithValue("@salar", Salar);
                com.Parameters.AddWithValue("@base", Base);

                com.Parameters.AddWithValue("@part", "");
                com.Parameters.AddWithValue("@date_Este", "");
                com.Parameters.AddWithValue("@year_Es", "");

            }
            return command(CommandText);

        }
        public int deleteRecord(){

            string CommandText = "DELETE_RECORD_USER";
            com.Parameters.AddWithValue("@num_Este", Num_Este_Old);
            com.Parameters.AddWithValue("@Var_per", Var_per);
            return command(CommandText);
        }
    }
}

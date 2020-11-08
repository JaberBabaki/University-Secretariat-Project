using JntNum2Text;
using personnelMangement.clas;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personnelMangement
{
            
    public partial class RegisterHokm : Form
    {
        private int auto;
        private string var_per;
        private string num_Este;
        private string num_Hokm;

        StiReport report = new StiReport();
        List<Input> recordFromHokm = new List<Input>();
        List<Input> recordFromUser = new List<Input>();

        public int Auto
        {
            set { auto = value; }
            get { return auto; }
        }
        public string Var_per
        {
            set { var_per = value; }
            get { return var_per; }
        }
        public string Num_Este
        {
            set { num_Este = value; }
            get { return num_Este; }
        }
        public string Num_Hokm
        {
            set { num_Hokm = value; }
            get { return num_Hokm; }
        }
        public RegisterHokm()
        {
            InitializeComponent();
        }

        private void elGroupBox5_Click(object sender, EventArgs e)
        {

        }

        private void elEntryBox5_Click(object sender, EventArgs e)
        {

        }

        private void elEntryBox6_Click(object sender, EventArgs e)
        {

        }

        private void elDivider1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (Auto == 1)
            {
                txt_numEste.Text = Num_Este;
                Cmb_var_per.SelectedIndex = (Convert.ToInt16(Var_per)-1);
                btn_search_Click(sender, e);
            }
            else if (Auto == 2)
            {
                Hokm hokm = new Hokm();
                hokm.Num_Este = Num_Este;
                hokm.Var_per = Var_per;
                hokm.Number_Hokm = Num_Hokm;                
                recordFromHokm=hokm.getRecordHokm();
                if(recordFromHokm.Count>0){
                txt_numEste.Text = Num_Este;
                Cmb_var_per.SelectedIndex = (Convert.ToInt16(Var_per) - 1);
                btn_search.Enabled = false;
                txt_numEste.Enabled = false;
                Cmb_var_per.Enabled = false;
                txt_dateSodor.Enabled = true;
                txt_run.Enabled = true;
                txt_numberHokm.Enabled = true;
                txt_Con_Str.Enabled = true;
                txt_AddAll.Enabled = true;
                elButton1.Text = "ثبت ویرایش";
                txt_run.Text = recordFromHokm[0].date_run;
                txt_dateSodor.Text = recordFromHokm[0].date_sodor;
                txt_numberHokm.Text = Num_Hokm;
                txt_Con_Str.Text = recordFromHokm[0].num2str;
                txt_Tozeh.Text = recordFromHokm[0].tozihat;
                elab_meli.Text = recordFromHokm[0].meli;
                elab_degree.Text = recordFromHokm[0].degree;
                if (recordFromHokm[0].Base == 0)
                {
                    elab_base.Text = "";
                }
                else
                {
                    elab_base.Text = recordFromHokm[0].Base.ToString();
                }
                elab_var.Text = Cmb_var_per.SelectedValue.ToString();
                elab_name.Text = recordFromHokm[0].name + " " + recordFromHokm[0].family;
                txt_AddAll.Text = recordFromHokm[0].add_all.ToString();
                txt_base.Text = recordFromHokm[0].costBase.ToString();
              //  MessageBox.Show(""+recordFromHokm[0].partical.ToString());
                if (Var_per == "1" || Var_per == "2" || Var_per == "4")
                {
                   // MessageBox.Show(recordFromHokm[0].partical.ToString() + "   " + recordFromHokm[0].partical);
                    txt_parti.Text = recordFromHokm[0].partical.ToString();
                    txt_abso.Text = recordFromHokm[0].absorption.ToString();
                    txt_mange.Text = recordFromHokm[0].mangment.ToString();
                    txt_help.Text = recordFromHokm[0].helop.ToString();
                    txt_costChild.Text = recordFromHokm[0].helpChild.ToString();
                    txt_speci.Text = recordFromHokm[0].special.ToString();
                    txt_heat.Text = recordFromHokm[0].heat.ToString();
                }
                else
                {
                    txt_parti.Text = recordFromHokm[0].job.ToString();
                    txt_abso.Text = recordFromHokm[0].mangment.ToString();
                    txt_mange.Text = recordFromHokm[0].special.ToString();
                    txt_help.Text = recordFromHokm[0].super.ToString();
                    txt_costChild.Text = recordFromHokm[0].expert.ToString();
                    txt_speci.Text = recordFromHokm[0].technic.ToString();
                    txt_heat.Text = recordFromHokm[0].childern.ToString();
                    txt_Cost.Text = recordFromHokm[0].house.ToString();
                    txt_Diff.Text = recordFromHokm[0].diff.ToString();
                    txt_Turn.Text = recordFromHokm[0].turn.ToString();

                }

                }
            }
            else
            {
                foreach (Control c in contin_main.Controls)
                {
                    if (!c.Name.Equals(Cmb_var_per.Name) && (!c.Name.Equals(txt_numEste.Name)) && !(c.Name.Equals(btn_search.Name)))
                    {
                        c.Enabled = false;
                    }

                }
                Cmb_var_per.SelectedIndex = 4;

                txt_Cost.Text = "0";
                txt_Diff.Text = "0";
                txt_Turn.Text = "0";

                txt_parti.Text = "0";
                txt_abso.Text = "0";
                txt_mange.Text = "0";
                txt_help.Text = "0";
                txt_costChild.Text = "0";
                txt_speci.Text = "0";
                txt_heat.Text = "0";
                txt_base.Text = "0";
            }

            
        }

        private void elButton1_Click(object sender, EventArgs e)
        {
            if (txt_numberHokm.Text != "")
            {
                Hokm hokm = new Hokm();
                hokm.Date_run = txt_run.Text;
                hokm.Date_sodor = txt_dateSodor.Text;
                hokm.Number_Hokm = txt_numberHokm.Text;
                hokm.Num2str = txt_Con_Str.Text;
                hokm.Tozehat = txt_Tozeh.Text;
                hokm.Var_per = "" + (Cmb_var_per.SelectedIndex + 1);
                hokm.Num_Este = txt_numEste.Text;
                hokm.Add_all = txt_AddAll.Text;
                hokm.Cost_base = txt_base.Text;
                if (Cmb_var_per.SelectedIndex == 0 || Cmb_var_per.SelectedIndex == 3)
                {

                    hokm.Partical = txt_parti.Text;
                    hokm.Absorption = txt_abso.Text;
                    hokm.Mangment = txt_mange.Text;
                    hokm.Helop = txt_help.Text;
                    hokm.HelpChild = txt_costChild.Text;
                    hokm.Special = txt_speci.Text;
                    hokm.Heat = txt_heat.Text;
                    hokm.Degree = elab_degree.Text;
                    hokm.Bse = elab_base.Text;
                }
                else if (Cmb_var_per.SelectedIndex == 1)
                {
                    hokm.Partical = txt_parti.Text;
                    hokm.Absorption = txt_abso.Text;
                    hokm.Mangment = txt_mange.Text;
                    hokm.Helop = txt_help.Text;
                    hokm.HelpChild = txt_costChild.Text;
                    hokm.Special = txt_speci.Text;
                    hokm.Heat = txt_heat.Text;
                    hokm.Degree = elab_degree.Text;
                    hokm.Bse = elab_base.Text;
                }
                else
                {
                    hokm.Job = txt_parti.Text;
                    hokm.Mangment = txt_abso.Text;
                    hokm.Special = txt_mange.Text;

                    hokm.Super = txt_help.Text;
                    hokm.Expert = txt_costChild.Text;
                    hokm.Technic = txt_speci.Text;
                    hokm.Childern = txt_heat.Text;
                    hokm.House = txt_Cost.Text;
                    hokm.Diff = txt_Diff.Text;
                    hokm.Turn = txt_Turn.Text;
                }
                int a = 0;
                if (auto == 2)
                {
                    hokm.Old_number_hokm = Num_Hokm;
                    a = hokm.updateHokm();
                }
                else
                {

                     a = hokm.insertHokm();
                }
                
                if (a == 1)
                {
                    //MessageBox.Show("عملیات موفقیت آمیز بود ");
                    DialogResult result1 = MessageBox.Show("عملیات موفقیت آمیز بود، آیا می خواهید حکم را پرینت بگیرید ؟ ",
                    "اخطار",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                    if (result1 == DialogResult.Yes)
                    {
                        string tb = "";
                        string tbHokm = "";
                        string Varhokm = "";
                        if (Cmb_var_per.SelectedIndex == 0)
                        {
                           tb = "SELECT A.name,A.family," +
                                 "A.salar,A.father,A.iden,A.meli," +
                                 "A.born,A.W_born,A.ex_ostan,A.ex_sharstan," +
                                 "A.w_Doc,A.trai,A.ser_ostan,A.ser_sharstan," +
                                 "A.date_Start,A.date_End,A.situ,A.marr,A.child," +
                                 "B.* FROM tb_contract A, tb_contract_hokm B WHERE " +
                                 "B.number_Hokm ='" + txt_numberHokm.Text.Trim() + "'";
                         //   tb = "tb_contract";
                            tbHokm = "tb_contract_hokm";
                            Varhokm = "Contract.mrt";
                        }
                        else if (Cmb_var_per.SelectedIndex == 1)
                        {
                            tb = "SELECT A.name,A.family," +
                                  "A.salar,A.father,A.iden,A.meli," +
                                  "A.born,A.W_born,A.ex_ostan,A.ex_sharstan," +
                                  "A.w_Doc,A.trai,A.ser_ostan,A.ser_sharstan," +
                                  "A.situ,A.marr,A.child," +
                                  "B.* FROM tb_formal A, tb_formal_hokm B WHERE " +
                                  "B.number_Hokm ='" + txt_numberHokm.Text.Trim() + "'";
                           // tb = "tb_formal";
                            tbHokm = "tb_formal_hokm";
                            Varhokm = "Formal.mrt";
                        }
                        else if (Cmb_var_per.SelectedIndex == 2)
                        {
                             tb = "SELECT A.name,A.family," +
                                   "A.salar,A.father,A.iden,A.meli," +
                                   "A.born,A.W_born,A.ex_ostan,A.ex_sharstan," +
                                   "A.w_Doc,A.trai,A.ser_ostan,A.ser_sharstan," +
                                   "A.situ,A.marr,A.child," +
                                   "B.* FROM tb_personel A, tb_hokm_personel B WHERE " +
                                   "B.number_Hokm ='" + txt_numberHokm.Text.Trim() + "'";
                            //tb = "tb_personel";
                            tbHokm = "tb_hokm_personel";
                            Varhokm = "Personel.mrt";
                        }
                        else if (Cmb_var_per.SelectedIndex == 3)
                        {
                            MessageBox.Show("kl");
                            tb  = "SELECT A.name,A.family," +
                                  "A.salar,A.father,A.iden,A.meli," +
                                  "A.born,A.W_born,A.ex_ostan,A.ex_sharstan," +
                                  "A.w_Doc,A.trai,A.ser_ostan,A.ser_sharstan," +
                                  "A.situ,A.marr,A.child," +
                                  "B.* FROM tb_contractual A, tb_contractual_hokm B WHERE " +
                                  "B.number_Hokm ='" + txt_numberHokm.Text.Trim() + "'";
                           // tb = "tb_contractual";
                            tbHokm = "tb_contractual_hokm";
                            Varhokm = "Contractual.mrt";
                        }

                        report.Load(Varhokm);
                        report.Compile();
                        report["var2"] = tb; 

                         //report.Render();
                         report.Show();
                    }


                }
                else
                {
                    MessageBox.Show("مشکل در عملیات ثبت ");
                }
            }
            else
            {
                MessageBox.Show("لطفا شماره حکم را وارد کنید");
            }
        }

        private void elEntryBox10_Click(object sender, EventArgs e)
        {

        }

        private void elContainer1_Click(object sender, EventArgs e)
        {

        }

        private void Cmb_var_per_SelectedIndexChanged(object sender, EventArgs e)
        {
            makeDecision(Cmb_var_per.SelectedIndex);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Personnel personel = new Personnel();
            personel.Var_per =""+ (Cmb_var_per.SelectedIndex + 1);
            personel.Num_Este = txt_numEste.Text;
            //MessageBox.Show(txt_numEste.Text.Length + "  " + (Cmb_var_per.SelectedIndex + 1));
            recordFromUser = personel.selectRecorUser();
            if (recordFromUser.Count() != 0)
            {
                btn_search.Enabled = false;
                txt_numEste.Enabled = false;
                Cmb_var_per.Enabled = false;
                elab_name.Text = "      " + recordFromUser[0].name + " " + recordFromUser[0].family;
                elab_meli.Text = "      " + recordFromUser[0].meli;
                PersianCalendar pc = new PersianCalendar();
                string mo = pc.GetMonth(DateTime.Now).ToString();
                if (mo.Length == 1)
                {
                    mo = "0" + mo;
                }
                string day = pc.GetDayOfMonth(DateTime.Now).ToString();
                if (day.Length == 1)
                {
                    day = "0" + day;
                }
                string m = pc.GetYear(DateTime.Now).ToString() + "/" + mo + "/" + day;
                txt_dateSodor.Text = m;
                if (recordFromUser[0].var_per == "1")
                {
                    elab_var.Text = "      " + "قراردادی";
                    Cmb_var_per.SelectedIndex = 0;
                    makeDecision(Convert.ToInt16(recordFromUser[0].var_per) - 1);
                }
                else if (recordFromUser[0].var_per == "2")
                {
                    //MessageBox.Show("jkj" + recordFromUser[0].var_per);
                    elab_var.Text = "      " + "رسمی قطعی";
                    Cmb_var_per.SelectedIndex = 1;
                    makeDecision(Convert.ToInt16(recordFromUser[0].var_per) - 1);
                }
                else if (recordFromUser[0].var_per == "3")
                {

                    elab_var.Text = "      " + "پرسنلی";
                    Cmb_var_per.SelectedIndex = 2;
                    makeDecision(Convert.ToInt16(recordFromUser[0].var_per) - 1);
                }
                else if (recordFromUser[0].var_per == "4")
                {

                    elab_var.Text = "      " + "پیمانی";
                    Cmb_var_per.SelectedIndex = 3;
                    makeDecision(Convert.ToInt16(recordFromUser[0].var_per) - 1);
                }
                else
                {
                    elab_var.Text = "      " + recordFromUser[0].var_per;
                }
                // MessageBox.Show("   " + recordFromUser[0].degree);
                elab_degree.Text = "      " + recordFromUser[0].degree;
                if (recordFromUser[0].Base == 0)
                {
                    elab_base.Text = "";
                }
                else
                {
                    elab_base.Text = "      " + recordFromUser[0].Base.ToString();
                }

                if (recordFromUser[0].Base != 0 && recordFromUser[0].degree != "")
                {
                    string str = recordFromUser[0].degree;
                    Calculation calculation = new Calculation(str);
                    calculation.bse = recordFromUser[0].Base.ToString();
                    txt_base.Text =Convert.ToSingle(Math.Round( calculation.selectF(),2)).ToString();
                    //MessageBox.Show("   " + calculation.calPartical());
                    txt_parti.Text = Convert.ToSingle(Math.Round( calculation.calPartical(),2)).ToString();// calculation.calPartical().ToString();
                    txt_abso.Text = Convert.ToSingle(Math.Round( calculation.calAbsorption(),2)).ToString();// calculation.calAbsorption().ToString();
                    txt_mange.Text = "0";
                    txt_help.Text = Convert.ToSingle(Math.Round( calculation.calHelpCost(),2)).ToString();// calculation.calHelpCost().ToString();
                    txt_costChild.Text = Convert.ToSingle(Math.Round( calculation.calHelpChild(),2)).ToString();// calculation.calHelpChild().ToString();
                    txt_speci.Text = Convert.ToSingle(Math.Round( calculation.calSpecial(),2)).ToString();// calculation.calSpecial().ToString();
                    txt_heat.Text = "0";



                }
                else
                {
                     MessageBox.Show(" مرتبه یا پایه ای برای این فرد ثبت نشده است");
                }

                foreach (Control c in contin_main.Controls)
                {
                    if (!c.Name.Equals(Cmb_var_per.Name) && (!c.Name.Equals(txt_numEste.Name)) && !(c.Name.Equals(btn_search.Name)))
                    {
                        c.Enabled = true;
                    }

                }
            }
            else
            {
                
                MessageBox.Show("کارمندی با شماره پرسنلی زیر وجود ندارد");
                clearDate();
            }

        }

        private void elLabel1_Click(object sender, EventArgs e)
        {

        }

        private void elLabel4_Click(object sender, EventArgs e)
        {

        }
        private void makeDecision(int a)
        {
            if (a == 0)
            {
                l9.Visible = false;
                l10.Visible = false;
                l11.Visible = false;
                txt_Cost.Visible = false;
                txt_Diff.Visible = false;
                txt_Turn.Visible = false;

                txt_parti.CaptionText = "فوق العاده مخصوص";
                txt_abso.CaptionText = "فوق العاده جذب";
                txt_mange.CaptionText = "فوق العاده مدیریت";
                txt_help.CaptionText = "کمک هزینه عائله مندی";
                txt_costChild.CaptionText = "کمک هزینه اولاد";
                txt_speci.CaptionText = "فوق العاده ویژه";
                txt_heat.CaptionText = "فوق العاده جذب هیئت امناء";
            }
            else if (a == 1)
            {
                l9.Visible = false;
                l10.Visible = false;
                l11.Visible = false;
                txt_Cost.Visible = false;
                txt_Diff.Visible = false;
                txt_Turn.Visible = false;

                txt_parti.CaptionText = "فوق العاده مخصوص";
                txt_abso.CaptionText = "فوق العاده جذب";
                txt_mange.CaptionText = "فوق العاده مدیریت";
                txt_help.CaptionText = "کمک هزینه عائله مندی";
                txt_costChild.CaptionText = "کمک هزینه اولاد";
                txt_speci.CaptionText = "فوق العاده ویژه";
                txt_heat.CaptionText = "فوق العاده جذب هیئت امناء";
            }
            else if (a == 2)
            {
                l9.Visible = true;
                l10.Visible = true;
                l11.Visible = true;
                txt_Cost.Visible = true;
                txt_Diff.Visible = true;
                txt_Turn.Visible = true;

                txt_parti.CaptionText = "فوق العاده شغل";
                txt_abso.CaptionText = "فوق العاده مدیریت";
                txt_mange.CaptionText = "فوق العاده ویژه";
                txt_help.CaptionText = "حق سرپرستی";
                txt_costChild.CaptionText = "فوق العاده کارشناسی";
                txt_speci.CaptionText = "حق فنی";
                txt_heat.CaptionText = "حق اولاد";
            }
            else if (a == 3)
            {
                l9.Visible = false;
                l10.Visible = false;
                l11.Visible = false;
                txt_Cost.Visible = false;
                txt_Diff.Visible = false;
                txt_Turn.Visible = false;

                txt_parti.CaptionText = "فوق العاده مخصوص";
                txt_abso.CaptionText = "فوق العاده جذب";
                txt_mange.CaptionText = "فوق العاده مدیریت";
                txt_help.CaptionText = "کمک هزینه عائله مندی";
                txt_costChild.CaptionText = "کمک هزینه اولاد";
                txt_speci.CaptionText = "فوق العاده ویژه";
                txt_heat.CaptionText = "فوق العاده جذب هیئت امناء";
            }
            else if (a== 4)
            {
                l9.Visible = true;
                l10.Visible = true;
                l11.Visible = true;
                txt_Cost.Visible = true;
                txt_Diff.Visible = true;
                txt_Turn.Visible = true;

                txt_parti.CaptionText = "فوق العاده مخصوص";
                txt_abso.CaptionText = "فوق العاده جذب";
                txt_mange.CaptionText = "فوق العاده مدیریت";
                txt_help.CaptionText = "کمک هزینه عائله مندی";
                txt_costChild.CaptionText = "کمک هزینه اولاد";
                txt_speci.CaptionText = "فوق العاده ویژه";
                txt_heat.CaptionText = "فوق العاده جذب هیئت امناء";
            }
        }
        private void clearDate()
        {
            btn_search.Enabled = true;
            txt_numEste.Enabled = true;
            Cmb_var_per.Enabled = true;
            Cmb_var_per.SelectedIndex = 4;
            txt_numEste.Text = "";
            elab_name.Text = "";
            elab_meli.Text = "";
            elab_var.Text = "";
            elab_degree.Text = "";
            elab_base.Text = "";
            txt_Tozeh.Text = "";
            txt_run.Text = "";
            txt_numberHokm.Text = "";
            txt_dateSodor.Text = "";
            txt_AddAll.Text = "0";
            txt_Con_Str.Text = "";
            
            txt_Cost.Text = "0";
            txt_Diff.Text = "0";
            txt_Turn.Text = "0";

            txt_parti.Text = "0";
            txt_abso.Text = "0";
            txt_mange.Text = "0";
            txt_help.Text = "0";
            txt_costChild.Text = "0";
            txt_speci.Text = "0";
            txt_heat.Text = "0";
            txt_base.Text = "0";
        }
        private void txt_base_TextChanged(object sender, EventArgs e)
        {
            try{

            
            if (txt_base.Text == "")
            {
                txt_base.Text = "0";
            }
           // MessageBox.Show("" + (Convert.ToInt64(txt_base.Text)));
          //  txt_AddAll.Text = "" + Math.Round((Convert.ToSingle(txt_base.Text) + Convert.ToSingle(txt_parti.Text)),2);
            txt_AddAll.Text = "" + Math.Round((Convert.ToSingle(txt_base.Text) + Convert.ToSingle(txt_parti.Text) + Convert.ToSingle(txt_abso.Text) + Convert.ToSingle(txt_mange.Text) + Convert.ToSingle(txt_help.Text) + Convert.ToSingle(txt_costChild.Text) + Convert.ToSingle(txt_speci.Text) + Convert.ToSingle(txt_heat.Text) + Convert.ToSingle(txt_Cost.Text) + Convert.ToSingle(txt_Diff.Text) + Convert.ToSingle(txt_Turn.Text)),2);
                   }
            catch
            {

            }
        }

        private void txt_parti_TextChanged(object sender, EventArgs e)
        {
            try
            {


                if (txt_parti.Text == "")
                {
                    txt_parti.Text = "0";
                }
                txt_AddAll.Text = "" + Math.Round((Convert.ToSingle(txt_parti.Text) + Convert.ToSingle(txt_base.Text) + Convert.ToSingle(txt_abso.Text) + Convert.ToSingle(txt_mange.Text) + Convert.ToSingle(txt_help.Text) + Convert.ToSingle(txt_costChild.Text) + Convert.ToSingle(txt_speci.Text) + Convert.ToSingle(txt_heat.Text) + Convert.ToSingle(txt_Cost.Text) + Convert.ToSingle(txt_Diff.Text) + Convert.ToSingle(txt_Turn.Text)), 2);
                //MessageBox.Show("" + txt_parti.Text);
                //txt_AddAll.Text = "" + Math.Round((Convert.ToSingle(txt_parti.Text) + Convert.ToSingle(txt_base.Text)),2);
                //  txt_AddAll.Text = "" + (Convert.ToInt64(txt_AddAll.Text) + Math.Round(Convert.ToSingle(txt_parti.Text)));
                //txt_AddAll.Text = "" + (Convert.ToSingle(txt_base.Text) + Convert.ToSingle(txt_abso.Text) + Convert.ToSingle(txt_mange.Text) + Convert.ToSingle(txt_help.Text) + Convert.ToSingle(txt_costChild.Text) + Convert.ToSingle(txt_speci.Text) + Convert.ToSingle(txt_heat.Text) + Convert.ToSingle(txt_Cost.Text) + Convert.ToSingle(txt_Diff.Text) + Convert.ToSingle(txt_Turn.Text));
            }
            catch
            {

            }
        }

        private void txt_abso_TextChanged(object sender, EventArgs e)
        {
            try
            {


                if (txt_abso.Text == "")
                {
                    txt_abso.Text = "0";
                }
                txt_AddAll.Text = "" + Math.Round((Convert.ToSingle(txt_parti.Text) + Convert.ToSingle(txt_base.Text) + Convert.ToSingle(txt_abso.Text) + Convert.ToSingle(txt_mange.Text) + Convert.ToSingle(txt_help.Text) + Convert.ToSingle(txt_costChild.Text) + Convert.ToSingle(txt_speci.Text) + Convert.ToSingle(txt_heat.Text) + Convert.ToSingle(txt_Cost.Text) + Convert.ToSingle(txt_Diff.Text) + Convert.ToSingle(txt_Turn.Text)), 2);
                // txt_AddAll.Text = "" + (Convert.ToInt64(txt_base.Text) + Convert.ToInt64(txt_parti.Text) + Convert.ToInt64(txt_mange.Text) + Convert.ToInt64(txt_help.Text) + Convert.ToInt64(txt_costChild.Text) + Convert.ToInt64(txt_speci.Text) + Convert.ToInt64(txt_heat.Text) + Convert.ToInt64(txt_Cost.Text) + Convert.ToInt64(txt_Diff.Text) + Convert.ToInt64(txt_Turn.Text));
            }
            catch
            {

            }
        }

        private void txt_mange_TextChanged(object sender, EventArgs e)
        {
            try
            {


                if (txt_mange.Text == "")
                {
                    txt_mange.Text = "0";
                }
                txt_AddAll.Text = "" + Math.Round((Convert.ToSingle(txt_parti.Text) + Convert.ToSingle(txt_base.Text) + Convert.ToSingle(txt_abso.Text) + Convert.ToSingle(txt_mange.Text) + Convert.ToSingle(txt_help.Text) + Convert.ToSingle(txt_costChild.Text) + Convert.ToSingle(txt_speci.Text) + Convert.ToSingle(txt_heat.Text) + Convert.ToSingle(txt_Cost.Text) + Convert.ToSingle(txt_Diff.Text) + Convert.ToSingle(txt_Turn.Text)), 2);
            }
            catch
            {

            }
        }


        private void txt_help_TextChanged(object sender, EventArgs e)
        {
            try
            {


                if (txt_help.Text == "")
                {
                    txt_help.Text = "0";
                }
                txt_AddAll.Text = "" + Math.Round((Convert.ToSingle(txt_parti.Text) + Convert.ToSingle(txt_base.Text) + Convert.ToSingle(txt_abso.Text) + Convert.ToSingle(txt_mange.Text) + Convert.ToSingle(txt_help.Text) + Convert.ToSingle(txt_costChild.Text) + Convert.ToSingle(txt_speci.Text) + Convert.ToSingle(txt_heat.Text) + Convert.ToSingle(txt_Cost.Text) + Convert.ToSingle(txt_Diff.Text) + Convert.ToSingle(txt_Turn.Text)), 2);
            }
            catch
            {

            }
        }

        private void txt_costChild_TextChanged(object sender, EventArgs e)
        {
            try
            {


                if (txt_costChild.Text == "")
                {
                    txt_costChild.Text = "0";
                }
                txt_AddAll.Text = "" + Math.Round((Convert.ToSingle(txt_parti.Text) + Convert.ToSingle(txt_base.Text) + Convert.ToSingle(txt_abso.Text) + Convert.ToSingle(txt_mange.Text) + Convert.ToSingle(txt_help.Text) + Convert.ToSingle(txt_costChild.Text) + Convert.ToSingle(txt_speci.Text) + Convert.ToSingle(txt_heat.Text) + Convert.ToSingle(txt_Cost.Text) + Convert.ToSingle(txt_Diff.Text) + Convert.ToSingle(txt_Turn.Text)), 2);
            }
            catch
            {

            }
        }

        private void txt_speci_TextChanged(object sender, EventArgs e)
        {
            try
            {


                if (txt_speci.Text == "")
                {
                    txt_speci.Text = "0";
                }
                txt_AddAll.Text = "" + Math.Round((Convert.ToSingle(txt_parti.Text) + Convert.ToSingle(txt_base.Text) + Convert.ToSingle(txt_abso.Text) + Convert.ToSingle(txt_mange.Text) + Convert.ToSingle(txt_help.Text) + Convert.ToSingle(txt_costChild.Text) + Convert.ToSingle(txt_speci.Text) + Convert.ToSingle(txt_heat.Text) + Convert.ToSingle(txt_Cost.Text) + Convert.ToSingle(txt_Diff.Text) + Convert.ToSingle(txt_Turn.Text)), 2);
            }
            catch
            {

            }
        }

        private void txt_Cost_TextChanged(object sender, EventArgs e)
        {
            try
            {


                if (txt_Cost.Text == "")
                {
                    txt_Cost.Text = "0";
                }
                txt_AddAll.Text = "" + Math.Round((Convert.ToSingle(txt_parti.Text) + Convert.ToSingle(txt_base.Text) + Convert.ToSingle(txt_abso.Text) + Convert.ToSingle(txt_mange.Text) + Convert.ToSingle(txt_help.Text) + Convert.ToSingle(txt_costChild.Text) + Convert.ToSingle(txt_speci.Text) + Convert.ToSingle(txt_heat.Text) + Convert.ToSingle(txt_Cost.Text) + Convert.ToSingle(txt_Diff.Text) + Convert.ToSingle(txt_Turn.Text)), 2);
            }
            catch
            {

            }
        }

        private void txt_heat_TextChanged(object sender, EventArgs e)
        {
            try
            {


                if (txt_heat.Text == "")
                {
                    txt_heat.Text = "0";
                }
                txt_AddAll.Text = "" + Math.Round((Convert.ToSingle(txt_parti.Text) + Convert.ToSingle(txt_base.Text) + Convert.ToSingle(txt_abso.Text) + Convert.ToSingle(txt_mange.Text) + Convert.ToSingle(txt_help.Text) + Convert.ToSingle(txt_costChild.Text) + Convert.ToSingle(txt_speci.Text) + Convert.ToSingle(txt_heat.Text) + Convert.ToSingle(txt_Cost.Text) + Convert.ToSingle(txt_Diff.Text) + Convert.ToSingle(txt_Turn.Text)), 2);
            }
            catch
            {

            }
        }

        private void txt_Diff_TextChanged(object sender, EventArgs e)
        {
            try
            {


                if (txt_Diff.Text == "")
                {
                    txt_Diff.Text = "0";
                }
                txt_AddAll.Text = "" + Math.Round((Convert.ToSingle(txt_parti.Text) + Convert.ToSingle(txt_base.Text) + Convert.ToSingle(txt_abso.Text) + Convert.ToSingle(txt_mange.Text) + Convert.ToSingle(txt_help.Text) + Convert.ToSingle(txt_costChild.Text) + Convert.ToSingle(txt_speci.Text) + Convert.ToSingle(txt_heat.Text) + Convert.ToSingle(txt_Cost.Text) + Convert.ToSingle(txt_Diff.Text) + Convert.ToSingle(txt_Turn.Text)), 2);
            }
            catch
            {

            }
        }

        private void txt_Turn_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_Turn.Text == "")
                {
                    txt_Turn.Text = "0";
                }
                txt_AddAll.Text = "" + Math.Round((Convert.ToSingle(txt_parti.Text) + Convert.ToSingle(txt_base.Text) + Convert.ToSingle(txt_abso.Text) + Convert.ToSingle(txt_mange.Text) + Convert.ToSingle(txt_help.Text) + Convert.ToSingle(txt_costChild.Text) + Convert.ToSingle(txt_speci.Text) + Convert.ToSingle(txt_heat.Text) + Convert.ToSingle(txt_Cost.Text) + Convert.ToSingle(txt_Diff.Text) + Convert.ToSingle(txt_Turn.Text)), 2);
            }
            catch
            {

            }
        }

        private void Form4_Validated(object sender, EventArgs e)
        {


        }

        private void txt_AddAll_Click(object sender, EventArgs e)
        {

        }

        private void txt_AddAll_TextChanged(object sender, EventArgs e)
        {
            try
            {


                if (txt_AddAll.Text == "")
                {
                    txt_AddAll.Text = "0";
                }

                txt_Con_Str.Text = Persian_Number_To_String.GET_Number_To_PersianString(txt_AddAll.Text); ///Num2Text.ToFarsi(a) + " ریـال ";
            }
            catch
            {

            }
        }

        private void elButton5_Click(object sender, EventArgs e)
        {
            clearDate();
        }

        private void txt_abso_Click(object sender, EventArgs e)
        {

        }

        private void txt_Con_Str_Click(object sender, EventArgs e)
        {

        }
    }
}

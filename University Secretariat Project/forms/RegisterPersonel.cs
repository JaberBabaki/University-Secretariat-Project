using personnelMangement.clas;
using personnelMangement.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personnelMangement
{
    
    public partial class RegisterPersonel : Form
    {
        List<Input> ostans=new List<Input>();
        List<Input> sharstan = new List<Input>();
        List<Input> recordFromUser = new List<Input>();
        private string num_Este;
        private string var_per;
        public RegisterPersonel()
        {
            InitializeComponent();
        }
        public string Num_Este
        {
            set { num_Este = value; }
            get { return num_Este; }
        }
        public string Var_per
        {
            set { var_per = value; }
            get { return var_per; }
        }
        private void elContainer2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            if (Var_per == null && Num_Este == null)
            {
                Pic.Image = Image.FromFile(G.DIRIMG);
                Pic.Tag = G.DIRIMG;

                foreach (Control c in Panel_Main.Controls)
                {
                    if (!c.Name.Equals(Cmb_var_per.Name))
                    {
                        c.Enabled = false;
                    }

                }
            }
            else
            {
                
                Personnel personel = new Personnel();
                personel.Num_Este = Num_Este;
                personel.Var_per = Var_per;
                recordFromUser=personel.selectRecorUser();
                if ("1" == recordFromUser[0].var_per)
                {
                    Cmb_var_per.SelectedIndex = 0;
                    Txt_Salar.Text =recordFromUser[0].salar.ToString();
                    Txt_Rank.Text = recordFromUser[0].degree;
                    Txt_Start.Text = recordFromUser[0].date_Start;
                    Txt_End.Text = recordFromUser[0].date_End;
                    Txt_Base.Text = recordFromUser[0].Base.ToString();
                }
                else if ("2" == recordFromUser[0].var_per)
                {
                    Cmb_var_per.SelectedIndex = 1;
                    Txt_Salar.Text = recordFromUser[0].salar.ToString();
                    Txt_Rank.Text = recordFromUser[0].degree;
                    Txt_Base.Text = recordFromUser[0].Base.ToString();
                }
                else if ("4" == recordFromUser[0].var_per)
                {
                    Cmb_var_per.SelectedIndex = 3;
                    Txt_Salar.Text = recordFromUser[0].salar.ToString();
                    Txt_Rank.Text = recordFromUser[0].degree;
                    Txt_Base.Text = recordFromUser[0].Base.ToString();
                }
                else
                {
                    Cmb_var_per.SelectedIndex = 2;
                    Txt_Part.Text = recordFromUser[0].part;
                    Txt_Year.Text = recordFromUser[0].year;
                    Txt_date.Text = recordFromUser[0].date_Este;
                }
                Txt_name.Text = recordFromUser[0].name;
                Txt_family.Text = recordFromUser[0].family;
                Txt_father.Text = recordFromUser[0].father;
                Txt_Iden.Text = recordFromUser[0].iden;
                Txt_Marr.Text = recordFromUser[0].marr;
                Txt_Meli.Text = recordFromUser[0].meli;
                Txt_Este.Text = recordFromUser[0].num_Este;
                if (recordFromUser[0].sex == 0)
                {
                    Cmb_Sex.SelectedIndex = 0;
                }
                else if (recordFromUser[0].sex == 1)
                {
                    Cmb_Sex.SelectedIndex = 1;
                }
                Txt_Born.Text = recordFromUser[0].born;
                Txt_W_Born.Text = recordFromUser[0].W_born;
                Txt_W_Doc.Text = recordFromUser[0].w_Doc;
                Txt_Trai.Text = recordFromUser[0].trai;
                Txt_Tel.Text = recordFromUser[0].mobile;
                Txt_Situ.Text = recordFromUser[0].situ;
                Txt_orga.Text = recordFromUser[0].organ;
                Pic.Image = Image.FromFile(recordFromUser[0].pic);
                Pic.Tag = recordFromUser[0].pic;
                Cmb_Ser_Ostan.Text = recordFromUser[0].ser_ostan;
                Cmb_Ser_sharstan.Text = recordFromUser[0].ser_sharstan;
                Cmb_Ex_ostan.Text = recordFromUser[0].ex_ostan;
                Cmb_Ex_sharsten.Text = recordFromUser[0].ex_sharstan;
               // MessageBox.Show("" + recordFromUser[0].ex_ostan);
                Cmb_var_per.Enabled = false;
                Btn_Save.Text = "ثبت ویرایش";
                Btn_New.Enabled = false;
            }
           WhereIs whereIs = new WhereIs();
           ostans = whereIs.selectRecordOstan();
           for (int i = 0; ostans.Count >i ;i++)
           {
               Cmb_Ser_Ostan.Items.Add(ostans[i].nameOstan);
               Cmb_Ex_ostan.Items.Add(ostans[i].nameOstan);
           }


        }

        private void elComboBox2_Click(object sender, EventArgs e)
        {

        }

        private void elEntryBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void elContainer1_Click(object sender, EventArgs e)
        {

        }

        private void elDivider1_Click(object sender, EventArgs e)
        {

        }

        private void elButton6_Click(object sender, EventArgs e)
        {
            clearEditText();

        }

        private void elComboBox8_Click(object sender, EventArgs e)
        {

        }

        private void TxtBankCode_Click(object sender, EventArgs e)
        {

        }

        private void Cmb_var_per_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_var_per.SelectedIndex==0)
            {
                foreach (Control c in Panel_Main.Controls)
                {
                        c.Enabled = true;
                }
                Txt_Part.Enabled = false;
                Txt_date.Enabled = false;
                Txt_Year.Enabled = false;
                Txt_Start.Enabled = true;
                Txt_End.Enabled = true;

                if (!(Cmb_Sex.SelectedIndex==0))
                {
                    panel_ser.Enabled = false;
                }
                if (!(Txt_Marr.SelectedIndex == 1))
                {
                    Txt_Child.Enabled = false;
                }
            }
            else if (Cmb_var_per.SelectedIndex == 1)
            {
                foreach (Control c in Panel_Main.Controls)
                {
                        c.Enabled = true;
                }
                panel_Con.Enabled = false;
                Txt_Part.Enabled = false;
                Txt_date.Enabled = false;
                Txt_Year.Enabled = false;
                if (!(Cmb_Sex.SelectedIndex == 0))
                {
                    panel_ser.Enabled = false;
                }
                if (!(Txt_Marr.SelectedIndex == 1))
                {
                    Txt_Child.Enabled = false;
                }
            }
            else if (Cmb_var_per.SelectedIndex == 2)
            {
                foreach (Control c in Panel_Main.Controls)
                {
                        c.Enabled = true;
                }
                Txt_Salar.Enabled = false;
                Txt_Rank.Enabled = false;
                Txt_Base.Enabled = false;
                panel_Con.Enabled = false;
                if (!(Cmb_Sex.SelectedIndex == 0))
                {
                    panel_ser.Enabled = false;
                }
                if (!(Txt_Marr.SelectedIndex == 1))
                {
                    Txt_Child.Enabled = false;
                }
            }else if (Cmb_var_per.SelectedIndex == 3)
            {
                foreach (Control c in Panel_Main.Controls)
                {
                    c.Enabled = true;
                }
                Txt_Part.Enabled = false;
                Txt_date.Enabled = false;
                Txt_Year.Enabled = false;
                Txt_Start.Enabled = false;
                Txt_End.Enabled = false;
                if (!(Cmb_Sex.SelectedIndex == 0))
                {
                    panel_ser.Enabled = false;
                }
                if (!(Txt_Marr.SelectedIndex == 1))
                {
                    Txt_Child.Enabled = false;
                }
            }
        }

        private void Txt_Sex_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Sex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_Sex.SelectedIndex == 0) {
                panel_ser.Enabled = true;
            }
            else
            {
                panel_ser.Enabled = false;
                Cmb_Ser_Ostan.Text="";
                Cmb_Ser_sharstan.Text="";
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Boolean check1 = false;
            Boolean check2 = false;
            Boolean check3 = false;
            Boolean check4 = false;
            Boolean check5 = false;
            Boolean check6 = false;

            Boolean c = false;
            if (Txt_name.Text == "" || Txt_family.Text == "" || Txt_Este.Text == "")
            {
                check1 = true;
            }
            if (check1 == true)
            {
                c = true;
                MessageBox.Show("پر کردن نام - نام خانوادگی - و شماره مستخدم الزامی است ");
            }
            if (check1 == false)
            {
                if ((Txt_Child.Enabled == true && Txt_Child.Text == "")||Cmb_Ex_ostan.Text == "" || Cmb_Ex_sharsten.Text == ""||Txt_Iden.Text == "" || Txt_father.Text == "" || Txt_Meli.Text == "" || Txt_Born.Text == "" || Txt_W_Born.Text == "" || Txt_Trai.Text == "" || Txt_W_Doc.Text == "" || Txt_orga.Text == "" || Txt_Situ.Text == "" || Txt_Tel.Text == "" || Cmb_Sex.Text == "" || Txt_Marr.Text == "")
                {
                    check2 = true;

                }

                if (panel_ser.Enabled == true)
                {
                    if (Cmb_Ser_Ostan.Text == "" || Cmb_Ser_sharstan.Text == "")
                    {
                        check2 = true;

                    }
                }
                if (check2==false &&Cmb_var_per.SelectedIndex == 0)
                {

                    if (Txt_Salar.Text == "" || Txt_Rank.Text == "" || Txt_Base.Text == "")
                    {
                        check3 = true;
                        
                    }
                    if( Txt_Start.Text == "" || Txt_End.Text == ""){
                        check3 = true;
                    }
                }
                else if (check2==false&&Cmb_var_per.SelectedIndex == 1)
                {
                    if (Txt_Salar.Text == "" || Txt_Rank.Text == ""||Txt_Base.Text=="")
                    {
                        check4 = true;
                    }
                }
                else if (check2 == false && Cmb_var_per.SelectedIndex == 2)
                {
                    if (Txt_Part.Text == "" || Txt_date.Text == "" || Txt_Year.Text=="")
                    {
                        check5 = true;
                    }
                }
                else if (check6 == false && Cmb_var_per.SelectedIndex == 3)
                {
                    if (Txt_Start.Text == "" || Txt_End.Text == "")
                    {
                        check5 = true;
                    }
                }

            }
            if (check2 == false && check3 == false && check4 == false && check5 == false&&c==false && check6==false)
            {
               sendParam();

            }
            else if (c == false) 
            {

               DialogResult result1 = MessageBox.Show("برخی از موارد پر نشده است عملیات ثبت را ادامه می دهید؟",
		      "اخطار",
		      MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning);
               if (result1==DialogResult.Yes)
               {                 
                   sendParam();
               }
            }


        }

        private void Cmb_Ser_Ostan_Click(object sender, EventArgs e)
        {

        }

        private void Cmb_Ser_Ostan_SelectedIndexChanged(object sender, EventArgs e)
        {
            sharstan.Clear();
            Cmb_Ser_sharstan.Items.Clear();
            WhereIs whereIs = new WhereIs();
            whereIs.setId = Cmb_Ser_Ostan.SelectedIndex+1;
            sharstan = whereIs.selectRecordSharstan();
            for (int i = 0; sharstan.Count > i; i++)
            {
                Cmb_Ser_sharstan.Items.Add(sharstan[i].sharstan);
            }
        }

        private void Cmb_Ex_sharsten_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cmb_Ex_ostan_SelectedIndexChanged(object sender, EventArgs e)
        {
            sharstan.Clear();
            Cmb_Ex_sharsten.Items.Clear();
            WhereIs whereIs = new WhereIs();
            whereIs.setId = Cmb_Ex_ostan.SelectedIndex+1 ;
            sharstan = whereIs.selectRecordSharstan();
            for (int i = 0; sharstan.Count > i; i++)
            {
                Cmb_Ex_sharsten.Items.Add(sharstan[i].sharstan);
            }
        }

        private void Btn_Selsect_Click(object sender, EventArgs e)
        {
            string filePath = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.bmp, *.jpe, *.png) | *.jpg; *.bmp; *.jpe; *.png";
            dialog.InitialDirectory = @"C:\Users\User\Pictures";
            dialog.Title = "لطفا عکس مورد نطر را انتخاب کنید";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
                Pic.Image = Image.FromFile(filePath);
                Pic.Tag = filePath;               
                //File.Copy(G.DIRPHOTO,filePath );
            }
        }

        private void Txt_Marr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Txt_Marr.SelectedIndex == 1)
            {
              Txt_Child.Enabled = true;
            }
            else
            {
                Txt_Child.Enabled = false;
                Txt_Child.Text = "";
            }
        }
        private void sendParam(){
            Personnel personnel = new Personnel();
            personnel.Name = Txt_name.Text;
            personnel.Family = Txt_family.Text;
            personnel.Num_Este = Txt_Este.Text;
            personnel.Iden = Txt_Iden.Text;
            personnel.Father = Txt_father.Text;
            personnel.Meli = Txt_Meli.Text;
            personnel.Born = Txt_Born.Text;
            personnel.w_born = Txt_W_Born.Text;
            personnel.Trai = Txt_Trai.Text;
            personnel.W_Doc = Txt_W_Doc.Text;
            personnel.Organ = Txt_orga.Text;
            personnel.Situ = Txt_Situ.Text;
            personnel.Pic = Convert.ToString(Pic.Tag);
            if (Cmb_Sex.SelectedIndex==0)
            {
                personnel.Sex = 0;//mard
            }
            else if (Cmb_Sex.SelectedIndex==1)
            {
                personnel.Sex = 1;

            }
            personnel.Marr = Txt_Marr.Text;
 
            personnel.Child = Convert.ToInt16(Convert.ToInt16(Txt_Child.Text)); 
            
            
            personnel.Mobile = Txt_Tel.Text;
            personnel.Ser_ostan = Cmb_Ser_Ostan.Text;
            personnel.Ser_sharstan = Cmb_Ser_sharstan.Text;
            personnel.Ex_ostan = Cmb_Ex_ostan.Text;
            personnel.Ex_sharstan = Cmb_Ex_sharsten.Text;
            personnel.Father = Txt_father.Text;
            if (Cmb_var_per.SelectedIndex == 0)
            {
                personnel.Degree = Txt_Rank.Text;
                personnel.Base = Txt_Base.Text;
                personnel.Salar = Convert.ToInt16(Convert.ToInt16(Txt_Salar.Text));
                
                
                personnel.Date_Start = Txt_Start.Text;
                personnel.Date_End = Txt_End.Text;
                if (Var_per == null && Num_Este == null)
                {
                    int a = personnel.insertContract();
                    if (a == 1)
                    {
                       /* MessageBox.Show(Pic.Tag.ToString());
                        Fper.AlowFolPer(G.DIRPHOTO, true);
                        File.Copy(Pic.Tag.ToString(), G.DIRPHOTO);*/
                        MessageBox.Show("عملیات ثبت با موفقیت انجام شده است ");
                        clearEditText();
                    }
                    else
                    {
                        MessageBox.Show("عملیات ثبت دچار مشکل شده");
                    }
                }
                else
                {
                    //Cmb_var_per.Enabled = false;
                    personnel.Var_per = Var_per;
                    personnel.Num_Este_Old = Num_Este;
                    int a = personnel.updateRecordUser();
                    if (a == 1)
                    {
                       /* MessageBox.Show(Pic.Tag.ToString());
                        Fper.AlowFolPer(G.DIRPHOTO, true);
                        File.Copy(Pic.Tag.ToString(),G.DIRPHOTO );*/
                        //Fper.AlowFolPer(backUpFoolder, true);
                        MessageBox.Show("عملیات ویرایش با موفقیت انجام شده است ");
                        clearEditText();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("عملیات ویرایش دچار مشکل شده");
                    }
                }
            }
            ////

            if (Cmb_var_per.SelectedIndex == 3)
            {
                personnel.Degree = Txt_Rank.Text;
                personnel.Base = Txt_Base.Text;
                personnel.Salar = Convert.ToInt16(Convert.ToInt16(Txt_Salar.Text));


                if (Var_per == null && Num_Este == null)
                {
                    int a = personnel.insertContractual();
                    if (a == 1)
                    {
                        /* MessageBox.Show(Pic.Tag.ToString());
                         Fper.AlowFolPer(G.DIRPHOTO, true);
                         File.Copy(Pic.Tag.ToString(), G.DIRPHOTO);*/
                        MessageBox.Show("عملیات ثبت با موفقیت انجام شده است ");
                        clearEditText();
                    }
                    else
                    {
                        MessageBox.Show("عملیات ثبت دچار مشکل شده");
                    }
                }
                else
                {
                    //Cmb_var_per.Enabled = false;
                    personnel.Var_per = Var_per;
                    personnel.Num_Este_Old = Num_Este;
                    int a = personnel.updateRecordUser();
                    if (a == 1)
                    {
                        /* MessageBox.Show(Pic.Tag.ToString());
                         Fper.AlowFolPer(G.DIRPHOTO, true);
                         File.Copy(Pic.Tag.ToString(),G.DIRPHOTO );*/
                        //Fper.AlowFolPer(backUpFoolder, true);
                        MessageBox.Show("عملیات ویرایش با موفقیت انجام شده است ");
                        clearEditText();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("عملیات ویرایش دچار مشکل شده");
                    }
                }
            }

            ////
            if (Cmb_var_per.SelectedIndex == 1)
            {
                personnel.Degree = Txt_Rank.Text;
                personnel.Base = Txt_Base.Text;
                personnel.Salar = Convert.ToInt16(Convert.ToInt16(Txt_Salar.Text));
                if (Var_per == null && Num_Este == null)
                {
                    int a = personnel.insertFormal();
                    if (a == 1)
                    {
                       /* MessageBox.Show(Pic.Tag.ToString());
                        Fper.AlowFolPer(G.DIRPHOTO, true);
                        File.Copy(G.DIRPHOTO,Pic.Tag.ToString() );*/
                        MessageBox.Show("عملیات ثبت با موفقیت انجام شده است ");
                        clearEditText();
                        
                    }
                    else
                    {
                        MessageBox.Show("عملیات ثبت دچار مشکل شده");
                    }
                }
                else
                {
                   // Cmb_var_per.Enabled = false;
                    personnel.Var_per = Var_per;
                    personnel.Num_Este_Old = Num_Este;
                    int a = personnel.updateRecordUser();
                    if (a == 1)
                    {
                       /* MessageBox.Show(Pic.Tag.ToString());
                        Fper.AlowFolPer(G.DIRPHOTO, true);
                        File.Copy(Pic.Tag.ToString(), G.DIRPHOTO);*/
                        MessageBox.Show("عملیات ویرایش با موفقیت انجام شده است ");
                        clearEditText();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("عملیات ویرایش دچار مشکل شده");
                    }
                }
            }
            if (Cmb_var_per.SelectedIndex == 2)
            {
                personnel.Date_Este = Txt_date.Text;
                personnel.Year = Txt_Year.Text;
                personnel.Part = Txt_Part.Text;
                if (Var_per == null && Num_Este == null)
                {
                    int a = personnel.insertPersonel();
                    if (a == 1)
                    {
                       /* MessageBox.Show(Pic.Tag.ToString());
                        Fper.AlowFolPer(G.DIRPHOTO, true);
                        File.Copy(Pic.Tag.ToString(), G.DIRPHOTO);*/
                        MessageBox.Show("عملیات ثبت با موفقیت انجام شده است ");
                        clearEditText();
                        
                    }
                    else
                    {
                        MessageBox.Show("عملیات ثبت دچار مشکل شده");
                    }
                }
                else
                {
                    //Cmb_var_per.Enabled = false;
                    personnel.Var_per = Var_per;
                    personnel.Num_Este_Old = Num_Este;
                    int a = personnel.updateRecordUser();
                    if (a == 1)
                    {
                       /* MessageBox.Show(Pic.Tag.ToString());
                        Fper.AlowFolPer(G.DIRPHOTO, true);
                        File.Copy(Pic.Tag.ToString(), G.DIRPHOTO);*/
                        MessageBox.Show("عملیات ویرایش با موفقیت انجام شده است ");
                        clearEditText();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("عملیات ویرایش دچار مشکل شده");
                    }
                }
            }
        }
        private void clearEditText()
        {
            Txt_name.Text = "";
            Txt_family.Text = "";
            Txt_Este.Text = "";
            Txt_Iden.Text = "";
            Txt_father.Text = "";
            Txt_Meli.Text = "";
            Txt_Born.Text = "";
            Txt_W_Born.Text = "";
            Txt_Trai.Text = "";
            Txt_W_Doc.Text = "";
            Txt_orga.Text = "";
            Txt_Situ.Text = "";
            Cmb_Sex.Text = "";
            Txt_Marr.Text = "";
            Txt_Child.Text = "";
            Txt_Tel.Text = "";
            Txt_Part.Text = "";
            Txt_date.Text = "";
            Txt_Rank.Text = "";
            Txt_Year.Text = "";
            Cmb_Ser_Ostan.Text = "";
            Cmb_Ser_sharstan.Text = "";
            Cmb_Ex_ostan.Text = "";
            Cmb_Ex_sharsten.Text = "";
            Txt_Start.Text = "";
            Txt_End.Text = "";
            Pic.Image = Image.FromFile(G.DIRIMG);
            Pic.Tag = G.DIRIMG;
            Txt_Salar.Text = "";
             Txt_Base.Text="";
        }
        private void Txt_End_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Marr_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Save_Click_1(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using personnelMangement.forms;
using personnelMangement.clas;



namespace personnelMangement
{
    public partial class Main : Form
    {
        private static string name;
        private string picture;
        private string esm;
        private string family;
        private string passWord;
        private string userName;




        Boolean slide = true;
        public string Picture
        {
            set { picture = value; }
            get { return picture; }
        }
        public string PassWord
        {
            set { passWord = value; }
            get { return passWord; }
        }
        public string UserName
        {
            set { userName = value; }
            get { return userName; }
        }
        public string Esm
        {
            set { esm = value; }
            get { return esm; }
        }
        public string Family
        {
            set { family = value; }
            get { return family; }
        }
        public static string Namee
        {
            set { name = value; }
            get { return name; }
        }
        public Main()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DataAcsess dataAcsess = new DataAcsess();
            dataAcsess.Name = Namee;
            int ab = dataAcsess.selectNewMessage();
            if (ab == 0)
            {
                lbl_count.Text = "";
                lbl_2count.Text = "";
            }
            else
            {
                lbl_count.Text = "" + ab;
                lbl_2count.Text = "" + ab;

            }
            
            if (Namee == "مسئول ثبت")
            {
                elContainer6.Enabled = false;
                elContainer3.Enabled = false;
            }
            else if (Namee == "مسئول حکم")
            {
                elContainer4.Enabled = false;
                elContainer3.Enabled = false;
            }
            else if (Namee == "مدیر بخش")
            {

            }
           // MessageBox.Show(Name+""+Family);
           lbl_re.Text = Namee;
           res_lbl.Text = Namee;
          // lbl_mess.Text = "";
           family_lbl.Text = Family;
           name_lbl.Text = Esm;
           if (Picture == "" || Picture == null || File.Exists(Picture) == false)
           {
               pic.Image = Image.FromFile(G.DIRIMG);
               pic.Tag = G.DIRIMG;
           }
           else
           {
               pic.Image = Image.FromFile(Picture);
               pic.Tag = Picture;
           }


        }

        private void elContainer2_Click(object sender, EventArgs e)
        {

        }

        private void elButton3_Click(object sender, EventArgs e)
        {
            RegisterPersonel frm = new RegisterPersonel();
            frm.Show();

        }

        private void elButton4_Click(object sender, EventArgs e)
        {
            ListOfPersenel frm = new ListOfPersenel();
            frm.Show();
        }

        private void elButton7_Click(object sender, EventArgs e)
        {
            RegisterHokm frm = new RegisterHokm();
            frm.Show();
        }

        private void elButton8_Click(object sender, EventArgs e)
        {
            ListOfHokm frm = new ListOfHokm();
            frm.Show();
        }

        private void elButton1_Click(object sender, EventArgs e)
        {
            Zarayeb frm8 = new Zarayeb();
            frm8.Show();
        }

        private void elButton9_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                Manger manger = new Manger();
                //Fper.AlowFolPer(fbd.SelectedPath.ToString(), true);
              // Fper.AlowFilePer(fbd.SelectedPath.ToString() + @"\perMange.bac");

                manger.Path = fbd.SelectedPath.ToString() + @"\perMangoe.bac";
                manger. backUp();
               // MessageBox.Show(fbd.SelectedPath.ToString() + @"\perMange.bac");

            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void lbl_re_Click(object sender, EventArgs e)
        {
            if (slide)
            {
                panel2.Visible = true;
                slide = false;
            }
            else
            {
                panel2.Visible = false;
                slide = true;
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (slide)
            {
                panel2.Visible = true;
                slide = false;
            }
            else
            {
                panel2.Visible = false;
                slide = true;
            }
        }

        private void pic_Click(object sender, EventArgs e)
        {
            string filePath = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.bmp, *.jpe, *.png) | *.jpg; *.bmp; *.jpe; *.png";
            dialog.InitialDirectory = @"C:\Users\User\Pictures";
            dialog.Title = "لطفا عکس مورد نطر را انتخاب کنید";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
                pic.Image = Image.FromFile(filePath);
                pic.Tag = filePath;
                DataAcsess dataAcsess = new DataAcsess();
                dataAcsess.Picture = filePath;
                dataAcsess.Name = Namee;
                dataAcsess.updatePic();
                //File.Copy(G.DIRPHOTO,filePath );
            }
        }

        private void lbl_family_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            slide = true;

        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            slide = true;
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_mes_Click(object sender, EventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            slide = true;
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            slide = true;
            ListOfMessage frm10 = new ListOfMessage();
            frm10.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            slide = true;
            ListOfMessage frm10 = new ListOfMessage();
            frm10.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            slide = true;
        }

        private void lbl_message_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            slide = true;
            ListOfMessage frm10 = new ListOfMessage();
            frm10.Show();
        }

        private void panel_message_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panrl_about_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            slide = true;
        }

        private void panel_exit_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            slide = true;
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void set_lbl_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            slide = true;
            EditRespons EditRespons = new EditRespons();
            EditRespons.Name = Esm;
            EditRespons.Response = Namee;
            EditRespons.Family = Family;
            EditRespons.UserName = UserName;
            EditRespons.PassWord = PassWord;
            EditRespons.Show();

        }

        private void panel_set_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            slide = true;
            EditRespons EditRespons = new EditRespons();
            EditRespons.Name = Esm;
            EditRespons.Response = Namee;
            EditRespons.Family = Family;
            EditRespons.UserName = UserName;
            EditRespons.PassWord = PassWord;
            EditRespons.Show();
        }

        private void icon_set_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            slide = true;
            EditRespons EditRespons = new EditRespons();
            EditRespons.Name = Esm;
            EditRespons.Response = Namee;
            EditRespons.Family = Family;
            EditRespons.UserName = UserName;
            EditRespons.PassWord = PassWord;
            EditRespons.Show();
        }

        private void elLabel2_Click(object sender, EventArgs e)
        {

        }

        private void panel_set_Click_1(object sender, EventArgs e)
        {

        }

        private void panel_set_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_exit_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
            slide = true;
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void icon_exit_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            slide = true;
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void lbl_about_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            slide = true;
        }

        private void panel_set_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

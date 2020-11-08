using personnelMangement.clas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personnelMangement.forms
{
    public partial class Login : Form
    {
        List<Input> recordUser = new List<Input>();
        int timeSec = 0;
        public Login()
        {
            InitializeComponent();
            //textBox1.ForeColor = SystemColors.GrayText;
            textBox1.Text = "نام کاربری ";
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);

            textBox2.Text = "رمز عبور";
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            int s = DateTime.Now.Second;
            timeSec = s;
           /* int m = DateTime.Now.Minute;
            lbl_min.Text = m.ToString();

            int h = DateTime.Now.Hour;
            lbl_ho.Text = h.ToString();*/
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = "نام کاربری ";
               // textBox1.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "نام کاربری ")
            {
                textBox1.Text = "";
                //textBox1.ForeColor = SystemColors.WindowText;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = "رمز عبور";
                // textBox1.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if ( textBox2.Text == "رمز عبور")
            {
                textBox2.Text = "";
                //textBox1.ForeColor = SystemColors.WindowText;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button2.Enabled = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataAcsess dataAcsess = new DataAcsess();
            dataAcsess.Name = comboBox1.Text;
            recordUser = dataAcsess.login();

            if (recordUser[0].num_Este == textBox1.Text.Trim() && recordUser[0].number_hokm == textBox2.Text.Trim())
            {
                this.Hide();
                Main frm1 = new Main();
                Main.Namee = comboBox1.Text.Trim();
                frm1.Esm = recordUser[0].name;
                frm1.Family = recordUser[0].family;
                frm1.Picture = recordUser[0].pic;
                frm1.PassWord = recordUser[0].number_hokm;
                frm1.UserName = recordUser[0].num_Este;
                frm1.Show();

            }
            else
            {
                MessageBox.Show("کلمه عبور یا رمز اشتباه می باشد");
                textBox1.Text = "";
                textBox2.Text = "";
            } 


        }

        private void Login_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_sec_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           /* lbl_sec.Enabled = !lbl_sec.Enabled;
            timeSec = timeSec+1 ;
            if (timeSec ==60)
            {
                MessageBox.Show("");
                int m = DateTime.Now.Minute;
                lbl_min.Text = m.ToString();

                int h = DateTime.Now.Hour;
                lbl_ho.Text = h.ToString();
                timeSec = 0;
            }*/
        }

        private void txt_Turn_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

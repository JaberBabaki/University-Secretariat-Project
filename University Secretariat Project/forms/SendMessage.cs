using personnelMangement.clas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personnelMangement.forms
{
    public partial class SendMessage : Form
    {
        private int auto;
        private string tilte;
        private string matn;
        private string sendBy;
        private int id;
        public int Auto
        {
            set { auto = value; }
            get { return auto; }

        }
        public int Id
        {
            set { id = value; }
            get { return id; }

        }
        public string Tilte
        {
            set { tilte = value; }
            get { return tilte; }

        }
        public string Matn
        {
            set { matn = value; }
            get { return matn; }

        }
        public string SendBy
        {
            set { sendBy = value; }
            get { return sendBy; }

        }
        public SendMessage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Auto == 1)
            {

                DataAcsess dataAcsess = new DataAcsess();
                dataAcsess.Name = Main.Namee;
                dataAcsess.Id = Id;
                dataAcsess.updateShow();
                this.Close();
            }
            else
            {
                if (comboBox1.Text != "" && textBox1.Text != "")
                {
                    DataAcsess dataAcsess = new DataAcsess();
                    dataAcsess.Name = comboBox1.Text;
                    dataAcsess.TitleMessage = textBox1.Text;
                    dataAcsess.MainText = textBox2.Text;
                    dataAcsess.SendFrom = Main.Namee;
                    int a = dataAcsess.insertMessage();
                    if (a == 1)
                    {
                        MessageBox.Show("پیام ارسال شد");
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("مشکل در ارسال پیام");
                    }
                }
                else
                {
                    MessageBox.Show("لطفا گیرنده و موضوع رو پر کنید");
                }
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            if (Auto == 1)
            {
                label1.Text = "از طرف";
                comboBox1.Text = SendBy;
                comboBox1.Enabled = false;
                textBox1.Text = Tilte;
                textBox2.Text = Matn;
                textBox2.Enabled = false;
                textBox1.Enabled = false;
                button2.Text = "بستن";

            }
            else
            {

            }
        }

        private void Form9_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (auto == 1)
            {
                DataAcsess dataAcsess = new DataAcsess();
                dataAcsess.Name = comboBox1.Text;
                dataAcsess.Id = Id;
                dataAcsess.updateShow();
            }
        }
    }
}

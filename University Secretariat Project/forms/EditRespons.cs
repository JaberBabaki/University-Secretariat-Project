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
    public partial class EditRespons : Form
    {
        private string name;
        private string family;
        private string userName;
        private string passWord;
        private string response;
        public string Name
        {
            set { name = value; }
            get { return name ; }

        }
        public string Family
        {
            set { family = value; }
            get { return family; }

        }
        public string UserName
        {
            set { userName = value; }
            get { return userName; }

        }
        public string PassWord
        {
            set { passWord = value; }
            get { return passWord; }

        }
        public string Response
        {
            set { response = value; }
            get { return response; }

        }
        public EditRespons()
        {
            InitializeComponent();
        }

        private void EditRespons_Load(object sender, EventArgs e)
        {
            txtname.Text = Name;
            txtfamily.Text = Family;
            txt_userName.Text = UserName;
            txt_pass.Text = PassWord;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DataAcsess dataAcsess = new DataAcsess();
            dataAcsess.Name=txtname.Text;
            dataAcsess.Family = txtfamily.Text;
            dataAcsess.UseName = txt_userName.Text;
            dataAcsess.Password = txt_pass.Text;
            dataAcsess.Num_Este = Response.Trim();
            int a=dataAcsess.updateUsers();
            if (a == 1)
            {
                MessageBox.Show("ویرایش با موفقیت انجام شد");
            }
            else
            {
                MessageBox.Show("ویرایش با موفقیت انجام نشد");
            }
        }
    }
}

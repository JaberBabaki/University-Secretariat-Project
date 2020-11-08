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
    public partial class ListOfMessage : Form
    {
        public ListOfMessage()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            DataAcsess dataAcsess = new DataAcsess();
            dataAcsess.Name = Main.Namee;
            DataTable dt = new DataTable();
            dt = dataAcsess.selectALLMessage();
            gridEX1.DataSource = dt;
        }

        private void elButton2_Click(object sender, EventArgs e)
        {
            SendMessage frm9 = new SendMessage();
            frm9.Show();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (gridEX1.CurrentRow != null)
            {
                SendMessage frm9 = new SendMessage();
                frm9.Auto = 1;
                frm9.Id = Convert.ToInt16(gridEX1.CurrentRow.Cells[5].Value.ToString());
                frm9.Tilte = gridEX1.CurrentRow.Cells[0].Value.ToString();
                frm9.Matn = gridEX1.CurrentRow.Cells[1].Value.ToString();
                frm9.SendBy = gridEX1.CurrentRow.Cells[4].Value.ToString();
                frm9.Show();
            }
        }

        private void Form10_Activated(object sender, EventArgs e)
        {
            DataAcsess dataAcsess = new DataAcsess();
            dataAcsess.Name = Main.Namee;
            DataTable dt = new DataTable();
            dt = dataAcsess.selectALLMessage();
            gridEX1.DataSource = dt;
        }

        private void elButton1_Click(object sender, EventArgs e)
        {
            if (gridEX1.CurrentRow != null)
            {
                DataAcsess dataAcsess = new DataAcsess();
                dataAcsess.Name = Main.Namee;
                dataAcsess.Id = Convert.ToInt16(gridEX1.CurrentRow.Cells[5].Value.ToString());
                dataAcsess.deleteMessage();
                gridEX1.CurrentRow.Delete();
            }
        }
    }
}

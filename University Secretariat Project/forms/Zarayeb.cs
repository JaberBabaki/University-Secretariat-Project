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
    public partial class Zarayeb : Form
    {
        List<Input> ListZarebDegre = new List<Input>();
        public Zarayeb()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            DeterminateFactor determinateFactor = new DeterminateFactor();
            determinateFactor.Degree = "مربی آموزشیار";
            ListZarebDegre = determinateFactor.getAllZareb();
            zareb_ma.Text =Math.Round( ListZarebDegre[0].costBase,2).ToString();
            part_ma.Text = Math.Round( ListZarebDegre[0].partical,2).ToString();
            abs_ma.Text = Math.Round( ListZarebDegre[0].absorption,2).ToString();
            manage_ma.Text = Math.Round( ListZarebDegre[0].mangment,2).ToString();
            special_ma.Text =Math.Round(  ListZarebDegre[0].special,2).ToString();
            heat_ma.Text = ListZarebDegre[0].heat.ToString();
            DeterminateFactor determinateFacto = new DeterminateFactor();
            determinateFacto.Degree = "مربی";
            ListZarebDegre = determinateFacto.getAllZareb();
            zareb_m.Text = Math.Round( ListZarebDegre[0].costBase,2).ToString();
            part_m.Text =Math.Round( ListZarebDegre[0].partical,2).ToString();
            abs_m.Text = Math.Round(ListZarebDegre[0].absorption,2).ToString();
            manage_m.Text = Math.Round(ListZarebDegre[0].mangment,2).ToString();
            special_m.Text = Math.Round(ListZarebDegre[0].special,2).ToString();
            heat_m.Text = Math.Round(ListZarebDegre[0].heat,2).ToString();
            DeterminateFactor determinateFact = new DeterminateFactor();
            determinateFact.Degree = "استادیار";
            ListZarebDegre = determinateFact.getAllZareb();
            zareb_osyar.Text = Math.Round(ListZarebDegre[0].costBase, 2).ToString();
            part_osyar.Text = Math.Round(ListZarebDegre[0].partical, 2).ToString();
            abs_osyar.Text = Math.Round(ListZarebDegre[0].absorption, 2).ToString();
            manage_osyar.Text = Math.Round(ListZarebDegre[0].mangment, 2).ToString();
            special_osyar.Text = Math.Round(ListZarebDegre[0].special, 2).ToString();
            heat_osyar.Text = Math.Round(ListZarebDegre[0].heat, 2).ToString();
            DeterminateFactor determinateFac = new DeterminateFactor();
            determinateFac.Degree = "دانشیار";
            ListZarebDegre = determinateFac.getAllZareb();
            zareb_dayar.Text = Math.Round(ListZarebDegre[0].costBase, 2).ToString();
            part_dayar.Text = Math.Round(ListZarebDegre[0].partical, 2).ToString();
            abs_dayar.Text = Math.Round(ListZarebDegre[0].absorption, 2).ToString();
            manage_dayar.Text = Math.Round(ListZarebDegre[0].mangment, 2).ToString();
            special_dayar.Text = Math.Round(ListZarebDegre[0].special, 2).ToString();
            heat_dayar.Text = Math.Round(ListZarebDegre[0].heat, 2).ToString();
            DeterminateFactor determinateFa = new DeterminateFactor();
            determinateFa.Degree = "استاد";
            ListZarebDegre = determinateFa.getAllZareb();
            zareb_ostad.Text = Math.Round(ListZarebDegre[0].costBase, 2).ToString();
            part_ostad.Text = Math.Round(ListZarebDegre[0].partical, 2).ToString();
            abs_ostad.Text = Math.Round(ListZarebDegre[0].absorption, 2).ToString();
            manage_ostad.Text = Math.Round(ListZarebDegre[0].mangment, 2).ToString();
            special_ostad.Text = Math.Round(ListZarebDegre[0].special, 2).ToString();
            heat_ostad.Text = Math.Round(ListZarebDegre[0].heat, 2).ToString();
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = false;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = true;
                }

            }
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeterminateFactor determinateFactor = new DeterminateFactor();
            determinateFactor.Degree = "مربی آموزشیار";
            determinateFactor.CostBase = zareb_ma.Text;
            determinateFactor.Partical = part_ma.Text;
            determinateFactor.Absorption = abs_ma.Text;
            determinateFactor.Mangment = manage_ma.Text;
            determinateFactor.Special = special_ma.Text;
            determinateFactor.Heat = heat_ma.Text;
            int a = determinateFactor.updateAllZareb();

            DeterminateFactor determinateFacto = new DeterminateFactor();
            determinateFacto.Degree = "مربی";
            determinateFacto.CostBase = zareb_m.Text;
            determinateFacto.Partical = part_m.Text;
            determinateFacto.Absorption = abs_m.Text;
            determinateFacto.Mangment = manage_m.Text;
            determinateFacto.Special = special_m.Text;
            determinateFacto.Heat = heat_m.Text;
            int b = determinateFacto.updateAllZareb();

            DeterminateFactor determinateFact = new DeterminateFactor();
            determinateFact.Degree = "استادیار";
            determinateFact.CostBase = zareb_osyar.Text;
            determinateFact.Partical = part_osyar.Text;
            determinateFact.Absorption = abs_osyar.Text;
            determinateFact.Mangment = manage_osyar.Text;
            determinateFact.Special = special_osyar.Text;
            determinateFact.Heat = heat_osyar.Text;
            int h = determinateFact.updateAllZareb();

            DeterminateFactor determinateFac = new DeterminateFactor();
            determinateFac.Degree = "دانشیار";
            determinateFac.CostBase = zareb_dayar.Text;
            determinateFac.Partical = part_dayar.Text;
            determinateFac.Absorption = abs_dayar.Text;
            determinateFac.Mangment = manage_dayar.Text;
            determinateFac.Special = special_dayar.Text;
            determinateFac.Heat = heat_dayar.Text;
            int d = determinateFac.updateAllZareb();

            DeterminateFactor determinateFa = new DeterminateFactor();
            determinateFa.Degree = "استاد";
            determinateFa.CostBase = zareb_ostad.Text;
            determinateFa.Partical = part_ostad.Text;
            determinateFa.Absorption = abs_ostad.Text;
            determinateFa.Mangment = manage_ostad.Text;
            determinateFa.Special = special_ostad.Text;
            determinateFa.Heat = heat_ostad.Text;
            int f= determinateFa.updateAllZareb();
            if(a==1||b==1||d==1||f==1||h==1){
                MessageBox.Show("ویرایش با موفقیت انجام شد");
            }
            else
            {
                MessageBox.Show("ویرایش با موفقیت انجام نشد");
            }
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = false;
                }

            }
            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeterminateFactor determinateFa = new DeterminateFactor();
           int A= determinateFa.incContractBase();
           int b= determinateFa.incFromalBase();
           if (A == 1 || b == 1)
           {
               MessageBox.Show("عملیات ترفیع با موفقیت انجام شد");
           }
        }
    }
}

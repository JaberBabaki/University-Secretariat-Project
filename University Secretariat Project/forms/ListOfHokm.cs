using Janus.Windows.GridEX;
using personnelMangement.clas;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personnelMangement
{
    public partial class ListOfHokm : Form
    {
        StiReport report = new StiReport();
        DataTable dt;
        Boolean ch=false;
        public ListOfHokm()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
             PersianCalendar pc = new PersianCalendar();
            ss.Text="1111/11/11";
            sr.Text = "1111/11/11";
           string m= pc.GetMonth(DateTime.Now).ToString();
           if (m.Length < 2)
           {
               m = "0" + m;
           }
            string da=pc.GetDayOfMonth(DateTime.Now).ToString();
           if (da.Length < 2)
           {
               da = "0" + da;
           }
           string date= pc.GetYear(DateTime.Now).ToString() + "/" + m + "/" + da;
           te.Text = date;
            er.Text=date;
            ch = true;
            Hokm hokm = new Hokm();
             dt = hokm.getAllHokm();
          
            DataTable dtCloned = dt.Clone();
            dtCloned.Columns[0].DataType = typeof(string);
            dtCloned.Columns[1].DataType = typeof(string);
            dtCloned.Columns[2].DataType = typeof(string);
            dtCloned.Columns[3].DataType = typeof(string);
            dtCloned.Columns[4].DataType = typeof(string);
            dtCloned.Columns[5].DataType = typeof(string);
            dtCloned.Columns[6].DataType = typeof(string);
            dtCloned.Columns[7].DataType = typeof(string);
            dtCloned.Columns[8].DataType = typeof(string);
            dtCloned.Columns[9].DataType = typeof(string);
            foreach (DataRow row in dt.Rows)
            {
                dtCloned.ImportRow(row);
            }
            gridEX1.DataSource = dtCloned;
        }
        private void filterDataGride()
        {
            string sss = ss.Text;
            string tee = te.Text;
            string srr = sr.Text;
            string err = er.Text;
            pic.Image = Image.FromFile(G.DIRIMG);
            pic.Tag = G.DIRIMG;
            try
            {
                if(ch){
                if (Cmb_var_per.Text != "")
                {
                    if (Cmb_var_per.SelectedIndex == 4)
                    {
                        (gridEX1.DataSource as DataTable).DefaultView.RowFilter = "name LIKE '%" + txtname.Text + "%' and date_run >= '" + srr + "' and date_run <= '" + err + "' and num_Este LIKE '%" + txtCode.Text + "%' and family like '%" + txtfamily.Text + "%' and number_Hokm like '%" + txtshsh.Text + "%' and date_sodor >= '" + sss + "' and date_sodor <= '" + tee + "' and add_all like '%" + txtmellicode.Text + "%'";
                    }
                    else
                    {
                        (gridEX1.DataSource as DataTable).DefaultView.RowFilter = "name LIKE '%" + txtname.Text + "%' and date_run >= '" + srr + "' and date_run <= '" + err + "' and num_Este LIKE '%" + txtCode.Text + "%' and family like '%" + txtfamily.Text + "%' and number_Hokm like '%" + txtshsh.Text + "%' and date_sodor >= '" + sss + "' and date_sodor <= '" + tee + "' and add_all like '%" + txtmellicode.Text + "%' and var_per like '%" + (Cmb_var_per.SelectedIndex + 1) + "%'";
                    }

                }
                else
                {
                    (gridEX1.DataSource as DataTable).DefaultView.RowFilter = "name LIKE '%" + txtname.Text + "%' and date_run >= '" + srr + "' and date_run <= '" + err + "' and num_Este LIKE '%" + txtCode.Text + "%' and family like '%" + txtfamily.Text + "%' and date_sodor >= '" + sss + "' and date_sodor <= '" + tee + "' and number_Hokm like '%" + txtshsh.Text + "%' and add_all like '%" + txtmellicode.Text + "%'";
                }
                }
            }
            catch (Exception e)
            {
               // MessageBox.Show("3 " + e.ToString());
            }

        }
        private void gridEX1_SelectionChanged(object sender, EventArgs e)
        {
            if (gridEX1.CurrentRow != null)
            {
                var b = gridEX1.CurrentRow.Cells[7].Value.ToString();
                if (b != "" && File.Exists(b))
                {
                    pic.Image = Image.FromFile(b);
                    pic.Tag = b;
                }
                else
                {
                    pic.Image = Image.FromFile(G.DIRIMG);
                    pic.Tag = G.DIRIMG;
                }
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            filterDataGride();
        }
        private void te_TextChanged(object sender, EventArgs e)
        {
            filterDataGride();
        }
        private void txtfamily_TextChanged(object sender, EventArgs e)
        {
            filterDataGride();
        }

        private void txtshsh_TextChanged(object sender, EventArgs e)
        {
            filterDataGride();
        }
        private void ss_TextChanged(object sender, EventArgs e)
        {
            filterDataGride();

        }
        private void sr_TextChanged(object sender, EventArgs e)
        {
            filterDataGride();

        }
        private void er_TextChanged(object sender, EventArgs e)
        {
            filterDataGride();

        }
        private void txtmellicode_TextChanged(object sender, EventArgs e)
        {
            filterDataGride();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            filterDataGride();
        }

        private void Cmb_var_per_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterDataGride();
        }

        private void elButton3_Click(object sender, EventArgs e)
        {
            if (gridEX1.CurrentRow != null)
            {
                Hokm hokm = new Hokm();
                hokm.Number_Hokm = gridEX1.CurrentRow.Cells[3].Value.ToString();
                hokm.Var_per = gridEX1.CurrentRow.Cells[8].Value.ToString();
                int a = hokm.deleteRecord();
                if (a == 1)
                {
                    gridEX1.CurrentRow.Delete();
                    MessageBox.Show("عملیات حذف با موفقیت انجام شده است ");

                }
                else
                {
                    MessageBox.Show("عملیات حذف دچار مشکل شده");
                }
            }
        }

        private void elButton2_Click(object sender, EventArgs e)
        {
            if (gridEX1.CurrentRow != null)
            {
                string number_Este = gridEX1.CurrentRow.Cells[2].Value.ToString();
                string number_hokm = gridEX1.CurrentRow.Cells[3].Value.ToString();
                string var_per = gridEX1.CurrentRow.Cells[8].Value.ToString();
                //MessageBox.Show("" + number_Este + "   " + var_per);
                RegisterHokm frm4 = new RegisterHokm();
                frm4.Var_per = var_per;
                frm4.Auto = 2;
                frm4.Num_Este = number_Este;
                frm4.Num_Hokm = number_hokm;
                frm4.Show();
            }
        }

        private void Form5_Activated(object sender, EventArgs e)
        {
            Hokm hokm = new Hokm();
            DataTable dt = hokm.getAllHokm();

            DataTable dtCloned = dt.Clone();
            dtCloned.Columns[0].DataType = typeof(string);
            dtCloned.Columns[1].DataType = typeof(string);
            dtCloned.Columns[2].DataType = typeof(string);
            dtCloned.Columns[3].DataType = typeof(string);
            dtCloned.Columns[4].DataType = typeof(string);
            dtCloned.Columns[5].DataType = typeof(string);
            dtCloned.Columns[6].DataType = typeof(string);
            dtCloned.Columns[7].DataType = typeof(string);
            dtCloned.Columns[8].DataType = typeof(string);
            dtCloned.Columns[9].DataType = typeof(string);

            foreach (DataRow row in dt.Rows)
            {
                dtCloned.ImportRow(row);
            }
            gridEX1.DataSource = dtCloned;
        }

        private void elButton4_Click(object sender, EventArgs e)
        {
            string str=gridEX1.CurrentRow.Cells[3].Value.ToString();
            string marr = gridEX1.CurrentRow.Cells[9].Value.ToString();
            string var_per = gridEX1.CurrentRow.Cells[8].Value.ToString();


            if (Cmb_var_per.SelectedIndex == 4 || Cmb_var_per.SelectedValue == null || Cmb_var_per.SelectedValue == "")
            {

               //MessageBox.Show(""+ gridEX1.RowCount);
                if (gridEX1.CurrentRow != null)
                {
                    int a1=0, a2=0, a3=0,a4=0;
                    for(int i=1;i<=gridEX1.RowCount;i++){
                        GridEXRow row = gridEX1.GetRow(i-1);
                        string var = row.Cells[8].Value.ToString();
                        if (var == "1")
                        {
                            a1++;
                        }else if(var == "2"){
                            a2++;
                        }
                        else if (var == "3")
                        {
                            a3++;
                        }
                        else if (var == "4")
                        {
                            a4++;
                        }
                        if(a1>=1 && a2>=1&& a3>=1&&a4>=1){
                            break;
                        }
                    }
                    if (a1 >= 1)
                    {
                        printContract();
                    }
                    if (a2 >= 1)
                    {
                        printFormal();
                    }
                    if (a3 >= 1)
                    {
                        printPersonel();
                    }
                    if (a4 >= 1)
                    {
                        printContractual();
                    }
                   
                }
            }

            if (Cmb_var_per.SelectedIndex == 0)
            {
                printContract();
            }
            else if (Cmb_var_per.SelectedIndex == 1)
            {
                printFormal();
            }
            else if (Cmb_var_per.SelectedIndex == 2)
            {
                printPersonel();
            }
            else if (Cmb_var_per.SelectedIndex == 3)
            {
                printContractual();
            }

        }

        private void txtname_Click(object sender, EventArgs e)
        {

        }
        private void te_Click(object sender, EventArgs e)
        {

        }
        private void ss_Click(object sender, EventArgs e)
        {

        }
        private void printContract()
        {
            string str = gridEX1.CurrentRow.Cells[3].Value.ToString();
            string marr = gridEX1.CurrentRow.Cells[9].Value.ToString();
            string var_per = gridEX1.CurrentRow.Cells[8].Value.ToString();

            string sss = ss.Text;
            string tee = te.Text;
            string srr = sr.Text;
            string err = er.Text;
            
            report.Load("Contract.mrt");
            report.Compile();
            report["var2"] = "SELECT A.name,A.family," +
                             "A.salar,A.father,A.iden,A.meli," +
                             "A.born,A.W_born,A.ex_ostan,A.ex_sharstan," +
                             "A.w_Doc,A.trai,A.ser_ostan,A.ser_sharstan," +
                             "A.date_Start,A.date_End,A.situ,A.marr,A.child," +
                             "B.* FROM tb_contract A, tb_contract_hokm B WHERE " +
                             "A.num_Este = B.num_Este and A.show=0 and B.show=0 and A.name LIKE '%" + txtname.Text + "%'" +
                             "and B.num_Este LIKE '%" + txtCode.Text + "%' and A.family like '%" + txtfamily.Text + "%'" +
                             "and B.date_run >= '" + sss + "' and B.date_run <= '" + tee + "'"+
                             "and B.date_sodor >= '" + srr + "' and B.date_sodor <= '" + err + "'"+
                             "and B.number_Hokm like '%" + txtshsh.Text + "%' and add_all like '%" + txtmellicode.Text + "%'";// and B.number_Hokm='" + str + "'";

            //report.Render();
            report.Show();
        }
        private void printContractual()
        {
            string str = gridEX1.CurrentRow.Cells[3].Value.ToString();
            string marr = gridEX1.CurrentRow.Cells[9].Value.ToString();
            string var_per = gridEX1.CurrentRow.Cells[8].Value.ToString();

            string sss = ss.Text;
            string tee = te.Text;
            string srr = sr.Text;
            string err = er.Text;

            report.Load("Contractual.mrt");
            report.Compile();
            report["var2"] = "SELECT A.name,A.family," +
                             "A.salar,A.father,A.iden,A.meli," +
                             "A.born,A.W_born,A.ex_ostan,A.ex_sharstan," +
                             "A.w_Doc,A.trai,A.ser_ostan,A.ser_sharstan," +
                             "A.organ,A.situ,A.marr,A.child," +
                             "B.* FROM tb_contractual A, tb_contractual_hokm B WHERE " +
                             "A.num_Este = B.num_Este and A.show=0 and B.show=0 and A.name LIKE '%" + txtname.Text + "%'" +
                             "and B.num_Este LIKE '%" + txtCode.Text + "%' and A.family like '%" + txtfamily.Text + "%'" +
                             "and B.date_run >= '" + sss + "' and B.date_run <= '" + tee + "'" +
                             "and B.date_sodor >= '" + srr + "' and B.date_sodor <= '" + err + "'" +
                             "and B.number_Hokm like '%" + txtshsh.Text + "%' and add_all like '%" + txtmellicode.Text + "%'";// and B.number_Hokm='" + str + "'";

            //report.Render();
            report.Show();
        }
        private void printFormal(){
            string str = gridEX1.CurrentRow.Cells[3].Value.ToString();
            string marr = gridEX1.CurrentRow.Cells[9].Value.ToString();
            string var_per = gridEX1.CurrentRow.Cells[8].Value.ToString();

            string sss = ss.Text;
            string tee = te.Text;
            string srr = sr.Text;
            string err = er.Text;

            report.Load("Formal.mrt");
            report.Compile();
            report["var2"] = "SELECT A.name,A.family," +
                             "A.salar,A.father,A.iden,A.meli," +
                             "A.born,A.W_born,A.ex_ostan,A.ex_sharstan," +
                             "A.w_Doc,A.trai,A.ser_ostan,A.ser_sharstan," +
                             "A.situ,A.marr,A.child," +
                             "B.* FROM tb_formal A, tb_formal_hokm B WHERE " +
                             "A.num_Este = B.num_Este and A.show=0 and B.show=0 and A.name LIKE '%" + txtname.Text + "%'" +
                             "and B.num_Este LIKE '%" + txtCode.Text + "%' and A.family like '%" + txtfamily.Text + "%'" +
                             "and B.date_run >= '" + sss + "' and B.date_run <= '" + tee + "'" +
                             "and B.date_sodor >= '" + srr + "' and B.date_sodor <= '" + err + "'" +
                             "and B.number_Hokm like '%" + txtshsh.Text + "%' and add_all like '%" + txtmellicode.Text + "%'";
            //report1.Render();
            report.Show();
        }
        private void printPersonel()
        {
            string str = gridEX1.CurrentRow.Cells[3].Value.ToString();
            string marr = gridEX1.CurrentRow.Cells[9].Value.ToString();
            string var_per = gridEX1.CurrentRow.Cells[8].Value.ToString();

            string sss = ss.Text;
            string tee = te.Text;
            string srr = sr.Text;
            string err = er.Text;

            report.Load("Personel.mrt");
            report.Compile();
            report["var2"] = "SELECT A.name,A.family," +
                             "A.num_Este,A.father,A.iden,A.meli," +
                             "A.born,A.W_born,A.ex_ostan,A.ex_sharstan," +
                             "A.w_Doc,A.trai,A.ser_ostan,A.ser_sharstan," +
                             "A.situ,A.marr,A.child,A.date_Este,A.year_Es,A.organ,A.part" +
                             "B.* FROM tb_personel A, tb_hokm_personel B WHERE " +
                             "A.num_Este = B.num_Este and A.show=0 and B.show=0 and A.name LIKE '%" + txtname.Text + "%'" +
                             "and B.num_Este LIKE '%" + txtCode.Text + "%' and A.family like '%" + txtfamily.Text + "%'" +
                              "and B.date_run >= '" + sss + "' and B.date_run <= '" + tee + "'" +
                             "and B.date_sodor >= '" + srr + "' and B.date_sodor <= '" + err + "'" +
                             "and B.number_Hokm like '%" + txtshsh.Text + "%' and add_all like '%" + txtmellicode.Text + "%'";
            report.Render();
            report.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
        private void btnSS_Click(object sender, EventArgs e)
        {
            
            try
            {
                string sss =  ss.Text ;
                string tee =  te.Text  ;
                (gridEX1.DataSource as DataTable).DefaultView.RowFilter = "date_sodor >= '" + sss + "' and date_sodor <= '" + tee + "'";
            }
            catch (Exception r)
            {
                MessageBox.Show("klSS"+ "   "+r.ToString());
            }

        }
        private void btnRR_Click(object sender, EventArgs e)
        {
            try
            {
                string sss =  ss.Text ;
                string tee =  te.Text ;
                (gridEX1.DataSource as DataTable).DefaultView.RowFilter = "date_run >= '" + sss + "' and date_run <= '" + tee + "'";
            }
            catch (Exception r)
            {
                MessageBox.Show("klRR" + "   " + r.ToString());
            }

        }
    }
}

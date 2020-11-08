using personnelMangement.clas;
using personnelMangement.forms;
using Stimulsoft.Report;
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

namespace personnelMangement
{
    public partial class ListOfPersenel : Form
    {
        StiReport report = new StiReport();
        public ListOfPersenel()
        {
            InitializeComponent();
        }

        private void gridEX2_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {

        }

        private void gridEX1_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {

        }

        private void txtCode_Click(object sender, EventArgs e)
        {
            (gridEX1.DataSource as DataTable).DefaultView.RowFilter = string.Format("name LIKE '%{0}%'", txtCode.Text);
        }

        private void txtshsh_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (Main.Namee == "مسئول ثبت")
            {
                btn_sodor.Enabled = false;
            }
            Cmb_var_per.SelectedValue = "همه";
            Personnel personel = new Personnel();
            DataTable dt= personel.getALLData();

            gridEX1.DataSource = dt;
        }

        private void gridEX1_Click(object sender, EventArgs e)
        {
            /*int rowindex = gridEX1.CurrentRow.RowIndex;
            MessageBox.Show(rowindex.ToString());*/
        }

        private void gridEX1_RootTableChanged(object sender, EventArgs e)
        {

        }

        private void gridEX1_RowCheckStateChanging(object sender, Janus.Windows.GridEX.RowCheckStateChangingEventArgs e)
        {
        }

        private void gridEX1_SelectionChanged(object sender, EventArgs e)
        {
           // MessageBox.Show("" + gridEX1.RowCount);
            if (gridEX1.RowCount >= 1)
            {

                    //int rowindex = gridEX1.CurrentRow.RowIndex;
                    // if(gridEX1.CurrentRow.)
                if (gridEX1.CurrentRow != null)
                {
                    var b = gridEX1.CurrentRow.Cells[8].Value.ToString();
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

        }

        private void elContainer2_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            filterDataGride();
        }

        private void gridEX1_CursorChanged(object sender, EventArgs e)
        {

        }
        private void filterDataGride()
        {
             pic.Image = Image.FromFile(G.DIRIMG);
             pic.Tag = G.DIRIMG;
            try
            {
                if (Cmb_var_per.Text != "")
                {
                    if (Cmb_var_per.SelectedIndex == 4)
                    {
                        (gridEX1.DataSource as DataTable).DefaultView.RowFilter = "name LIKE '%" + txtname.Text + "%' and num_Este LIKE '%" + txtCode.Text + "%' and family like '%" + txtfamily.Text + "%' and meli like '%" + txtshsh.Text + "%' and mobile like '%" + txtmellicode.Text + "%'"; 
                    }
                    else
                    {
                        (gridEX1.DataSource as DataTable).DefaultView.RowFilter = "name LIKE '%" + txtname.Text + "%' and num_Este LIKE '%" + txtCode.Text + "%' and family like '%" + txtfamily.Text + "%' and meli like '%" + txtshsh.Text + "%' and mobile like '%" + txtmellicode.Text + "%'and var_per like '%" + (Cmb_var_per.SelectedIndex + 1) + "%'";
                    }
                   
                }else
                {
                    //MessageBox.Show("3  " + Cmb_var_per.SelectedIndex);
                    (gridEX1.DataSource as DataTable).DefaultView.RowFilter = "name LIKE '%" + txtname.Text + "%' and num_Este LIKE '%" + txtCode.Text + "%' and family like '%" + txtfamily.Text + "%' and meli like '%" + txtshsh.Text + "%' and mobile like '%" + txtmellicode.Text + "%'";
                }
            }
            catch (Exception e)
            {

            }

        }
        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            filterDataGride();
        }

        private void Cmb_var_per_Click(object sender, EventArgs e)
        {
            
        }

        private void Cmb_var_per_SelectedIndexChanged(object sender, EventArgs e)
        {


           // MessageBox.Show(""+Cmb_var_per.SelectedIndex);
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

        private void txtmellicode_TextChanged(object sender, EventArgs e)
        {
            filterDataGride();
        }

        private void gridEX1_TabIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("" + gridEX1.RowCount);
        }

        private void gridEX1_Move(object sender, EventArgs e)
        {
            //MessageBox.Show("" + gridEX1.RowCount);
        }

        private void gridEX1_LoadingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
           // MessageBox.Show("" + gridEX1.RowCount);
        }

        private void elDivider1_Click(object sender, EventArgs e)
        {

        }

        private void elButton2_Click(object sender, EventArgs e)
        {
            if (gridEX1.CurrentRow != null) { 
            string number_Este = gridEX1.CurrentRow.Cells[2].Value.ToString();
            string var_per = gridEX1.CurrentRow.Cells[9].Value.ToString();
            //MessageBox.Show("" + number_Este + "   " + var_per);
            RegisterPersonel frm2 = new RegisterPersonel();
            frm2.Var_per = var_per;
            frm2.Num_Este = number_Este;
            frm2.Show();
            }
        }

        private void Form3_Activated(object sender, EventArgs e)
        {
            Personnel personel = new Personnel();
            DataTable dt = personel.getALLData();

            gridEX1.DataSource = dt;
        }

        private void elButton4_Click(object sender, EventArgs e)
        {
            if (gridEX1.CurrentRow != null)
            {
                if (Cmb_var_per.SelectedIndex == 0)
                {
                    report.Load("ListPersonel.mrt");
                    report.Compile();
                    report["var2"] = " SELECT tb_contract.name, tb_contract.family, tb_contract.num_Este," +
                                     " tb_contract.born, tb_contract.meli, tb_contract.trai,tb_contract.mobile" +
                                     " FROM tb_contract where name LIKE '%" + txtname.Text + "%'"+
                                     " and num_Este LIKE '%" + txtCode.Text + "%' and family like '%" + txtfamily.Text + "%'"+
                                     " and meli like '%" + txtshsh.Text + "%' and mobile like '%" + txtmellicode.Text + "%'";
                    report.Show();
                }else if(Cmb_var_per.SelectedIndex == 1){

                    report.Load("ListPersonel.mrt");
                    report.Compile();
                    report["var2"] = " SELECT name, family, num_Este," +
                                     " born, meli, trai,mobile" +
                                     " FROM tb_formal where name LIKE '%" + txtname.Text + "%'" +
                                     " and num_Este LIKE '%" + txtCode.Text + "%' and family like '%" + txtfamily.Text + "%'" +
                                     " and meli like '%" + txtshsh.Text + "%' and mobile like '%" + txtmellicode.Text + "%'";
                    report.Show();
                }
                else if (Cmb_var_per.SelectedIndex == 2)
                {

                    report.Load("ListPersonel.mrt");
                    report.Compile();
                    report["var2"] = " SELECT name, family, num_Este," +
                                     " born, meli, trai,mobile" +
                                     " FROM tb_personel where name LIKE '%" + txtname.Text + "%'" +
                                     " and num_Este LIKE '%" + txtCode.Text + "%' and family like '%" + txtfamily.Text + "%'" +
                                     " and meli like '%" + txtshsh.Text + "%' and mobile like '%" + txtmellicode.Text + "%'";
                    report.Show();
                }
                else if (Cmb_var_per.SelectedIndex == 3)
                {

                    report.Load("ListPersonel.mrt");
                    report.Compile();
                    report["var2"] = " SELECT name, family, num_Este," +
                                     " born, meli, trai,mobile" +
                                     " FROM tb_contractual where name LIKE '%" + txtname.Text + "%'" +
                                     " and num_Este LIKE '%" + txtCode.Text + "%' and family like '%" + txtfamily.Text + "%'" +
                                     " and meli like '%" + txtshsh.Text + "%' and mobile like '%" + txtmellicode.Text + "%'";
                }
                else
                {
                    report.Load("ListPersonel.mrt");
                    report.Compile();
                    report["var2"] = " Select b.* from(" +
                                     " SELECT tb_contract.name, tb_contract.family, tb_contract.num_Este,born, tb_contract.meli, tb_contract.trai,tb_contract.mobile" +
                                     " FROM tb_contract" +
                                     " UNION ALL" +
                                     " SELECT tb_formal.name, tb_formal.family, tb_formal.num_Este, tb_formal.born," +
                                     " tb_formal.meli, tb_formal.trai, tb_formal.mobile" +
                                     " FROM tb_formal" +
                                     " UNION ALL" +
                                     " SELECT tb_contractual.name, tb_contractual.family, tb_contractual.num_Este, tb_contractual.born," +
                                     " tb_contractual.meli, tb_contractual.trai, tb_contractual.mobile" +
                                     " FROM tb_contractual" +
                                     " UNION ALL" +
                                     " SELECT tb_personel.name, tb_personel.family, tb_personel.num_Este," +
                                     " tb_personel.born, tb_personel.meli, tb_personel.trai, tb_personel.mobile" +
                                     " FROM tb_personel" +
                                     " ) b where name LIKE '%" + txtname.Text + "%'" +
                                     " and num_Este LIKE '%" + txtCode.Text + "%' and family like '%" + txtfamily.Text + "%'" +
                                     " and meli like '%" + txtshsh.Text + "%' and mobile like '%" + txtmellicode.Text + "%'";
                    report.Show();
                }
            }



        }

        private void btn_sodor_Click(object sender, EventArgs e)
        {
            if (gridEX1.CurrentRow != null)
            {
                RegisterHokm frm4 = new RegisterHokm();
                string Num_Este_Old = gridEX1.CurrentRow.Cells[2].Value.ToString();
                string Var_per = gridEX1.CurrentRow.Cells[9].Value.ToString();
                frm4.Auto = 1;
                frm4.Num_Este = Num_Este_Old;
                frm4.Var_per = Var_per;
                frm4.Show();
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (gridEX1.CurrentRow != null)
            {
                Personnel personnel = new Personnel();
                personnel.Num_Este_Old = gridEX1.CurrentRow.Cells[2].Value.ToString();
                personnel.Var_per = gridEX1.CurrentRow.Cells[9].Value.ToString();
                int a= personnel.deleteRecord();
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
    }
}

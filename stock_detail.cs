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
using System.Data.OleDb;

namespace my_project
{
    public partial class stock_detail : Form
    {
        OleDbConnection cn;
        OleDbDataAdapter da;
        DataSet ds;
        string apppath = Path.GetDirectoryName(Application.ExecutablePath);
        logclass procs = new logclass();
        public stock_detail()
        {
            InitializeComponent();
            //cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + apppath + @"\patanjali1.accdb");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = "Date :" + DateTime.Now.ToShortDateString();
            labltime.Text = "time :" + DateTime.Now.ToShortTimeString();
        }

        private void stock_detail_Load(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            datagrid();
            datagrid_Header();
            b_idd.Visible = false;
            b_inm.Visible = false;
           // b_itemtype.Visible = false; 
            


        }
        public void datagrid()
        {
            ds = procs.select_data("select * from stock_detail");
            dataGridView1.DataSource = ds.Tables[0];
        }
        public void datagrid_Header()
        {
            dataGridView1.Columns[0].HeaderText = "PRO.ID";
            dataGridView1.Columns[1].HeaderText = "STOCK";
            dataGridView1.Columns[2].HeaderText = "PRO.PRICE";
            dataGridView1.Columns[3].HeaderText = "ITEM_TYPE";
            dataGridView1.Columns[4].HeaderText = "ITEM_NAME";
            dataGridView1.Columns[5].HeaderText = "ITEM_CATEGORY";
        }
        

        private void b_all_CheckedChanged(object sender, EventArgs e)
        {
            datagrid();
            b_idd.Visible = false;
            b_inm.Visible = false;
            //b_itemtype.Visible = false;
        }

       

       

        private void show_Click_1(object sender, EventArgs e)
        {
            if (b_idd.Visible == true)
            {
                ds = procs.select_data("select * from stock_detail where sd_id =" + b_idd.Text + "");
                dataGridView1.DataSource = ds.Tables[0];

            }
           
           

            if(b_inm.Visible == true)
            {
                ds = procs.select_data("select * from stock_detail where sd_itemname='" + b_inm.Text + "'");
                dataGridView1.DataSource = ds.Tables[0];
            }


             if (b_all.Checked == true)
            {
                b_idd.Visible = false;
                datagrid();
            }
        }

        private void b_nm_CheckedChanged_1(object sender, EventArgs e)
        {
            if (b_nm.Checked == true)
            {
                b_inm.Items.Clear();
                 b_idd.Visible = false;
                //b_itemtype.Visible = false;

                b_inm.Visible = true;
                ds = new DataSet();
                ds = procs.select_data("select sd_itemname from stock_detail");
                int cc = Convert.ToInt32(ds.Tables[0].Rows.Count.ToString());
                //  b_inm.Items.Clear();
                for (int i = 0; i < cc; i++)
                {
                    b_inm.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                }
            }
            else
            {
                b_inm.Visible = false;
                b_inm.Text = "";
            }
        }

        private void b_id_CheckedChanged_1(object sender, EventArgs e)
        {
            if (b_id.Checked ==true)
            {
                b_idd.Items.Clear();
                 b_inm.Visible = false;
                //b_itemtype.Visible = false;

               b_idd.Visible = true;
                ds = new DataSet();
                ds = procs.select_data("select sd_id from stock_detail");
                int cc = Convert.ToInt32(ds.Tables[0].Rows.Count.ToString());
                //  b_inm.Items.Clear();
                for (int i = 0; i < cc; i++)
                {
                    b_idd.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                }
            }
            else
            {
                b_idd.Visible = false;
                b_idd.Text = "";
            }
            

        }

        private void exir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to exit  ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
        }

        private void b_inm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void b_all_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}

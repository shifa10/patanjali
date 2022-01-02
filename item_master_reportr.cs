using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace my_project
{
    public partial class item_master_reportr : Form
    {
        logclass procs = new logclass(); 
        DataSet ds;


        public item_master_reportr()
        {
            InitializeComponent();
        }

        private void item_master_reportr_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbdate.Text = "Date :" + DateTime.Now.ToShortDateString();
            lbtime.Text = "time :" + DateTime.Now.ToShortTimeString();
        }

        private void cust_id_CheckedChanged(object sender, EventArgs e)
        {
            if(cust_id.Checked)
            {
                cust_id.Visible=true;
                ds=procs.select_data("select i_id from item_master");
                c_cmboid.Items.Clear();
                for(int i=0;i<ds.Tables[0].Rows.Count; i++)
                    c_cmboid.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            else
                c_cmboid.Visible=false;
          }

        private void c_bnm_CheckedChanged(object sender, EventArgs e)
        {
            if (c_bnm.Checked)
            {
                c_cmboid.Visible = true;
                ds = procs.select_data("select i_combo2 from item_master");
                c_cnm.Items.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    c_cnm.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            else
                c_cmboid.Visible = false;
        }
        }
    }


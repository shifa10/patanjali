using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_project
{
    public partial class customer_report : Form
    {
        logclass procs = new logclass();
        DataSet ds;

        public customer_report()
        {
            InitializeComponent();
        }

        private void customer_report_Load(object sender, EventArgs e)
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
            if (cust_id.Checked)
            {
                comid.Visible = true;
                ds = procs.select_data("select c_id from custom_master");
                comid.Items.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    comid.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            else
                comid.Visible = false;
        }

        private void cnm_CheckedChanged(object sender, EventArgs e)
        {
            if (cnm.Checked)
            {
                cnm.Visible = true;
                ds = procs.select_data("select c_nm from custom_master");
                comnm.Items.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    comnm.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            else
                comnm.Visible = false;
        }

      
    }
}

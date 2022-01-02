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
    public partial class purchase_report : Form
    {
        logclass procs = new logclass();
        DataSet ds;

        public purchase_report()
        {
            InitializeComponent();
        }

        private void purchase_report_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked)
            {
                b_bill.Visible = true;
                ds = procs.select_data("select p_bill from purchase");
                b_bill.Items.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    b_bill.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            else
                b_bill.Visible = false;
        }

       
    }
}

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
    public partial class purchase_detail : Form
    {
        public purchase_detail()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

























        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void purchase_detail_Load(object sender, EventArgs e)
        {

            timer1.Enabled = true;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbdate.Text = "Date :" + DateTime.Now.ToShortDateString();
            lbtime.Text = "time :" + DateTime.Now.ToShortTimeString();
        }
    }
}

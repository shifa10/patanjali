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

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            p_bill.Clear();
            p_grandtotal.Clear();
            p_id.Clear();
            pd_qty.Clear();
            p_snm.Clear();
            p_subtotal.Clear();
            p_tax.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isvalidated())
            {

            }
        }

        private bool isvalidated()
        {
            if (p_id.Text.Trim() == string.Empty)
            {
                MessageBox.Show(" product id is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (p_bill.Text.Trim() == string.Empty)
            {
                MessageBox.Show(" bill num is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (p_snm.Text.Trim() == string.Empty)
            {
                MessageBox.Show(" supplier name is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (pd_qty.Text.Trim() == string.Empty)
            {
                MessageBox.Show("units is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (p_combo2.Text.Trim() == string.Empty)
            {
                MessageBox.Show(" please select the item", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;

          
        }

        private void p_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("please enter only number");
                e.Handled = true;
            }
        }

        private void p_bill_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("please enter only number");
                e.Handled = true;
            }
        }

        private void p_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("please enter only number");
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbtime_Click(object sender, EventArgs e)
        {

        }

        private void p_qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void pd_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("please enter only number");
                e.Handled = true;
            }

        }
    }
}

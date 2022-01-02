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
using System.IO;

namespace my_project
{
    public partial class sales_details : Form
    {


        OleDbConnection cn;
        OleDbDataAdapter da;
        DataSet ds;
        string apppath = Path.GetDirectoryName(Application.ExecutablePath);
        logclass procs = new logclass();
        int btflag = 0;
        int qty1;
        private int index;
        public sales_details()
        {
            InitializeComponent();
            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + apppath + @"\patanjali1.accdb");
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = "Date :" + DateTime.Now.ToShortDateString();
            labltime.Text = "time :" + DateTime.Now.ToShortTimeString();
        }

        private void sales_details_Load(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            dis_enable_control(false);
            btnenable(true);
            datagrid();
            datagrid_Header();
            bill_Pcmd.Visible = false;
            cmd_id.Visible = false;


            ds = new DataSet();
            ds = procs.select_data("select i_id from item_master");
            int b = Convert.ToInt32(ds.Tables[0].Rows.Count.ToString());
            for (int i = 0; i < b; i++)
            {
                ps_id.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            ds = new DataSet();
            ds = procs.select_data("select c_nm from custom_master");
            int c = Convert.ToInt32(ds.Tables[0].Rows.Count.ToString());
            for (int i = 0; i < c; i++)
            {
                cs_nm.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

            datagrid();
            datagrid_Header();
        }

        public void dis_enable_control(Boolean b)
        {
            ps_id.Enabled = b;
            s_bill.Enabled = b;
            cs_nm.Enabled = b;
            s_itemtype.Enabled = b;
            s_itemname.Enabled = b;
            s_itemcategory.Enabled = b;
            s_price.Enabled = b;
            s_date.Enabled = b;
            s_subtotal.Enabled = b;
            s_tax.Enabled = b;
            s_grandtotal.Enabled = b;
            s_qty.Enabled = b;

        }
        public void clear()
        {
            ps_id.Text = "";
            cs_nm.Text = "";
            s_bill.Text = "";
            s_itemtype.Text = "";
            s_itemname.Text = "";
            s_itemcategory.Text = "";
            s_date.Text = "";
            s_grandtotal.Text = "";
            s_tax.Text = "";
            s_price.Text = "";
            s_subtotal.Text = "";
            s_qty.Text = "";

        }
        public void datagrid_Header()
        {
            dataGridView1.Columns[0].HeaderText = "SALES_BILL";
            dataGridView1.Columns[1].HeaderText = "PRODUCT_ID";
            dataGridView1.Columns[2].HeaderText = "CUSTOMER.NM";
            dataGridView1.Columns[3].HeaderText = "ITEMTYPE";
            dataGridView1.Columns[4].HeaderText = "ITEM_NAME"; 
            dataGridView1.Columns[5].HeaderText = "ITEM_CATEGORY";
            dataGridView1.Columns[6].HeaderText = "UNIT";
            dataGridView1.Columns[7].HeaderText = "PRICE";
            dataGridView1.Columns[8].HeaderText = "DATE";
            dataGridView1.Columns[9].HeaderText = "SUBTOTAL";
            dataGridView1.Columns[10].HeaderText = "TAX";
            dataGridView1.Columns[11].HeaderText = "GRAND_TOTAL";
       }
        public void datagrid()
        {
            ds = procs.select_data("select * from sales");
            dataGridView1.DataSource = ds.Tables[0];
        }


        public void btnenable(Boolean b)
        {
            i_ins.Enabled = b;
            i_save.Enabled = !b;
            i_cancel.Enabled = !b;
            i_edit.Enabled = b;
            i_delete.Enabled = b;

        }
       
        private void i_fclick_Click(object sender, EventArgs e)
        {
            index = 0;
            display();
            dis_enable_control(true);
            btnenable(false);
        }

        private void s_id_KeyPress(object sender, KeyPressEventArgs e)
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

        private void s_bill_KeyPress(object sender, KeyPressEventArgs e)
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

       

        private void s_id_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void s_bill_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void s_qty_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("please enter only number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
         
        private void p_qty_TextChanged(object sender, EventArgs e)
        {
            if (s_qty.Text == "")
            {

            }
            else
            {
                decimal a = Convert.ToDecimal(s_price.Text);
                decimal b = Convert.ToDecimal(s_qty.Text);
                decimal d = a * b;
                s_subtotal.Text = Convert.ToString(d);
            }
        }

       

        private void bill_Pcmd_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(bill_Pcmd.SelectedItem.ToString());

            da = new OleDbDataAdapter("select * from custom_master where c_id Like '%" + x + "%'", cn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void i_ins_Click(object sender, EventArgs e)
        {
            btflag = 1;
            dis_enable_control(true);
            ds = new DataSet();
            ds = procs.select_data("select max(s_bill) from sales");
            int x;
            if (ds.Tables[0].Rows[0][0].ToString().Equals(""))
                x = 1001;
            else
                x = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1;
            s_bill.Text = x.ToString();
            s_bill.Enabled = false;

            btnenable(false);
        }

        private void i_save_Click(object sender, EventArgs e)
        {
            if (isvalited())
            {
                qty1 = Int32.Parse(s_qty.Text);
                ds = new DataSet();
                ds = procs.select_data("select sd_qty from stock_detail where sd_id=" + ps_id.Text + "");
                int q = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                q = q - qty1;
                if (q < 0)
                {
                    MessageBox.Show("You Have Not Enough Stock...", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    q = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                    s_qty.Text = "";
                }
                else if (btflag == 1)
                {
                    bool ad = procs.insert_up_delete("update stock_detail set sd_qty=" + q + " where sd_id=" + ps_id.Text + "");
                    bool ans = procs.insert_up_delete("insert into sales values(" + s_bill.Text + "," + ps_id.Text + ",'" + cs_nm.Text + "','" + s_itemtype.Text + "','" + s_itemname.Text + "','" + s_itemcategory.Text + "','" + s_qty.Text + "'," + s_price.Text + ",'" + s_date.Value.Date.ToShortDateString() + "','" + s_subtotal.Text + "','" + s_tax.Text + "','" + s_grandtotal.Text + "')");
                    if (ans)
                    {
                        MessageBox.Show("sucessfully inserted", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        datagrid();
                        clear();
                        btflag = 0;
                    }
                    else
                    {
                        MessageBox.Show(" not inserted", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    clear();
                    dis_enable_control(false);
                    btnenable(true);
                    datagrid();
                    btflag = 0;

                }
                else if (btflag == 2)
                {

                    bool ans1 = procs.insert_up_delete("update stock_detail set sd_qty=" + q + " where sd_id=" + ps_id.Text + "");
                    bool ans = procs.insert_up_delete("update sales set ps_id='" + ps_id.Text + "', cs_nm='" + cs_nm.Text + "',s_itentype='" + s_itemtype.Text + "',s_itemname='" + s_itemname.Text + "',s_itemcategory='" + s_itemcategory.Text + "', s_qty='" + s_qty.Text + "',s_price='" + s_price.Text + "',s_date='" + s_date.Value.Date.ToShortDateString() + "',s_subtotal='" + s_subtotal.Text + "',s_tax='" + s_tax.Text + "',s_grandtotal='" + s_grandtotal.Text + "'  where s_bill=" + bill_Pcmd.Text + "");
                    if (ans)
                    {
                        
                        MessageBox.Show("record sucessfully updated", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        datagrid();
                        clear();
                        btflag = 0;
                        s_bill.Visible = true;
                        bill_Pcmd.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("error!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clear();
                        dis_enable_control(true);
                        s_bill.Visible = true;
                        bill_Pcmd.Visible = false;
                    }
                    clear();
                    dis_enable_control(false);
                    btnenable(true);
                    datagrid();
                    btflag = 0;


                }
            }
        }

        private bool isvalited()
        {
            

              
                 if (ps_id.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" product id is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                else if (cs_nm.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" customer name is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                else if (s_qty.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("quantity is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                else if (s_tax.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("tax is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
            return true;
          
        }

        private void ps_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds = procs.select_data("select  i_combo1 from item_master where i_id=" + ps_id.Text + "");
            if (ds.Tables[0].Rows.Count > 0)
            {
                s_itemtype.Text = ds.Tables[0].Rows[0]["i_combo1"].ToString();
            }
            ds = procs.select_data("select i_combo2 from item_master where i_id=" + ps_id.Text + "");
            if (ds.Tables[0].Rows.Count > 0)
            {
                s_itemname.Text = ds.Tables[0].Rows[0]["i_combo2"].ToString();
            }
            ds = procs.select_data("select  i_combo3 from item_master where i_id=" + ps_id.Text + "");
            if (ds.Tables[0].Rows.Count > 0)
            {
                s_itemcategory.Text = ds.Tables[0].Rows[0]["i_combo3"].ToString();
            }
            ds = procs.select_data("select i_price from item_master where i_id=" + ps_id.Text + "");
            if (ds.Tables[0].Rows.Count > 0)
            {
                s_price.Text = ds.Tables[0].Rows[0]["i_price"].ToString();
            }

           //datagrid();
            //datagrid_Header();
        }

        private void cs_nm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void s_tax_TextChanged(object sender, EventArgs e)
        {
            if (s_tax.Text == "")
            {
            }
            else
            {

                decimal a = Convert.ToDecimal(s_subtotal.Text);
                decimal b = Convert.ToDecimal(s_tax.Text);
                decimal c = (a + b) / 100;
                decimal d = a + c;
                s_grandtotal.Text = Convert.ToString(d);
            }
        }

        private void i_edit_Click(object sender, EventArgs e)
        {
            btflag = 2;
            dis_enable_control(true);
            btnenable(false);
            bill_Pcmd.Visible = true;
            s_bill.Visible = false;


            da = new OleDbDataAdapter("select s_bill from sales", cn);
            ds = new DataSet();
            da.Fill(ds);
            bill_Pcmd.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                bill_Pcmd.Items.Add(ds.Tables[0].Rows[i][0]);
        }

        private void i_fclick_Click_1(object sender, EventArgs e)
        {
         
            index = 0;
            display();
            dis_enable_control(true);
            btnenable(false);
        }

        private void i_next_Click_1(object sender, EventArgs e)
        {
            int cnt = Convert.ToInt32(ds.Tables[0].Rows.Count.ToString());
            if (index < cnt)
            {

                display();
                dis_enable_control(true);
                btnenable(false);
                index++;

            }
        }

        private void i_prvious_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            if (index > cnt)
            {
                index--;
                display();
            }
            dis_enable_control(true);
            btnenable(false);
        }

        private void i_last_Click(object sender, EventArgs e)
        {
            index = Convert.ToInt32(ds.Tables[0].Rows.Count.ToString()) - 1;
            display();
            dis_enable_control(true);
            btnenable(false);
        }

      

        private void cmd_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(cmd_id.SelectedItem.ToString());

            da = new OleDbDataAdapter("select * from sales where s_bill Like '%" + x + "%'", cn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void ic_rid_CheckedChanged(object sender, EventArgs e)
        {
            cmd_id.Visible = true;
            da = new OleDbDataAdapter("select s_bill from sales", cn);
            ds = new DataSet();
            da.Fill(ds);
            cmd_id.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                cmd_id.Items.Add(ds.Tables[0].Rows[i][0]);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            datagrid();
            cmd_id.Visible = false;
        }

        private void i_cancel_Click(object sender, EventArgs e)
        {
            clear();
            btflag = 0;
            btnenable(true);
            dis_enable_control(false);
            btflag = 0;
            bill_Pcmd.Visible = false;

            s_bill.Visible = true;
        }

        private void i_delete_Click(object sender, EventArgs e)
        
        {
            if (s_bill.Text == "")
            {
                MessageBox.Show("please selcet value from gridview", "information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                qty1 = Int32.Parse(s_qty.Text);
                ds = new DataSet();
                ds = procs.select_data("select sd_qty from stock_detail where sd_id=" + ps_id.Text + "");
                int q = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                q = q + qty1;

                if (MessageBox.Show("are you sure to delet this record ?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    bool ad = procs.insert_up_delete("update stock_detail set sd_qty=" + q + " where sd_id=" + ps_id.Text + "");
                    bool ans = procs.insert_up_delete(" delete from sales where s_bill=" + s_bill.Text + "");
                    if (ans)
                    {
                        MessageBox.Show("record sucessfully deleted", "delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        {
                            datagrid();
                            clear();
                            btflag = 0;
                        }
                    }

                    else
                    {
                        MessageBox.Show("error", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        clear();
                    }

                }
                else
                {

                    clear();
                }
            }
        }

        private void i_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to exit from sales ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];

                s_bill.Text = r.Cells["s_bill"].Value.ToString();
                ps_id.Text = r.Cells["ps_id"].Value.ToString();
                cs_nm.Text = r.Cells["cs_nm"].Value.ToString();
                s_itemtype.Text = r.Cells["s_itentype"].Value.ToString();
                s_itemname.Text = r.Cells["s_itemname"].Value.ToString();
                s_itemcategory.Text = r.Cells["s_itemcategory"].Value.ToString();
                s_price.Text = r.Cells["s_price"].Value.ToString();
                s_qty.Text = r.Cells["s_qty"].Value.ToString();
                s_date.Text = r.Cells["s_date"].Value.ToString();
                s_subtotal.Text = r.Cells["s_subtotal"].Value.ToString();
                s_tax.Text = r.Cells["s_tax"].Value.ToString();
                s_grandtotal.Text = r.Cells["s_grandtotal"].Value.ToString();

                // datagrid();
            }
        }
        public void display()
        {

            DataGridViewRow row = this.dataGridView1.Rows[index];

            string p_billl = row.Cells["s_bill"].Value.ToString();
            string id = row.Cells["ps_id"].Value.ToString();
            string p_snmm = row.Cells["cs_nm"].Value.ToString();
            string p_comboo = row.Cells["s_itentype"].Value.ToString();
            string p_comboo2 = row.Cells["s_itemname"].Value.ToString();
            string p_comboo3 = row.Cells["s_itemcategory"].Value.ToString();
            string p_pricee = row.Cells["s_price"].Value.ToString();
            string pd_qtyy = row.Cells["s_qty"].Value.ToString();
            string p_datee = row.Cells["s_date"].Value.ToString();
            string p_subtotall = row.Cells["s_subtotal"].Value.ToString();
            string p_taxx = row.Cells["s_tax"].Value.ToString();
            string p_gtotal = row.Cells["s_grandtotal"].Value.ToString();

            s_bill.Text = p_billl;
            ps_id.Text = id;
            cs_nm.Text = p_snmm;
            s_itemtype.Text = p_comboo;
            s_itemname.Text = p_comboo2;
            s_itemcategory.Text = p_comboo3;
            s_price.Text = p_pricee;
            s_qty.Text = pd_qtyy;
            s_date.Text = p_datee;
            s_subtotal.Text = p_subtotall;
            s_tax.Text = p_taxx;
            s_grandtotal.Text = p_gtotal;
            datagrid();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void s_price_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("please enter only number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void s_subtotal_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("please enter only number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void s_tax_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("please enter only number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void s_grandtotal_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("please enter only number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }


    }
}

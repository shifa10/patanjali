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
    public partial class sales_return : Form
    {

        OleDbConnection cn;
        OleDbDataAdapter da;
        DataSet ds;
        string apppath = Path.GetDirectoryName(Application.ExecutablePath);
        logclass procs = new logclass();
        int btflag = 0;
        int qty1;
        private int index;
        public sales_return()
        {
            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + apppath + @"\patanjali1.accdb");
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = "Date :" + DateTime.Now.ToShortDateString();
            labltime.Text = "time :" + DateTime.Now.ToShortTimeString();
        }
         


        private void sales_return_Load(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
             dis_enable_control(false);
            btnenable(true);
             datagrid();
            datagrid_Header();
              
            
           //bill_Pcmd.Visible = false;
            cmd_id.Visible = false;

            ds = new DataSet();
            ds = procs.select_data("select s_bill from sales");
            int b = Convert.ToInt32(ds.Tables[0].Rows.Count.ToString());
            for (int i = 0; i < b; i++)
            {
                sr_bill.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            datagrid();
            datagrid_Header();
            
        
        }
        

         public void dis_enable_control(Boolean b)
        {
            sr_id.Enabled = b;
            sr_bill.Enabled = b;
            sr_cnm.Enabled = b;
            p_itemtype.Enabled = b;
            p_itemname.Enabled = b;
            p_itemcategory.Enabled = b;
            sr_price.Enabled = b;
            sr_date.Enabled = b;
            sr_subtotal.Enabled = b;
            sr_tax.Enabled = b;
            sr_grandtotal.Enabled = b;
            sr_unit.Enabled = b;

        }
        public void clear()
        {
            sr_id.Text = "";
            sr_cnm.Text = "";
            sr_bill.Text = "";
            p_itemtype.Text = "";
            p_itemname.Text = "";
            p_itemcategory.Text = "";
            sr_date.Text = "";
            sr_grandtotal.Text = "";
            sr_tax.Text = "";
            sr_price.Text = "";
            sr_subtotal.Text = "";
            sr_unit.Text = "";

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
            //datagrid();

        }
        public void datagrid()
        {
            ds = procs.select_data("select * from sales_return");
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
       

       
        private void button5_Click(object sender, EventArgs e)
        {
             clear();
            btflag = 0;
            btnenable(true);
            dis_enable_control(false);
            btflag = 0;
        }

      

       

        private bool isvalidated()
        {
            if (sr_id.Text.Trim() == string.Empty)
            {
                MessageBox.Show(" product id is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (sr_bill.Text.Trim() == string.Empty)
            {
                MessageBox.Show(" bill num is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (sr_cnm.Text.Trim() == string.Empty)
            {
                MessageBox.Show(" customer name is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (sr_unit.Text.Trim() == string.Empty)
            {
                MessageBox.Show("quantity is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            
          

       return true;
        }

       
      

        private void pr_id_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void pr_bill_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void pr_qty_KeyPress_1(object sender, KeyPressEventArgs e)
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

       private void i_save_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            ds = procs.select_data("select pr_bill from purchase_return");
            int c = Convert.ToInt32(ds.Tables[0].Rows.Count.ToString());
            for (int i = 0; i < c; i++)
            {
                if (sr_bill.Text == ds.Tables[0].Rows[i][0].ToString())
                {
                    MessageBox.Show("you can return only one time...!!", "confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btflag = 0;
                    clear();
                }


            }
              if (isvalidated())
                {
                    qty1 = Int32.Parse(sr_unit.Text);
                    ds = new DataSet();
                    ds = procs.select_data("select sd_qty from stock_detail where sd_id=" + sr_id.Text + "");
                    int q = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                    q = q + qty1;
                    if (q < 0)
                    {
                        MessageBox.Show("You have not enough stock !!...", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        q = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                        sr_unit.Text = "";
                    }

                    else if (btflag == 1)
                    {


                        bool ad = procs.insert_up_delete("update stock_detail set sd_qty=" + q + " where sd_id=" + sr_id.Text + "");
                        bool ans = procs.insert_up_delete("insert into sales_return values(" + sr_bill.Text + "," + sr_id.Text + ",'" + sr_cnm.Text + "','" + p_itemtype.Text + "','" + p_itemname.Text + "','" + p_itemcategory.Text + "','" + sr_unit.Text + "'," + sr_price.Text + ",'" + sr_date.Value.Date.ToShortDateString() + "','" + sr_subtotal.Text + "','" + sr_tax.Text + "','" + sr_grandtotal.Text + "')");
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


                        bool ad = procs.insert_up_delete("update stock_detail set sd_qty=" + q + " where sd_id=" + sr_id.Text + "");
                        bool ans = procs.insert_up_delete("update sales_return set sr_id='" + sr_id.Text + "', sr_cnm='" + sr_cnm.Text + "',p_itemtype='" + p_itemtype.Text + "',p_itemname='" + p_itemname.Text + "',p_itemcategory='" + p_itemcategory.Text + "', sr_unit'" + sr_unit.Text + "',sr_price='" + sr_price.Text + "',sr_date='" + sr_date.Value.Date.ToShortDateString() + "',sr_subtotal='" + sr_subtotal.Text + "',sr_tax='" + sr_tax.Text + "',sr_grandtotal='" + sr_grandtotal.Text + "'  where sr_bill=" + sr_bill.Text + "");
                        if (ans)
                        {
                            MessageBox.Show("record sucessfully updated", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            datagrid();
                            clear();
                            btflag = 0;

                        }
                        else
                        {
                            MessageBox.Show("error!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clear();
                            dis_enable_control(true);

                        }



                    }





                }
            
        }

        private void i_ins_Click(object sender, EventArgs e)
        {
            btflag = 1;
            btnenable(false);
            dis_enable_control(true);
            sr_id.Enabled = false;
          
            sr_cnm.Enabled = false;
            sr_price.Enabled = false;
            p_itemcategory.Enabled = false;
            p_itemname.Enabled = false;
            p_itemtype.Enabled = false;
            sr_bill.Enabled = true; ;
        }

        private void p_itemname_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void sr_bill_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds = procs.select_data("select  ps_id from sales where s_bill=" + sr_bill.Text + "");
            if (ds.Tables[0].Rows.Count > 0)
            {
                sr_id.Text = ds.Tables[0].Rows[0]["ps_id"].ToString();
            }
            ds = procs.select_data("select  cs_nm from sales where s_bill=" + sr_bill.Text + "");
            if (ds.Tables[0].Rows.Count > 0)
            {
                sr_cnm.Text = ds.Tables[0].Rows[0]["cs_nm"].ToString();
            }
            ds = procs.select_data("select  s_itentype from sales where s_bill=" + sr_bill.Text + "");
            if (ds.Tables[0].Rows.Count > 0)
            {
                p_itemtype.Text = ds.Tables[0].Rows[0]["s_itentype"].ToString();
            }
            ds = procs.select_data("select  s_itemname from sales where s_bill=" + sr_bill.Text + "");
            if (ds.Tables[0].Rows.Count > 0)
            {
                p_itemname.Text = ds.Tables[0].Rows[0]["s_itemname"].ToString();
            }
            ds = procs.select_data("select  s_itemcategory from sales where s_bill=" + sr_bill.Text + "");
            if (ds.Tables[0].Rows.Count > 0)
            {
                p_itemcategory.Text = ds.Tables[0].Rows[0]["s_itemcategory"].ToString();
            }
            ds = procs.select_data("select  s_price from sales where s_bill=" + sr_bill.Text + "");
            if (ds.Tables[0].Rows.Count > 0)
            {
                sr_price.Text = ds.Tables[0].Rows[0]["s_price"].ToString();
            }

            ds = procs.select_data("select  s_qty from sales where s_bill=" + sr_bill.Text + "");
            if (ds.Tables[0].Rows.Count > 0)
            {
                sr_unit.Text = ds.Tables[0].Rows[0]["s_qty"].ToString();
            }
           // datagrid();
           // datagrid_Header();
        }

        private void sr_unit_TextChanged(object sender, EventArgs e)
        {

            if (sr_unit.Text == "")
            {

            }
            else
            {
                decimal a = Convert.ToDecimal(sr_price.Text);
                decimal b = Convert.ToDecimal(sr_unit.Text);
                decimal d = a * b;
                sr_subtotal.Text = Convert.ToString(d);
            }
        }

        private void sr_tax_TextChanged(object sender, EventArgs e)
        {
            if (sr_tax.Text == "")
            {
            }
            else
            {

                decimal a = Convert.ToDecimal(sr_subtotal.Text);
                decimal b = Convert.ToDecimal(sr_tax.Text);
                decimal c = (a + b) / 100;
                decimal d = a + c;
                sr_grandtotal.Text = Convert.ToString(d);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void i_delete_Click(object sender, EventArgs e)
        {
          
            if (sr_bill.Text == "")
            {
                MessageBox.Show("please selcet value from gridview","information",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
            else
            {
                qty1 = Int32.Parse(sr_unit.Text);
                ds = new DataSet();
                ds = procs.select_data("select sd_qty from stock_detail where sd_id=" + sr_id.Text + "");
                int q = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                q = q - qty1;

                if (MessageBox.Show("are you sure to delet this record ?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    bool ad = procs.insert_up_delete("update stock_detail set sd_qty=" + q + " where sd_id=" + sr_id.Text + "");
                    bool ans = procs.insert_up_delete(" delete from sales_return where sr_bill=" + sr_bill.Text + "");
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btflag = 0;
            if (e.RowIndex >= 0)
            {

                DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];

                sr_bill.Text = r.Cells["sr_bill"].Value.ToString();
                sr_id.Text = r.Cells["sr_id"].Value.ToString();
                sr_cnm.Text = r.Cells["sr_cnm"].Value.ToString();
                p_itemtype.Text = r.Cells["p_itemtype"].Value.ToString();
                p_itemname.Text = r.Cells["p_itemname"].Value.ToString();
                p_itemcategory.Text = r.Cells["p_itemcategory"].Value.ToString();
                sr_price.Text = r.Cells["sr_price"].Value.ToString();
                sr_unit.Text = r.Cells["sr_unit"].Value.ToString();
                sr_date.Text = r.Cells["sr_date"].Value.ToString();
                sr_subtotal.Text = r.Cells["sr_subtotal"].Value.ToString();
                sr_tax.Text = r.Cells["sr_tax"].Value.ToString();
               sr_grandtotal.Text = r.Cells["sr_grandtotal"].Value.ToString();

                // datagrid();
            }
        }
        public void display()
        {
            btflag = 0;
            DataGridViewRow row = this.dataGridView1.Rows[index];

            string p_billl = row.Cells["sr_bill"].Value.ToString();
            string id = row.Cells["sr_id"].Value.ToString();
            string p_snmm = row.Cells["sr_cnm"].Value.ToString();
            string p_comboo = row.Cells["p_itemtype"].Value.ToString();
            string p_comboo2 = row.Cells["p_itemname"].Value.ToString();
            string p_comboo3 = row.Cells["p_itemcategory"].Value.ToString();
            string p_pricee = row.Cells["sr_price"].Value.ToString();
            string pd_qtyy = row.Cells["sr_unit"].Value.ToString();
            string p_datee = row.Cells["sr_date"].Value.ToString();
            string p_subtotall = row.Cells["sr_subtotal"].Value.ToString();
            string p_taxx = row.Cells["sr_tax"].Value.ToString();
            string p_gtotal = row.Cells["sr_grandtotal"].Value.ToString();

            sr_bill.Text = p_billl;
            sr_id.Text = id;
            sr_cnm.Text = p_snmm;
            p_itemtype.Text = p_comboo;
            p_itemname.Text = p_comboo2;
            p_itemcategory.Text = p_comboo3;
            sr_price.Text = p_pricee;
            sr_unit.Text = pd_qtyy;
            sr_date.Text = p_datee;
            sr_subtotal.Text = p_subtotall;
            sr_tax.Text = p_taxx;
            sr_grandtotal.Text = p_gtotal;
            datagrid();
        }

        private void i_fclick_Click(object sender, EventArgs e)
        {
            index = 0;
            display();
            dis_enable_control(true);
            btnenable(false);
        }

        private void i_next_Click(object sender, EventArgs e)
        {
            int cnt = Convert.ToInt32(ds.Tables[0].Rows.Count.ToString());
            if (index < cnt)
            {
                index++;
                display();
                dis_enable_control(true);
                btnenable(false);

            }
        }

        private void i_privious_Click(object sender, EventArgs e)
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void b_bill_CheckedChanged(object sender, EventArgs e)
        {

            cmd_id.Visible = true;
            da = new OleDbDataAdapter("select sr_bill from sales_return", cn);
            ds = new DataSet();
            da.Fill(ds);
            cmd_id.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                cmd_id.Items.Add(ds.Tables[0].Rows[i][0]);
        }

        private void cmd_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(cmd_id.SelectedItem.ToString());

            da = new OleDbDataAdapter("select * from sales_return where sr_bill Like '%" + x + "%'", cn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            datagrid();
            cmd_id.Visible = false;
        }

        private void sr_price_KeyPress(object sender, KeyPressEventArgs e)
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

        private void sr_subtotal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void sr_tax_KeyPress(object sender, KeyPressEventArgs e)
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

        private void sr_grandtotal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void i_exit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("are you sure to exit from sales return ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
        }

           
        }

     
       
    }


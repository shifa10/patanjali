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
    public partial class purchase_detail : Form
    {
    
        OleDbConnection cn;
        OleDbDataAdapter da;
        DataSet ds;
        string apppath = Path.GetDirectoryName(Application.ExecutablePath);
        logclass procs = new logclass();
        int btflag = 0;
        int qty1;
        private int index;
        public purchase_detail()
        {
            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + apppath + @"\patanjali1.accdb");
            InitializeComponent();
        }

            private void purchase_detail_Load(object sender, EventArgs e)
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
                p_id.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            ds = new DataSet();
            ds = procs.select_data("select sp_nm from supplier_master");
            int c = Convert.ToInt32(ds.Tables[0].Rows.Count.ToString());
            for (int i = 0; i < c; i++)
            {
                p_snm.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            datagrid();
            datagrid_Header();
        }
          public void dis_enable_control(Boolean b)
        {
            p_id.Enabled = b;
            p_bill.Enabled = b;
            p_snm.Enabled = b;
            p_itemtype.Enabled = b;
            p_itemname.Enabled = b;
            p_itemcategory.Enabled = b;
            p_price.Enabled = b;
            p_date.Enabled = b;
            p_subtotal.Enabled = b;
            p_tax.Enabled = b;
            p_grandtotal.Enabled = b;
            p_unit.Enabled = b;

        }
        public void clear()
        {
            p_id.Text = "";
            p_bill.Text = "";
            p_snm.Text = "";
            p_itemtype.Text = "";
            p_itemname.Text = "";
            p_itemcategory.Text = "";
            p_date.Text = "";
            p_grandtotal.Text = "";
            p_tax.Text = "";
            p_price.Text = "";
            p_subtotal.Text = "";
            p_unit.Text = "";




        }
        public void datagrid_Header()
        {
            dataGridView1.Columns[0].HeaderText = "PURCHASE_BILL";
            dataGridView1.Columns[1].HeaderText = "PRODUCT_ID";
            dataGridView1.Columns[2].HeaderText = "SUPPLIER.NM";
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
            ds = procs.select_data("select * from purchase");
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

   

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbdate.Text = "Date :" + DateTime.Now.ToShortDateString();
            lbtime.Text = "time :" + DateTime.Now.ToShortTimeString();
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

     

      

        private void pd_qty_KeyPress(object sender, KeyPressEventArgs e)
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
            qty1 = Int32.Parse(p_unit.Text);
            ds = new DataSet();
            ds = procs.select_data("select sd_qty from stock_detail where sd_id=" + p_id.Text + "");
            int q = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
            q = q + qty1;
            if (isvalidated())
            {
             
                if (btflag == 1)
                {
                  bool ans1 = procs.insert_up_delete("update stock_detail set sd_qty=" + q + " where sd_id=" + p_id.Text + "");
                    bool ans = procs.insert_up_delete("insert into purchase values(" + p_bill.Text + "," + p_id.Text + ",'" + p_snm.Text + "','" + p_itemtype.Text + "','" + p_itemname.Text + "','" + p_itemcategory.Text + "','" + p_unit.Text + "'," + p_price.Text + ",'" + p_date.Value.Date.ToShortDateString() + "','" + p_subtotal.Text + "','" + p_tax.Text + "','" + p_grandtotal.Text + "')");
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
                    bool ans1 = procs.insert_up_delete("update stock_detail set sd_qty=" + q + " where sd_id=" + p_id.Text + "");
                    bool ans = procs.insert_up_delete("update purchase set p_id='" + p_id.Text + "', p_snm='" + p_snm.Text + "',p_itemtype='" + p_itemtype.Text + "',p_itemname='" + p_itemname.Text + "',p_itemcategory='" + p_itemcategory.Text + "', pq_qty='" + p_unit.Text + "',p_price='" + p_price.Text + "',p_date='" + p_date.Value.Date.ToShortDateString() + "',p_subtotal='" + p_subtotal.Text + "',p_tax='" + p_tax.Text + "',p_grandtotal='" + p_grandtotal.Text + "'  where p_bill=" + bill_Pcmd.Text + "");
                    if (ans)
                    {
                        MessageBox.Show("record sucessfully updated", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        datagrid();
                        clear();
                        btflag = 0;
                        p_bill.Visible = true;
                        bill_Pcmd.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("error!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clear();
                        dis_enable_control(true);
                        p_bill.Visible = true;
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

        private bool isvalidated()
        {
            if (p_id.Text.Trim() == string.Empty)
            {
                MessageBox.Show(" id is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (p_snm.Text.Trim() == string.Empty)
            {
                MessageBox.Show(" supplier name is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (p_unit.Text.Trim() == string.Empty)
            {
                MessageBox.Show("units is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (p_itemname.Text.Trim() == string.Empty)
            {
                MessageBox.Show(" please select the item", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            
            return true;
        }

        private void i_ins_Click(object sender, EventArgs e)
        {
            btflag = 1;
            dis_enable_control(true);
            ds = new DataSet();
            ds = procs.select_data("select max(p_bill) from purchase");
            int x;
            if (ds.Tables[0].Rows[0][0].ToString().Equals(""))
                x = 1001;
            else
                x = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1;
            p_bill.Text = x.ToString();
            p_bill.Enabled = false;

            btnenable(false);
        }

        private void p_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds = procs.select_data("select  i_combo1 from item_master where i_id=" + p_id.Text + "");
            if (ds.Tables[0].Rows.Count > 0)
            {
                p_itemtype.Text = ds.Tables[0].Rows[0]["i_combo1"].ToString();
            }
            ds = procs.select_data("select i_combo2 from item_master where i_id=" + p_id.Text + "");
            if (ds.Tables[0].Rows.Count > 0)
            {
                p_itemname.Text = ds.Tables[0].Rows[0]["i_combo2"].ToString();
            }
            ds = procs.select_data("select  i_combo3 from item_master where i_id=" + p_id.Text + "");
            if (ds.Tables[0].Rows.Count > 0)
            {
                p_itemcategory.Text = ds.Tables[0].Rows[0]["i_combo3"].ToString();
            }
            ds = procs.select_data("select i_price from item_master where i_id=" + p_id.Text + "");
            if (ds.Tables[0].Rows.Count > 0)
            {
                p_price.Text = ds.Tables[0].Rows[0]["i_price"].ToString();
            }

           // datagrid();
           // datagrid_Header();
        }

        private void p_unit_TextChanged(object sender, EventArgs e)
        {
            if (p_unit.Text == "")
            {

            }
            else
            {
                decimal a = Convert.ToDecimal(p_price.Text);
                decimal b = Convert.ToDecimal(p_unit.Text);
                decimal d = a * b;
                p_subtotal.Text = Convert.ToString(d);
            }
        }

        private void p_tax_TextChanged(object sender, EventArgs e)
        {
            if (p_tax.Text == "")
            {
            }
            else
            {

                decimal a = Convert.ToDecimal(p_subtotal.Text);
                decimal b = Convert.ToDecimal(p_tax.Text);
                decimal c = (a + b) / 100;
                decimal d = a + c;
                p_grandtotal.Text = Convert.ToString(d);
            }
        }

        private void i_edit_Click(object sender, EventArgs e)
        {
            btflag = 2;
            dis_enable_control(true);
            btnenable(false);
            bill_Pcmd.Visible = true;
            p_bill.Visible = false;


            da = new OleDbDataAdapter("select p_bill from purchase", cn);
            ds = new DataSet();
            da.Fill(ds);
            bill_Pcmd.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                bill_Pcmd.Items.Add(ds.Tables[0].Rows[i][0]);
        }

        private void i_delete_Click(object sender, EventArgs e)
        {
            if (p_bill.Text == "")
            {
                MessageBox.Show("please selcet value from gridview");
            }
            else
            {

                if (MessageBox.Show("are you sure to delet this record ?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    bool ad = procs.insert_up_delete("update stock_detail set sd_qty=" + 0 + " where sd_id=" + p_id.Text + "");
                    bool ans = procs.insert_up_delete(" delete from purchase where p_bill=" + p_bill.Text + "");
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
            if (MessageBox.Show("are you sure to exit from purchase detail?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];

                p_bill.Text = r.Cells["p_bill"].Value.ToString();
                p_id.Text = r.Cells["p_id"].Value.ToString();
                 p_snm.Text = r.Cells["p_snm"].Value.ToString();
                 p_itemtype.Text = r.Cells["p_itemtype"].Value.ToString();
                 p_itemname.Text = r.Cells["p_itemname"].Value.ToString();
                 p_itemcategory.Text = r.Cells["p_itemcategory"].Value.ToString();
                p_price.Text = r.Cells["p_price"].Value.ToString();
                p_unit.Text = r.Cells["pq_qty"].Value.ToString();
                p_date.Text = r.Cells["p_date"].Value.ToString();
                p_subtotal.Text = r.Cells["p_subtotal"].Value.ToString();
                p_tax.Text = r.Cells["p_tax"].Value.ToString();
                p_grandtotal.Text = r.Cells["p_grandtotal"].Value.ToString();

                // datagrid();
            }
           
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            cmd_id.Visible = true;
            da = new OleDbDataAdapter("select p_bill from purchase", cn);
            ds = new DataSet();
            da.Fill(ds);
            cmd_id.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                cmd_id.Items.Add(ds.Tables[0].Rows[i][0]);
        }

        private void cmd_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(cmd_id.SelectedItem.ToString());

            da = new OleDbDataAdapter("select * from purchase where p_bill Like '%" + x + "%'", cn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            datagrid();
            cmd_id.Visible = false;
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

        private void i_last_Click(object sender, EventArgs e)
        {
            index = Convert.ToInt32(ds.Tables[0].Rows.Count.ToString()) - 1;
            display();
            dis_enable_control(true);
            btnenable(false);
        }

        private void p_snm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void display()
        {

            DataGridViewRow row = this.dataGridView1.Rows[index];
            string bill = row.Cells["p_bill"].Value.ToString();
            string id = row.Cells["p_id"].Value.ToString();
            string sname = row.Cells["p_snm"].Value.ToString();
            string itemm = row.Cells["p_itemtype"].Value.ToString();
            string itemnm = row.Cells["p_itemname"].Value.ToString();
            string itemcate = row.Cells["p_itemcategory"].Value.ToString();
            string price = row.Cells["p_price"].Value.ToString();
            string unit = row.Cells["pq_qty"].Value.ToString();
            string date = row.Cells["p_date"].Value.ToString();
            string subtotal = row.Cells["p_subtotal"].Value.ToString();
            string tax = row.Cells["p_tax"].Value.ToString();
            string grandtotal = row.Cells["p_grandtotal"].Value.ToString();


            p_bill.Text = bill;
            p_id.Text = id;
            p_snm.Text = sname;
            p_itemtype.Text = itemm;
            p_itemname.Text = itemnm;
            p_itemcategory.Text = itemcate;
            p_price.Text = price;
            p_unit.Text = unit;
            p_date.Text = date;
            p_subtotal.Text = subtotal;
            p_tax.Text = tax;
            p_grandtotal.Text = grandtotal;
            datagrid();

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void i_cancel_Click(object sender, EventArgs e)
        {
            clear();
            btflag = 0;
            btnenable(true);
            dis_enable_control(false);
            btflag = 0;
            bill_Pcmd.Visible = false;
        }

        private void i_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p_price_KeyPress(object sender, KeyPressEventArgs e)
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

        private void p_subtotal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void p_tax_KeyPress(object sender, KeyPressEventArgs e)
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

        private void p_grandtotal_KeyPress(object sender, KeyPressEventArgs e)
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


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
    public partial class purchase_return : Form
    {
        OleDbConnection cn;
        OleDbDataAdapter da;
        DataSet ds;
        string apppath = Path.GetDirectoryName(Application.ExecutablePath);
        logclass procs = new logclass();
        int btflag = 0;
        int qty1;
        private int index;
        public purchase_return()
        {
            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + apppath + @"\patanjali1.accdb");
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void purchase_return_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            dis_enable_control(false);
            btnenable(true);
            datagrid();
            datagrid_Header();
            
           //bill_Pcmd.Visible = false;
            cmd_id.Visible = false;

            ds = new DataSet();
            ds = procs.select_data("select p_bill from purchase");
            int b = Convert.ToInt32(ds.Tables[0].Rows.Count.ToString());
            for (int i = 0; i < b; i++)
            {
                pr_bill.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            datagrid();
            datagrid_Header();

        }
        public void datagrid()
        {
            ds = procs.select_data("select * from purchase_return");
            dataGridView1.DataSource = ds.Tables[0];
        }
        public void dis_enable_control(Boolean b)
        {
            pr_bill.Enabled = b;
            pr_id.Enabled = b;
            pr_snm.Enabled = b;
            p_itemtype.Enabled = b;
            p_itemname.Enabled = b;
            p_itemcategory.Enabled = b;
            pr_price.Enabled = b;
            pr_unit.Enabled = b;
            pr_date.Enabled = b;
            pr_subtotal.Enabled = b;
            pr_tax.Enabled = b;
            pr_grandtotal.Enabled = b;

        }
        public void clear()
        {
            pr_bill.Text = "";
            pr_snm.Text = "";
            pr_id.Text="";
            p_itemtype.Text = "";
            p_itemname.Text = "";
            p_itemcategory.Text = "";
            pr_date.Text = "";
            pr_grandtotal.Text = "";
            pr_tax.Text = "";
            pr_price.Text = "";
            pr_subtotal.Text = "";
            pr_unit.Text = "";

}
        public void btnenable(Boolean b)
        {
            i_ins.Enabled = b;
            i_save.Enabled = !b;
            i_cancel.Enabled = !b;
            i_edit.Enabled = b;
            i_delete.Enabled = b;

        }
       public void datagrid_Header()
        {
            dataGridView1.Columns[0].HeaderText = "PRODUCT_BILL";
            dataGridView1.Columns[1].HeaderText = "PRODUCT_ID";
            dataGridView1.Columns[2].HeaderText = "SUPPLIER.NM";
            dataGridView1.Columns[3].HeaderText = "p_ITEMTYPE";
            dataGridView1.Columns[4].HeaderText = "P_ITEM_NAME";
            dataGridView1.Columns[5].HeaderText = "ITEM_CATEGORY";
            dataGridView1.Columns[6].HeaderText = "UNIT";
            dataGridView1.Columns[7].HeaderText = "PRICE";
            dataGridView1.Columns[8].HeaderText = "DATE";
            dataGridView1.Columns[9].HeaderText = "SUBTOTAL";
            dataGridView1.Columns[10].HeaderText = "TAX";
            dataGridView1.Columns[11].HeaderText = "GRAND_TOTAL";


      }
       public void display()
       {

           DataGridViewRow row = this.dataGridView1.Rows[index];

           string p_billl = row.Cells["pr_bill"].Value.ToString();
           string id = row.Cells["pr_id"].Value.ToString();
           string p_snmm = row.Cells["pr_snm"].Value.ToString();
           string p_comboo = row.Cells["p_itemtype"].Value.ToString();
           string p_comboo2 = row.Cells["p_itemname"].Value.ToString();
           string p_comboo3 = row.Cells["p_itemcategory"].Value.ToString();
           string p_pricee = row.Cells["pr_price"].Value.ToString();
           string pd_qtyy = row.Cells["pr_unit"].Value.ToString();
           string p_datee = row.Cells["pr_date"].Value.ToString();
           string p_subtotall = row.Cells["pr_subtotal"].Value.ToString();
           string p_taxx = row.Cells["pr_tax"].Value.ToString();
           string p_gtotal = row.Cells["pr_grandtotal"].Value.ToString();

           pr_bill.Text = p_billl;
           pr_id.Text = id;

           pr_snm.Text = p_snmm;
           p_itemtype.Text = p_comboo;
           p_itemname.Text = p_comboo2;
           p_itemcategory.Text = p_comboo3;
           pr_price.Text = p_pricee;
           pr_unit.Text = pd_qtyy;
           pr_date.Text = p_datee;
           pr_subtotal.Text = p_subtotall;
           pr_tax.Text = p_taxx;
           pr_grandtotal.Text = p_gtotal;
           datagrid();
       }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = "Date :" + DateTime.Now.ToShortDateString();
            labltime.Text = "time :" + DateTime.Now.ToShortTimeString();
        }

      
        private void button4_Click(object sender, EventArgs e)
        {
           ds = new DataSet();
            ds = procs.select_data("select pr_bill from purchase_return");
            int c = Convert.ToInt32(ds.Tables[0].Rows.Count.ToString());
            for (int i = 0; i < c; i++)
            {
                if (pr_bill.Text == ds.Tables[0].Rows[i][0].ToString())
                {
                    MessageBox.Show("you can return only one time...!!","confirmation",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    btflag = 0;
                    clear();
                }
                
                    
            }
            if (isvalidated())
                    {

                        qty1 = Int32.Parse(pr_unit.Text);
                        ds = new DataSet();
                        ds = procs.select_data("select sd_qty from stock_detail where sd_id=" + pr_id.Text + "");
                        int q = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                        q = q - qty1;

                        if (q < 0)
                        {
                            MessageBox.Show("You have Not Enough Stock..!!...", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            q = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                            pr_unit.Text = "";
                        }


                        else if (btflag == 1)
                        {



                            bool ans1 = procs.insert_up_delete("update stock_detail set sd_qty=" + q + " where sd_id=" + pr_id.Text + "");
                            bool ans = procs.insert_up_delete("insert into purchase_return values(" + pr_bill.Text + "," + pr_id.Text + ",'" + pr_snm.Text + "','" + p_itemtype.Text + "','" + p_itemname.Text + "','" + p_itemcategory.Text + "','" + pr_unit.Text + "'," + pr_price.Text + ",'" + pr_date.Value.Date.ToShortDateString() + "','" + pr_subtotal.Text + "','" + pr_tax.Text + "','" + pr_grandtotal.Text + "')");
                            if (ans)
                            {
                                MessageBox.Show("sucessfully inserted", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                datagrid();
                                clear();
                                btflag = 0;
                            }
                            else
                            {
                                MessageBox.Show("not inserted", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }


                            clear();
                            dis_enable_control(false);
                            btnenable(true);
                            datagrid();
                            btflag = 0;

                        }
                        else if (btflag == 2)
                        {
                            bool ans1 = procs.insert_up_delete("update stock_detail set sd_qty=" + q + " where sd_id=" + pr_id.Text + "");
                            bool ans = procs.insert_up_delete("update purchase_return set pr_id='" + pr_id.Text + "', pr_snm='" + pr_snm.Text + "',p_itemtype='" + p_itemtype.Text + "',p_itemname='" + p_itemname.Text + "',p_itemcategory='" + p_itemcategory.Text + "', pr_unit='" + pr_unit.Text + "',pr_price='" + pr_price.Text + "',pr_date='" + pr_date.Value.Date.ToShortDateString() + "',pr_subtotal='" + pr_subtotal.Text + "',pr_tax='" + pr_tax.Text + "',pr_grandtotal='" + pr_grandtotal.Text + "'  where pr_bill=" + pr_bill.Text + "");
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
            if (pr_id.Text.Trim() == string.Empty)
            {
                MessageBox.Show(" product id is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            
            if (pr_bill.Text.Trim() == string.Empty)
            {
                MessageBox.Show(" bill num is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (pr_snm.Text.Trim() == string.Empty)
            {
                MessageBox.Show(" supplier name is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (pr_unit.Text.Trim() == string.Empty)
            {
                MessageBox.Show("quantity is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            
           return true;

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

        private void p_id_TextChanged(object sender, EventArgs e)
        {

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



        private void p_id_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void p_bill_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void p_qty_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void i_ins_Click(object sender, EventArgs e)
        {
            btflag = 1;
            btnenable(false);
            dis_enable_control(true);
            pr_id.Enabled = false;
            pr_id.Enabled = false;
            pr_snm.Enabled = false;
            pr_price.Enabled = false;
            p_itemcategory.Enabled = false;
            p_itemname.Enabled = false;
            p_itemtype.Enabled = false;
        }

        private void pr_bill_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds = procs.select_data("select  p_id from purchase where p_bill=" + pr_bill.Text + "");
            if (ds.Tables[0].Rows.Count > 0)
            {
                pr_id.Text = ds.Tables[0].Rows[0]["p_id"].ToString();
            }
            ds = procs.select_data("select  p_snm from purchase where p_bill=" + pr_bill.Text + "");
            if (ds.Tables[0].Rows.Count > 0)
            {
                pr_snm.Text = ds.Tables[0].Rows[0]["p_snm"].ToString();
            }
            ds = procs.select_data("select  p_itemtype from purchase where p_bill=" + pr_bill.Text + "");
            if (ds.Tables[0].Rows.Count > 0)
            {
                p_itemtype.Text = ds.Tables[0].Rows[0]["p_itemtype"].ToString();
            }
            ds = procs.select_data("select  p_itemname from purchase where p_bill=" + pr_bill.Text + "");
            if (ds.Tables[0].Rows.Count > 0)
            {
                p_itemname.Text = ds.Tables[0].Rows[0]["p_itemname"].ToString();
            }
            ds = procs.select_data("select  p_itemcategory from purchase where p_bill=" + pr_bill.Text + "");
            if (ds.Tables[0].Rows.Count > 0)
            {
                p_itemcategory.Text = ds.Tables[0].Rows[0]["p_itemcategory"].ToString();
            }
            ds = procs.select_data("select  p_price from purchase where p_bill=" + pr_bill.Text + "");
            if (ds.Tables[0].Rows.Count > 0)
            {
                pr_price.Text = ds.Tables[0].Rows[0]["p_price"].ToString();
            }

            ds = procs.select_data("select  pq_qty from purchase where p_bill=" + pr_bill.Text + "");
            if (ds.Tables[0].Rows.Count > 0)
            {
                pr_unit.Text = ds.Tables[0].Rows[0]["pq_qty"].ToString();
            }
           // datagrid();
           // datagrid_Header();
            
        }

        private void pr_unit_TextChanged(object sender, EventArgs e)
        {
            if (pr_unit.Text == "")
            {

            }
            else
            {
                decimal a = Convert.ToDecimal(pr_price.Text);
                decimal b = Convert.ToDecimal(pr_unit.Text);
                decimal d = a * b;
                pr_subtotal.Text = Convert.ToString(d);
            }
        }

        private void pr_unit_Leave(object sender, EventArgs e)
        {
            
        }

        private void pr_unit_Click(object sender, EventArgs e)
        {
           
        }

        private void pr_unit_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];

                pr_bill.Text = r.Cells["pr_bill"].Value.ToString();
                pr_id.Text = r.Cells["pr_id"].Value.ToString();
                pr_snm.Text = r.Cells["pr_snm"].Value.ToString();
                p_itemtype.Text = r.Cells["p_itemtype"].Value.ToString();
                p_itemname.Text = r.Cells["p_itemname"].Value.ToString();
                p_itemcategory.Text = r.Cells["p_itemcategory"].Value.ToString();
                pr_unit.Text = r.Cells["pr_unit"].Value.ToString();
                pr_price.Text = r.Cells["pr_price"].Value.ToString();
                pr_date.Text = r.Cells["pr_date"].Value.ToString();
                pr_subtotal.Text = r.Cells["pr_subtotal"].Value.ToString();
                pr_tax.Text = r.Cells["pr_tax"].Value.ToString();
                pr_grandtotal.Text = r.Cells["pr_grandtotal"].Value.ToString();
               //datagrid();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            cmd_id.Visible = true;
            da = new OleDbDataAdapter("select pr_bill from purchase_return", cn);
            ds = new DataSet();
            da.Fill(ds);
            cmd_id.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                cmd_id.Items.Add(ds.Tables[0].Rows[i][0]);
        }

        private void cmd_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(cmd_id.SelectedItem.ToString());

            da = new OleDbDataAdapter("select * from purchase_return where pr_bill Like '%" + x + "%'", cn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void i_cancel_Click(object sender, EventArgs e)
        {
            clear();
            btflag = 0;
            btnenable(true);
            dis_enable_control(false);
            btflag = 0;
            
        }

        private void i_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to exit from purchase return ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
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

        private void pr_tax_TextChanged(object sender, EventArgs e)
        {
            if (pr_tax.Text == "")
            {

            }
            else
            {

                decimal a = Convert.ToDecimal(pr_subtotal.Text);
                decimal b = Convert.ToDecimal(pr_tax.Text);
                decimal c = (a + b) / 100;
                decimal d = a + c;
                pr_grandtotal.Text = Convert.ToString(d);
            }

        }

        private void i_delete_Click(object sender, EventArgs e)
        {
            
            if (pr_bill.Text == "")
            {
                MessageBox.Show("please selcet value from gridview", "information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                qty1 = Int32.Parse(pr_unit.Text);
                ds = new DataSet();
                ds = procs.select_data("select sd_qty from stock_detail where sd_id=" + pr_id.Text + "");
                int q = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                q = q + qty1;

                if (MessageBox.Show("are you sure to delet this record ?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    bool ad = procs.insert_up_delete("update stock_detail set sd_qty=" + q+ " where sd_id=" + pr_id.Text + "");
                    bool ans = procs.insert_up_delete(" delete from purchase_return where pr_bill=" + pr_bill.Text + "");
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

        private void p_itemcategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            datagrid();
            cmd_id.Visible = false;
        }

        private void pr_tax_KeyPress(object sender, KeyPressEventArgs e)
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

        private void pr_subtotal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void pr_grandtotal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void pr_price_KeyPress(object sender, KeyPressEventArgs e)
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


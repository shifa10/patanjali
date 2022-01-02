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
    public partial class item_master : Form
    {
        OleDbConnection cn;
        OleDbDataAdapter da;
        DataSet ds;
        string apppath = Path.GetDirectoryName(Application.ExecutablePath);
        logclass procs = new logclass();
        int btflag = 0;
        private int index;
        public item_master()
        {
           
            InitializeComponent();
            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + apppath + @"\patanjali1.accdb");
        }

          private void item_master_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            dis_enable_control(false);
            btnenable(true);
            datagrid();
            datagrid_Header();
          

            ic_rid.Visible = false;
            i_iname.Visible = false;
            i_rid.Checked = false;
            bill_Pcmd.Visible = false;
        }
          public void dis_enable_control(Boolean b)
          {
              i_id.Enabled = b;
              i_stock.Enabled = b;
              i_combo.Enabled = b;
              i_combo2.Enabled = b;
              i_combo3.Enabled = b;
              i_price.Enabled = b;

          }
          public void clear()
          {
              i_id.Text = "";
              i_price.Text = "";
              i_stock.Text = "";
              i_combo.Text = "";
              i_combo2.Text = "";
              i_combo3.Text = "";

          }
          public void datagrid_Header()
          {
              itemdataGridView1.Columns[0].HeaderText = "PRO.ID";
              itemdataGridView1.Columns[1].HeaderText = "STOCK";
              itemdataGridView1.Columns[2].HeaderText = "PRO.PRICE";
              itemdataGridView1.Columns[3].HeaderText = "ITEM";
              itemdataGridView1.Columns[4].HeaderText = "ITEM_TYPE";
              itemdataGridView1.Columns[5].HeaderText = "ITEM_CATEGORY";
          }
          public void datagrid()
          {
              ds = procs.select_data("select * from item_master");
              itemdataGridView1.DataSource = ds.Tables[0];
          }


          public void btnenable(Boolean b)
          {
              i_ins.Enabled = b;
              i_save.Enabled = !b;
              i_cancel.Enabled = !b;
              i_edit.Enabled = b;
              i_delet.Enabled = b;


          }


        private void i_ins_Click(object sender, EventArgs e)
        {
            btflag = 1;
            dis_enable_control(true);
            ds = new DataSet();
            ds = procs.select_data("select max(i_id) from item_master");
            int x;
            if (ds.Tables[0].Rows[0][0].ToString().Equals(""))
                x=1;
            else
             x = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1;
            i_id.Text = x.ToString();
            i_id.Enabled = false;
            i_stock.Focus();
            btnenable(false);
        }

        private void i_save_Click(object sender, EventArgs e)
        {
            if (isvalidate())
            {

            }
              
        }

        private bool isvalidate()
        {
            if (btflag == 1)
     {
                if (i_stock.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" stock is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                else if (i_price.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" price is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }

                else if (i_combo2.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" please select the item", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                else if (i_combo3.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" please select the item", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                else if (i_combo.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" please select the item", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }


                else
                {
                   
                
                    bool ans1 = procs.insert_up_delete("insert into stock_detail values(" + i_id.Text + ",'" + i_stock.Text + "','" + i_price.Text + "','" + i_combo.Text + "','" + i_combo2.Text + "','" + i_combo3.Text + "')");
                    bool ans = procs.insert_up_delete("insert into item_master values(" + i_id.Text + ",'" + i_stock.Text + "','" + i_price.Text + "','" + i_combo.Text + "','" + i_combo2.Text + "','" + i_combo3.Text + "')");
                    if (ans)
                    {
                        MessageBox.Show("sucessfully inserted","inserted",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        datagrid();
                        clear();
                        btflag = 0;
                        bill_Pcmd.Visible = false;
                        i_id.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("error");
                    }


       }
                
                  

                 
                    
      }
            if (btflag == 2)
            {

                if (i_stock.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" stock is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                else if (i_price.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" price is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }

                else if (i_combo2.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" please select the item", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                else if (i_combo3.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" please select the item", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                else if (i_combo.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" please select the item", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                else if (bill_Pcmd.Text != ds.Tables[0].Rows[0][0].ToString())
                {
                    MessageBox.Show("dosen't exit this record" ,"does'nt exist",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }


                else
                {

                    bool ans = procs.insert_up_delete("update  item_master set i_stock='" + i_stock.Text + "',i_price='" + i_price.Text + "',i_combo1='" + i_combo.Text + "',i_combo2='" + i_combo2.Text + "',i_combo3='" + i_combo3.Text + "' where i_id="+ bill_Pcmd.Text + "");
                    if (ans)
                    {
                        MessageBox.Show("record sucessfully updated", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        datagrid();
                        clear();
                        btflag = 0;
                        bill_Pcmd.Visible = false;
                        i_id.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("error record not updated ","error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    }
                }
            }

                    clear();
                    dis_enable_control(false);
                    btnenable(true);
                    datagrid();
                    btflag = 0;
                

                return true;
            
            }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = "Date :" + DateTime.Now.ToShortDateString();
            labltime.Text = "time :" + DateTime.Now.ToShortTimeString();
        }

        private void i_cancel_Click(object sender, EventArgs e)
        {
            clear();
            btflag = 0;
            btnenable(true);
            dis_enable_control(false);
            btflag = 0;
            bill_Pcmd.Visible = false;
            i_id.Visible = true;
        }

        private void ic_rid_SelectedIndexChanged(object sender, EventArgs e)
        {
          int x = Convert.ToInt32(ic_rid.SelectedItem.ToString());

            da = new OleDbDataAdapter("select * from item_master where i_id="+x+"", cn);
            ds = new DataSet();
            da.Fill(ds);
            itemdataGridView1.DataSource = ds.Tables[0];
        }


        private void i_all_CheckedChanged(object sender, EventArgs e)
        {
            datagrid();
            ic_rid.Visible = false;
            i_iname.Visible = false;
        }

        private void i_rid_CheckedChanged(object sender, EventArgs e)
        {
            ic_rid.Visible = true;
            i_iname.Visible = false;

            da = new OleDbDataAdapter("select i_id from item_master", cn);
            ds = new DataSet();
            da.Fill(ds);
            i_iname.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                ic_rid.Items.Add(ds.Tables[0].Rows[i][0]);
        }

        private void i_name_CheckedChanged(object sender, EventArgs e)
        {
            if (i_name.Checked == true)
            {
                i_iname.Items.Clear();
                i_iname.Visible=true;
                ic_rid.Visible = false;
                ds = new DataSet();
                ds = procs.select_data("select i_combo2 from item_master");
                int a = Convert.ToInt32(ds.Tables[0].Rows.Count.ToString());
                for (int i = 0; i < a; i++)
                {
                    i_iname.Items.Add(ds.Tables[0].Rows[i][0].ToString());

                }

            }
        }

        private void i_iname_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds = procs.select_data("select *from item_master where i_combo2='"+i_iname.Text+"'");
                itemdataGridView1.DataSource = ds.Tables[0];
        }

       
        public void display()
        {

            DataGridViewRow row = this.itemdataGridView1.Rows[index];
            string id = row.Cells["i_id"].Value.ToString();
            string stock = row.Cells["i_stock"].Value.ToString();
            string price = row.Cells["i_price"].Value.ToString();
            string itemm= row.Cells["i_combo1"].Value.ToString();
            string itemnamm = row.Cells["i_combo2"].Value.ToString();
            string itemcateg = row.Cells["i_combo3"].Value.ToString();

            i_id.Text = id;
            i_stock.Text = stock;
            i_price.Text = price;
            i_combo.Text = itemm;
            i_combo2.Text = itemnamm;
            i_combo3.Text = itemcateg;

}
        private void i_fclick_Click(object sender, EventArgs e)
        {
            index = 0;
            display();

            
        }
        private void i_previous_Click(object sender, EventArgs e)
        {
           
        }
       

        private void i_next_Click(object sender, EventArgs e)
        {

             
            int cnt = Convert.ToInt32(ds.Tables[0].Rows.Count.ToString());
            if (index < cnt)
            {
                index++;
                display();

            }

        }
       

        private void i_last_Click(object sender, EventArgs e)
        {
            index = Convert.ToInt32(ds.Tables[0].Rows.Count.ToString()) -1;
            display();
        }

        private void i_previous_Click_1(object sender, EventArgs e)
        {
            int cnt = 0;
            if (index > cnt)
            {
                index--;
                display();
            }

        }

        private void i_edit_Click(object sender, EventArgs e)
        {

            btflag = 2;
            dis_enable_control(true);
            btnenable(false);


            bill_Pcmd.Visible = true;
            i_id.Visible = false;


            da = new OleDbDataAdapter("select i_id from item_master", cn);
            ds = new DataSet();
            da.Fill(ds);
            bill_Pcmd.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                bill_Pcmd.Items.Add(ds.Tables[0].Rows[i][0]);


        }

        private void i_delet_Click(object sender, EventArgs e)
        {
            if (i_id.Text == "")
            {

                MessageBox.Show("please selcet value from gridview","select", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
             
            else
            {

                if (MessageBox.Show("are you sure to delet this record ?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {

                    bool ad = procs.insert_up_delete(" delete from stock_detail where sd_id=" + i_id.Text + "");
                    bool ans = procs.insert_up_delete(" delete from item_master where i_id=" + i_id.Text + "");
                    if (ans)
                    {
                        MessageBox.Show("record sucessfully deleted","delete", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        {
                            datagrid();
                            clear();
                            btflag = 0;
                        }
                    }

                    else
                    {
                        MessageBox.Show("error");
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
            if (MessageBox.Show("are you sure to exit from item mastter ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            this.Dispose();
        
        }

        private void i_stock_TextChanged(object sender, EventArgs e)
        {

        }

        private void i_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void bill_Pcmd_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(bill_Pcmd.SelectedItem.ToString());

            da = new OleDbDataAdapter("select * from item_master where i_id Like '%" + x + "%'", cn);
            ds = new DataSet();
            da.Fill(ds);
            itemdataGridView1.DataSource = ds.Tables[0];
        }

        private void i_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (i_combo.SelectedItem.ToString() == "Natural personal care")
            {
                i_combo2.Items.Clear();
                i_combo2.Items.Add("Body lotion");
                i_combo2.Items.Add("Face wash");
                i_combo2.Items.Add("Shampoo");
                i_combo2.Items.Add("Hair oil");

            }
            else if (i_combo.SelectedItem.ToString() == "Natural food care")
            {
                i_combo2.Items.Clear();
                i_combo2.Items.Add("oats");
                i_combo2.Items.Add("pulses");
                i_combo2.Items.Add("murabba");


            }

            else if (i_combo.SelectedItem.ToString() == "Natural health care")
            {
                i_combo2.Items.Clear();
                i_combo2.Items.Add("pak");
                i_combo2.Items.Add("sharbat");
                i_combo2.Items.Add("juice");


            }
           



        }

        private void i_combo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (i_combo2.SelectedItem.ToString() == "Body lotion")
            {
                i_combo3.Items.Clear();
                i_combo3.Items.Add(" sundarya Body lotion");
                i_combo3.Items.Add("milk body lotion");
               
            }
            else if (i_combo2.SelectedItem.ToString() == "Face wash")

            {
                i_combo3.Items.Clear();
                i_combo3.Items.Add(" Neem face wash");
                i_combo3.Items.Add("Orange honey");

            }
            else if (i_combo2.SelectedItem.ToString() == "Shampoo")
            {
                i_combo3.Items.Clear();
                i_combo3.Items.Add(" Rethai hair wash");
                i_combo3.Items.Add("Shikhakai shampoo");

            }
            else if (i_combo2.SelectedItem.ToString() == "sharbat")
            {
               
                 i_combo3.Items.Clear();
                i_combo3.Items.Add("khas sharbat");
                i_combo3.Items.Add("Variyali sharbat");

            }
            else if (i_combo2.SelectedItem.ToString() == "Hair oil")
            {
                i_combo3.Items.Clear();
                i_combo3.Items.Add(" Amla hair oil");
                i_combo3.Items.Add("Coconut hair oil");

          }
            else if (i_combo2.SelectedItem.ToString() == "oats")
            {
                i_combo3.Items.Clear();
                i_combo3.Items.Add(" Row oats");
                i_combo3.Items.Add("Instant oats");

            }
            else if (i_combo2.SelectedItem.ToString() == "pulses")
            {
                i_combo3.Items.Clear();
                i_combo3.Items.Add("dal pulses");
                i_combo3.Items.Add("mix pulses");
            }
            else if (i_combo2.SelectedItem.ToString() == "murabba")
            {
                i_combo3.Items.Clear();
                i_combo3.Items.Add("amla murabba");
                i_combo3.Items.Add("refress murabba");
            }
            else if (i_combo2.SelectedItem.ToString() == "pak")
            {
                i_combo3.Items.Clear();
                i_combo3.Items.Add("badam pak");
                i_combo3.Items.Add("mosli pak");

            }
            else if (i_combo2.SelectedItem.ToString() == "juice")
            {
                i_combo3.Items.Clear();
                i_combo3.Items.Add("aamla juice");
                i_combo3.Items.Add("alo veera juice");
                i_combo3.Items.Add("tulsi giloy juice");
            }
        }

        private void i_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void i_stock_KeyPress(object sender, KeyPressEventArgs e)
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

        private void i_price_KeyPress(object sender, KeyPressEventArgs e)
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

        private void itemdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void itemdataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void itemdataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow r = this.itemdataGridView1.Rows[e.RowIndex];
                i_id.Text = r.Cells["i_id"].Value.ToString();
                i_price.Text = r.Cells["i_price"].Value.ToString();
                i_stock.Text = r.Cells["i_stock"].Value.ToString();
                i_combo.Text = r.Cells["i_combo1"].Value.ToString();
                i_combo2.Text = r.Cells["i_combo2"].Value.ToString();
                i_combo3.Text = r.Cells["i_combo3"].Value.ToString();
                //datagrid();

            }
        }
           
        }

        

        }

       

        
      

        
    


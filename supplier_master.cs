using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using System.IO;

namespace my_project
{
    public partial class supplier_master : Form
    {
        OleDbConnection cn;
        OleDbDataAdapter da;
        DataSet ds;
        string apppath = Path.GetDirectoryName(Application.ExecutablePath);
        logclass procs = new logclass();
        int bttflag = 0;
        private int index;
        

        public supplier_master()
        {
            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + apppath + @"\patanjali1.accdb");
            InitializeComponent();
        }

        private void supplier_master_Load(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            
            dis_enable_control(false);
            btnenable(true);
            datagrid();
            datagrid_Header();
            cmd_id.Visible = false;
            txtnm.Visible = false;
            bill_Pcmd.Visible = false;
            
        }
        public void dis_enable_control(Boolean b)
        {
            sp_id.Enabled = b;
            sp_nm.Enabled = b;
            sp_add.Enabled = b;
            sp_pin.Enabled = b;
            sp_con.Enabled = b;
            sp_email.Enabled = b;

        }
        public void clear()
        {
            sp_id.Text = "";
            sp_nm.Text = "";
            sp_add.Text = "";
            sp_pin.Text = "";
            sp_con.Text = "";
            sp_email.Text = "";

        }
        public void datagrid_Header()
        {
            dataGridView1.Columns[0].HeaderText = "SUPPLIER.ID";
            dataGridView1.Columns[1].HeaderText = "SUPPLIER.NAME";
            dataGridView1.Columns[2].HeaderText = "SUPPLIER_ADDRESS";
            dataGridView1.Columns[3].HeaderText = "SUPPLIER_PIN";
            dataGridView1.Columns[4].HeaderText = "CONATCT_NM.";
            dataGridView1.Columns[5].HeaderText = "SUPPLIER_EMAIL";
        }
        public void datagrid()
        {
            ds = procs.select_data("select * from supplier_master");
           
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

        
        private void i_ins_Click(object sender, EventArgs e)
        {
            bttflag = 1;
            dis_enable_control(true);
            ds = new DataSet();
            ds = procs.select_data("select max(sp_id) from supplier_master");
            int x;
            if (ds.Tables[0].Rows[0][0].ToString().Equals(""))
                x = 1;
            else
                x = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1;
            sp_id.Text = x.ToString();
            sp_id.Enabled = false;
            sp_nm.Focus();
            btnenable(false);
            
        }

        private void p_email_Leave(object sender, EventArgs e)
        {
            Regex remail = new Regex(@"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");

            if (!remail.IsMatch(sp_email.Text.Trim()))
            {
                MessageBox.Show("invalid email address", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sp_email.Focus();
            }
            
        }

        

        private void sp_id_KeyPress(object sender, KeyPressEventArgs e)
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

        

        private void sp_pin_KeyPress(object sender, KeyPressEventArgs e)
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

        private void i_save_Click(object sender, EventArgs e)
        {

            if (isvalidate())
            {

            }

 }

        private bool isvalidate()
        {

            if (bttflag == 1)
            {
                if (sp_nm.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" customer name is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }

                else if (sp_add.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" customer address is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                else if (sp_email.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" email is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                else if (sp_pin.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" pin num  is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                else if (sp_pin.TextLength < 6 || sp_pin.TextLength > 6)
                {
                    MessageBox.Show("please enter valid pin number");
                    return false;
                }
                else if (sp_con.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" contact num is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                else if (sp_con.TextLength < 10 || sp_con.TextLength > 10)
                {
                    MessageBox.Show("please enter valid contact  num", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                    sp_con.Text = "";
                }



                else
                {

                  bool ans = procs.insert_up_delete("insert into supplier_master values(" + sp_id.Text + ",'" + sp_nm.Text + "','" + sp_add.Text + "','" + sp_pin.Text + "','" + sp_con.Text + "','" + sp_email.Text + "')");
                    if (ans)
                    {
                        MessageBox.Show("sucessfully inserted", "inserted", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                        datagrid();
                        clear();
                        bttflag = 0;
                    }
                    else
                    {
                        MessageBox.Show("error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }


            if (bttflag == 2)
            {
                if (sp_nm.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" customer name is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }

                else if (sp_add.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" customer address is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                else if (sp_email.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" email is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                else if (sp_pin.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" pin num  is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                else if (sp_pin.TextLength < 6 || sp_pin.TextLength > 6)
                {
                    MessageBox.Show("please enter valid pin number");
                }
                else if (sp_con.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" contact num is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                else if (sp_con.TextLength < 10 || sp_con.TextLength > 10)
                {
                    MessageBox.Show("please enter valid contact  num", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    sp_con.Text = "";
                    return false;
                }



                else
                {

                    bool ans = procs.insert_up_delete("update  supplier_master set sp_nm='" + sp_nm.Text + "',sp_add='" + sp_add.Text + "',sp_pin='" + sp_pin.Text + "',sp_con='" + sp_con.Text + "',sp_email='" + sp_email.Text + "' where sp_id=" + bill_Pcmd.Text + "");
                    if (ans)
                    {
                        MessageBox.Show("record sucessfully updated", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        datagrid();
                        clear();
                        bttflag = 0;
                        bill_Pcmd.Visible = false;
                        sp_id.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("error! record doesn't exist", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clear();
                        dis_enable_control(true);
                        bill_Pcmd.Visible = false;
                        sp_id.Visible = true;
                    }
                }
            }

            clear();
            dis_enable_control(false);
            btnenable(true);
            datagrid();
            bttflag = 0;

         return true;
        }

        private void i_edit_Click(object sender, EventArgs e)
        {
            bttflag = 2;
            dis_enable_control(true);
            btnenable(false);


            bill_Pcmd.Visible = true;
            sp_id.Visible = false;


            da = new OleDbDataAdapter("select sp_id from supplier_master", cn);
            ds = new DataSet();
            da.Fill(ds);
            bill_Pcmd.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                bill_Pcmd.Items.Add(ds.Tables[0].Rows[i][0]);

        }

        private void i_delete_Click(object sender, EventArgs e)
        {
            if (sp_id.Text == "")
            {
                MessageBox.Show("please selcet value from gridview","select",MessageBoxButtons.OK,MessageBoxIcon.Information );
            }
            else
            {

                if (MessageBox.Show("are you sure to delet this record ?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    bool ans = procs.insert_up_delete(" delete from supllier_master where sp_id=" + sp_id.Text + "");
                    if (ans)
                    {
                        MessageBox.Show("record sucessfully deleted", "delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        {
                            datagrid();
                            clear();
                            bttflag = 0;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];
                sp_id.Text = r.Cells["sp_id"].Value.ToString();
                sp_nm.Text = r.Cells["sp_nm"].Value.ToString();
                sp_add.Text = r.Cells["sp_add"].Value.ToString();
                sp_pin.Text = r.Cells["sp_pin"].Value.ToString();
                sp_con.Text = r.Cells["sp_con"].Value.ToString();
                sp_email.Text = r.Cells["sp_email"].Value.ToString();

            }
        }
        public void display()
        {

            DataGridViewRow row = this.dataGridView1.Rows[index];
            string id = row.Cells["sp_id"].Value.ToString();
            string sp_nmm= row.Cells["sp_nm"].Value.ToString();
            string sp_addd = row.Cells["sp_add"].Value.ToString();
            string sp_pinn = row.Cells["sp_pin"].Value.ToString();
            string sp_conn = row.Cells["sp_con"].Value.ToString();
            string sp_emaill = row.Cells["sp_email"].Value.ToString();

            sp_id.Text = id;
            sp_nm.Text = sp_nmm;
            sp_add.Text = sp_addd;
            sp_pin.Text = sp_pinn;
            sp_con.Text = sp_conn;
            sp_email.Text = sp_emaill;

            
            
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

        private void c_cmdid_CheckedChanged(object sender, EventArgs e)
        {
            cmd_id.Visible = true;
            txtnm.Visible = false;

            da = new OleDbDataAdapter("select sp_id from supplier_master", cn);
            ds = new DataSet();
            da.Fill(ds);
            cmd_id.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                cmd_id.Items.Add(ds.Tables[0].Rows[i][0]);
        }

        private void cmd_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(cmd_id.SelectedItem.ToString());

            da = new OleDbDataAdapter("select * from supplier_master where sp_id Like '%" + x + "%'", cn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void c_cmdnm_CheckedChanged(object sender, EventArgs e)
        {
            cmd_id.Visible = false;
            txtnm.Visible = true;

        }

        private void txtnm_TextChanged(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("select * from supplier_master where sp_nm Like '%" + txtnm.Text + "%'", cn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void sp_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void i_cancel_Click(object sender, EventArgs e)
        {
            clear();
            bttflag = 0;
            btnenable(true);
            dis_enable_control(false);
            bttflag = 0;
            bill_Pcmd.Visible = false;
            sp_id.Visible = true;

        }

        private void i_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to exit from supplier master ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cmd_id.Visible = false;
            txtnm.Visible = false;
            datagrid();
        }

        private void bill_Pcmd_SelectedIndexChanged(object sender, EventArgs e)
        {

            int x = Convert.ToInt32(bill_Pcmd.SelectedItem.ToString());

            da = new OleDbDataAdapter("select * from supplier_master where sp_id Like '%" + x + "%'", cn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void sp_con_KeyPress(object sender, KeyPressEventArgs e)
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

        private void sp_con_TextChanged(object sender, EventArgs e)
        {

        }
       
        
    }
}


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
    public partial class customer_master : Form
    {
        OleDbConnection cn;
        OleDbDataAdapter da;
        DataSet ds;
        string apppath = Path.GetDirectoryName(Application.ExecutablePath);
        logclass procs = new logclass();
        int bttflag = 0;
        private int index;
        public customer_master()
        {
            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + apppath + @"\patanjali1.accdb");
            InitializeComponent();
        }

        private void customer_master_Load(object sender, EventArgs e)
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
            c_id.Enabled = b;
            c_nm.Enabled = b;
            c_add.Enabled = b;
            c_pin.Enabled = b;
            contact.Enabled = b;
            email.Enabled = b;

        }
        public void clear()
        {
            c_id.Text = "";
            c_nm.Text = "";
            c_add.Text = "";
            c_pin.Text = "";
            contact.Text = "";
            email.Text = "";

        }
        public void datagrid_Header()
        {
            dataGridView1.Columns[0].HeaderText = "C_ID";
            dataGridView1.Columns[1].HeaderText = "C_NAME";
            dataGridView1.Columns[2].HeaderText = "C_ADDRESS";
            dataGridView1.Columns[3].HeaderText = "C_PIN";
            dataGridView1.Columns[4].HeaderText = "CONATCT_NM.";
            dataGridView1.Columns[5].HeaderText = "C_EMAIL";
        }
        public void datagrid()
        {
            ds = procs.select_data("select * from custom_master");
            dataGridView1.DataSource = ds.Tables[0];
        }

        public void btnenable(Boolean b)
        {
            i_ins.Enabled = b;
            i_savee.Enabled = !b;
            i_cancel.Enabled = !b;
            i_edit.Enabled = b;
            i_delete.Enabled = b;


        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lbdate.Text = "Date :" + DateTime.Now.ToShortDateString();
            lbtime.Text = "time :" + DateTime.Now.ToShortTimeString();
        }


        private void id_KeyPress(object sender, KeyPressEventArgs e)
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
        private void i_ins_Click(object sender, EventArgs e)
        {
            bttflag = 1;
            dis_enable_control(true);
            ds = new DataSet();
            ds = procs.select_data("select max(c_id) from custom_master");
            int x;
            if (ds.Tables[0].Rows[0][0].ToString().Equals(""))
                x = 1;
            else
                x = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1;
            c_id.Text = x.ToString();
            c_id.Enabled = false;
            c_nm.Focus();
            btnenable(false);

        }





        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }



        public void display()
        {

            DataGridViewRow row = this.dataGridView1.Rows[index];
            string id = row.Cells["c_id"].Value.ToString();
            string name = row.Cells["c_nm"].Value.ToString();
            string add = row.Cells["c_add"].Value.ToString();
            string pin = row.Cells["c_pin"].Value.ToString();
            string con = row.Cells["contact"].Value.ToString();
            string em = row.Cells["email"].Value.ToString();

            c_id.Text = id;
            c_nm.Text = name;
            c_add.Text = add;
            c_pin.Text = pin;
            contact.Text = con;
            email.Text = em;

        }



        private void i_savee_Click(object sender, EventArgs e)
        {
            
            if (isvalidate())
            {


            }


        }
        private bool isvalidate()
        {

            if (bttflag == 1)
            {
                if (c_nm.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" customer name is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
               
                else if (c_add.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" customer address is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                else if (email.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" email is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                else if (c_pin.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" pin num  is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                else if (c_pin.TextLength < 6 || c_pin.TextLength > 6)
                {
                    MessageBox.Show("please enter valid pin number");
                    return false;
                }
                else if (contact.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" contact num is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                else if (contact.TextLength < 10 || contact.TextLength > 10)
                {
                    MessageBox.Show("please enter valid contact  num", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                    contact.Text = "";
                }
               else
                {
                   bool ans = procs.insert_up_delete("insert into custom_master values(" + c_id.Text + ",'" + c_nm.Text + "','" + c_add.Text + "','" + c_pin.Text + "','" + contact.Text + "','" + email.Text + "')");
                    if(ans)
                    {
                        MessageBox.Show("sucessfully inserted", "inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        datagrid();
                        clear();
                        bttflag = 0;
                    }
                    else
                    {
                        MessageBox.Show("error");
                    }

                }
            }

                if (bttflag == 2)
                {
                    if (c_nm.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show(" customer name is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;

                    }

                    else if (c_add.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show(" customer address is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;

                    }
                    else if (email.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show(" email is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    else if (c_pin.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show(" pin num  is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;

                    }
                    else if (c_pin.TextLength < 6 || c_pin.TextLength > 6)
                    {
                        MessageBox.Show("please enter valid pin number");
                    }
                    else if (contact.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show(" contact num is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;

                    }
                    else if (contact.TextLength < 10 || contact.TextLength > 10)
                    {
                        MessageBox.Show("please enter valid contact  num", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                  

                    else
                    {
                        bool ans = procs.insert_up_delete("update  custom_master set c_nm='" + c_nm.Text + "',c_add='" + c_add.Text + "',c_pin='" + c_pin.Text + "',contact='" + contact.Text + "',email='" + email.Text + "' where c_id=" + bill_Pcmd.Text + "");
                        if (ans)
                        {
                            MessageBox.Show("record sucessfully updated", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            datagrid();
                            clear();
                            bttflag = 0;
                            bill_Pcmd.Visible = false;
                            c_id.Visible = true;


                        }
                        else
                        {
                            MessageBox.Show("error! record not updated ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            bill_Pcmd.Visible = false;
                            c_id.Visible = true;
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

       
        private void email_Leave(object sender, EventArgs e)
        {
            Regex remail = new Regex(@"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");

            if (!remail.IsMatch(email.Text.Trim()))
            {
                MessageBox.Show("invalid email address", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                email.Focus();
            }
        }

        private void i_edit_Click(object sender, EventArgs e)
        {
            bttflag = 2;
            dis_enable_control(true);
            btnenable(false);
            bill_Pcmd.Visible = true;
            c_id.Visible = false;


            da = new OleDbDataAdapter("select c_id from custom_master", cn);
            ds = new DataSet();
            da.Fill(ds);
            bill_Pcmd.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                bill_Pcmd.Items.Add(ds.Tables[0].Rows[i][0]);
        }

        private void i_cancel_Click(object sender, EventArgs e)
        {
            clear();
            bttflag = 0;
            btnenable(true);
            dis_enable_control(false);
            bttflag = 0;
            bill_Pcmd.Visible = false;

            c_id.Visible = true;


           
        }


        private void i_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to exit from customer mastter ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
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

        private void c_cmdid_CheckedChanged(object sender, EventArgs e)
        {
            cmd_id.Visible = true;
            txtnm.Visible = false;

            da = new OleDbDataAdapter("select c_id from custom_master", cn);
            ds = new DataSet();
            da.Fill(ds);
            cmd_id.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                cmd_id.Items.Add(ds.Tables[0].Rows[i][0]);
        }

        private void cmd_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(cmd_id.SelectedItem.ToString());

            da = new OleDbDataAdapter("select * from custom_master where c_id=" + x + "", cn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void c_cmdnm_CheckedChanged(object sender, EventArgs e)
        {
            cmd_id.Visible = false;
            txtnm.Visible = true;


        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            datagrid();
            cmd_id.Visible=false;
            txtnm.Visible=false;
        }

        private void txtnm_TextChanged(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("select * from custom_master where c_nm Like '%"+ txtnm.Text+"%'", cn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void i_delete_Click(object sender, EventArgs e)
        {
            if (c_id.Text == " ")
            {
                MessageBox.Show("please selcet value from gridview","select", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                
                if (MessageBox.Show("are you sure to delet this record ?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    bool ans = procs.insert_up_delete(" delete from custom_master where c_id=" + c_id.Text + "");
                    if (ans)
                    {
                        MessageBox.Show("record sucessfully deleted", "delete", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        {
                            datagrid();
                            clear();
                            bttflag = 0;
                        }
                    }

                    else
                    {
                        MessageBox.Show("error","error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                        clear();
                    }

                }
                else
                {
                    
                    clear();
                }
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

        private void c_pin_KeyPress(object sender, KeyPressEventArgs e)
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

        private void contact_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];
                c_id.Text = r.Cells["c_id"].Value.ToString();
                c_nm.Text = r.Cells["c_nm"].Value.ToString();
                c_add.Text = r.Cells["c_add"].Value.ToString();
                c_pin.Text = r.Cells["c_pin"].Value.ToString();
                contact.Text = r.Cells["contact"].Value.ToString();
                email.Text = r.Cells["email"].Value.ToString();

            }
        }

       

        }

    }


                   
    


      
    



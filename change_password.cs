using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.IO;



namespace my_project
{
    public partial class change_password : Form
    {
        
        logclass procs = new logclass();

      
     public change_password()
        {

          
           
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            if (old_pass.PasswordChar == '\0')
            {
                button6.BringToFront();
               old_pass.PasswordChar = '.';
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (old_pass.PasswordChar == '.')
            {
                button3.BringToFront();
                old_pass.PasswordChar = '\0';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isvalidated())
            {
                
            }
        }

       


        private bool isvalidated()
        {
            if (old_pass.Text.Trim() == string.Empty)
            {
                MessageBox.Show("new password is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
              
            }
            
            else if (new_pass.Text.Trim() == string.Empty)
            {
                MessageBox.Show("confirm the password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (new_pass.Text != con_pass.Text)
            {
                MessageBox.Show("password didn't match ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else
            {
                if (con_pass.Text == old_pass.Text)
                {
                    MessageBox.Show("enter uniq password", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                                                                                                                                                                                                                         
                else
                {
                    bool ans = procs.insert_up_delete("update login set [password]='" + this.con_pass.Text + "'  where Password='" + this.old_pass.Text + "'");
                    if (ans)
                    {
                        MessageBox.Show("password successfully changed ", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("password is incorrect!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }
            old_pass.Clear();
            new_pass.Clear();
            con_pass.Clear();
            return true; 
        }

        

        private void change_password_Load(object sender, EventArgs e)
        {
            
        }

        private void current_password_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

       

       

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.LimeGreen;
            
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Green;
        }

        private void eye_Click(object sender, EventArgs e)
        {
            if (old_pass.PasswordChar == '\0')
            {
                eye2.BringToFront();
                old_pass.PasswordChar = '.';
            }
        }

        private void eye2_Click(object sender, EventArgs e)
        {
            if (new_pass.PasswordChar == '.')
            {
                button2.BringToFront();
                new_pass.PasswordChar = '\0';
            }
        }

        private void eye2_Click_1(object sender, EventArgs e)
        {
            if (new_pass.PasswordChar == '.')
            {
                button2.BringToFront();
                new_pass.PasswordChar = '\0';
            }
        }

        private void con_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (new_pass.PasswordChar == '\0')
            {
                eye2.BringToFront();
                new_pass.PasswordChar = '.';
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (con_pass.PasswordChar == '.')
            {
                button5.BringToFront();
                con_pass.PasswordChar = '\0';
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (con_pass.PasswordChar == '\0')
            {
                button4.BringToFront();
                con_pass.PasswordChar = '.';
            }
        }

       

        

      

        
    }
}

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
    public partial class login : Form
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            string apppath = Path.GetDirectoryName(Application.ExecutablePath);
            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + apppath + @"\patanjali1.accdb");
            cn.Open();
        }
    
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("select * from login where  user='"+username.Text+"' AND password ='"+password.Text+"'",cn);
            dr=cmd.ExecuteReader();

            int c = 0;

            while(dr.Read())
                c++;

                if(c==1)
                {
                    c = 0;
                   if( MessageBox.Show("login is sucessfully","login", MessageBoxButtons.OKCancel,MessageBoxIcon.Information)==System.Windows.Forms.DialogResult.OK)
                   {
                       patnjali m = new patnjali();
                           m.Show();
                       this.Hide(); 
                   }
                   }
                   else
                   {
                       MessageBox.Show("password or usrername is incorrect", "login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    username.Text="";
                    password.Text="";
                   }
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LimeGreen;
        }
       

        private void ok_MouseHover(object sender, EventArgs e)
        {
            ok.BackColor = Color.LimeGreen;
            

                
        }

        private void ok_MouseMove(object sender, MouseEventArgs e)
        {
            ok.BackColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (password.PasswordChar == '\0')
            {
                button2.BringToFront();
                password.PasswordChar = '.';
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (password.PasswordChar == '.')
            {
                button1.BringToFront();
                password.PasswordChar = '\0';
            }

        }
    }
}

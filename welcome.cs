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
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar2.Value == 100)
            {
                timer1.Enabled = false;
                login ln = new login();
                ln.Show();
                this.Hide();
            }
            else
            {
                this.progressBar2.Value += 10;
                lbp.Text = progressBar2.Value + "%";

            }
            lbldate.Text = "Date :" + DateTime.Now.ToShortDateString();
            labltime.Text = "time :" + DateTime.Now.ToShortTimeString();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }

        private void labltime_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        }
    }


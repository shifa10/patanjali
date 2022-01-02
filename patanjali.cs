using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace my_project
{
    public partial class patnjali : Form
    {
        public patnjali()
        {
            InitializeComponent();
        }

        private void mWDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            item_master f2 = new item_master();
            f2.MdiParent = this;
            f2.Show();
            
            
        }

        private void supplierMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "supplier_master")
                {
                    IsOpen = true;
                    f.Focus();
                    break;

                }
            }
            if (IsOpen == false)
            {
                supplier_master f2 = new supplier_master();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void customerMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "customer_master")
                {
                    IsOpen = true;
                    f.Focus();
                    break;

                }
            }
            if (IsOpen == false)
            {
                customer_master f2 = new customer_master();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void mdi_form_Load(object sender, EventArgs e)
        {

        }

        private void salesReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
             if (f.Text == "sales_return")
                {
                    IsOpen = true;
                    f.Focus();
                    break;

                }
            }
            if (IsOpen == false)
            {
                sales_return f2 = new sales_return();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void menuStrip4_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "purchase_detail")
                {
                    IsOpen = true;
                    f.Focus();
                    break;

                }
            }
            if (IsOpen == false)
            {
                purchase_detail f2 = new purchase_detail();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "sales_details")
                {
                    IsOpen = true;
                    f.Focus();
                    break;

                }
            }
            if (IsOpen == false)
            {
                sales_details f2 = new sales_details();
                f2.MdiParent = this;
                f2.Show();
            }

        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Process p = new Process();   
            p.StartInfo = new ProcessStartInfo("notepad.exe");
            p.Start();
            StartPosition = FormStartPosition.CenterScreen;
           
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            
           Process.Start("Calc");

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "purchase_return")
                {
                    IsOpen = true;
                    f.Focus();
                    break;

                }
            }
            if (IsOpen == false)
            {
                purchase_return f2 = new purchase_return();
                f2.MdiParent = this;
                f2.Show();
            }
            
         }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "stock_detail")
                {
                    IsOpen = true;
                    f.Focus();
                    break;

                }
            }
            if (IsOpen == false)
            {
               stock_detail f2 = new stock_detail();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "change password")
                {
                    IsOpen = true;
                    f.Focus();
                    break;

                }
            }
            if (IsOpen == false)
            {
                change_password f2 = new change_password();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void mASTERToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do you realy want to exit?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
                    
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {

            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "about_us")
                {
                    IsOpen = true;
                    f.Focus();
                    break;

                }
            }
            if (IsOpen == false)
            {
               about_us f2 = new about_us();
                f2.MdiParent = this;
                f2.Show();
            }

        }

        private void salesDetailReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "sales_report")
                {
                    IsOpen = true;
                    f.Focus();
                    break;

                }
            }
            if (IsOpen == false)
            {
                sales_report f2 = new sales_report();
                f2.MdiParent = this;
                f2.Show();
            }

        }

        private void itemMasterReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "item_master_reportr")
                {
                    IsOpen = true;
                    f.Focus();
                    break;

                }
            }
            if (IsOpen == false)
            {
                item_master_reportr f2 = new item_master_reportr();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void dealerMasterReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "supplier_report")
                {
                    IsOpen = true;
                    f.Focus();
                    break;

                }
            }
            if (IsOpen == false)
            {
                supplier_report f2 = new supplier_report();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void purchaseDetailReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "purchase_report")
                {
                    IsOpen = true;
                    f.Focus();
                    break;

                }
            }
            if (IsOpen == false)
            {
               purchase_report f2 = new purchase_report();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void purchaseReturnReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "purchase_return_report")
                {
                    IsOpen = true;
                    f.Focus();
                    break;

                }
            }
            if (IsOpen == false)
            {
               purchase_return_report f2 = new purchase_return_report();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void salesRetunReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "sales_return_report")
                {
                    IsOpen = true;
                    f.Focus();
                    break;

                }
            }
            if (IsOpen == false)
            {
                sales_return_report f2 = new sales_return_report();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void stockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "stock_detail_report")
                {
                    IsOpen = true;
                    f.Focus();
                    break;

                }
            }
            if (IsOpen == false)
            {
                stock_detail_report f2 = new stock_detail_report();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void customerMasterReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "customer_report")
                {
                    IsOpen = true;
                    f.Focus();
                    break;

                }
            }
            if (IsOpen == false)
            {
                customer_report f2 = new customer_report();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        }
    }


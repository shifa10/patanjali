namespace my_project
{
    partial class stock_detail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stock_detail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labltime = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.b_inm = new System.Windows.Forms.ComboBox();
            this.b_idd = new System.Windows.Forms.ComboBox();
            this.b_all = new System.Windows.Forms.RadioButton();
            this.b_nm = new System.Windows.Forms.RadioButton();
            this.b_id = new System.Windows.Forms.RadioButton();
            this.exir = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.labltime);
            this.panel1.Controls.Add(this.lbldate);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 138);
            this.panel1.TabIndex = 37;
            // 
            // labltime
            // 
            this.labltime.AutoSize = true;
            this.labltime.BackColor = System.Drawing.Color.Transparent;
            this.labltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labltime.ForeColor = System.Drawing.Color.White;
            this.labltime.Location = new System.Drawing.Point(888, 92);
            this.labltime.Name = "labltime";
            this.labltime.Size = new System.Drawing.Size(82, 25);
            this.labltime.TabIndex = 12;
            this.labltime.Text = "label20";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.Transparent;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.White;
            this.lbldate.Location = new System.Drawing.Point(888, 28);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(82, 25);
            this.lbldate.TabIndex = 11;
            this.lbldate.Text = "label19";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(35, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.label1);
            this.panel8.Location = new System.Drawing.Point(283, 24);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(575, 100);
            this.panel8.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "STOCK DETAILS";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Bright", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(14, 493);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1109, 178);
            this.dataGridView1.TabIndex = 72;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.b_inm);
            this.panel2.Controls.Add(this.b_idd);
            this.panel2.Controls.Add(this.b_all);
            this.panel2.Controls.Add(this.b_nm);
            this.panel2.Controls.Add(this.b_id);
            this.panel2.Controls.Add(this.exir);
            this.panel2.Controls.Add(this.show);
            this.panel2.Location = new System.Drawing.Point(227, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 313);
            this.panel2.TabIndex = 90;
            // 
            // b_inm
            // 
            this.b_inm.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_inm.ForeColor = System.Drawing.Color.Green;
            this.b_inm.FormattingEnabled = true;
            this.b_inm.Location = new System.Drawing.Point(390, 83);
            this.b_inm.Name = "b_inm";
            this.b_inm.Size = new System.Drawing.Size(269, 35);
            this.b_inm.TabIndex = 88;
            this.b_inm.SelectedIndexChanged += new System.EventHandler(this.b_inm_SelectedIndexChanged);
            // 
            // b_idd
            // 
            this.b_idd.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_idd.ForeColor = System.Drawing.Color.Green;
            this.b_idd.FormattingEnabled = true;
            this.b_idd.Location = new System.Drawing.Point(390, 11);
            this.b_idd.Name = "b_idd";
            this.b_idd.Size = new System.Drawing.Size(269, 35);
            this.b_idd.TabIndex = 87;
            // 
            // b_all
            // 
            this.b_all.AutoSize = true;
            this.b_all.Font = new System.Drawing.Font("Lucida Bright", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_all.ForeColor = System.Drawing.Color.Green;
            this.b_all.Location = new System.Drawing.Point(54, 168);
            this.b_all.Name = "b_all";
            this.b_all.Size = new System.Drawing.Size(119, 37);
            this.b_all.TabIndex = 10;
            this.b_all.TabStop = true;
            this.b_all.Text = "By all";
            this.b_all.UseVisualStyleBackColor = true;
            this.b_all.CheckedChanged += new System.EventHandler(this.b_all_CheckedChanged_1);
            // 
            // b_nm
            // 
            this.b_nm.AutoSize = true;
            this.b_nm.Font = new System.Drawing.Font("Lucida Bright", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_nm.ForeColor = System.Drawing.Color.Green;
            this.b_nm.Location = new System.Drawing.Point(53, 83);
            this.b_nm.Name = "b_nm";
            this.b_nm.Size = new System.Drawing.Size(222, 37);
            this.b_nm.TabIndex = 9;
            this.b_nm.TabStop = true;
            this.b_nm.Text = "By itemname";
            this.b_nm.UseVisualStyleBackColor = true;
            this.b_nm.CheckedChanged += new System.EventHandler(this.b_nm_CheckedChanged_1);
            // 
            // b_id
            // 
            this.b_id.AutoSize = true;
            this.b_id.Font = new System.Drawing.Font("Lucida Bright", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_id.ForeColor = System.Drawing.Color.Green;
            this.b_id.Location = new System.Drawing.Point(53, 7);
            this.b_id.Name = "b_id";
            this.b_id.Size = new System.Drawing.Size(119, 37);
            this.b_id.TabIndex = 6;
            this.b_id.TabStop = true;
            this.b_id.Text = "By  id";
            this.b_id.UseVisualStyleBackColor = true;
            this.b_id.CheckedChanged += new System.EventHandler(this.b_id_CheckedChanged_1);
            // 
            // exir
            // 
            this.exir.BackColor = System.Drawing.Color.Green;
            this.exir.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exir.ForeColor = System.Drawing.Color.White;
            this.exir.Location = new System.Drawing.Point(528, 219);
            this.exir.Name = "exir";
            this.exir.Size = new System.Drawing.Size(131, 66);
            this.exir.TabIndex = 5;
            this.exir.Text = "Exit";
            this.exir.UseVisualStyleBackColor = false;
            this.exir.Click += new System.EventHandler(this.exir_Click);
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.Green;
            this.show.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.ForeColor = System.Drawing.Color.White;
            this.show.Location = new System.Drawing.Point(331, 221);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(132, 66);
            this.show.TabIndex = 4;
            this.show.Text = "Show";
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.show_Click_1);
            // 
            // stock_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1135, 676);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "stock_detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " stock_detail";
            this.Load += new System.EventHandler(this.stock_detail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labltime;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox b_inm;
        private System.Windows.Forms.ComboBox b_idd;
        private System.Windows.Forms.RadioButton b_all;
        private System.Windows.Forms.RadioButton b_nm;
        private System.Windows.Forms.RadioButton b_id;
        private System.Windows.Forms.Button exir;
        private System.Windows.Forms.Button show;
    }
}
namespace my_project
{
    partial class customer_master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer_master));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.c_cmdid = new System.Windows.Forms.RadioButton();
            this.c_cmdnm = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtnm = new System.Windows.Forms.TextBox();
            this.cmd_id = new System.Windows.Forms.ComboBox();
            this.i_savee = new System.Windows.Forms.Button();
            this.i_delete = new System.Windows.Forms.Button();
            this.i_edit = new System.Windows.Forms.Button();
            this.i_ins = new System.Windows.Forms.Button();
            this.i_cancel = new System.Windows.Forms.Button();
            this.i_exit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbdate = new System.Windows.Forms.Label();
            this.lbtime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.i_privious = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.i_last = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.i_next = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.i_fclick = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bill_Pcmd = new System.Windows.Forms.ComboBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.c_pin = new System.Windows.Forms.TextBox();
            this.c_add = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.c_nm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.c_id = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 31);
            this.label11.TabIndex = 0;
            this.label11.Text = "search by:";
            // 
            // c_cmdid
            // 
            this.c_cmdid.AutoSize = true;
            this.c_cmdid.BackColor = System.Drawing.Color.Transparent;
            this.c_cmdid.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_cmdid.ForeColor = System.Drawing.Color.White;
            this.c_cmdid.Location = new System.Drawing.Point(50, 65);
            this.c_cmdid.Name = "c_cmdid";
            this.c_cmdid.Size = new System.Drawing.Size(110, 35);
            this.c_cmdid.TabIndex = 20;
            this.c_cmdid.TabStop = true;
            this.c_cmdid.Text = "By id";
            this.c_cmdid.UseVisualStyleBackColor = false;
            this.c_cmdid.CheckedChanged += new System.EventHandler(this.c_cmdid_CheckedChanged);
            // 
            // c_cmdnm
            // 
            this.c_cmdnm.AutoSize = true;
            this.c_cmdnm.BackColor = System.Drawing.Color.Transparent;
            this.c_cmdnm.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_cmdnm.ForeColor = System.Drawing.Color.White;
            this.c_cmdnm.Location = new System.Drawing.Point(203, 65);
            this.c_cmdnm.Name = "c_cmdnm";
            this.c_cmdnm.Size = new System.Drawing.Size(159, 35);
            this.c_cmdnm.TabIndex = 21;
            this.c_cmdnm.TabStop = true;
            this.c_cmdnm.Text = "By name";
            this.c_cmdnm.UseVisualStyleBackColor = false;
            this.c_cmdnm.CheckedChanged += new System.EventHandler(this.c_cmdnm_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(380, 65);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 35);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "All";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Controls.Add(this.txtnm);
            this.panel5.Controls.Add(this.cmd_id);
            this.panel5.Controls.Add(this.radioButton1);
            this.panel5.Controls.Add(this.c_cmdnm);
            this.panel5.Controls.Add(this.c_cmdid);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(558, 372);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(520, 157);
            this.panel5.TabIndex = 9;
            // 
            // txtnm
            // 
            this.txtnm.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnm.ForeColor = System.Drawing.Color.Green;
            this.txtnm.Location = new System.Drawing.Point(224, 110);
            this.txtnm.Name = "txtnm";
            this.txtnm.Size = new System.Drawing.Size(139, 31);
            this.txtnm.TabIndex = 37;
            this.txtnm.TextChanged += new System.EventHandler(this.txtnm_TextChanged);
            // 
            // cmd_id
            // 
            this.cmd_id.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_id.FormattingEnabled = true;
            this.cmd_id.Location = new System.Drawing.Point(44, 111);
            this.cmd_id.Name = "cmd_id";
            this.cmd_id.Size = new System.Drawing.Size(121, 31);
            this.cmd_id.TabIndex = 6;
            this.cmd_id.SelectedIndexChanged += new System.EventHandler(this.cmd_id_SelectedIndexChanged);
            // 
            // i_savee
            // 
            this.i_savee.BackColor = System.Drawing.Color.White;
            this.i_savee.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i_savee.ForeColor = System.Drawing.Color.Green;
            this.i_savee.Location = new System.Drawing.Point(200, 19);
            this.i_savee.Name = "i_savee";
            this.i_savee.Size = new System.Drawing.Size(120, 50);
            this.i_savee.TabIndex = 0;
            this.i_savee.Text = "save";
            this.i_savee.UseVisualStyleBackColor = false;
            this.i_savee.Click += new System.EventHandler(this.i_savee_Click);
            // 
            // i_delete
            // 
            this.i_delete.BackColor = System.Drawing.Color.White;
            this.i_delete.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i_delete.ForeColor = System.Drawing.Color.Green;
            this.i_delete.Location = new System.Drawing.Point(198, 94);
            this.i_delete.Name = "i_delete";
            this.i_delete.Size = new System.Drawing.Size(120, 50);
            this.i_delete.TabIndex = 1;
            this.i_delete.Text = "Delete";
            this.i_delete.UseVisualStyleBackColor = false;
            this.i_delete.Click += new System.EventHandler(this.i_delete_Click);
            // 
            // i_edit
            // 
            this.i_edit.BackColor = System.Drawing.Color.White;
            this.i_edit.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i_edit.ForeColor = System.Drawing.Color.Green;
            this.i_edit.Location = new System.Drawing.Point(23, 94);
            this.i_edit.Name = "i_edit";
            this.i_edit.Size = new System.Drawing.Size(120, 50);
            this.i_edit.TabIndex = 2;
            this.i_edit.Text = "Edit";
            this.i_edit.UseVisualStyleBackColor = false;
            this.i_edit.Click += new System.EventHandler(this.i_edit_Click);
            // 
            // i_ins
            // 
            this.i_ins.BackColor = System.Drawing.Color.White;
            this.i_ins.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i_ins.ForeColor = System.Drawing.Color.Green;
            this.i_ins.Location = new System.Drawing.Point(23, 19);
            this.i_ins.Name = "i_ins";
            this.i_ins.Size = new System.Drawing.Size(120, 50);
            this.i_ins.TabIndex = 3;
            this.i_ins.Text = "insert";
            this.i_ins.UseVisualStyleBackColor = false;
            this.i_ins.Click += new System.EventHandler(this.i_ins_Click);
            // 
            // i_cancel
            // 
            this.i_cancel.BackColor = System.Drawing.Color.White;
            this.i_cancel.FlatAppearance.BorderSize = 0;
            this.i_cancel.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i_cancel.ForeColor = System.Drawing.Color.Green;
            this.i_cancel.Location = new System.Drawing.Point(370, 19);
            this.i_cancel.Name = "i_cancel";
            this.i_cancel.Size = new System.Drawing.Size(120, 50);
            this.i_cancel.TabIndex = 4;
            this.i_cancel.Text = "Cancel";
            this.i_cancel.UseVisualStyleBackColor = false;
            this.i_cancel.Click += new System.EventHandler(this.i_cancel_Click);
            // 
            // i_exit
            // 
            this.i_exit.BackColor = System.Drawing.Color.White;
            this.i_exit.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i_exit.ForeColor = System.Drawing.Color.Green;
            this.i_exit.Location = new System.Drawing.Point(370, 92);
            this.i_exit.Name = "i_exit";
            this.i_exit.Size = new System.Drawing.Size(120, 50);
            this.i_exit.TabIndex = 5;
            this.i_exit.Text = "Exit";
            this.i_exit.UseVisualStyleBackColor = false;
            this.i_exit.Click += new System.EventHandler(this.i_exit_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.i_exit);
            this.panel4.Controls.Add(this.i_cancel);
            this.panel4.Controls.Add(this.i_ins);
            this.panel4.Controls.Add(this.i_edit);
            this.panel4.Controls.Add(this.i_delete);
            this.panel4.Controls.Add(this.i_savee);
            this.panel4.Location = new System.Drawing.Point(18, 371);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(520, 157);
            this.panel4.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(304, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUSTOMER MASTER";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(44, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // lbdate
            // 
            this.lbdate.AutoSize = true;
            this.lbdate.BackColor = System.Drawing.Color.Transparent;
            this.lbdate.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdate.ForeColor = System.Drawing.Color.White;
            this.lbdate.Location = new System.Drawing.Point(905, 36);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(16, 23);
            this.lbdate.TabIndex = 13;
            this.lbdate.Text = "l";
            // 
            // lbtime
            // 
            this.lbtime.AutoSize = true;
            this.lbtime.BackColor = System.Drawing.Color.Transparent;
            this.lbtime.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtime.ForeColor = System.Drawing.Color.White;
            this.lbtime.Location = new System.Drawing.Point(905, 100);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(82, 23);
            this.lbtime.TabIndex = 14;
            this.lbtime.Text = "label20";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lbtime);
            this.panel1.Controls.Add(this.lbdate);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 138);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.panel15);
            this.panel7.Controls.Add(this.panel13);
            this.panel7.Controls.Add(this.panel14);
            this.panel7.Controls.Add(this.panel16);
            this.panel7.Location = new System.Drawing.Point(231, 535);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(721, 69);
            this.panel7.TabIndex = 70;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Controls.Add(this.i_privious);
            this.panel15.Controls.Add(this.pictureBox8);
            this.panel15.Location = new System.Drawing.Point(379, 14);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(143, 42);
            this.panel15.TabIndex = 63;
            // 
            // i_privious
            // 
            this.i_privious.AutoSize = true;
            this.i_privious.BackColor = System.Drawing.Color.Transparent;
            this.i_privious.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i_privious.ForeColor = System.Drawing.Color.Green;
            this.i_privious.Location = new System.Drawing.Point(6, 8);
            this.i_privious.Name = "i_privious";
            this.i_privious.Size = new System.Drawing.Size(94, 23);
            this.i_privious.TabIndex = 0;
            this.i_privious.Text = "privious";
            this.i_privious.Click += new System.EventHandler(this.i_privious_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(107, 7);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 29);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 54;
            this.pictureBox8.TabStop = false;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.i_last);
            this.panel13.Controls.Add(this.pictureBox5);
            this.panel13.Location = new System.Drawing.Point(558, 14);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(143, 42);
            this.panel13.TabIndex = 61;
            // 
            // i_last
            // 
            this.i_last.AutoSize = true;
            this.i_last.BackColor = System.Drawing.Color.Transparent;
            this.i_last.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i_last.ForeColor = System.Drawing.Color.Green;
            this.i_last.Location = new System.Drawing.Point(18, 8);
            this.i_last.Name = "i_last";
            this.i_last.Size = new System.Drawing.Size(45, 23);
            this.i_last.TabIndex = 0;
            this.i_last.Text = "last";
            this.i_last.Click += new System.EventHandler(this.i_last_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(101, 7);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 29);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 54;
            this.pictureBox5.TabStop = false;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.i_next);
            this.panel14.Controls.Add(this.pictureBox7);
            this.panel14.Location = new System.Drawing.Point(200, 14);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(143, 42);
            this.panel14.TabIndex = 62;
            // 
            // i_next
            // 
            this.i_next.AutoSize = true;
            this.i_next.BackColor = System.Drawing.Color.Transparent;
            this.i_next.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i_next.ForeColor = System.Drawing.Color.Green;
            this.i_next.Location = new System.Drawing.Point(23, 8);
            this.i_next.Name = "i_next";
            this.i_next.Size = new System.Drawing.Size(54, 23);
            this.i_next.TabIndex = 0;
            this.i_next.Text = "next";
            this.i_next.Click += new System.EventHandler(this.i_next_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(94, 7);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 29);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 54;
            this.pictureBox7.TabStop = false;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.Controls.Add(this.i_fclick);
            this.panel16.Controls.Add(this.pictureBox9);
            this.panel16.Location = new System.Drawing.Point(10, 14);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(143, 42);
            this.panel16.TabIndex = 60;
            // 
            // i_fclick
            // 
            this.i_fclick.AutoSize = true;
            this.i_fclick.BackColor = System.Drawing.Color.Transparent;
            this.i_fclick.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i_fclick.ForeColor = System.Drawing.Color.Green;
            this.i_fclick.Location = new System.Drawing.Point(18, 8);
            this.i_fclick.Name = "i_fclick";
            this.i_fclick.Size = new System.Drawing.Size(55, 23);
            this.i_fclick.TabIndex = 0;
            this.i_fclick.Text = "First";
            this.i_fclick.Click += new System.EventHandler(this.i_fclick_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.White;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(101, 7);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 29);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 54;
            this.pictureBox9.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.bill_Pcmd);
            this.panel3.Controls.Add(this.contact);
            this.panel3.Controls.Add(this.c_pin);
            this.panel3.Controls.Add(this.c_add);
            this.panel3.Controls.Add(this.email);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.c_nm);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.c_id);
            this.panel3.Location = new System.Drawing.Point(24, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1063, 226);
            this.panel3.TabIndex = 71;
            // 
            // bill_Pcmd
            // 
            this.bill_Pcmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_Pcmd.ForeColor = System.Drawing.Color.Green;
            this.bill_Pcmd.FormattingEnabled = true;
            this.bill_Pcmd.Location = new System.Drawing.Point(76, 62);
            this.bill_Pcmd.Name = "bill_Pcmd";
            this.bill_Pcmd.Size = new System.Drawing.Size(244, 34);
            this.bill_Pcmd.TabIndex = 96;
            // 
            // contact
            // 
            this.contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.ForeColor = System.Drawing.Color.Green;
            this.contact.Location = new System.Drawing.Point(415, 165);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(249, 35);
            this.contact.TabIndex = 95;
            // 
            // c_pin
            // 
            this.c_pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_pin.ForeColor = System.Drawing.Color.Green;
            this.c_pin.Location = new System.Drawing.Point(77, 168);
            this.c_pin.Name = "c_pin";
            this.c_pin.Size = new System.Drawing.Size(251, 35);
            this.c_pin.TabIndex = 94;
            // 
            // c_add
            // 
            this.c_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_add.ForeColor = System.Drawing.Color.Green;
            this.c_add.Location = new System.Drawing.Point(758, 59);
            this.c_add.Name = "c_add";
            this.c_add.Size = new System.Drawing.Size(226, 35);
            this.c_add.TabIndex = 93;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.Green;
            this.email.Location = new System.Drawing.Point(766, 161);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(226, 35);
            this.email.TabIndex = 92;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(763, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 27);
            this.label9.TabIndex = 91;
            this.label9.Text = "Email id:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(410, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 27);
            this.label8.TabIndex = 90;
            this.label8.Text = "Contact no.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(71, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 27);
            this.label7.TabIndex = 89;
            this.label7.Text = "Pin code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(763, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 27);
            this.label6.TabIndex = 88;
            this.label6.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(410, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 27);
            this.label5.TabIndex = 86;
            this.label5.Text = "Customer Name:";
            // 
            // c_nm
            // 
            this.c_nm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_nm.ForeColor = System.Drawing.Color.Green;
            this.c_nm.Location = new System.Drawing.Point(415, 64);
            this.c_nm.Name = "c_nm";
            this.c_nm.Size = new System.Drawing.Size(249, 35);
            this.c_nm.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(72, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 27);
            this.label4.TabIndex = 84;
            this.label4.Text = "Customer id:";
            // 
            // c_id
            // 
            this.c_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_id.ForeColor = System.Drawing.Color.Green;
            this.c_id.Location = new System.Drawing.Point(76, 64);
            this.c_id.Name = "c_id";
            this.c_id.Size = new System.Drawing.Size(252, 35);
            this.c_id.TabIndex = 85;
            this.c_id.Text = " ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Bright", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 610);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1112, 237);
            this.dataGridView1.TabIndex = 72;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // customer_master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1122, 779);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "customer_master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.customer_master_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton c_cmdid;
        private System.Windows.Forms.RadioButton c_cmdnm;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button i_savee;
        private System.Windows.Forms.Button i_delete;
        private System.Windows.Forms.Button i_edit;
        private System.Windows.Forms.Button i_ins;
        private System.Windows.Forms.Button i_cancel;
        private System.Windows.Forms.Button i_exit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label i_last;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label i_next;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label i_fclick;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.ComboBox cmd_id;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label i_privious;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TextBox txtnm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox bill_Pcmd;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.TextBox c_pin;
        private System.Windows.Forms.TextBox c_add;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox c_nm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox c_id;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}
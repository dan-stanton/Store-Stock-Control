namespace NewStores
{
    partial class MainMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.dragme = new System.Windows.Forms.Panel();
            this.MainForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.currentuser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Stats = new System.Windows.Forms.DataGridView();
            this.Statistics1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NewUserBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.CheckBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logout = new System.Windows.Forms.Button();
            this.NewEntry = new System.Windows.Forms.Button();
            this.Logs = new System.Windows.Forms.Button();
            this.Suppliers = new System.Windows.Forms.Button();
            this.Groups = new System.Windows.Forms.Button();
            this.Products = new System.Windows.Forms.Button();
            this.RefreshStats = new System.Windows.Forms.Timer(this.components);
            this.dragme.SuspendLayout();
            this.MainForm.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stats)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dragme
            // 
            this.dragme.Controls.Add(this.Logout);
            this.dragme.Controls.Add(this.NewEntry);
            this.dragme.Controls.Add(this.Logs);
            this.dragme.Controls.Add(this.Suppliers);
            this.dragme.Controls.Add(this.Groups);
            this.dragme.Controls.Add(this.Products);
            this.dragme.Dock = System.Windows.Forms.DockStyle.Top;
            this.dragme.Location = new System.Drawing.Point(0, 0);
            this.dragme.Name = "dragme";
            this.dragme.Size = new System.Drawing.Size(1056, 100);
            this.dragme.TabIndex = 0;
            // 
            // MainForm
            // 
            this.MainForm.BackColor = System.Drawing.Color.White;
            this.MainForm.Controls.Add(this.label10);
            this.MainForm.Controls.Add(this.button6);
            this.MainForm.Controls.Add(this.panel1);
            this.MainForm.Controls.Add(this.label6);
            this.MainForm.Controls.Add(this.button5);
            this.MainForm.Controls.Add(this.label4);
            this.MainForm.Controls.Add(this.button4);
            this.MainForm.Controls.Add(this.button3);
            this.MainForm.Controls.Add(this.richTextBox1);
            this.MainForm.Controls.Add(this.label5);
            this.MainForm.Controls.Add(this.groupBox1);
            this.MainForm.Controls.Add(this.button1);
            this.MainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm.Location = new System.Drawing.Point(0, 100);
            this.MainForm.Name = "MainForm";
            this.MainForm.Size = new System.Drawing.Size(1056, 728);
            this.MainForm.TabIndex = 2;
            this.MainForm.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.currentuser);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.Stats);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 728);
            this.panel1.TabIndex = 25;
            // 
            // currentuser
            // 
            this.currentuser.AutoSize = true;
            this.currentuser.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.currentuser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.currentuser.Location = new System.Drawing.Point(113, 704);
            this.currentuser.Name = "currentuser";
            this.currentuser.Size = new System.Drawing.Size(35, 15);
            this.currentuser.TabIndex = 22;
            this.currentuser.Text = "null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.label3.Location = new System.Drawing.Point(9, 704);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Current User:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(58, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Stores System";
            // 
            // Stats
            // 
            this.Stats.AllowUserToAddRows = false;
            this.Stats.AllowUserToDeleteRows = false;
            this.Stats.AllowUserToResizeColumns = false;
            this.Stats.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.Stats.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.Stats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Stats.BackgroundColor = System.Drawing.Color.White;
            this.Stats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Stats.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Stats.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Stats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.Stats.ColumnHeadersHeight = 21;
            this.Stats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Stats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Statistics1,
            this.Data1});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Stats.DefaultCellStyle = dataGridViewCellStyle11;
            this.Stats.EnableHeadersVisualStyles = false;
            this.Stats.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Stats.Location = new System.Drawing.Point(12, 156);
            this.Stats.MultiSelect = false;
            this.Stats.Name = "Stats";
            this.Stats.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Stats.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.Stats.RowHeadersVisible = false;
            this.Stats.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Stats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Stats.Size = new System.Drawing.Size(211, 109);
            this.Stats.TabIndex = 2;
            // 
            // Statistics1
            // 
            this.Statistics1.HeaderText = "Statistics";
            this.Statistics1.Name = "Statistics1";
            this.Statistics1.ReadOnly = true;
            this.Statistics1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Data1
            // 
            this.Data1.HeaderText = "";
            this.Data1.Name = "Data1";
            this.Data1.ReadOnly = true;
            this.Data1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.label6.Location = new System.Drawing.Point(419, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(329, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "UPDATE Products SET Stock = 0 WHERE Stock < 0;";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.button5.Location = new System.Drawing.Point(254, 156);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 44);
            this.button5.TabIndex = 23;
            this.button5.Text = "Fix negative stock";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.label4.Location = new System.Drawing.Point(419, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(469, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Sends an email to store admins showing stock thats in the negative";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.button4.Location = new System.Drawing.Point(254, 85);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 44);
            this.button4.TabIndex = 21;
            this.button4.Text = "Negative Stock";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.button3.Location = new System.Drawing.Point(891, 666);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 38);
            this.button3.TabIndex = 20;
            this.button3.Text = "Update Notes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.richTextBox1.Location = new System.Drawing.Point(254, 460);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(772, 200);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.label5.Location = new System.Drawing.Point(419, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Force low stock email";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.groupBox1.Location = new System.Drawing.Point(254, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 238);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Accounts";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.groupBox3.Location = new System.Drawing.Point(314, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 217);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Account";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.button2.Location = new System.Drawing.Point(41, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Delete User";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 23);
            this.comboBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choose user or place RFID tag";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.NewUserBtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Admin);
            this.groupBox2.Controls.Add(this.Username);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Password);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.groupBox2.Location = new System.Drawing.Point(6, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 217);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Account";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.label9.Location = new System.Drawing.Point(12, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Choose user or place RFID tag";
            // 
            // NewUserBtn
            // 
            this.NewUserBtn.Enabled = false;
            this.NewUserBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.NewUserBtn.Location = new System.Drawing.Point(13, 156);
            this.NewUserBtn.Name = "NewUserBtn";
            this.NewUserBtn.Size = new System.Drawing.Size(137, 45);
            this.NewUserBtn.TabIndex = 1;
            this.NewUserBtn.Text = "New User";
            this.NewUserBtn.UseVisualStyleBackColor = true;
            this.NewUserBtn.Click += new System.EventHandler(this.NewUserBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Location = new System.Drawing.Point(15, 131);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(61, 19);
            this.Admin.TabIndex = 8;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(13, 61);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(196, 23);
            this.Username.TabIndex = 2;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.label8.Location = new System.Drawing.Point(13, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Password";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(13, 102);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(196, 23);
            this.Password.TabIndex = 6;
            this.Password.UseSystemPasswordChar = true;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.button1.Location = new System.Drawing.Point(254, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 44);
            this.button1.TabIndex = 16;
            this.button1.Text = "Low Stock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.button6.Location = new System.Drawing.Point(609, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(159, 44);
            this.button6.TabIndex = 26;
            this.button6.Text = "SQL Query";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(771, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(238, 30);
            this.label10.TabIndex = 27;
            this.label10.Text = "Please dont use \r\nunless you know what you\'re doing\r\n";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::NewStores.Properties.Resources.Wye_Valley_Group_Retina;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 6);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(211, 90);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.LightCoral;
            this.Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Logout.Dock = System.Windows.Forms.DockStyle.Left;
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Logout.ForeColor = System.Drawing.Color.White;
            this.Logout.Image = global::NewStores.Properties.Resources.account_logout_64;
            this.Logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Logout.Location = new System.Drawing.Point(920, 0);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(136, 100);
            this.Logout.TabIndex = 16;
            this.Logout.Text = "Logout";
            this.Logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // NewEntry
            // 
            this.NewEntry.BackColor = System.Drawing.Color.Black;
            this.NewEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NewEntry.Dock = System.Windows.Forms.DockStyle.Left;
            this.NewEntry.FlatAppearance.BorderSize = 0;
            this.NewEntry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.NewEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewEntry.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.NewEntry.ForeColor = System.Drawing.Color.White;
            this.NewEntry.Image = global::NewStores.Properties.Resources.plus_5_64;
            this.NewEntry.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NewEntry.Location = new System.Drawing.Point(736, 0);
            this.NewEntry.Name = "NewEntry";
            this.NewEntry.Size = new System.Drawing.Size(184, 100);
            this.NewEntry.TabIndex = 12;
            this.NewEntry.Text = "New Entry";
            this.NewEntry.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NewEntry.UseVisualStyleBackColor = false;
            this.NewEntry.Click += new System.EventHandler(this.NewEntry_Click);
            // 
            // Logs
            // 
            this.Logs.BackColor = System.Drawing.Color.Black;
            this.Logs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Logs.Dock = System.Windows.Forms.DockStyle.Left;
            this.Logs.FlatAppearance.BorderSize = 0;
            this.Logs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Logs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Logs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logs.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Logs.ForeColor = System.Drawing.Color.White;
            this.Logs.Image = global::NewStores.Properties.Resources.clipboard_4_64__1_;
            this.Logs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Logs.Location = new System.Drawing.Point(552, 0);
            this.Logs.Name = "Logs";
            this.Logs.Size = new System.Drawing.Size(184, 100);
            this.Logs.TabIndex = 11;
            this.Logs.Text = "Logs";
            this.Logs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Logs.UseVisualStyleBackColor = false;
            this.Logs.Click += new System.EventHandler(this.Logs_Click);
            // 
            // Suppliers
            // 
            this.Suppliers.BackColor = System.Drawing.Color.Black;
            this.Suppliers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Suppliers.Dock = System.Windows.Forms.DockStyle.Left;
            this.Suppliers.FlatAppearance.BorderSize = 0;
            this.Suppliers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Suppliers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Suppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Suppliers.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Suppliers.ForeColor = System.Drawing.Color.White;
            this.Suppliers.Image = global::NewStores.Properties.Resources.conference_64;
            this.Suppliers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Suppliers.Location = new System.Drawing.Point(368, 0);
            this.Suppliers.Name = "Suppliers";
            this.Suppliers.Size = new System.Drawing.Size(184, 100);
            this.Suppliers.TabIndex = 10;
            this.Suppliers.Text = "Suppliers";
            this.Suppliers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Suppliers.UseVisualStyleBackColor = false;
            this.Suppliers.Click += new System.EventHandler(this.Suppliers_Click);
            // 
            // Groups
            // 
            this.Groups.BackColor = System.Drawing.Color.Black;
            this.Groups.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Groups.Dock = System.Windows.Forms.DockStyle.Left;
            this.Groups.FlatAppearance.BorderSize = 0;
            this.Groups.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Groups.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Groups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Groups.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Groups.ForeColor = System.Drawing.Color.White;
            this.Groups.Image = ((System.Drawing.Image)(resources.GetObject("Groups.Image")));
            this.Groups.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Groups.Location = new System.Drawing.Point(184, 0);
            this.Groups.Name = "Groups";
            this.Groups.Size = new System.Drawing.Size(184, 100);
            this.Groups.TabIndex = 8;
            this.Groups.Text = "Groups";
            this.Groups.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Groups.UseVisualStyleBackColor = false;
            this.Groups.Click += new System.EventHandler(this.Groups_Click);
            // 
            // Products
            // 
            this.Products.BackColor = System.Drawing.Color.Black;
            this.Products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Products.Dock = System.Windows.Forms.DockStyle.Left;
            this.Products.FlatAppearance.BorderSize = 0;
            this.Products.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Products.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Products.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Products.ForeColor = System.Drawing.Color.White;
            this.Products.Image = global::NewStores.Properties.Resources.product_64;
            this.Products.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Products.Location = new System.Drawing.Point(0, 0);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(184, 100);
            this.Products.TabIndex = 6;
            this.Products.Text = "Products";
            this.Products.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Products.UseVisualStyleBackColor = false;
            this.Products.Click += new System.EventHandler(this.Products_Click);
            // 
            // RefreshStats
            // 
            this.RefreshStats.Interval = 60000;
            this.RefreshStats.Tick += new System.EventHandler(this.RefreshStats_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 828);
            this.ControlBox = false;
            this.Controls.Add(this.MainForm);
            this.Controls.Add(this.dragme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1056, 828);
            this.MinimumSize = new System.Drawing.Size(1056, 828);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseDown);
            this.dragme.ResumeLayout(false);
            this.MainForm.ResumeLayout(false);
            this.MainForm.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stats)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel dragme;
        private System.Windows.Forms.PictureBox guna2PictureBox1;
        private System.Windows.Forms.Panel MainForm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Admin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NewUserBtn;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button NewEntry;
        private System.Windows.Forms.Button Logs;
        private System.Windows.Forms.Button Suppliers;
        private System.Windows.Forms.Button Groups;
        private System.Windows.Forms.Button Products;
        private System.Windows.Forms.DataGridView Stats;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label currentuser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statistics1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer RefreshStats;
    }
}
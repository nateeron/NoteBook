namespace NoteBook
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.List_data = new System.Windows.Forms.ListView();
            this.bt_add = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.list_Group = new System.Windows.Forms.ListBox();
            this.select_Group = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_reset = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.bt_copy_User = new System.Windows.Forms.Button();
            this.bt_copy_pass = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_shearch = new System.Windows.Forms.TextBox();
            this.bt_clearShearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // List_data
            // 
            this.List_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.List_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.List_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.List_data.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.List_data.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.List_data.Location = new System.Drawing.Point(159, 243);
            this.List_data.Name = "List_data";
            this.List_data.Size = new System.Drawing.Size(683, 544);
            this.List_data.TabIndex = 12;
            this.List_data.UseCompatibleStateImageBehavior = false;
            this.List_data.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.List_data.KeyDown += new System.Windows.Forms.KeyEventHandler(this.List_data_KeyDown);
            this.List_data.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.List_data_MouseDoubleClick);
            // 
            // bt_add
            // 
            this.bt_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_add.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bt_add.Location = new System.Drawing.Point(674, 208);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(71, 29);
            this.bt_add.TabIndex = 9;
            this.bt_add.Text = "Save";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Name.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_Name.Location = new System.Drawing.Point(103, 74);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(202, 18);
            this.txt_Name.TabIndex = 2;
            // 
            // txt_Path
            // 
            this.txt_Path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txt_Path.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Path.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Path.ForeColor = System.Drawing.Color.Orange;
            this.txt_Path.Location = new System.Drawing.Point(103, 100);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(739, 18);
            this.txt_Path.TabIndex = 3;
            // 
            // txt_User
            // 
            this.txt_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txt_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_User.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_User.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.txt_User.Location = new System.Drawing.Point(103, 126);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(202, 18);
            this.txt_User.TabIndex = 4;
            // 
            // txt_Pass
            // 
            this.txt_Pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txt_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Pass.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Pass.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.txt_Pass.Location = new System.Drawing.Point(103, 152);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(202, 18);
            this.txt_Pass.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.label1.Location = new System.Drawing.Point(53, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.label2.Location = new System.Drawing.Point(63, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.label3.Location = new System.Drawing.Point(33, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "UserLogin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.label4.Location = new System.Drawing.Point(64, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pass";
            // 
            // txt_desc
            // 
            this.txt_desc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txt_desc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_desc.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_desc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_desc.Location = new System.Drawing.Point(103, 178);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(743, 18);
            this.txt_desc.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.label5.Location = new System.Drawing.Point(22, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Description";
            // 
            // list_Group
            // 
            this.list_Group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.list_Group.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.list_Group.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_Group.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.list_Group.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.list_Group.FormattingEnabled = true;
            this.list_Group.ItemHeight = 17;
            this.list_Group.Location = new System.Drawing.Point(5, 243);
            this.list_Group.Name = "list_Group";
            this.list_Group.Size = new System.Drawing.Size(148, 544);
            this.list_Group.TabIndex = 11;
            this.list_Group.SelectedIndexChanged += new System.EventHandler(this.list_Group_SelectedIndexChanged);
            this.list_Group.KeyDown += new System.Windows.Forms.KeyEventHandler(this.list_Group_KeyDown);
            // 
            // select_Group
            // 
            this.select_Group.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.select_Group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_Group.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.select_Group.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.select_Group.FormattingEnabled = true;
            this.select_Group.Location = new System.Drawing.Point(103, 43);
            this.select_Group.Name = "select_Group";
            this.select_Group.Size = new System.Drawing.Size(202, 25);
            this.select_Group.TabIndex = 1;
            this.select_Group.SelectedIndexChanged += new System.EventHandler(this.select_Group_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.label6.Location = new System.Drawing.Point(53, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Group";
            // 
            // bt_reset
            // 
            this.bt_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_reset.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bt_reset.Location = new System.Drawing.Point(767, 208);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(77, 29);
            this.bt_reset.TabIndex = 10;
            this.bt_reset.Text = "Reset";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // txt_id
            // 
            this.txt_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_id.Location = new System.Drawing.Point(810, 40);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(38, 27);
            this.txt_id.TabIndex = 2;
            this.txt_id.Visible = false;
            // 
            // bt_copy_User
            // 
            this.bt_copy_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_copy_User.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_copy_User.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_copy_User.Location = new System.Drawing.Point(310, 123);
            this.bt_copy_User.Name = "bt_copy_User";
            this.bt_copy_User.Size = new System.Drawing.Size(36, 23);
            this.bt_copy_User.TabIndex = 5;
            this.bt_copy_User.Text = "Copy";
            this.bt_copy_User.UseVisualStyleBackColor = true;
            this.bt_copy_User.Click += new System.EventHandler(this.bt_copy_User_Click);
            // 
            // bt_copy_pass
            // 
            this.bt_copy_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_copy_pass.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_copy_pass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_copy_pass.Location = new System.Drawing.Point(310, 148);
            this.bt_copy_pass.Name = "bt_copy_pass";
            this.bt_copy_pass.Size = new System.Drawing.Size(36, 23);
            this.bt_copy_pass.TabIndex = 7;
            this.bt_copy_pass.Text = "Copy";
            this.bt_copy_pass.UseVisualStyleBackColor = true;
            this.bt_copy_pass.Click += new System.EventHandler(this.bt_copy_pass_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(813, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(771, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "O";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(729, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "_";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 36);
            this.panel1.TabIndex = 15;
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // txt_shearch
            // 
            this.txt_shearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txt_shearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_shearch.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_shearch.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.txt_shearch.Location = new System.Drawing.Point(3, 4);
            this.txt_shearch.Name = "txt_shearch";
            this.txt_shearch.Size = new System.Drawing.Size(207, 18);
            this.txt_shearch.TabIndex = 6;
            this.txt_shearch.TextChanged += new System.EventHandler(this.txt_shearch_TextChanged);
            // 
            // bt_clearShearch
            // 
            this.bt_clearShearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_clearShearch.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_clearShearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_clearShearch.Location = new System.Drawing.Point(378, 210);
            this.bt_clearShearch.Name = "bt_clearShearch";
            this.bt_clearShearch.Size = new System.Drawing.Size(36, 27);
            this.bt_clearShearch.TabIndex = 7;
            this.bt_clearShearch.Text = "De";
            this.bt_clearShearch.UseVisualStyleBackColor = true;
            this.bt_clearShearch.Click += new System.EventHandler(this.bt_clearShearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.txt_shearch);
            this.panel2.Location = new System.Drawing.Point(159, 210);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 27);
            this.panel2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.label7.Location = new System.Drawing.Point(8, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "V.0.1.2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(854, 789);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.select_Group);
            this.Controls.Add(this.list_Group);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.txt_Path);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.bt_clearShearch);
            this.Controls.Add(this.bt_copy_pass);
            this.Controls.Add(this.bt_copy_User);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.List_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NoteBook";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView List_data;
        private Button bt_add;
        private TextBox txt_Name;
        private TextBox txt_Path;
        private TextBox txt_User;
        private TextBox txt_Pass;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_desc;
        private Label label5;
        private ListBox list_Group;
        private ComboBox select_Group;
        private Label label6;
        private Button bt_reset;
        private TextBox txt_id;
        private Button bt_copy_User;
        private Button bt_copy_pass;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private TextBox txt_shearch;
        private Button bt_clearShearch;
        private Panel panel2;
        private Label label7;
    }
}
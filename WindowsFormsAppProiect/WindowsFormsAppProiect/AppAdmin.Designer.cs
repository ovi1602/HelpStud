namespace WindowsFormsAppProiect
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.updateCourse = new System.Windows.Forms.Button();
            this.deleteCourse = new System.Windows.Forms.Button();
            this.insertCourse = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxoldPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonName = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.linkSources = new System.Windows.Forms.LinkLabel();
            this.contentTextbox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listboxTitluriPostari = new System.Windows.Forms.ListBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 444);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::WindowsFormsAppProiect.Properties.Resources.bg;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.buttonRefresh);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxComment);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.linkSources);
            this.tabPage1.Controls.Add(this.contentTextbox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.listboxTitluriPostari);
            this.tabPage1.Controls.Add(this.updateCourse);
            this.tabPage1.Controls.Add(this.deleteCourse);
            this.tabPage1.Controls.Add(this.insertCourse);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.comboBox4);
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Wall";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // updateCourse
            // 
            this.updateCourse.Location = new System.Drawing.Point(408, 91);
            this.updateCourse.Name = "updateCourse";
            this.updateCourse.Size = new System.Drawing.Size(75, 23);
            this.updateCourse.TabIndex = 9;
            this.updateCourse.Text = "Update";
            this.updateCourse.UseVisualStyleBackColor = true;
            this.updateCourse.Click += new System.EventHandler(this.updateCourse_Click);
            // 
            // deleteCourse
            // 
            this.deleteCourse.Location = new System.Drawing.Point(408, 62);
            this.deleteCourse.Name = "deleteCourse";
            this.deleteCourse.Size = new System.Drawing.Size(75, 23);
            this.deleteCourse.TabIndex = 8;
            this.deleteCourse.Text = "Delete";
            this.deleteCourse.UseVisualStyleBackColor = true;
            this.deleteCourse.Click += new System.EventHandler(this.deleteCourse_Click);
            // 
            // insertCourse
            // 
            this.insertCourse.Location = new System.Drawing.Point(408, 33);
            this.insertCourse.Name = "insertCourse";
            this.insertCourse.Size = new System.Drawing.Size(75, 23);
            this.insertCourse.TabIndex = 7;
            this.insertCourse.Text = "Insert";
            this.insertCourse.UseVisualStyleBackColor = true;
            this.insertCourse.Click += new System.EventHandler(this.insertCourse_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(387, 6);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 3;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(260, 6);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged_1);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(133, 6);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::WindowsFormsAppProiect.Properties.Resources.bg;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.labelUser);
            this.tabPage2.Controls.Add(this.linkLabel1);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(787, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "My Account";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textBoxoldPassword);
            this.groupBox4.Controls.Add(this.textBoxNewPassword);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Location = new System.Drawing.Point(244, 313);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(302, 90);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Change Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Please introduce your old password!";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxoldPassword
            // 
            this.textBoxoldPassword.Location = new System.Drawing.Point(9, 38);
            this.textBoxoldPassword.Name = "textBoxoldPassword";
            this.textBoxoldPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxoldPassword.TabIndex = 3;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(9, 64);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewPassword.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(165, 44);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 25);
            this.button7.TabIndex = 1;
            this.button7.Text = "Modify";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxEmail);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.labelEmail);
            this.groupBox3.Location = new System.Drawing.Point(244, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 90);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Change Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(9, 44);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(165, 44);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 25);
            this.button6.TabIndex = 1;
            this.button6.Text = "Modify";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(6, 20);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "label2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxUsername);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.labelUsername);
            this.groupBox2.Location = new System.Drawing.Point(244, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 90);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Change Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(9, 44);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(165, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 25);
            this.button5.TabIndex = 1;
            this.button5.Text = "Modify";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(6, 20);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(35, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.buttonName);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Location = new System.Drawing.Point(244, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 90);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(9, 44);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // buttonName
            // 
            this.buttonName.Location = new System.Drawing.Point(165, 44);
            this.buttonName.Name = "buttonName";
            this.buttonName.Size = new System.Drawing.Size(70, 25);
            this.buttonName.TabIndex = 1;
            this.buttonName.Text = "Modify";
            this.buttonName.UseVisualStyleBackColor = true;
            this.buttonName.Click += new System.EventHandler(this.buttonName_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "label2";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(29, 90);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 25);
            this.button4.TabIndex = 5;
            this.button4.Text = "Change photo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.ForeColor = System.Drawing.Color.Red;
            this.labelUser.Location = new System.Drawing.Point(168, 24);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(35, 13);
            this.labelUser.TabIndex = 4;
            this.labelUser.Text = "label3";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(134, 51);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(46, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 60);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello, ";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(617, 327);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(101, 23);
            this.button8.TabIndex = 30;
            this.button8.Text = "Add a comment";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Comments";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(457, 327);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(125, 20);
            this.textBoxComment.TabIndex = 28;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(457, 168);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(243, 121);
            this.richTextBox1.TabIndex = 27;
            this.richTextBox1.Text = "";
            // 
            // linkSources
            // 
            this.linkSources.AutoSize = true;
            this.linkSources.Location = new System.Drawing.Point(141, 327);
            this.linkSources.Name = "linkSources";
            this.linkSources.Size = new System.Drawing.Size(55, 13);
            this.linkSources.TabIndex = 26;
            this.linkSources.TabStop = true;
            this.linkSources.Text = "linkLabel2";
            this.linkSources.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSources_LinkClicked);
            // 
            // contentTextbox
            // 
            this.contentTextbox.Location = new System.Drawing.Point(144, 168);
            this.contentTextbox.Name = "contentTextbox";
            this.contentTextbox.Size = new System.Drawing.Size(262, 121);
            this.contentTextbox.TabIndex = 25;
            this.contentTextbox.Text = "";
            this.contentTextbox.TextChanged += new System.EventHandler(this.contentTextbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Titles";
            // 
            // listboxTitluriPostari
            // 
            this.listboxTitluriPostari.FormattingEnabled = true;
            this.listboxTitluriPostari.Location = new System.Drawing.Point(17, 168);
            this.listboxTitluriPostari.Name = "listboxTitluriPostari";
            this.listboxTitluriPostari.Size = new System.Drawing.Size(120, 212);
            this.listboxTitluriPostari.TabIndex = 23;
            this.listboxTitluriPostari.SelectedIndexChanged += new System.EventHandler(this.listboxTitluriPostari_SelectedIndexChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(643, 6);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 31;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(29, 121);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(88, 24);
            this.button9.TabIndex = 23;
            this.button9.Text = "Add a post!";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button updateCourse;
        private System.Windows.Forms.Button deleteCourse;
        private System.Windows.Forms.Button insertCourse;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxoldPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.LinkLabel linkSources;
        private System.Windows.Forms.RichTextBox contentTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listboxTitluriPostari;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button button9;
    }
}
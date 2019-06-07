namespace WindowsFormsAppProiect
{
    partial class InsertCourseAdmin
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFaculty = new System.Windows.Forms.TextBox();
            this.textBoxSemester = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelSemester = new System.Windows.Forms.Label();
            this.labelFaculty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Faculty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Semester";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name";
            // 
            // textBoxFaculty
            // 
            this.textBoxFaculty.Location = new System.Drawing.Point(112, 194);
            this.textBoxFaculty.Name = "textBoxFaculty";
            this.textBoxFaculty.Size = new System.Drawing.Size(100, 20);
            this.textBoxFaculty.TabIndex = 17;
            this.textBoxFaculty.TextChanged += new System.EventHandler(this.textBoxFaculty_TextChanged);
            // 
            // textBoxSemester
            // 
            this.textBoxSemester.Location = new System.Drawing.Point(112, 147);
            this.textBoxSemester.Name = "textBoxSemester";
            this.textBoxSemester.Size = new System.Drawing.Size(100, 20);
            this.textBoxSemester.TabIndex = 16;
            this.textBoxSemester.TextChanged += new System.EventHandler(this.textBoxSemester_TextChanged);
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(112, 104);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxYear.TabIndex = 15;
            this.textBoxYear.TextChanged += new System.EventHandler(this.textBoxYear_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(112, 62);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 14;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.Color.Red;
            this.labelName.Location = new System.Drawing.Point(240, 69);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 13);
            this.labelName.TabIndex = 22;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.ForeColor = System.Drawing.Color.Red;
            this.labelYear.Location = new System.Drawing.Point(240, 111);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(0, 13);
            this.labelYear.TabIndex = 23;
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.ForeColor = System.Drawing.Color.Red;
            this.labelSemester.Location = new System.Drawing.Point(240, 154);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(0, 13);
            this.labelSemester.TabIndex = 24;
            // 
            // labelFaculty
            // 
            this.labelFaculty.AutoSize = true;
            this.labelFaculty.ForeColor = System.Drawing.Color.Red;
            this.labelFaculty.Location = new System.Drawing.Point(240, 201);
            this.labelFaculty.Name = "labelFaculty";
            this.labelFaculty.Size = new System.Drawing.Size(0, 13);
            this.labelFaculty.TabIndex = 25;
            // 
            // InsertCourseAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 320);
            this.Controls.Add(this.labelFaculty);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFaculty);
            this.Controls.Add(this.textBoxSemester);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.button1);
            this.Name = "InsertCourseAdmin";
            this.Text = "InsertCourseAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFaculty;
        private System.Windows.Forms.TextBox textBoxSemester;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.Label labelFaculty;
    }
}
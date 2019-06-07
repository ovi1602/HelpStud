namespace WindowsFormsAppProiect
{
    partial class UpdateFacultyAdmin
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
            this.labelOldName = new System.Windows.Forms.Label();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelOldName
            // 
            this.labelOldName.AutoSize = true;
            this.labelOldName.Location = new System.Drawing.Point(82, 27);
            this.labelOldName.Name = "labelOldName";
            this.labelOldName.Size = new System.Drawing.Size(35, 13);
            this.labelOldName.TabIndex = 0;
            this.labelOldName.Text = "label1";
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(75, 58);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewName.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateFacultyAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 148);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.labelOldName);
            this.Name = "UpdateFacultyAdmin";
            this.Text = "UpdateFacultyAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOldName;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Button button1;
    }
}
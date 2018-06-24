namespace WindowsFormsApp3
{
    partial class AdminProfil
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
            this.ADDSTUDENT = new System.Windows.Forms.Button();
            this.ADDTEACHER = new System.Windows.Forms.Button();
            this.ADDCLASS = new System.Windows.Forms.Button();
            this.SHOWCLASSES = new System.Windows.Forms.Button();
            this.SHOWTEACHERS = new System.Windows.Forms.Button();
            this.SHOWSTUDENTS = new System.Windows.Forms.Button();
            this.BACKTOFRONT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ADDSTUDENT
            // 
            this.ADDSTUDENT.Location = new System.Drawing.Point(53, 42);
            this.ADDSTUDENT.Name = "ADDSTUDENT";
            this.ADDSTUDENT.Size = new System.Drawing.Size(195, 41);
            this.ADDSTUDENT.TabIndex = 0;
            this.ADDSTUDENT.Text = "ADDSTUDENT";
            this.ADDSTUDENT.UseVisualStyleBackColor = true;
            this.ADDSTUDENT.Click += new System.EventHandler(this.ADDSTUDENT_Click);
            // 
            // ADDTEACHER
            // 
            this.ADDTEACHER.Location = new System.Drawing.Point(345, 42);
            this.ADDTEACHER.Name = "ADDTEACHER";
            this.ADDTEACHER.Size = new System.Drawing.Size(195, 41);
            this.ADDTEACHER.TabIndex = 1;
            this.ADDTEACHER.Text = "ADDTEACHER";
            this.ADDTEACHER.UseVisualStyleBackColor = true;
            this.ADDTEACHER.Click += new System.EventHandler(this.ADDTEACHER_Click);
            // 
            // ADDCLASS
            // 
            this.ADDCLASS.Location = new System.Drawing.Point(651, 42);
            this.ADDCLASS.Name = "ADDCLASS";
            this.ADDCLASS.Size = new System.Drawing.Size(195, 41);
            this.ADDCLASS.TabIndex = 2;
            this.ADDCLASS.Text = "ADDCLASS";
            this.ADDCLASS.UseVisualStyleBackColor = true;
            // 
            // SHOWCLASSES
            // 
            this.SHOWCLASSES.Location = new System.Drawing.Point(651, 124);
            this.SHOWCLASSES.Name = "SHOWCLASSES";
            this.SHOWCLASSES.Size = new System.Drawing.Size(195, 41);
            this.SHOWCLASSES.TabIndex = 5;
            this.SHOWCLASSES.Text = "SHOWCLASSES";
            this.SHOWCLASSES.UseVisualStyleBackColor = true;
            // 
            // SHOWTEACHERS
            // 
            this.SHOWTEACHERS.Location = new System.Drawing.Point(345, 124);
            this.SHOWTEACHERS.Name = "SHOWTEACHERS";
            this.SHOWTEACHERS.Size = new System.Drawing.Size(195, 41);
            this.SHOWTEACHERS.TabIndex = 4;
            this.SHOWTEACHERS.Text = "SHOWTEACHER";
            this.SHOWTEACHERS.UseVisualStyleBackColor = true;
            // 
            // SHOWSTUDENTS
            // 
            this.SHOWSTUDENTS.Location = new System.Drawing.Point(53, 124);
            this.SHOWSTUDENTS.Name = "SHOWSTUDENTS";
            this.SHOWSTUDENTS.Size = new System.Drawing.Size(195, 41);
            this.SHOWSTUDENTS.TabIndex = 3;
            this.SHOWSTUDENTS.Text = "SHOWSTUDENT";
            this.SHOWSTUDENTS.UseVisualStyleBackColor = true;
            // 
            // BACKTOFRONT
            // 
            this.BACKTOFRONT.Location = new System.Drawing.Point(651, 209);
            this.BACKTOFRONT.Name = "BACKTOFRONT";
            this.BACKTOFRONT.Size = new System.Drawing.Size(195, 41);
            this.BACKTOFRONT.TabIndex = 6;
            this.BACKTOFRONT.Text = "BACKTOFRONT";
            this.BACKTOFRONT.UseVisualStyleBackColor = true;
            // 
            // AdminProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 300);
            this.Controls.Add(this.BACKTOFRONT);
            this.Controls.Add(this.SHOWCLASSES);
            this.Controls.Add(this.SHOWTEACHERS);
            this.Controls.Add(this.SHOWSTUDENTS);
            this.Controls.Add(this.ADDCLASS);
            this.Controls.Add(this.ADDTEACHER);
            this.Controls.Add(this.ADDSTUDENT);
            this.Name = "AdminProfil";
            this.Text = "AdminProfil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ADDSTUDENT;
        private System.Windows.Forms.Button ADDTEACHER;
        private System.Windows.Forms.Button ADDCLASS;
        private System.Windows.Forms.Button SHOWCLASSES;
        private System.Windows.Forms.Button SHOWTEACHERS;
        private System.Windows.Forms.Button SHOWSTUDENTS;
        private System.Windows.Forms.Button BACKTOFRONT;
    }
}
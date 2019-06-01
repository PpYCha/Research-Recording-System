namespace ResearchRecordingSystem
{
    partial class MainForm
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
            this.bt_ManageAccount = new System.Windows.Forms.Button();
            this.bt_CourseManagement = new System.Windows.Forms.Button();
            this.bt_ManageThesis = new System.Windows.Forms.Button();
            this.tb_SearchForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_ManageAccount
            // 
            this.bt_ManageAccount.Location = new System.Drawing.Point(78, 68);
            this.bt_ManageAccount.Name = "bt_ManageAccount";
            this.bt_ManageAccount.Size = new System.Drawing.Size(149, 75);
            this.bt_ManageAccount.TabIndex = 0;
            this.bt_ManageAccount.Text = "Manage Acount";
            this.bt_ManageAccount.UseVisualStyleBackColor = true;
            this.bt_ManageAccount.Click += new System.EventHandler(this.bt_ManageAccount_Click);
            // 
            // bt_CourseManagement
            // 
            this.bt_CourseManagement.Location = new System.Drawing.Point(78, 164);
            this.bt_CourseManagement.Name = "bt_CourseManagement";
            this.bt_CourseManagement.Size = new System.Drawing.Size(149, 75);
            this.bt_CourseManagement.TabIndex = 1;
            this.bt_CourseManagement.Text = "Manage Course";
            this.bt_CourseManagement.UseVisualStyleBackColor = true;
            this.bt_CourseManagement.Click += new System.EventHandler(this.bt_CourseManagement_Click);
            // 
            // bt_ManageThesis
            // 
            this.bt_ManageThesis.Location = new System.Drawing.Point(310, 68);
            this.bt_ManageThesis.Name = "bt_ManageThesis";
            this.bt_ManageThesis.Size = new System.Drawing.Size(149, 75);
            this.bt_ManageThesis.TabIndex = 2;
            this.bt_ManageThesis.Text = "Maange Thesis";
            this.bt_ManageThesis.UseVisualStyleBackColor = true;
            this.bt_ManageThesis.Click += new System.EventHandler(this.bt_ManageThesis_Click);
            // 
            // tb_SearchForm
            // 
            this.tb_SearchForm.Location = new System.Drawing.Point(310, 173);
            this.tb_SearchForm.Name = "tb_SearchForm";
            this.tb_SearchForm.Size = new System.Drawing.Size(149, 75);
            this.tb_SearchForm.TabIndex = 3;
            this.tb_SearchForm.Text = "Search Thesis";
            this.tb_SearchForm.UseVisualStyleBackColor = true;
            this.tb_SearchForm.Click += new System.EventHandler(this.tb_SearchForm_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 75);
            this.button1.TabIndex = 4;
            this.button1.Text = "Burrow Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(544, 369);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_SearchForm);
            this.Controls.Add(this.bt_ManageThesis);
            this.Controls.Add(this.bt_CourseManagement);
            this.Controls.Add(this.bt_ManageAccount);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Research Recording System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_ManageAccount;
        private System.Windows.Forms.Button bt_CourseManagement;
        private System.Windows.Forms.Button bt_ManageThesis;
        private System.Windows.Forms.Button tb_SearchForm;
        private System.Windows.Forms.Button button1;
    }
}


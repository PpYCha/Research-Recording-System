﻿namespace ResearchRecordingSystemInCollegeOfScience.Tabpages.ViewReport
{
    partial class ViewByCourse
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ViewByCourseRpt1 = new ResearchRecordingSystemInCollegeOfScience.ViewByCourseRpt();
            this.cachedCrystalReport1 = new ResearchRecordingSystemInCollegeOfScience.Tabpages.ViewReport.CachedCrystalReport();
            this.cb_Course = new System.Windows.Forms.ComboBox();
            this.chb_Course = new System.Windows.Forms.CheckBox();
            this.chb_YearPublish = new System.Windows.Forms.CheckBox();
            this.chb_Author = new System.Windows.Forms.CheckBox();
            this.chb_Category = new System.Windows.Forms.CheckBox();
            this.cb_YearPublished = new System.Windows.Forms.ComboBox();
            this.cb_Classification = new System.Windows.Forms.ComboBox();
            this.tb_AuthorName = new System.Windows.Forms.TextBox();
            this.tb_Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 123);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.ViewByCourseRpt1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1332, 603);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // cb_Course
            // 
            this.cb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Course.FormattingEnabled = true;
            this.cb_Course.Location = new System.Drawing.Point(246, 24);
            this.cb_Course.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cb_Course.Name = "cb_Course";
            this.cb_Course.Size = new System.Drawing.Size(199, 29);
            this.cb_Course.TabIndex = 1;
            // 
            // chb_Course
            // 
            this.chb_Course.AutoSize = true;
            this.chb_Course.Location = new System.Drawing.Point(108, 28);
            this.chb_Course.Name = "chb_Course";
            this.chb_Course.Size = new System.Drawing.Size(87, 25);
            this.chb_Course.TabIndex = 3;
            this.chb_Course.Text = "Course:";
            this.chb_Course.UseVisualStyleBackColor = true;
            // 
            // chb_YearPublish
            // 
            this.chb_YearPublish.AutoSize = true;
            this.chb_YearPublish.Location = new System.Drawing.Point(69, 73);
            this.chb_YearPublish.Name = "chb_YearPublish";
            this.chb_YearPublish.Size = new System.Drawing.Size(126, 25);
            this.chb_YearPublish.TabIndex = 4;
            this.chb_YearPublish.Text = "Year Publish:";
            this.chb_YearPublish.UseVisualStyleBackColor = true;
            // 
            // chb_Author
            // 
            this.chb_Author.AutoSize = true;
            this.chb_Author.Location = new System.Drawing.Point(495, 28);
            this.chb_Author.Name = "chb_Author";
            this.chb_Author.Size = new System.Drawing.Size(88, 25);
            this.chb_Author.TabIndex = 5;
            this.chb_Author.Text = "Author:";
            this.chb_Author.UseVisualStyleBackColor = true;
            // 
            // chb_Category
            // 
            this.chb_Category.AutoSize = true;
            this.chb_Category.Location = new System.Drawing.Point(475, 73);
            this.chb_Category.Name = "chb_Category";
            this.chb_Category.Size = new System.Drawing.Size(131, 25);
            this.chb_Category.TabIndex = 6;
            this.chb_Category.Text = "Classfication:";
            this.chb_Category.UseVisualStyleBackColor = true;
            // 
            // cb_YearPublished
            // 
            this.cb_YearPublished.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_YearPublished.FormattingEnabled = true;
            this.cb_YearPublished.Location = new System.Drawing.Point(246, 69);
            this.cb_YearPublished.Margin = new System.Windows.Forms.Padding(5);
            this.cb_YearPublished.Name = "cb_YearPublished";
            this.cb_YearPublished.Size = new System.Drawing.Size(199, 29);
            this.cb_YearPublished.TabIndex = 7;
            // 
            // cb_Classification
            // 
            this.cb_Classification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Classification.FormattingEnabled = true;
            this.cb_Classification.Location = new System.Drawing.Point(611, 71);
            this.cb_Classification.Margin = new System.Windows.Forms.Padding(5);
            this.cb_Classification.Name = "cb_Classification";
            this.cb_Classification.Size = new System.Drawing.Size(199, 29);
            this.cb_Classification.TabIndex = 9;
            // 
            // tb_AuthorName
            // 
            this.tb_AuthorName.Location = new System.Drawing.Point(611, 24);
            this.tb_AuthorName.Name = "tb_AuthorName";
            this.tb_AuthorName.Size = new System.Drawing.Size(199, 27);
            this.tb_AuthorName.TabIndex = 10;
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(926, 47);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(109, 51);
            this.tb_Search.TabIndex = 11;
            this.tb_Search.Text = "Search";
            this.tb_Search.UseVisualStyleBackColor = true;
            this.tb_Search.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewByCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 727);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.tb_AuthorName);
            this.Controls.Add(this.cb_Classification);
            this.Controls.Add(this.cb_YearPublished);
            this.Controls.Add(this.chb_Category);
            this.Controls.Add(this.chb_Author);
            this.Controls.Add(this.chb_YearPublish);
            this.Controls.Add(this.chb_Course);
            this.Controls.Add(this.cb_Course);
            this.Controls.Add(this.crystalReportViewer1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ViewByCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewByCourse";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewByCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private ViewByCourseRpt ViewByCourseRpt1;
        private CachedCrystalReport cachedCrystalReport1;
        private System.Windows.Forms.ComboBox cb_Course;
        private System.Windows.Forms.CheckBox chb_Course;
        private System.Windows.Forms.CheckBox chb_YearPublish;
        private System.Windows.Forms.CheckBox chb_Author;
        private System.Windows.Forms.CheckBox chb_Category;
        private System.Windows.Forms.ComboBox cb_YearPublished;
        private System.Windows.Forms.ComboBox cb_Classification;
        private System.Windows.Forms.TextBox tb_AuthorName;
        private System.Windows.Forms.Button tb_Search;
    }
}
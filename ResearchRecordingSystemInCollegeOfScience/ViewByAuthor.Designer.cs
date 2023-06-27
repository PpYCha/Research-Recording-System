namespace ResearchRecordingSystemInCollegeOfScience
{
    partial class ViewByAuthor
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
            this.tb_AuthorName = new System.Windows.Forms.TextBox();
            this.bt_SearchAuthor = new System.Windows.Forms.Button();
            this.ViewByAuthorRpt1 = new ResearchRecordingSystemInCollegeOfScience.ViewByAuthorRpt();
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
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 97);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.ViewByAuthorRpt1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(808, 324);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.ToolPanelWidth = 367;
            // 
            // tb_AuthorName
            // 
            this.tb_AuthorName.Location = new System.Drawing.Point(93, 34);
            this.tb_AuthorName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tb_AuthorName.Name = "tb_AuthorName";
            this.tb_AuthorName.Size = new System.Drawing.Size(180, 31);
            this.tb_AuthorName.TabIndex = 1;
            // 
            // bt_SearchAuthor
            // 
            this.bt_SearchAuthor.Location = new System.Drawing.Point(311, 34);
            this.bt_SearchAuthor.Name = "bt_SearchAuthor";
            this.bt_SearchAuthor.Size = new System.Drawing.Size(110, 31);
            this.bt_SearchAuthor.TabIndex = 2;
            this.bt_SearchAuthor.Text = "Search";
            this.bt_SearchAuthor.UseVisualStyleBackColor = true;
            this.bt_SearchAuthor.Click += new System.EventHandler(this.bt_SearchAuthor_Click);
            // 
            // ViewByAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 421);
            this.Controls.Add(this.bt_SearchAuthor);
            this.Controls.Add(this.tb_AuthorName);
            this.Controls.Add(this.crystalReportViewer1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ViewByAuthor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewByAuthor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TextBox tb_AuthorName;
        private System.Windows.Forms.Button bt_SearchAuthor;
        private ViewByAuthorRpt ViewByAuthorRpt1;
    }
}
namespace ResearchRecordingSystemInCollegeOfScience
{
    partial class ViewListOfBorrowedBooks
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
            this.ViewListOfBorrowedBooksRpt1 = new ResearchRecordingSystemInCollegeOfScience.ViewListOfBorrowedBooksRpt();
            this.btn_SearchListOfBorrowedBooks = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 163);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.ViewListOfBorrowedBooksRpt1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1333, 564);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelWidth = 333;
            // 
            // btn_SearchListOfBorrowedBooks
            // 
            this.btn_SearchListOfBorrowedBooks.Location = new System.Drawing.Point(316, 58);
            this.btn_SearchListOfBorrowedBooks.Name = "btn_SearchListOfBorrowedBooks";
            this.btn_SearchListOfBorrowedBooks.Size = new System.Drawing.Size(128, 58);
            this.btn_SearchListOfBorrowedBooks.TabIndex = 1;
            this.btn_SearchListOfBorrowedBooks.Text = "Search";
            this.btn_SearchListOfBorrowedBooks.UseVisualStyleBackColor = true;
            this.btn_SearchListOfBorrowedBooks.Click += new System.EventHandler(this.btn_SearchListOfBorrowedBooks_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 27);
            this.textBox1.TabIndex = 2;
            // 
            // ViewListOfBorrowedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 727);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_SearchListOfBorrowedBooks);
            this.Controls.Add(this.crystalReportViewer1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ViewListOfBorrowedBooks";
            this.Text = "ViewListOfBorrowedBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private ViewListOfBorrowedBooksRpt ViewListOfBorrowedBooksRpt1;
        private System.Windows.Forms.Button btn_SearchListOfBorrowedBooks;
        private System.Windows.Forms.TextBox textBox1;
    }
}
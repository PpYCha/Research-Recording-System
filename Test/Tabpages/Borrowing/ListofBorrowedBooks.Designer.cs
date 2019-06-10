namespace Test.Tabpages
{
    partial class ListofBorrowedBooks
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.borrowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borrowerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBorrowedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateWillRetrunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thesisTitleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bContactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.researchBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrowerIdDataGridViewTextBoxColumn,
            this.bFullNameDataGridViewTextBoxColumn,
            this.bookBorrowedDateDataGridViewTextBoxColumn,
            this.dateWillRetrunDataGridViewTextBoxColumn,
            this.thesisTitleIdDataGridViewTextBoxColumn,
            this.bContactNumberDataGridViewTextBoxColumn,
            this.researchBookDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.borrowBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // borrowBindingSource
            // 
            this.borrowBindingSource.DataSource = typeof(ResearchRecordingSystem.Borrow);
            // 
            // borrowerIdDataGridViewTextBoxColumn
            // 
            this.borrowerIdDataGridViewTextBoxColumn.DataPropertyName = "BorrowerId";
            this.borrowerIdDataGridViewTextBoxColumn.HeaderText = "BorrowerId";
            this.borrowerIdDataGridViewTextBoxColumn.Name = "borrowerIdDataGridViewTextBoxColumn";
            this.borrowerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.borrowerIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // bFullNameDataGridViewTextBoxColumn
            // 
            this.bFullNameDataGridViewTextBoxColumn.DataPropertyName = "BFullName";
            this.bFullNameDataGridViewTextBoxColumn.HeaderText = "Borrower Name";
            this.bFullNameDataGridViewTextBoxColumn.Name = "bFullNameDataGridViewTextBoxColumn";
            // 
            // bookBorrowedDateDataGridViewTextBoxColumn
            // 
            this.bookBorrowedDateDataGridViewTextBoxColumn.DataPropertyName = "BookBorrowedDate";
            this.bookBorrowedDateDataGridViewTextBoxColumn.HeaderText = "Date Borrow";
            this.bookBorrowedDateDataGridViewTextBoxColumn.Name = "bookBorrowedDateDataGridViewTextBoxColumn";
            // 
            // dateWillRetrunDataGridViewTextBoxColumn
            // 
            this.dateWillRetrunDataGridViewTextBoxColumn.DataPropertyName = "DateWillRetrun";
            this.dateWillRetrunDataGridViewTextBoxColumn.HeaderText = "Date Will Retrun";
            this.dateWillRetrunDataGridViewTextBoxColumn.Name = "dateWillRetrunDataGridViewTextBoxColumn";
            // 
            // thesisTitleIdDataGridViewTextBoxColumn
            // 
            this.thesisTitleIdDataGridViewTextBoxColumn.DataPropertyName = "ThesisTitleId";
            this.thesisTitleIdDataGridViewTextBoxColumn.HeaderText = "Book Title";
            this.thesisTitleIdDataGridViewTextBoxColumn.Name = "thesisTitleIdDataGridViewTextBoxColumn";
            // 
            // bContactNumberDataGridViewTextBoxColumn
            // 
            this.bContactNumberDataGridViewTextBoxColumn.DataPropertyName = "BContactNumber";
            this.bContactNumberDataGridViewTextBoxColumn.HeaderText = "Contact No";
            this.bContactNumberDataGridViewTextBoxColumn.Name = "bContactNumberDataGridViewTextBoxColumn";
            // 
            // researchBookDataGridViewTextBoxColumn
            // 
            this.researchBookDataGridViewTextBoxColumn.DataPropertyName = "ResearchBook";
            this.researchBookDataGridViewTextBoxColumn.HeaderText = "ResearchBook";
            this.researchBookDataGridViewTextBoxColumn.Name = "researchBookDataGridViewTextBoxColumn";
            this.researchBookDataGridViewTextBoxColumn.Visible = false;
            // 
            // ListofBorrowedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListofBorrowedBooks";
            this.Text = "ListofBorrowedBooks";
            this.Load += new System.EventHandler(this.ListofBorrowedBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource borrowBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookBorrowedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateWillRetrunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thesisTitleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bContactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn researchBookDataGridViewTextBoxColumn;
    }
}
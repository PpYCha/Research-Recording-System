﻿namespace Test.Tabpages
{
    partial class ReturnABorrowedBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnABorrowedBook));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_AddAuthor = new System.Windows.Forms.Button();
            this.borrowerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bContactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBorrowedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateWillRetrunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thesisTitleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.researchBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.bContactNumberDataGridViewTextBoxColumn,
            this.bookBorrowedDateDataGridViewTextBoxColumn,
            this.dateWillRetrunDataGridViewTextBoxColumn,
            this.thesisTitleIdDataGridViewTextBoxColumn,
            this.researchBookDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.borrowBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(65, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(812, 260);
            this.dataGridView1.TabIndex = 0;
            // 
            // bt_AddAuthor
            // 
            this.bt_AddAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_AddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddAuthor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddAuthor.ForeColor = System.Drawing.Color.White;
            this.bt_AddAuthor.Image = ((System.Drawing.Image)(resources.GetObject("bt_AddAuthor.Image")));
            this.bt_AddAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_AddAuthor.Location = new System.Drawing.Point(65, 372);
            this.bt_AddAuthor.Name = "bt_AddAuthor";
            this.bt_AddAuthor.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bt_AddAuthor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_AddAuthor.Size = new System.Drawing.Size(182, 47);
            this.bt_AddAuthor.TabIndex = 74;
            this.bt_AddAuthor.Text = "Return Book";
            this.bt_AddAuthor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_AddAuthor.UseVisualStyleBackColor = true;
            this.bt_AddAuthor.Click += new System.EventHandler(this.bt_AddAuthor_Click);
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
            this.bFullNameDataGridViewTextBoxColumn.HeaderText = "Borrower";
            this.bFullNameDataGridViewTextBoxColumn.Name = "bFullNameDataGridViewTextBoxColumn";
            // 
            // bContactNumberDataGridViewTextBoxColumn
            // 
            this.bContactNumberDataGridViewTextBoxColumn.DataPropertyName = "BContactNumber";
            this.bContactNumberDataGridViewTextBoxColumn.HeaderText = "Contact No";
            this.bContactNumberDataGridViewTextBoxColumn.Name = "bContactNumberDataGridViewTextBoxColumn";
            // 
            // bookBorrowedDateDataGridViewTextBoxColumn
            // 
            this.bookBorrowedDateDataGridViewTextBoxColumn.DataPropertyName = "BookBorrowedDate";
            this.bookBorrowedDateDataGridViewTextBoxColumn.HeaderText = "Date Borrowed";
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
            this.thesisTitleIdDataGridViewTextBoxColumn.HeaderText = "ThesisTitleId";
            this.thesisTitleIdDataGridViewTextBoxColumn.Name = "thesisTitleIdDataGridViewTextBoxColumn";
            this.thesisTitleIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // researchBookDataGridViewTextBoxColumn
            // 
            this.researchBookDataGridViewTextBoxColumn.DataPropertyName = "ResearchBook";
            this.researchBookDataGridViewTextBoxColumn.HeaderText = "ResearchBook";
            this.researchBookDataGridViewTextBoxColumn.Name = "researchBookDataGridViewTextBoxColumn";
            this.researchBookDataGridViewTextBoxColumn.Visible = false;
            // 
            // borrowBindingSource
            // 
            this.borrowBindingSource.DataSource = typeof(ResearchRecordingSystem.Borrow);
            // 
            // ReturnABorrowedBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(959, 467);
            this.Controls.Add(this.bt_AddAuthor);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReturnABorrowedBook";
            this.Text = "ReturnABorrowBook";
            this.Load += new System.EventHandler(this.ReturnABorrowedBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_AddAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bContactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookBorrowedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateWillRetrunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thesisTitleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn researchBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource borrowBindingSource;
    }
}
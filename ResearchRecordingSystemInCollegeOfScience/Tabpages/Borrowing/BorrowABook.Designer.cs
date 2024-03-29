﻿namespace ResearchRecordingSystemInCollegeOfScience.Tabpages
{
    partial class BorrowABook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowABook));
            this.tb_BContactNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_BFName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_AddAuthor = new System.Windows.Forms.Button();
            this.dataGridView_Borrow = new System.Windows.Forms.DataGridView();
            this.thesisTitleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishedYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameRbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cataloging = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbstractEcopy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApprovalSheetEcopy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfCopiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.researchBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker_Return = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Borrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchBookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_BContactNumber
            // 
            this.tb_BContactNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_BContactNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_BContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_BContactNumber.ForeColor = System.Drawing.Color.DimGray;
            this.tb_BContactNumber.Location = new System.Drawing.Point(191, 53);
            this.tb_BContactNumber.Multiline = true;
            this.tb_BContactNumber.Name = "tb_BContactNumber";
            this.tb_BContactNumber.Size = new System.Drawing.Size(221, 20);
            this.tb_BContactNumber.TabIndex = 77;
            this.tb_BContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_BContactNumber_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(88, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 76;
            this.label3.Text = "Contact #:";
            // 
            // tb_BFName
            // 
            this.tb_BFName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_BFName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_BFName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_BFName.ForeColor = System.Drawing.Color.DimGray;
            this.tb_BFName.Location = new System.Drawing.Point(191, 18);
            this.tb_BFName.Multiline = true;
            this.tb_BFName.Name = "tb_BFName";
            this.tb_BFName.Size = new System.Drawing.Size(221, 20);
            this.tb_BFName.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 19);
            this.label4.TabIndex = 74;
            this.label4.Text = "Name of Borrower:";
            // 
            // bt_AddAuthor
            // 
            this.bt_AddAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_AddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddAuthor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddAuthor.ForeColor = System.Drawing.Color.White;
            this.bt_AddAuthor.Image = ((System.Drawing.Image)(resources.GetObject("bt_AddAuthor.Image")));
            this.bt_AddAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_AddAuthor.Location = new System.Drawing.Point(92, 371);
            this.bt_AddAuthor.Name = "bt_AddAuthor";
            this.bt_AddAuthor.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bt_AddAuthor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_AddAuthor.Size = new System.Drawing.Size(182, 47);
            this.bt_AddAuthor.TabIndex = 73;
            this.bt_AddAuthor.Text = "Borrow";
            this.bt_AddAuthor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_AddAuthor.UseVisualStyleBackColor = true;
            this.bt_AddAuthor.Click += new System.EventHandler(this.bt_AddAuthor_Click);
            // 
            // dataGridView_Borrow
            // 
            this.dataGridView_Borrow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Borrow.AutoGenerateColumns = false;
            this.dataGridView_Borrow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Borrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Borrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thesisTitleIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.publishedYearDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn,
            this.courseNameRbDataGridViewTextBoxColumn,
            this.Cataloging,
            this.Classification,
            this.AbstractEcopy,
            this.ApprovalSheetEcopy,
            this.numberOfCopiesDataGridViewTextBoxColumn});
            this.dataGridView_Borrow.DataSource = this.researchBookBindingSource;
            this.dataGridView_Borrow.Location = new System.Drawing.Point(23, 95);
            this.dataGridView_Borrow.Name = "dataGridView_Borrow";
            this.dataGridView_Borrow.ReadOnly = true;
            this.dataGridView_Borrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Borrow.Size = new System.Drawing.Size(945, 225);
            this.dataGridView_Borrow.TabIndex = 72;
            this.dataGridView_Borrow.DataSourceChanged += new System.EventHandler(this.dataGridView_Borrow_DataSourceChanged_1);
            this.dataGridView_Borrow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Borrow_CellContentClick);
            this.dataGridView_Borrow.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_Borrow_DataError);
            this.dataGridView_Borrow.DoubleClick += new System.EventHandler(this.dataGridView_Borrow_DoubleClick);
            // 
            // thesisTitleIdDataGridViewTextBoxColumn
            // 
            this.thesisTitleIdDataGridViewTextBoxColumn.DataPropertyName = "ThesisTitleId";
            this.thesisTitleIdDataGridViewTextBoxColumn.HeaderText = "ThesisTitleId";
            this.thesisTitleIdDataGridViewTextBoxColumn.Name = "thesisTitleIdDataGridViewTextBoxColumn";
            this.thesisTitleIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.thesisTitleIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publishedYearDataGridViewTextBoxColumn
            // 
            this.publishedYearDataGridViewTextBoxColumn.DataPropertyName = "PublishedYear";
            this.publishedYearDataGridViewTextBoxColumn.HeaderText = "Published Year";
            this.publishedYearDataGridViewTextBoxColumn.Name = "publishedYearDataGridViewTextBoxColumn";
            this.publishedYearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseNameRbDataGridViewTextBoxColumn
            // 
            this.courseNameRbDataGridViewTextBoxColumn.DataPropertyName = "CourseNameRb";
            this.courseNameRbDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseNameRbDataGridViewTextBoxColumn.Name = "courseNameRbDataGridViewTextBoxColumn";
            this.courseNameRbDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Cataloging
            // 
            this.Cataloging.DataPropertyName = "Cataloging";
            this.Cataloging.HeaderText = "Cataloging";
            this.Cataloging.Name = "Cataloging";
            this.Cataloging.ReadOnly = true;
            // 
            // Classification
            // 
            this.Classification.DataPropertyName = "Classification";
            this.Classification.HeaderText = "Classification";
            this.Classification.Name = "Classification";
            this.Classification.ReadOnly = true;
            // 
            // AbstractEcopy
            // 
            this.AbstractEcopy.DataPropertyName = "AbstractEcopy";
            this.AbstractEcopy.HeaderText = "AbstractEcopy";
            this.AbstractEcopy.Name = "AbstractEcopy";
            this.AbstractEcopy.ReadOnly = true;
            this.AbstractEcopy.Visible = false;
            // 
            // ApprovalSheetEcopy
            // 
            this.ApprovalSheetEcopy.DataPropertyName = "ApprovalSheetEcopy";
            this.ApprovalSheetEcopy.HeaderText = "ApprovalSheetEcopy";
            this.ApprovalSheetEcopy.Name = "ApprovalSheetEcopy";
            this.ApprovalSheetEcopy.ReadOnly = true;
            this.ApprovalSheetEcopy.Visible = false;
            // 
            // numberOfCopiesDataGridViewTextBoxColumn
            // 
            this.numberOfCopiesDataGridViewTextBoxColumn.DataPropertyName = "NumberOfCopies";
            this.numberOfCopiesDataGridViewTextBoxColumn.HeaderText = "Availability";
            this.numberOfCopiesDataGridViewTextBoxColumn.Name = "numberOfCopiesDataGridViewTextBoxColumn";
            this.numberOfCopiesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // researchBookBindingSource
            // 
            this.researchBookBindingSource.DataSource = typeof(ResearchRecordingSystemInCollegeOfScience.ResearchBook);
            // 
            // dateTimePicker_Return
            // 
            this.dateTimePicker_Return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker_Return.Location = new System.Drawing.Point(578, 19);
            this.dateTimePicker_Return.Name = "dateTimePicker_Return";
            this.dateTimePicker_Return.Size = new System.Drawing.Size(221, 20);
            this.dateTimePicker_Return.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(437, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 81;
            this.label2.Text = "Date will return:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(748, 62);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 82;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(667, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 83;
            this.label5.Text = "Search:";
            // 
            // BorrowABook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(985, 454);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_Return);
            this.Controls.Add(this.tb_BContactNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_BFName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_AddAuthor);
            this.Controls.Add(this.dataGridView_Borrow);
            this.MinimumSize = new System.Drawing.Size(972, 492);
            this.Name = "BorrowABook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorrowBook";
            this.Load += new System.EventHandler(this.BurrowBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Borrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchBookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_BContactNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_BFName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_AddAuthor;
        private System.Windows.Forms.DataGridView dataGridView_Borrow;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Return;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource researchBookBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn thesisTitleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishedYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameRbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cataloging;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classification;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbstractEcopy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApprovalSheetEcopy;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfCopiesDataGridViewTextBoxColumn;
    }
}
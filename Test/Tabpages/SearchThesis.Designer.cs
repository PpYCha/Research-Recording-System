namespace Test.Tabpages
{
    partial class SearchThesis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchThesis));
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.bt_Search = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.bt_ViewEcopy = new System.Windows.Forms.Button();
            this.thesisTitleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishedYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameRbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.researchBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchBookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSearch.AutoGenerateColumns = false;
            this.dataGridViewSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thesisTitleIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.publishedYearDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn,
            this.courseNameRbDataGridViewTextBoxColumn,
            this.borrowerDataGridViewTextBoxColumn,
            this.authorsDataGridViewTextBoxColumn});
            this.dataGridViewSearch.DataSource = this.researchBookBindingSource;
            this.dataGridViewSearch.Location = new System.Drawing.Point(12, 93);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSearch.Size = new System.Drawing.Size(827, 399);
            this.dataGridViewSearch.TabIndex = 0;
            this.dataGridViewSearch.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewSearch_DataError);
            this.dataGridViewSearch.DoubleClick += new System.EventHandler(this.dataGridViewSearch_DoubleClick);
            // 
            // bt_Search
            // 
            this.bt_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Search.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Search.ForeColor = System.Drawing.Color.White;
            this.bt_Search.Image = ((System.Drawing.Image)(resources.GetObject("bt_Search.Image")));
            this.bt_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Search.Location = new System.Drawing.Point(413, 25);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bt_Search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_Search.Size = new System.Drawing.Size(182, 47);
            this.bt_Search.TabIndex = 53;
            this.bt_Search.Text = "Search";
            this.bt_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // tb_Search
            // 
            this.tb_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Search.ForeColor = System.Drawing.Color.DimGray;
            this.tb_Search.Location = new System.Drawing.Point(618, 37);
            this.tb_Search.Multiline = true;
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(221, 20);
            this.tb_Search.TabIndex = 52;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // bt_ViewEcopy
            // 
            this.bt_ViewEcopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ViewEcopy.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ViewEcopy.ForeColor = System.Drawing.Color.White;
            this.bt_ViewEcopy.Image = ((System.Drawing.Image)(resources.GetObject("bt_ViewEcopy.Image")));
            this.bt_ViewEcopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ViewEcopy.Location = new System.Drawing.Point(143, 25);
            this.bt_ViewEcopy.Name = "bt_ViewEcopy";
            this.bt_ViewEcopy.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bt_ViewEcopy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_ViewEcopy.Size = new System.Drawing.Size(182, 47);
            this.bt_ViewEcopy.TabIndex = 54;
            this.bt_ViewEcopy.Text = "View E-Copy";
            this.bt_ViewEcopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_ViewEcopy.UseVisualStyleBackColor = true;
            this.bt_ViewEcopy.Click += new System.EventHandler(this.bt_ViewEcopy_Click);
            // 
            // thesisTitleIdDataGridViewTextBoxColumn
            // 
            this.thesisTitleIdDataGridViewTextBoxColumn.DataPropertyName = "ThesisTitleId";
            this.thesisTitleIdDataGridViewTextBoxColumn.HeaderText = "ThesisTitleId";
            this.thesisTitleIdDataGridViewTextBoxColumn.Name = "thesisTitleIdDataGridViewTextBoxColumn";
            this.thesisTitleIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // publishedYearDataGridViewTextBoxColumn
            // 
            this.publishedYearDataGridViewTextBoxColumn.DataPropertyName = "PublishedYear";
            this.publishedYearDataGridViewTextBoxColumn.HeaderText = "PublishedYear";
            this.publishedYearDataGridViewTextBoxColumn.Name = "publishedYearDataGridViewTextBoxColumn";
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            // 
            // courseNameRbDataGridViewTextBoxColumn
            // 
            this.courseNameRbDataGridViewTextBoxColumn.DataPropertyName = "CourseNameRb";
            this.courseNameRbDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseNameRbDataGridViewTextBoxColumn.Name = "courseNameRbDataGridViewTextBoxColumn";
            // 
            // borrowerDataGridViewTextBoxColumn
            // 
            this.borrowerDataGridViewTextBoxColumn.DataPropertyName = "Borrower";
            this.borrowerDataGridViewTextBoxColumn.HeaderText = "Borrower";
            this.borrowerDataGridViewTextBoxColumn.Name = "borrowerDataGridViewTextBoxColumn";
            this.borrowerDataGridViewTextBoxColumn.Visible = false;
            // 
            // authorsDataGridViewTextBoxColumn
            // 
            this.authorsDataGridViewTextBoxColumn.DataPropertyName = "Authors";
            this.authorsDataGridViewTextBoxColumn.HeaderText = "Authors";
            this.authorsDataGridViewTextBoxColumn.Name = "authorsDataGridViewTextBoxColumn";
            this.authorsDataGridViewTextBoxColumn.Visible = false;
            // 
            // researchBookBindingSource
            // 
            this.researchBookBindingSource.DataSource = typeof(ResearchRecordingSystem.ResearchBook);
            // 
            // SearchThesis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(851, 504);
            this.Controls.Add(this.bt_ViewEcopy);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.dataGridViewSearch);
            this.MinimumSize = new System.Drawing.Size(867, 542);
            this.Name = "SearchThesis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchThesis";
            this.Load += new System.EventHandler(this.SearchThesis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchBookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSearch;
     
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Button bt_ViewEcopy;
        private System.Windows.Forms.BindingSource researchBookBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn thesisTitleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishedYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameRbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorsDataGridViewTextBoxColumn;
    }
}
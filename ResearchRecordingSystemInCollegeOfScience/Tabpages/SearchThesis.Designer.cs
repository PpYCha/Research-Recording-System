namespace ResearchRecordingSystemInCollegeOfScience.Tabpages
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
            this.tb_TitleSearch = new System.Windows.Forms.TextBox();
            this.tb_PublishYearSearch = new System.Windows.Forms.TextBox();
            this.tb_RemarksSearch = new System.Windows.Forms.TextBox();
            this.tb_CourseSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.researchBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thesisTitleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishedYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameRbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalogingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abstractEcopyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvalSheetEcopyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.catalogingDataGridViewTextBoxColumn,
            this.classificationDataGridViewTextBoxColumn,
            this.abstractEcopyDataGridViewTextBoxColumn,
            this.approvalSheetEcopyDataGridViewTextBoxColumn});
            this.dataGridViewSearch.DataSource = this.researchBookBindingSource;
            this.dataGridViewSearch.Location = new System.Drawing.Point(12, 96);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.ReadOnly = true;
            this.dataGridViewSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSearch.Size = new System.Drawing.Size(981, 316);
            this.dataGridViewSearch.TabIndex = 0;
            this.dataGridViewSearch.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewSearch_DataError);
            this.dataGridViewSearch.DoubleClick += new System.EventHandler(this.dataGridViewSearch_Click);
            // 
            // bt_Search
            // 
            this.bt_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Search.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Search.ForeColor = System.Drawing.Color.White;
            this.bt_Search.Image = ((System.Drawing.Image)(resources.GetObject("bt_Search.Image")));
            this.bt_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Search.Location = new System.Drawing.Point(487, 49);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bt_Search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_Search.Size = new System.Drawing.Size(182, 41);
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
            this.tb_Search.Location = new System.Drawing.Point(675, 49);
            this.tb_Search.Multiline = true;
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(318, 41);
            this.tb_Search.TabIndex = 52;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // tb_TitleSearch
            // 
            this.tb_TitleSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_TitleSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_TitleSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TitleSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TitleSearch.ForeColor = System.Drawing.Color.DimGray;
            this.tb_TitleSearch.Location = new System.Drawing.Point(61, 464);
            this.tb_TitleSearch.Multiline = true;
            this.tb_TitleSearch.Name = "tb_TitleSearch";
            this.tb_TitleSearch.Size = new System.Drawing.Size(221, 20);
            this.tb_TitleSearch.TabIndex = 54;
            this.tb_TitleSearch.TextChanged += new System.EventHandler(this.tb_TitleSearch_TextChanged);
            // 
            // tb_PublishYearSearch
            // 
            this.tb_PublishYearSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_PublishYearSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_PublishYearSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_PublishYearSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PublishYearSearch.ForeColor = System.Drawing.Color.DimGray;
            this.tb_PublishYearSearch.Location = new System.Drawing.Point(298, 464);
            this.tb_PublishYearSearch.Multiline = true;
            this.tb_PublishYearSearch.Name = "tb_PublishYearSearch";
            this.tb_PublishYearSearch.Size = new System.Drawing.Size(221, 20);
            this.tb_PublishYearSearch.TabIndex = 55;
            this.tb_PublishYearSearch.TextChanged += new System.EventHandler(this.tb_PublishYearSearch_TextChanged);
            // 
            // tb_RemarksSearch
            // 
            this.tb_RemarksSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_RemarksSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_RemarksSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_RemarksSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RemarksSearch.ForeColor = System.Drawing.Color.DimGray;
            this.tb_RemarksSearch.Location = new System.Drawing.Point(529, 464);
            this.tb_RemarksSearch.Multiline = true;
            this.tb_RemarksSearch.Name = "tb_RemarksSearch";
            this.tb_RemarksSearch.Size = new System.Drawing.Size(221, 20);
            this.tb_RemarksSearch.TabIndex = 56;
            this.tb_RemarksSearch.TextChanged += new System.EventHandler(this.tb_RemarksSearch_TextChanged);
            // 
            // tb_CourseSearch
            // 
            this.tb_CourseSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_CourseSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_CourseSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_CourseSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CourseSearch.ForeColor = System.Drawing.Color.DimGray;
            this.tb_CourseSearch.Location = new System.Drawing.Point(765, 464);
            this.tb_CourseSearch.Multiline = true;
            this.tb_CourseSearch.Name = "tb_CourseSearch";
            this.tb_CourseSearch.Size = new System.Drawing.Size(221, 20);
            this.tb_CourseSearch.TabIndex = 57;
            this.tb_CourseSearch.TextChanged += new System.EventHandler(this.tb_CourseSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(761, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 61;
            this.label4.Text = "Course:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(525, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 60;
            this.label3.Text = "Remarks:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 59;
            this.label2.Text = "Publish Year:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 58;
            this.label1.Text = "Title:";
            // 
            // researchBookBindingSource
            // 
            this.researchBookBindingSource.DataSource = typeof(ResearchRecordingSystemInCollegeOfScience.ResearchBook);
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
            this.publishedYearDataGridViewTextBoxColumn.HeaderText = "PublishedYear";
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
            this.courseNameRbDataGridViewTextBoxColumn.HeaderText = "CourseNameRb";
            this.courseNameRbDataGridViewTextBoxColumn.Name = "courseNameRbDataGridViewTextBoxColumn";
            this.courseNameRbDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // catalogingDataGridViewTextBoxColumn
            // 
            this.catalogingDataGridViewTextBoxColumn.DataPropertyName = "Cataloging";
            this.catalogingDataGridViewTextBoxColumn.HeaderText = "Cataloging";
            this.catalogingDataGridViewTextBoxColumn.Name = "catalogingDataGridViewTextBoxColumn";
            this.catalogingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classificationDataGridViewTextBoxColumn
            // 
            this.classificationDataGridViewTextBoxColumn.DataPropertyName = "Classification";
            this.classificationDataGridViewTextBoxColumn.HeaderText = "Classification";
            this.classificationDataGridViewTextBoxColumn.Name = "classificationDataGridViewTextBoxColumn";
            this.classificationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // abstractEcopyDataGridViewTextBoxColumn
            // 
            this.abstractEcopyDataGridViewTextBoxColumn.DataPropertyName = "AbstractEcopy";
            this.abstractEcopyDataGridViewTextBoxColumn.HeaderText = "AbstractEcopy";
            this.abstractEcopyDataGridViewTextBoxColumn.Name = "abstractEcopyDataGridViewTextBoxColumn";
            this.abstractEcopyDataGridViewTextBoxColumn.ReadOnly = true;
            this.abstractEcopyDataGridViewTextBoxColumn.Visible = false;
            // 
            // approvalSheetEcopyDataGridViewTextBoxColumn
            // 
            this.approvalSheetEcopyDataGridViewTextBoxColumn.DataPropertyName = "ApprovalSheetEcopy";
            this.approvalSheetEcopyDataGridViewTextBoxColumn.HeaderText = "ApprovalSheetEcopy";
            this.approvalSheetEcopyDataGridViewTextBoxColumn.Name = "approvalSheetEcopyDataGridViewTextBoxColumn";
            this.approvalSheetEcopyDataGridViewTextBoxColumn.ReadOnly = true;
            this.approvalSheetEcopyDataGridViewTextBoxColumn.Visible = false;
            // 
            // SearchThesis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1030, 504);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_CourseSearch);
            this.Controls.Add(this.tb_RemarksSearch);
            this.Controls.Add(this.tb_PublishYearSearch);
            this.Controls.Add(this.tb_TitleSearch);
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
        private System.Windows.Forms.TextBox tb_TitleSearch;
        private System.Windows.Forms.TextBox tb_PublishYearSearch;
        private System.Windows.Forms.TextBox tb_RemarksSearch;
        private System.Windows.Forms.TextBox tb_CourseSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource researchBookBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn thesisTitleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishedYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameRbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catalogingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abstractEcopyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvalSheetEcopyDataGridViewTextBoxColumn;
    }
}
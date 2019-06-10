namespace Test.Tabpages
{
    partial class ViewBookInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBookInformation));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.authorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorContactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thesisTitleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.researchBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_vTitle = new System.Windows.Forms.TextBox();
            this.tb_vPublishYear = new System.Windows.Forms.TextBox();
            this.tb_vRemarks = new System.Windows.Forms.TextBox();
            this.tb_vCourse = new System.Windows.Forms.TextBox();
            this.tb_vCataloging = new System.Windows.Forms.TextBox();
            this.tb_vCategory = new System.Windows.Forms.TextBox();
            this.bt_ViewEcopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Publish Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Remarks:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Course:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cataloging:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Category:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorIdDataGridViewTextBoxColumn,
            this.authorNameDataGridViewTextBoxColumn,
            this.authorContactNumberDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.thesisTitleIdDataGridViewTextBoxColumn,
            this.researchBookDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.authorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(67, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(863, 237);
            this.dataGridView1.TabIndex = 56;
            // 
            // authorIdDataGridViewTextBoxColumn
            // 
            this.authorIdDataGridViewTextBoxColumn.DataPropertyName = "AuthorId";
            this.authorIdDataGridViewTextBoxColumn.HeaderText = "AuthorId";
            this.authorIdDataGridViewTextBoxColumn.Name = "authorIdDataGridViewTextBoxColumn";
            this.authorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // authorNameDataGridViewTextBoxColumn
            // 
            this.authorNameDataGridViewTextBoxColumn.DataPropertyName = "AuthorName";
            this.authorNameDataGridViewTextBoxColumn.HeaderText = "AuthorName";
            this.authorNameDataGridViewTextBoxColumn.Name = "authorNameDataGridViewTextBoxColumn";
            // 
            // authorContactNumberDataGridViewTextBoxColumn
            // 
            this.authorContactNumberDataGridViewTextBoxColumn.DataPropertyName = "AuthorContactNumber";
            this.authorContactNumberDataGridViewTextBoxColumn.HeaderText = "AuthorContactNumber";
            this.authorContactNumberDataGridViewTextBoxColumn.Name = "authorContactNumberDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
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
            // authorBindingSource
            // 
            this.authorBindingSource.DataSource = typeof(ResearchRecordingSystem.Author);
            // 
            // tb_vTitle
            // 
            this.tb_vTitle.Location = new System.Drawing.Point(257, 12);
            this.tb_vTitle.Name = "tb_vTitle";
            this.tb_vTitle.ReadOnly = true;
            this.tb_vTitle.Size = new System.Drawing.Size(209, 27);
            this.tb_vTitle.TabIndex = 57;
            // 
            // tb_vPublishYear
            // 
            this.tb_vPublishYear.Location = new System.Drawing.Point(257, 45);
            this.tb_vPublishYear.Name = "tb_vPublishYear";
            this.tb_vPublishYear.ReadOnly = true;
            this.tb_vPublishYear.Size = new System.Drawing.Size(209, 27);
            this.tb_vPublishYear.TabIndex = 58;
            // 
            // tb_vRemarks
            // 
            this.tb_vRemarks.Location = new System.Drawing.Point(257, 78);
            this.tb_vRemarks.Name = "tb_vRemarks";
            this.tb_vRemarks.ReadOnly = true;
            this.tb_vRemarks.Size = new System.Drawing.Size(209, 27);
            this.tb_vRemarks.TabIndex = 59;
            // 
            // tb_vCourse
            // 
            this.tb_vCourse.Location = new System.Drawing.Point(257, 111);
            this.tb_vCourse.Name = "tb_vCourse";
            this.tb_vCourse.ReadOnly = true;
            this.tb_vCourse.Size = new System.Drawing.Size(209, 27);
            this.tb_vCourse.TabIndex = 60;
            // 
            // tb_vCataloging
            // 
            this.tb_vCataloging.Location = new System.Drawing.Point(257, 144);
            this.tb_vCataloging.Name = "tb_vCataloging";
            this.tb_vCataloging.ReadOnly = true;
            this.tb_vCataloging.Size = new System.Drawing.Size(209, 27);
            this.tb_vCataloging.TabIndex = 61;
            // 
            // tb_vCategory
            // 
            this.tb_vCategory.Location = new System.Drawing.Point(257, 177);
            this.tb_vCategory.Name = "tb_vCategory";
            this.tb_vCategory.ReadOnly = true;
            this.tb_vCategory.Size = new System.Drawing.Size(209, 27);
            this.tb_vCategory.TabIndex = 62;
            // 
            // bt_ViewEcopy
            // 
            this.bt_ViewEcopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.bt_ViewEcopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ViewEcopy.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ViewEcopy.ForeColor = System.Drawing.Color.White;
            this.bt_ViewEcopy.Image = ((System.Drawing.Image)(resources.GetObject("bt_ViewEcopy.Image")));
            this.bt_ViewEcopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ViewEcopy.Location = new System.Drawing.Point(768, 45);
            this.bt_ViewEcopy.Name = "bt_ViewEcopy";
            this.bt_ViewEcopy.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bt_ViewEcopy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_ViewEcopy.Size = new System.Drawing.Size(182, 47);
            this.bt_ViewEcopy.TabIndex = 63;
            this.bt_ViewEcopy.Text = "View E-Copy";
            this.bt_ViewEcopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_ViewEcopy.UseVisualStyleBackColor = false;
            // 
            // ViewBookInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1010, 497);
            this.Controls.Add(this.bt_ViewEcopy);
            this.Controls.Add(this.tb_vCategory);
            this.Controls.Add(this.tb_vCataloging);
            this.Controls.Add(this.tb_vCourse);
            this.Controls.Add(this.tb_vRemarks);
            this.Controls.Add(this.tb_vPublishYear);
            this.Controls.Add(this.tb_vTitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ViewBookInformation";
            this.Text = "ViewBookInformation";
            this.Load += new System.EventHandler(this.ViewBookInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorContactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thesisTitleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn researchBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private System.Windows.Forms.TextBox tb_vTitle;
        private System.Windows.Forms.TextBox tb_vPublishYear;
        private System.Windows.Forms.TextBox tb_vRemarks;
        private System.Windows.Forms.TextBox tb_vCourse;
        private System.Windows.Forms.TextBox tb_vCataloging;
        private System.Windows.Forms.TextBox tb_vCategory;
        private System.Windows.Forms.Button bt_ViewEcopy;
    }
}
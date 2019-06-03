namespace Test
{
    partial class CourseManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseManagerForm));
            this.tb_Course = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Course = new System.Windows.Forms.DataGridView();
            this.bt_SaveCourse = new System.Windows.Forms.Button();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Course
            // 
            this.tb_Course.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_Course.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_Course.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Course.ForeColor = System.Drawing.Color.DimGray;
            this.tb_Course.Location = new System.Drawing.Point(113, 351);
            this.tb_Course.Multiline = true;
            this.tb_Course.Name = "tb_Course";
            this.tb_Course.Size = new System.Drawing.Size(221, 20);
            this.tb_Course.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "Course:";
            // 
            // dataGridView_Course
            // 
            this.dataGridView_Course.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Course.AutoGenerateColumns = false;
            this.dataGridView_Course.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Course.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseNameDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.dataGridView_Course.DataSource = this.courseBindingSource;
            this.dataGridView_Course.Location = new System.Drawing.Point(26, 22);
            this.dataGridView_Course.Name = "dataGridView_Course";
            this.dataGridView_Course.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Course.Size = new System.Drawing.Size(962, 301);
            this.dataGridView_Course.TabIndex = 43;
            // 
            // bt_SaveCourse
            // 
            this.bt_SaveCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_SaveCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SaveCourse.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SaveCourse.ForeColor = System.Drawing.Color.White;
            this.bt_SaveCourse.Image = ((System.Drawing.Image)(resources.GetObject("bt_SaveCourse.Image")));
            this.bt_SaveCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_SaveCourse.Location = new System.Drawing.Point(806, 339);
            this.bt_SaveCourse.Name = "bt_SaveCourse";
            this.bt_SaveCourse.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bt_SaveCourse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_SaveCourse.Size = new System.Drawing.Size(182, 47);
            this.bt_SaveCourse.TabIndex = 54;
            this.bt_SaveCourse.Text = "Save";
            this.bt_SaveCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_SaveCourse.UseVisualStyleBackColor = true;
            this.bt_SaveCourse.Click += new System.EventHandler(this.bt_SaveCourse_Click);
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(ResearchRecordingSystem.Course);
            // 
            // CourseManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1008, 406);
            this.Controls.Add(this.bt_SaveCourse);
            this.Controls.Add(this.dataGridView_Course);
            this.Controls.Add(this.tb_Course);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1024, 444);
            this.Name = "CourseManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseManagerForm";
            this.Load += new System.EventHandler(this.CourseManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Course;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Course;
        private System.Windows.Forms.Button bt_SaveCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource courseBindingSource;
    }
}
namespace Test
{
    partial class ThesisManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThesisManagerForm));
            this.tb_Remarks = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Course = new System.Windows.Forms.ComboBox();
            this.bt_SaveCourse = new System.Windows.Forms.Button();
            this.bt_Ecopy1 = new System.Windows.Forms.Button();
            this.bt_Ecopy2 = new System.Windows.Forms.Button();
            this.cb_PublishedYear = new System.Windows.Forms.ComboBox();
            this.tb_AuthorContactNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_AuthorFName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_AuthorMName = new System.Windows.Forms.TextBox();
            this.tb_AuthorLName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_Gender = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_AddAuthor = new System.Windows.Forms.Button();
            this.bt_RemoveAuthor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_NumberOfCopies = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView_Thesis = new System.Windows.Forms.DataGridView();
            this.thesisTitleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Thesis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thesisTitleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Remarks
            // 
            this.tb_Remarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_Remarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Remarks.ForeColor = System.Drawing.Color.DimGray;
            this.tb_Remarks.Location = new System.Drawing.Point(173, 56);
            this.tb_Remarks.Multiline = true;
            this.tb_Remarks.Name = "tb_Remarks";
            this.tb_Remarks.Size = new System.Drawing.Size(221, 20);
            this.tb_Remarks.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 52;
            this.label6.Text = "Remarks:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(423, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 19);
            this.label5.TabIndex = 50;
            this.label5.Text = "Published Year:";
            // 
            // tb_Title
            // 
            this.tb_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Title.ForeColor = System.Drawing.Color.DimGray;
            this.tb_Title.Location = new System.Drawing.Point(173, 29);
            this.tb_Title.Multiline = true;
            this.tb_Title.Name = "tb_Title";
            this.tb_Title.Size = new System.Drawing.Size(221, 20);
            this.tb_Title.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 48;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 54;
            this.label2.Text = "Course:";
            // 
            // cb_Course
            // 
            this.cb_Course.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Course.FormattingEnabled = true;
            this.cb_Course.Location = new System.Drawing.Point(557, 53);
            this.cb_Course.Name = "cb_Course";
            this.cb_Course.Size = new System.Drawing.Size(168, 29);
            this.cb_Course.TabIndex = 55;
            // 
            // bt_SaveCourse
            // 
            this.bt_SaveCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SaveCourse.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SaveCourse.ForeColor = System.Drawing.Color.White;
            this.bt_SaveCourse.Image = ((System.Drawing.Image)(resources.GetObject("bt_SaveCourse.Image")));
            this.bt_SaveCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_SaveCourse.Location = new System.Drawing.Point(210, 646);
            this.bt_SaveCourse.Name = "bt_SaveCourse";
            this.bt_SaveCourse.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bt_SaveCourse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_SaveCourse.Size = new System.Drawing.Size(196, 58);
            this.bt_SaveCourse.TabIndex = 57;
            this.bt_SaveCourse.Text = "Save Thesis";
            this.bt_SaveCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_SaveCourse.UseVisualStyleBackColor = true;
            this.bt_SaveCourse.Click += new System.EventHandler(this.bt_SaveCourse_Click);
            // 
            // bt_Ecopy1
            // 
            this.bt_Ecopy1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Ecopy1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Ecopy1.ForeColor = System.Drawing.Color.White;
            this.bt_Ecopy1.Image = ((System.Drawing.Image)(resources.GetObject("bt_Ecopy1.Image")));
            this.bt_Ecopy1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Ecopy1.Location = new System.Drawing.Point(6, 579);
            this.bt_Ecopy1.Name = "bt_Ecopy1";
            this.bt_Ecopy1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bt_Ecopy1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_Ecopy1.Size = new System.Drawing.Size(198, 58);
            this.bt_Ecopy1.TabIndex = 58;
            this.bt_Ecopy1.Text = "Add Ecopy Abstract";
            this.bt_Ecopy1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Ecopy1.UseVisualStyleBackColor = true;
            this.bt_Ecopy1.Click += new System.EventHandler(this.bt_Ecopy1_Click);
            // 
            // bt_Ecopy2
            // 
            this.bt_Ecopy2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Ecopy2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Ecopy2.ForeColor = System.Drawing.Color.White;
            this.bt_Ecopy2.Image = ((System.Drawing.Image)(resources.GetObject("bt_Ecopy2.Image")));
            this.bt_Ecopy2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Ecopy2.Location = new System.Drawing.Point(210, 579);
            this.bt_Ecopy2.Name = "bt_Ecopy2";
            this.bt_Ecopy2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bt_Ecopy2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_Ecopy2.Size = new System.Drawing.Size(198, 58);
            this.bt_Ecopy2.TabIndex = 59;
            this.bt_Ecopy2.Text = "Add Ecopy Approval Sheet";
            this.bt_Ecopy2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Ecopy2.UseVisualStyleBackColor = true;
            this.bt_Ecopy2.Click += new System.EventHandler(this.bt_Ecopy2_Click);
            // 
            // cb_PublishedYear
            // 
            this.cb_PublishedYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_PublishedYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PublishedYear.FormattingEnabled = true;
            this.cb_PublishedYear.Location = new System.Drawing.Point(557, 19);
            this.cb_PublishedYear.Name = "cb_PublishedYear";
            this.cb_PublishedYear.Size = new System.Drawing.Size(168, 29);
            this.cb_PublishedYear.TabIndex = 60;
            // 
            // tb_AuthorContactNumber
            // 
            this.tb_AuthorContactNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_AuthorContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_AuthorContactNumber.ForeColor = System.Drawing.Color.DimGray;
            this.tb_AuthorContactNumber.Location = new System.Drawing.Point(138, 64);
            this.tb_AuthorContactNumber.Multiline = true;
            this.tb_AuthorContactNumber.Name = "tb_AuthorContactNumber";
            this.tb_AuthorContactNumber.Size = new System.Drawing.Size(221, 20);
            this.tb_AuthorContactNumber.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 64;
            this.label3.Text = "Contact #:";
            // 
            // tb_AuthorFName
            // 
            this.tb_AuthorFName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_AuthorFName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_AuthorFName.ForeColor = System.Drawing.Color.DimGray;
            this.tb_AuthorFName.Location = new System.Drawing.Point(139, 32);
            this.tb_AuthorFName.Multiline = true;
            this.tb_AuthorFName.Name = "tb_AuthorFName";
            this.tb_AuthorFName.Size = new System.Drawing.Size(221, 20);
            this.tb_AuthorFName.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 62;
            this.label4.Text = "Author Name:";
            // 
            // tb_AuthorMName
            // 
            this.tb_AuthorMName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_AuthorMName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_AuthorMName.ForeColor = System.Drawing.Color.DimGray;
            this.tb_AuthorMName.Location = new System.Drawing.Point(166, 108);
            this.tb_AuthorMName.Multiline = true;
            this.tb_AuthorMName.Name = "tb_AuthorMName";
            this.tb_AuthorMName.Size = new System.Drawing.Size(221, 20);
            this.tb_AuthorMName.TabIndex = 66;
            // 
            // tb_AuthorLName
            // 
            this.tb_AuthorLName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_AuthorLName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_AuthorLName.ForeColor = System.Drawing.Color.DimGray;
            this.tb_AuthorLName.Location = new System.Drawing.Point(166, 77);
            this.tb_AuthorLName.Multiline = true;
            this.tb_AuthorLName.Name = "tb_AuthorLName";
            this.tb_AuthorLName.Size = new System.Drawing.Size(221, 20);
            this.tb_AuthorLName.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 68;
            this.label7.Text = "Last Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 19);
            this.label8.TabIndex = 69;
            this.label8.Text = "Middle Name:";
            // 
            // cb_Gender
            // 
            this.cb_Gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Gender.FormattingEnabled = true;
            this.cb_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_Gender.Location = new System.Drawing.Point(458, 29);
            this.cb_Gender.Name = "cb_Gender";
            this.cb_Gender.Size = new System.Drawing.Size(168, 29);
            this.cb_Gender.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(380, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 19);
            this.label9.TabIndex = 70;
            this.label9.Text = "Gender:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.bt_AddAuthor);
            this.groupBox1.Controls.Add(this.bt_RemoveAuthor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_AuthorFName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_AuthorContactNumber);
            this.groupBox1.Controls.Add(this.cb_Gender);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(6, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 399);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Author Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(15, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(692, 221);
            this.dataGridView1.TabIndex = 76;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Author Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Contact No.";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Gender";
            this.Column3.Name = "Column3";
            // 
            // bt_AddAuthor
            // 
            this.bt_AddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddAuthor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddAuthor.ForeColor = System.Drawing.Color.White;
            this.bt_AddAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_AddAuthor.Location = new System.Drawing.Point(509, 329);
            this.bt_AddAuthor.Name = "bt_AddAuthor";
            this.bt_AddAuthor.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bt_AddAuthor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_AddAuthor.Size = new System.Drawing.Size(198, 58);
            this.bt_AddAuthor.TabIndex = 75;
            this.bt_AddAuthor.Text = "Add Author";
            this.bt_AddAuthor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_AddAuthor.UseVisualStyleBackColor = true;
            this.bt_AddAuthor.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_RemoveAuthor
            // 
            this.bt_RemoveAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_RemoveAuthor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_RemoveAuthor.ForeColor = System.Drawing.Color.White;
            this.bt_RemoveAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_RemoveAuthor.Location = new System.Drawing.Point(305, 329);
            this.bt_RemoveAuthor.Name = "bt_RemoveAuthor";
            this.bt_RemoveAuthor.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bt_RemoveAuthor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_RemoveAuthor.Size = new System.Drawing.Size(198, 58);
            this.bt_RemoveAuthor.TabIndex = 74;
            this.bt_RemoveAuthor.Text = "Remove Author";
            this.bt_RemoveAuthor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_RemoveAuthor.UseVisualStyleBackColor = true;
            this.bt_RemoveAuthor.Click += new System.EventHandler(this.bt_RemoveAuthor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tb_NumberOfCopies);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_Title);
            this.groupBox2.Controls.Add(this.cb_PublishedYear);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_Remarks);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cb_Course);
            this.groupBox2.Location = new System.Drawing.Point(14, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(735, 143);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Research Book Details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(463, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 19);
            this.label11.TabIndex = 63;
            this.label11.Text = "Category:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(557, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 29);
            this.comboBox1.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 19);
            this.label10.TabIndex = 61;
            this.label10.Text = "Number of Copies:";
            // 
            // tb_NumberOfCopies
            // 
            this.tb_NumberOfCopies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_NumberOfCopies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_NumberOfCopies.ForeColor = System.Drawing.Color.DimGray;
            this.tb_NumberOfCopies.Location = new System.Drawing.Point(173, 82);
            this.tb_NumberOfCopies.Multiline = true;
            this.tb_NumberOfCopies.Name = "tb_NumberOfCopies";
            this.tb_NumberOfCopies.Size = new System.Drawing.Size(221, 20);
            this.tb_NumberOfCopies.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(88, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 19);
            this.label12.TabIndex = 65;
            this.label12.Text = "Catalog:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(173, 108);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 66;
            // 
            // dataGridView_Thesis
            // 
            this.dataGridView_Thesis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Thesis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Thesis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Thesis.Location = new System.Drawing.Point(21, 146);
            this.dataGridView_Thesis.Name = "dataGridView_Thesis";
            this.dataGridView_Thesis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Thesis.Size = new System.Drawing.Size(1, 33);
            this.dataGridView_Thesis.TabIndex = 56;
            this.dataGridView_Thesis.Visible = false;
            this.dataGridView_Thesis.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_Thesis_DataError);
            // 
            // thesisTitleBindingSource
            // 
            this.thesisTitleBindingSource.DataSource = typeof(ResearchRecordingSystem.ResearchBook);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(ResearchRecordingSystem.Course);
            // 
            // ThesisManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(768, 710);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bt_Ecopy2);
            this.Controls.Add(this.bt_Ecopy1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_AuthorLName);
            this.Controls.Add(this.bt_SaveCourse);
            this.Controls.Add(this.tb_AuthorMName);
            this.Controls.Add(this.dataGridView_Thesis);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(784, 736);
            this.Name = "ThesisManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThesisManagerForm";
            this.Load += new System.EventHandler(this.ThesisManagerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Thesis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thesisTitleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Remarks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Course;
        private System.Windows.Forms.Button bt_SaveCourse;
        private System.Windows.Forms.Button bt_Ecopy1;
        private System.Windows.Forms.Button bt_Ecopy2;
        private System.Windows.Forms.ComboBox cb_PublishedYear;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.BindingSource thesisTitleBindingSource;
        private System.Windows.Forms.TextBox tb_AuthorContactNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_AuthorFName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_AuthorMName;
        private System.Windows.Forms.TextBox tb_AuthorLName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_Gender;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_NumberOfCopies;
        private System.Windows.Forms.Button bt_AddAuthor;
        private System.Windows.Forms.Button bt_RemoveAuthor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView_Thesis;
    }
}
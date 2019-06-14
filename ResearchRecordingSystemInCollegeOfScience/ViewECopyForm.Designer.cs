namespace ResearchRecordingSystemInCollegeOfScience
{
    partial class ViewECopyForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_ECopy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ECopy)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ECopy
            // 
            this.dataGridView_ECopy.AllowUserToAddRows = false;
            this.dataGridView_ECopy.AllowUserToDeleteRows = false;
            this.dataGridView_ECopy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ECopy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_ECopy.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ECopy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ECopy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ECopy.Location = new System.Drawing.Point(12, 30);
            this.dataGridView_ECopy.MultiSelect = false;
            this.dataGridView_ECopy.Name = "dataGridView_ECopy";
            this.dataGridView_ECopy.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_ECopy.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_ECopy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ECopy.Size = new System.Drawing.Size(776, 408);
            this.dataGridView_ECopy.TabIndex = 14;
            this.dataGridView_ECopy.Tag = "CLIENTS";
            this.dataGridView_ECopy.DataSourceChanged += new System.EventHandler(this.dataGridView_ECopy_DataSourceChanged);
            this.dataGridView_ECopy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ECopy_CellContentClick);
            this.dataGridView_ECopy.Click += new System.EventHandler(this.dataGridView_ECopy_Click);
            this.dataGridView_ECopy.DoubleClick += new System.EventHandler(this.dataGridView_ECopy_DoubleClick);
            // 
            // ViewECopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_ECopy);
            this.Name = "ViewECopyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewECopyForm";
            this.Load += new System.EventHandler(this.ViewECopyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ECopy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ECopy;
    }
}
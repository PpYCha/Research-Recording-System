using System;
using System.IO;
using System.Windows.Forms;

namespace ResearchRecordingSystemInCollegeOfScience
{
    public partial class ViewECopyForm : Form
    {
        public ViewECopyForm()
        {
            InitializeComponent();
        }

        private void ViewECopyForm_Load(object sender, EventArgs e)
        {

            var AllFiles = new DirectoryInfo(Application.StartupPath + "\\E-copy").GetDirectories();
            dataGridView_ECopy.DataSource = AllFiles;
        }

        private void dataGridView_ECopy_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_ECopy.SelectedRows.Count > 0)
            {
                System.Diagnostics.Process.Start(dataGridView_ECopy.SelectedRows[0].Cells["FullName"].Value.ToString());
            }
        }

        private void dataGridView_ECopy_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView_ECopy_DataSourceChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn c in dataGridView_ECopy.Columns)
            {
                if (c.HeaderText != "Name")
                {
                    c.Visible = false;
                }
            }
        }

        private void dataGridView_ECopy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

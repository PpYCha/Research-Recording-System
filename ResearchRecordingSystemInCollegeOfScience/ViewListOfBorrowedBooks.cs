using System;
using System.Windows.Forms;

namespace ResearchRecordingSystemInCollegeOfScience
{
    public partial class ViewListOfBorrowedBooks : Form
    {
        public ViewListOfBorrowedBooks()
        {
            InitializeComponent();
        }

        private void btn_SearchListOfBorrowedBooks_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.SelectionFormula = "{ResearchBooks.Title} Like '*" + textBox1.Text + "*'";
            crystalReportViewer1.RefreshReport();
        }
    }
}

using System;
using System.Windows.Forms;

namespace ResearchRecordingSystemInCollegeOfScience
{
    public partial class ViewByAuthor : Form
    {
        public ViewByAuthor()
        {
            InitializeComponent();
        }

        private void bt_SearchAuthor_Click(object sender, EventArgs e)
        {

            //string ttt = "BSIT";
            //crystalReportViewer1.SelectionFormula = "{ResearchBooks.CourseNameRb} Like '*" + ttt + "*'";
            crystalReportViewer1.SelectionFormula = "{Authors.AuthorName} Like '*" + tb_AuthorName.Text + "*'";
            crystalReportViewer1.RefreshReport();



        }
    }
}

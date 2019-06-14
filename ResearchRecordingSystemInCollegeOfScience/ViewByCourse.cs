using System;
using System.Linq;
using System.Windows.Forms;

namespace ResearchRecordingSystemInCollegeOfScience.Tabpages.ViewReport
{
    public partial class ViewByCourse : Form
    {
        public ViewByCourse()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            LoadCourse();
            LoadYear();
        }

        private void LoadYear()
        {
            DateTime currentYear = DateTime.Now;
            int cyear = currentYear.Year;
            for (int i = 1999; i <= cyear; i++)
            {

                cb_YearPublished.Items.Add(i);


            }
        }

        private void ViewByCourse_Load(object sender, EventArgs e)
        {
            //string ttt = "BSIT";
            //crystalReportViewer1.SelectionFormula = "{ResearchBooks.CourseNameRb} Like '*" + ttt + "*'";
        }

        private void LoadCourse()
        {

            using (RRSContext ctx = new RRSContext())
            {

                var course_List = ctx.Courses.Where(x => x.IsActive == true).ToList();
                if (course_List.Count > 0)
                {
                    cb_Course.DataSource = course_List;
                    //cb_Course.Items.Add(cb_Course.DataSource = ctx.Courses.ToString());
                    cb_Course.DisplayMember = "CourseName";
                    cb_Course.ValueMember = "CourseId";

                }




            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (chb_Course.Checked == true)
            {
                //string ttt = "BSIT";
                //crystalReportViewer1.SelectionFormula = "{ResearchBooks.CourseNameRb} Like '*" + ttt + "*'";
                crystalReportViewer1.SelectionFormula = "{ResearchBooks.CourseNameRb} Like '*" + cb_Course.GetItemText(cb_Course.SelectedItem) + "*'";
                crystalReportViewer1.RefreshReport();


            }
            //else if (chb_YearPublish.Checked == true)
            //{
            //    crystalReportViewer1.SelectionFormula = "{ResearchBooks.PublishedYear} Like '*" + cb_YearPublished.GetItemText(cb_YearPublished.SelectedItem) + "*'";
            //    crystalReportViewer1.RefreshReport();
            //}
            //else if (chb_Author.Checked == true)
            //{
            //    crystalReportViewer1.SelectionFormula = "{ResearchBooks.PublishedYear} Like '*" + cb_YearPublished.GetItemText(cb_YearPublished.SelectedItem) + "*'";
            //    crystalReportViewer1.RefreshReport();
            //}
            //else if (chb_Category.Checked == true)
            //{
            //    crystalReportViewer1.SelectionFormula = "{Classfications.ClassficationName} Like '*" + cb_Classification.GetItemText(cb_Classification.SelectedItem) + "*'";
            //    crystalReportViewer1.RefreshReport();
            //}



        }
    }
}

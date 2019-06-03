using ResearchRecordingSystem;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Test.Tabpages
{
    public partial class SearchThesis : Form
    {
        public SearchThesis()
        {
            InitializeComponent();
            LoadThesis();
        }

        private void LoadThesis()
        {
            using (RRSContext ctx = new RRSContext())
            {



                researchBookBindingSource.DataSource = ctx.ResearchBooks.ToList();



            }
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            using (RRSContext ctx = new RRSContext())
            {
                //researchBookBindingSource.DataSource = ctx.ResearchBooks
                //                                                    .Where(x => x.Title.Contains(tb_Search.Text) ||
                //                                                    x.PublishedYear.Contains(tb_Search.Text) ||
                //                                                    x.CourseNameRb.Contains(tb_Search.Text) ||
                //                                                    x.Remarks.Contains(tb_Search.Text)).ToList()
                //                                                    .Select(x => new
                //                                                    {
                //                                                        Title = x.Title,
                //                                                        Publis = x.PublishedYear,
                //                                                        Course = x.CourseNameRb
                //                                                    }).ToList();
                researchBookBindingSource.DataSource = ctx.ResearchBooks.ToList();


            }
        }



        private void SearchThesis_Load(object sender, EventArgs e)
        {

        }

        private void LoadSearch()
        {
            using (RRSContext ctx = new RRSContext())
            {
                var query = from p1 in ctx.ResearchBooks
                            join f1 in ctx.Authors on p1.ThesisTitleId equals f1.AuthorId
                            select new { p1.Title, p1.PublishedYear, p1.CourseNameRb, p1.Remarks, f1.AuthorName/*, f1.AuthorLName*/ };



                dataGridViewSearch.DataSource = query.ToList();
                dataGridViewSearch.Columns[0].HeaderCell.Value = "Title";
                dataGridViewSearch.Columns[1].HeaderCell.Value = "Published Year";
                dataGridViewSearch.Columns[2].HeaderCell.Value = "Course";
                dataGridViewSearch.Columns[3].HeaderCell.Value = "Remarks";
                dataGridViewSearch.Columns[4].HeaderCell.Value = "Author Name";





            }
        }

        private void dataGridViewSearch_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void bt_ViewEcopy_Click(object sender, EventArgs e)
        {
            ViewECopyForm viewECopyForm = new ViewECopyForm();
            viewECopyForm.Show();
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            using (RRSContext ctx = new RRSContext())
            {
                researchBookBindingSource.DataSource = ctx.ResearchBooks.Where(x => x.Title.Contains(tb_Search.Text) ||
                                                                    x.PublishedYear.Contains(tb_Search.Text) ||
                                                                    x.CourseNameRb.Contains(tb_Search.Text) ||
                                                                    x.Remarks.Contains(tb_Search.Text)).ToList();


            }
        }

        private void dataGridViewSearch_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewSearch.SelectedRows.Count > 0)
            {
                ViewReportForrm viewclientform = new ViewReportForrm();

                viewclientform.ShowDialog();
            }
        }
    }
}

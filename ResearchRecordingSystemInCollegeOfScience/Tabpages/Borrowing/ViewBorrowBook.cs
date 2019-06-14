using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ResearchRecordingSystemInCollegeOfScience.Tabpages.Borrowing
{
    public partial class ViewBorrowBook : Form
    {
        public ViewBorrowBook()
        {
            InitializeComponent();
        }

        public DataGridViewRow dgvr1;

        private void ViewBorrowBook_Load(object sender, EventArgs e)
        {
            tb_vTitle.Text = dgvr1.Cells[1].Value.ToString();
            tb_vPublishYear.Text = dgvr1.Cells[2].Value.ToString();
            tb_vRemarks.Text = dgvr1.Cells[3].Value.ToString();
            tb_vCourse.Text = dgvr1.Cells[4].Value.ToString();
            tb_vCataloging.Text = dgvr1.Cells[6].Value.ToString();


            using (RRSContext ctx = new RRSContext())
            {
                int tempId = Int32.Parse(dgvr1.Cells[0].Value.ToString());
                authorBindingSource.DataSource = ctx.Authors.Where(x => x.ThesisTitleId == tempId).ToList();
            }
        }
    }
}

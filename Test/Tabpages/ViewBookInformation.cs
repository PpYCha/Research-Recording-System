using ResearchRecordingSystem;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Test.Tabpages
{
    public partial class ViewBookInformation : Form
    {
        public ViewBookInformation()
        {
            InitializeComponent();
        }
        public DataGridViewRow dgvr;

        private void ViewBookInformation_Load(object sender, EventArgs e)
        {
            tb_vTitle.Text = dgvr.Cells[1].Value.ToString();
            tb_vPublishYear.Text = dgvr.Cells[2].Value.ToString();
            tb_vRemarks.Text = dgvr.Cells[3].Value.ToString();
            tb_vCourse.Text = dgvr.Cells[4].Value.ToString();

            using (RRSContext ctx = new RRSContext())
            {
                int tempId = Int32.Parse(dgvr.Cells[0].Value.ToString());
                authorBindingSource.DataSource = ctx.Authors.Where(x => x.ThesisTitleId == tempId).ToList();
            }
        }
    }
}

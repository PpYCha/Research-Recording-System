using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ResearchRecordingSystemInCollegeOfScience.Tabpages
{
    public partial class ViewBookInformation : Form
    {
        public ViewBookInformation()
        {
            InitializeComponent();
        }
        public DataGridViewRow dgvr;

        private string approvalSheetName;
        private string abstractName;

        private void ViewBookInformation_Load(object sender, EventArgs e)
        {


            tb_vTitle.Text = dgvr.Cells[1].Value.ToString();
            tb_vPublishYear.Text = dgvr.Cells[2].Value.ToString();
            tb_vRemarks.Text = dgvr.Cells[3].Value.ToString();
            tb_vCourse.Text = dgvr.Cells[4].Value.ToString();
            tb_vCataloging.Text = dgvr.Cells[6].Value.ToString();
            abstractName = dgvr.Cells[7].Value.ToString();
            approvalSheetName = dgvr.Cells[8].Value.ToString();

            using (RRSContext ctx = new RRSContext())
            {
                int tempId = Int32.Parse(dgvr.Cells[0].Value.ToString());
                authorBindingSource.DataSource = ctx.Authors.Where(x => x.ThesisTitleId == tempId).ToList();
            }

        }

        private void bt_ViewEcopy_Click(object sender, EventArgs e)
        {
            try
            {


                var approvalSheetPath = new DirectoryInfo(Application.StartupPath + "\\E-copy\\Approval Sheet\\");
                Process.Start(approvalSheetPath + approvalSheetName);
                //"C:\\Users\\PpYCha\\source\\repos\\Test\\Test\\bin\\Debug\\E-copy\\Approval Sheet\\"

                var abstractPath = new DirectoryInfo(Application.StartupPath + "\\E-copy\\Abstract\\");
                Process.Start(abstractPath + abstractName);
            }
            catch
            {
            }

        }
    }
}
